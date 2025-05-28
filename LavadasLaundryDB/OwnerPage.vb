Imports System.Data.SqlClient
Imports System.DirectoryServices
Imports System.IO
Imports System.Transactions
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Mysqlx.Expect.Open.Types
Imports Mysqlx.XDevAPI.Common
Imports Org.BouncyCastle.Tls

Public Class OwnerPage
    Public Property AdminUserName As String

    'FOR PRINTING REPORTS
    Public receiptFromAdmin As New PrintDocument
    Public salesReport As New PrintDocument
    Public serviceReport As New PrintDocument
    Public inventoryReport As New PrintDocument

    Dim inventory_query As String = "SELECT * FROM inventory"
    Dim services_query As String = "SELECT * FROM service"
    Dim employees_query As String = "SELECT * FROM employees"
    Dim admin_query As String = "SELECT * FROM admins"
    Dim pendings_query As String = "SELECT * FROM transactions WHERE transaction_status = 'Pending'"
    Dim finished_query As String = "SELECT * FROM transactions WHERE transaction_status IN ('Finished', 'Cancelled')"
    Dim filter_finished_query As String = "SELECT * FROM transactions WHERE transaction_status = 'Finished'"
    Dim filter_cancelled_query As String = "SELECT * FROM transactions WHERE transaction_status = 'Cancelled'"
    Dim transac_service As String = "SELECT * FROM transactions_services"
    Dim transac_order As String = "SELECT * FROM transactions_orders"

    ReadOnly Property fv_comforters_avail As Boolean
        Get
            Return GetServiceStatus("Comforters")
        End Get
    End Property

    ReadOnly Property fv_wdf_avail As Boolean
        Get
            Return GetServiceStatus("Wash, Dry, Fold")
        End Get
    End Property

    ReadOnly Property sv_wash_avail As Boolean
        Get
            Return GetServiceStatus("Wash")
        End Get
    End Property

    ReadOnly Property fv_dry_avail As Boolean
        Get
            Return GetServiceStatus("Dry")
        End Get
    End Property

    ReadOnly Property sv_wash_fee As Decimal
        Get
            Return GetSubTotal("Wash", "Self Service")
        End Get
    End Property

    ReadOnly Property sv_dry_fee As Decimal
        Get
            Return GetSubTotal("Dry", "Self Service")
        End Get
    End Property

    ReadOnly Property sv_washdry_fee As Decimal
        Get
            Return GetSubTotal("Wash and Dry", "Self Service")
        End Get
    End Property

    ReadOnly Property fv_comforters_fee As Decimal
        Get
            Return GetSubTotal("Comforters", "Full Service")
        End Get
    End Property

    ReadOnly Property fv_wdf_fee As Decimal
        Get
            Return GetSubTotal("Wash, Dry, Fold", "Full Service")
        End Get
    End Property

    ReadOnly Property detergent_price As Decimal
        Get
            Return GetItemPrice("Ariel/Breeze/Tide")
        End Get
    End Property

    ReadOnly Property regular_bleach_price As Decimal
        Get
            Return GetItemPrice("Regular Bleach")
        End Get
    End Property

    ReadOnly Property colored_bleach_price As Decimal
        Get
            Return GetItemPrice("Colored Safe Bleach")
        End Get
    End Property

    ReadOnly Property fabcon_price As Decimal
        Get
            Return GetItemPrice("Fabric Conditioner")
        End Get
    End Property

    Public current_user_id As Integer

    Private Sub UpdateServiceVisibility()
        If fv_comforters_avail = True Then
            rbComforters.Visible = True
        Else
            rbComforters.Visible = False
        End If

        If fv_wdf_avail = True Then
            rbWDF.Visible = True
        Else
            rbWDF.Visible = False
        End If

        If sv_wash_avail = True Then
            cbWash.Visible = True
        Else
            cbWash.Visible = False
        End If

        If fv_dry_avail = True Then
            cbDry.Visible = True
        Else
            cbDry.Visible = False
        End If
    End Sub

    Public Sub ModifyAdminCreds()
        Try
            Dim exFolder As String = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
            Dim configFolder As String = Path.Combine(exFolder, "config_fold")
            Dim filePath As String = Path.Combine(configFolder, "config_creds.txt")

            If File.Exists(filePath) Then
                Dim currentContent As String = File.ReadAllText(filePath)

                Console.WriteLine("Current Content: " & currentContent)

                Dim hashedus As String = BCrypt.Net.BCrypt.HashPassword(txtChangeConfigUs.Text.Trim())
                Dim hashedpass As String = BCrypt.Net.BCrypt.HashPassword(txtChangeConfigPass.Text.Trim())

                Dim newContent As String = hashedus & vbCrLf &
                                           hashedpass & vbCrLf
                File.WriteAllText(filePath, newContent)

                MsgBox("File Successfully modified!" & filePath, MsgBoxStyle.Information)
            Else
                MsgBox("File not found: " & filePath, MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub CheckBoxHandler(selectedAddons As List(Of (Name As String, UnitPrice As Decimal, Quantity As Integer)), servicePrice As Decimal)
        Dim addonLabels() As Label = {lblAddon1, lblAddon2, lblAddon3, lblAddon4}
        Dim addonPriceLabels() As Label = {lblAddon1Fee, lblAddon2Fee, lblAddon3Fee, lblAddon4Fee}
        Dim addonTotalLabels() As Label = {lblAddon1Total, lblAddon2Total, lblAddon3Total, lblAddon4Total}

        Dim totalPrice As Decimal = servicePrice

        For i As Integer = 0 To addonLabels.Length - 1
            If i < selectedAddons.Count Then
                Dim addon = selectedAddons(i)
                Dim subtotal = addon.UnitPrice * addon.Quantity

                addonLabels(i).Text = $"{addon.Name}"
                addonLabels(i).Visible = True

                addonPriceLabels(i).Text = $"₱{addon.UnitPrice:F2}"
                addonPriceLabels(i).Visible = True

                addonTotalLabels(i).Text = $"₱{subtotal:F2}"
                addonTotalLabels(i).Visible = True

                totalPrice += subtotal
            Else
                addonLabels(i).Visible = False
                addonPriceLabels(i).Visible = False
                addonTotalLabels(i).Visible = False
            End If
        Next

        lblTotal.Text = $"₱{totalPrice:F2}"
    End Sub


    Private Sub LoadServiceChart()
        chService.Series.Clear()
        chService.Titles.Clear()

        chService.Titles.Add("Weekly availed services")

        Dim series As New Series("Services")
        series.ChartType = SeriesChartType.Column

        Dim serviceData = GetServices()
        For Each kvp In serviceData
            series.Points.AddXY(kvp.Key, kvp.Value)
        Next

        chService.Series.Add(series)
    End Sub

    Private Sub LoadInventoryChart()
        chItems.Series.Clear()
        chItems.Titles.Clear()

        chItems.Titles.Add("Weekly availed items")

        Dim series As New Series("Items")
        series.ChartType = SeriesChartType.Column

        Dim itemData = GetItem()
        For Each kvp In itemData
            series.Points.AddXY(kvp.Key, kvp.Value)
        Next

        chItems.Series.Add(series)
    End Sub

    Private Sub OwnerPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        cbNone.Checked = True
        lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy")

        numLoadWeight.Maximum = 8
        numLoadWeight.Minimum = 1

        numLoadWeight.Maximum = 8
        numLoadWeight.Minimum = 1
        'numAddon1.Minimum = 0
        'numAddon2.Minimum = 0
        'numAddon3.Minimum = 0
        'numAddon4.Minimum = 0

        panPendingOrdersss.Enabled = False
        panFinished.Enabled = False
        lblPendingOrderID.Visible = False

        lblPendingFullName.Visible = False
        lblPendingContact.Visible = False
        lblPendingService.Visible = False

        lblPendingAddon1.Visible = False
        lblPendingAddon2.Visible = False
        lblPendingAddon3.Visible = False
        lblPendingAddon4.Visible = False

        lblPendingTotal.Visible = False

        btnCancel.Visible = False
        btnFinish.Visible = False

        'FOR EYE BUTTONS
        txtEditAdminUser.PasswordChar = "*"
        txtChangePassword.PasswordChar = "*"
        txtConfirmPassword.PasswordChar = "*"
        txtAddEmPassword.PasswordChar = "*"
        txtAddConfirmPass.PasswordChar = "*"
        txtEmPassword.PasswordChar = "*"
        txtEditConfirmPass.PasswordChar = "*"

        'FOR ADMIN ACCOUNT
        Dim user_name As String = AdminUserName
        Dim userInfo As UserInfo = SearchAccount(user_name)
        Dim reusable_id As Integer


        lblAdminUsername.Text = user_name
        If userInfo.UserID > 0 Then
            'Sets the labels with the user info
            lblAccountID.Text = userInfo.UserID.ToString()
            lblSmallUserID.Text = userInfo.UserID.ToString()

            'Stores for resuablity
            reusable_id = userInfo.UserID
            lblEditOwnID.Text = userInfo.UserID.ToString()
            lblAccountDateCreated.Text = userInfo.DateCreated.ToString("MMMM dd, yyyy")

            'For admin info
            Dim admin_id As Integer = GetAdminID(reusable_id)
            Dim admin_name As String = GetAdminFullName(admin_id)
            lblAdminID.Text = admin_id.ToString()
            lblAdminFullName.Text = admin_name

            'SET ACCOUNT STATUS TO ONLINE
            SetUserOnline(reusable_id)
        End If

        LoadToDGV(inventory_query, dgvInventory, db_name)
        LoadToDGV(services_query, dgvServices, db_name)
        LoadToDGV(employees_query, dgvEmployee, db_name)
        LoadToDGV(pendings_query, dgvPending, db_name)
        LoadToDGV(finished_query, dgvFinished, db_name)

        With dgvEmployee
            .Columns("employee_fname").HeaderText = "First Name"
            .Columns("employee_lname").HeaderText = "Last Name"
            .Columns("employee_contact").HeaderText = "Contact"
            .Columns("employee_age").HeaderText = "Age"
            .Columns("employee_sex").HeaderText = "Sex"
            .Columns("employee_city").HeaderText = "City"
            .Columns("employee_province").HeaderText = "Province"
            .Columns("email").HeaderText = "Email Address"
            .Columns("working_hours").HeaderText = "Working Hours"
            .Columns("shift").HeaderText = "Shift Schedule"
        End With

        'Inventory items for combobox kasi nagang error
        cbItemName.Items.Add("Detergent")
        cbItemName.Items.Add("Fabric conditioner")
        cbItemName.Items.Add("Bleach")
        cbItemName.Items.Add("Plastic bags")
        cbItemName.Items.Add("Scotch tape")
        cbItemName.Items.Add("Alcohol")
        cbItemName.Items.Add("Tissue")

        'Setting the postal code to null to avoid accidental "placeholder"
        lblPostalCode.Text = ""

        If fv_comforters_avail = True Then rbComforters.Visible = True Else rbComforters.Visible = False
        If fv_wdf_avail = True Then rbWDF.Visible = True Else rbWDF.Visible = False
        If sv_wash_avail = True Then cbWash.Visible = True Else cbWash.Visible = False
        If fv_dry_avail = True Then cbDry.Visible = True Else cbDry.Visible = False

        lblMostTransactionFinished.Text = GetMostTransactionFinished()
        lblMostAvailedService.Text = GetServiceTimesAvailed()
        lblMostAvailedItem.Text = GetItemTimesAvailed()
        lblTotalCustomers.Text = GetTotalCustomersLastWeek()
        'For Charts
        LoadServiceChart()
        LoadInventoryChart()
    End Sub

    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Down Then
            txtChangeConfigUs.Visible = True
            txtChangeConfigPass.Visible = True
            btnChangeConfig.Visible = True

        ElseIf e.KeyCode = Keys.Escape Then
            txtChangeConfigUs.Visible = False
            txtChangeConfigPass.Visible = False
            btnChangeConfig.Visible = False

        End If
    End Sub

    Private Sub rbFullService_CheckedChanged(sender As Object, e As EventArgs) Handles rbFullService.CheckedChanged
        If rbFullService.Checked Then
            panSelfService.Visible = False
            panFullService.Visible = True
        End If

        cbWash.Checked = False
        cbDry.Checked = False

    End Sub

    Private Sub rbSelfService_CheckedChanged(sender As Object, e As EventArgs) Handles rbSelfService.CheckedChanged
        If rbSelfService.Checked Then
            panSelfService.Visible = True
            panFullService.Visible = False
        End If

        rbComforters.Checked = False
        rbWDF.Checked = False


    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNextAd.Click
        Dim result As DialogResult
        Dim selectedAddons As New List(Of (Name As String, Price As Decimal, Quantity As Integer))
        Dim servicePrice As Decimal = 0D

        If rbFullService.Checked OrElse rbSelfService.Checked Then
            If Not String.IsNullOrWhiteSpace(cbColored.Text.Trim()) Then
                If rbFullService.Checked Then
                    If rbComforters.Checked OrElse rbWDF.Checked Then
                        If Not (String.IsNullOrWhiteSpace(numLoadWeight.Text)) Then
                            result = MessageBox.Show("Confirm order?", "Confirm order", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            If result = DialogResult.Yes Then
                                panOrderInfo.Visible = True 'Error Handler
                                MessageBox.Show("Order confirmed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                If rbComforters.Checked = True Then
                                    lblServiceAvailed.Visible = True
                                    lblServiceFee.Visible = True
                                    lblServiceCategory.Visible = True
                                    lblServiceCategory.Text = "Full Service"
                                    lblServiceAvailed.Text = "Comforters"
                                    lblServiceFee.Text = fv_comforters_fee.ToString()
                                ElseIf rbWDF.Checked = True Then
                                    lblServiceAvailed.Visible = True
                                    lblServiceFee.Visible = True
                                    lblServiceCategory.Visible = True
                                    lblServiceCategory.Text = "Full Service"
                                    lblServiceAvailed.Text = "Wash, Dry, Fold"
                                    lblServiceFee.Text = fv_wdf_fee.ToString()
                                ElseIf cbDry.Checked = True AndAlso cbWash.Checked = True Then
                                    lblServiceAvailed.Visible = True
                                    lblServiceFee.Visible = True
                                    lblServiceCategory.Visible = True
                                    lblServiceAvailed.Text = "Wash and Dry"
                                    lblServiceCategory.Text = "Self Service"
                                    lblServiceFee.Text = sv_washdry_fee.ToString()

                                ElseIf cbDry.Checked = True Then
                                    lblServiceAvailed.Visible = True
                                    lblServiceFee.Visible = True
                                    lblServiceCategory.Visible = True
                                    lblServiceAvailed.Text = "Dry"
                                    lblServiceCategory.Text = "Self Service"
                                    lblServiceFee.Text = sv_dry_fee.ToString()

                                ElseIf cbWash.Checked = True Then
                                    lblServiceAvailed.Visible = True
                                    lblServiceFee.Visible = True
                                    lblServiceCategory.Visible = True
                                    lblServiceAvailed.Text = "Wash"
                                    lblServiceCategory.Text = "Self Service"
                                    lblServiceFee.Text = sv_wash_fee.ToString()
                                End If

                                If rbComforters.Checked = True Then
                                    servicePrice = fv_comforters_fee
                                ElseIf rbWDF.Checked = True Then
                                    servicePrice = fv_wdf_fee
                                End If

                                ' Collect checked items

                                selectedAddons.Clear()

                                If cbNone.Checked Then
                                    selectedAddons.Add(("None", 0D, 0)) ' name, price, quantity
                                Else
                                    If cbAddon1.Checked Then selectedAddons.Add(("Ariel/Breeze/Tide", detergent_price, CInt(numAddon1.Value)))
                                    If cbAddon2.Checked Then selectedAddons.Add(("Regular Bleach", regular_bleach_price, CInt(numAddon2.Value)))
                                    If cbAddon3.Checked Then selectedAddons.Add(("Colored Safe Bleach", colored_bleach_price, CInt(numAddon3.Value)))
                                    If cbAddon4.Checked Then selectedAddons.Add(("Fabric Conditioner", fabcon_price, CInt(numAddon4.Value)))
                                End If


                                If cbColored.Text.Trim() = "True" Then
                                    lblIscolored.Text = "True"
                                ElseIf cbColored.Text.Trim() = "False" Then
                                    lblIscolored.Text = "False"
                                End If

                                lblDateAdded.Visible = True
                                lblDateAdded.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy")
                                ' Call the method to update labels
                                CheckBoxHandler(selectedAddons, servicePrice)


                                lblLoadWeight.Visible = True
                                lblLoadWeight.Text = numLoadWeight.Value.ToString + "kg"
                                lblTotal.Visible = True

                                panLayer1.Enabled = False
                                panLayer2.Enabled = False
                                panLayer3.Enabled = False
                                btnNextAd.Enabled = False

                                Exit Sub
                            End If

                        Else
                            MessageBox.Show("PLEASE ENTER ALL FIELDS", "Incomplete fields", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                    Else
                        MessageBox.Show("PLEASE ENTER ALL FIELDS", "Incomplete fields", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                ElseIf rbSelfService.Checked Then
                    If cbWash.Checked OrElse cbDry.Checked Then
                        If Not (String.IsNullOrWhiteSpace(numLoadWeight.Text)) Then
                            result = MessageBox.Show("Confirm order?", "Confirm order", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            If result = DialogResult.Yes Then
                                panOrderInfo.Visible = True 'Error Handler
                                MessageBox.Show("Order confirmed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                If rbComforters.Checked = True Then
                                    lblServiceAvailed.Visible = True
                                    lblServiceFee.Visible = True
                                    lblServiceCategory.Visible = True
                                    lblServiceCategory.Text = "Full Service"
                                    lblServiceAvailed.Text = "Comforters"
                                    lblServiceFee.Text = fv_comforters_fee.ToString()
                                ElseIf rbWDF.Checked = True Then
                                    lblServiceAvailed.Visible = True
                                    lblServiceFee.Visible = True
                                    lblServiceCategory.Visible = True
                                    lblServiceCategory.Text = "Full Service"
                                    lblServiceAvailed.Text = "Wash, Dry, Fold"
                                    lblServiceFee.Text = fv_wdf_fee.ToString()
                                ElseIf cbDry.Checked = True AndAlso cbWash.Checked = True Then
                                    lblServiceAvailed.Visible = True
                                    lblServiceFee.Visible = True
                                    lblServiceCategory.Visible = True
                                    lblServiceAvailed.Text = "Wash and Dry"
                                    lblServiceCategory.Text = "Self Service"
                                    lblServiceFee.Text = sv_washdry_fee.ToString()

                                ElseIf cbDry.Checked = True Then
                                    lblServiceAvailed.Visible = True
                                    lblServiceFee.Visible = True
                                    lblServiceCategory.Visible = True
                                    lblServiceAvailed.Text = "Dry"
                                    lblServiceCategory.Text = "Self Service"
                                    lblServiceFee.Text = sv_dry_fee.ToString()

                                ElseIf cbWash.Checked = True Then
                                    lblServiceAvailed.Visible = True
                                    lblServiceFee.Visible = True
                                    lblServiceCategory.Visible = True
                                    lblServiceAvailed.Text = "Wash"
                                    lblServiceCategory.Text = "Self Service"
                                    lblServiceFee.Text = sv_wash_fee.ToString()
                                End If

                                If cbWash.Checked = True AndAlso cbDry.Checked = True Then
                                    servicePrice = sv_washdry_fee
                                ElseIf cbDry.Checked = True Then
                                    servicePrice = sv_dry_fee
                                ElseIf cbWash.Checked = True Then
                                    servicePrice = sv_wash_fee
                                End If


                                ' Collect checked items
                                selectedAddons.Clear()

                                If cbNone.Checked Then
                                    selectedAddons.Add(("None", 0D, 0)) ' name, price, quantity
                                Else
                                    If cbAddon1.Checked Then selectedAddons.Add(("Ariel/Breeze/Tide", detergent_price, CInt(numAddon1.Value)))
                                    If cbAddon2.Checked Then selectedAddons.Add(("Regular Bleach", regular_bleach_price, CInt(numAddon2.Value)))
                                    If cbAddon3.Checked Then selectedAddons.Add(("Colored Safe Bleach", colored_bleach_price, CInt(numAddon3.Value)))
                                    If cbAddon4.Checked Then selectedAddons.Add(("Fabric Conditioner", fabcon_price, CInt(numAddon4.Value)))
                                End If


                                If cbColored.Text.Trim() = "True" Then
                                    lblIscolored.Text = "True"
                                ElseIf cbColored.Text.Trim() = "False" Then
                                    lblIscolored.Text = "False"
                                End If

                                lblDateAdded.Visible = True
                                lblDateAdded.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy")

                                ' Call the method to update labels
                                CheckBoxHandler(selectedAddons, servicePrice)

                                lblLoadWeight.Visible = True
                                lblLoadWeight.Text = numLoadWeight.Value.ToString + "kg"
                                lblTotal.Visible = True

                                panFullService.Visible = False
                                panSelfService.Visible = False


                                panLayer1.Enabled = False
                                panLayer2.Enabled = False
                                panLayer3.Enabled = False
                                btnNext.Enabled = False

                                Exit Sub
                            End If
                        Else
                            MessageBox.Show("PLEASE ENTER ALL FIELDS", "Incomplete fields", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                    Else
                        MessageBox.Show("PLEASE ENTER ALL FIELDS", "Incomplete fields", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                End If
            Else
                MessageBox.Show("Please enter if colored or not", "Incomplete fields", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("PLEASE ENTER ALL FIELDS", "Incomplete fields", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If




    End Sub

    Private Sub cbNone_CheckedChanged(sender As Object, e As EventArgs) Handles cbNone.CheckedChanged
        cbAddon1.Checked = False
        cbAddon2.Checked = False
        cbAddon3.Checked = False
        cbAddon4.Checked = False

        numAddon1.Value = 0
        numAddon2.Value = 0
        numAddon3.Value = 0
        numAddon4.Value = 0
    End Sub


    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        Dim result As DialogResult

        If Not String.IsNullOrWhiteSpace(txtFirstName.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(txtLastName.Text.Trim()) _
        AndAlso Not String.IsNullOrWhiteSpace(cbCustomerSex.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(txtAmountPaid.Text.Trim()) _
        AndAlso Not String.IsNullOrWhiteSpace(cbProvince.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(cbCity.Text.Trim()) _
        AndAlso Not String.IsNullOrWhiteSpace(cbPaymentMethod.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(lblPostalCode.Text.Trim()) Then
            Try

                'Fields for Customer
                Dim user_id As Integer = Integer.Parse(lblSmallUserID.Text.Trim())
                Dim first_name As String = txtFirstName.Text.Trim()
                Dim last_name As String = txtLastName.Text.Trim()
                Dim middle_ini As String = txtMiddleIni.Text.Trim()
                Dim sex As String = cbCustomerSex.Text.Trim()
                Dim contact As String = txtContactNum.Text.Trim()
                Dim province As String = cbProvince.Text.Trim()
                Dim city As String = cbCity.Text.Trim()
                Dim postal_code As String = lblPostalCode.Text.Trim()
                Dim payment_received As Decimal = Decimal.Parse(txtAmountPaid.Text.Trim())
                Dim payment_method As String = cbPaymentMethod.Text.Trim()


                Dim customer_id As Integer = InsertCustomerData(first_name, last_name, middle_ini, sex, contact, city, province, postal_code)
                Dim transaction_id As Integer = InsertTransaction(customer_id, user_id, payment_received, payment_method)

                'Fields for Transaction Service
                Dim service_name As String = lblServiceAvailed.Text.Trim()
                Dim service_category As String = lblServiceCategory.Text.Trim()
                Dim is_colored As Boolean = Boolean.Parse(lblIscolored.Text.Trim())
                Dim sub_total As Decimal = GetSubTotal(service_name, service_category)
                Dim service_id As Integer = GetServiceID(service_name, service_category)
                Dim note As String = txtRemarks.Text.Trim()
                Dim load_weight As Integer = Integer.Parse(lblLoadWeight.Text.Trim().Replace("kg", ""))

                InsertTransactionService(transaction_id, user_id, sub_total, service_id, is_colored, load_weight, note, service_name)

                Dim addonLabels As Label() = {lblAddon1, lblAddon2, lblAddon3, lblAddon4}
                Dim addonNumbers As NumericUpDown() = {numAddon1, numAddon2, numAddon3, numAddon4}

                For i As Integer = 0 To addonLabels.Length - 1
                    Dim itemName As String = addonLabels(i).Text.Trim()
                    Dim quantity As Integer = CInt(addonNumbers(i).Value)

                    If Not String.IsNullOrWhiteSpace(itemName) AndAlso quantity > 0 Then
                        InsertTransactionOrders(transaction_id, user_id, quantity, note, itemName)
                    End If

                Next

                result = MessageBox.Show("Transaction inserted successfully. Would you like a receipt?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If result = DialogResult.Yes Then
                    Try
                        ' Set file path to Downloads folder
                        Dim downloadsPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")
                        Dim filePath As String = Path.Combine(downloadsPath, "Lavadas_Receipt_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".pdf")

                        ' Create the PDF document
                        Dim pdfDoc As New Document(PageSize.A4, 40, 40, 40, 40)
                        PdfWriter.GetInstance(pdfDoc, New FileStream(filePath, FileMode.Create))
                        pdfDoc.Open()

                        ' Define fonts properly
                        Dim titleFont As iTextSharp.text.Font = FontFactory.GetFont("Verdana", 18.0F, iTextSharp.text.Font.BOLD)
                        Dim headerFont As iTextSharp.text.Font = FontFactory.GetFont("Verdana", 12.0F, iTextSharp.text.Font.BOLD)
                        Dim normalFont As iTextSharp.text.Font = FontFactory.GetFont("Verdana", 11.0F, iTextSharp.text.Font.NORMAL)


                        ' Header
                        pdfDoc.Add(New Paragraph("Lavada's Laundry Services", titleFont))
                        pdfDoc.Add(New Paragraph("Official Receipt", headerFont))
                        pdfDoc.Add(New Paragraph("Date: " & DateTime.Now.ToString("MM/dd/yyyy"), normalFont))
                        pdfDoc.Add(New Paragraph(" "))

                        'Transaction ID
                        pdfDoc.Add(New Paragraph("Transaction ID: " & transaction_id, normalFont))

                        ' Customer Info
                        pdfDoc.Add(New Paragraph("Customer Information", headerFont))
                        pdfDoc.Add(New Paragraph("Name: " & txtFirstName.Text.Trim() & " " & txtMiddleIni.Text.Trim() & " " & txtLastName.Text.Trim(), normalFont))
                        pdfDoc.Add(New Paragraph("Sex: " & cbCustomerSex.Text.Trim(), normalFont))
                        pdfDoc.Add(New Paragraph("Contact: " & txtContactNum.Text.Trim(), normalFont))
                        pdfDoc.Add(New Paragraph("Address: " & cbCity.Text.Trim() & ", " & cbProvince.Text.Trim() & " " & lblPostalCode.Text.Trim(), normalFont))
                        pdfDoc.Add(New Paragraph(" "))

                        ' Service Info
                        pdfDoc.Add(New Paragraph("Service Availed", headerFont))
                        pdfDoc.Add(New Paragraph("Service Name: " & lblServiceAvailed.Text.Trim(), normalFont))
                        pdfDoc.Add(New Paragraph("Category: " & lblServiceCategory.Text.Trim(), normalFont))
                        pdfDoc.Add(New Paragraph("Colored: " & lblIscolored.Text.Trim(), normalFont))
                        pdfDoc.Add(New Paragraph("Load Weight: " & lblLoadWeight.Text.Trim(), normalFont))

                        ' Subtotal using F2 formatting (for 2 decimal places)
                        Dim subtotal As Decimal = GetSubTotal(lblServiceAvailed.Text.Trim(), lblServiceCategory.Text.Trim())
                        pdfDoc.Add(New Paragraph("Subtotal: ₱" & subtotal.ToString("F2"), normalFont))
                        pdfDoc.Add(New Paragraph("Remarks: " & txtRemarks.Text.Trim(), normalFont))
                        pdfDoc.Add(New Paragraph(" "))

                        ' Addons Section
                        pdfDoc.Add(New Paragraph("Add-ons", headerFont))
                        Dim labelAddons As Label() = {lblAddon1, lblAddon2, lblAddon3, lblAddon4}
                        Dim addonNumber As NumericUpDown() = {numAddon1, numAddon2, numAddon3, numAddon4}
                        Dim hasAddon As Boolean = False

                        For i As Integer = 0 To addonLabels.Length - 1
                            Dim addonName As String = labelAddons(i).Text.Trim()
                            Dim qty As Integer = CInt(addonNumber(i).Value)
                            If Not String.IsNullOrWhiteSpace(addonName) AndAlso qty > 0 Then
                                pdfDoc.Add(New Paragraph(addonName & " x " & qty, normalFont))
                                hasAddon = True
                            End If
                        Next

                        If Not hasAddon Then
                            pdfDoc.Add(New Paragraph("None", normalFont))
                        End If

                        pdfDoc.Add(New Paragraph(" "))

                        ' Payment Info
                        pdfDoc.Add(New Paragraph("Payment Details", headerFont))
                        pdfDoc.Add(New Paragraph("Amount Paid: ₱" & txtAmountPaid.Text.Trim(), normalFont))
                        pdfDoc.Add(New Paragraph("Payment Method: " & cbPaymentMethod.Text.Trim(), normalFont))

                        ' Footer
                        pdfDoc.Add(New Paragraph(" "))
                        pdfDoc.Add(New Paragraph("Thank you for trusting Lavada's!", normalFont))

                        pdfDoc.Close()
                        MessageBox.Show("PDF receipt saved to Downloads folder." & vbCrLf & filePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Catch ex As Exception
                        MessageBox.Show("Error generating PDF: " & ex.Message, "PDF Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        WriteLog("Error generating PDF: " & ex.Message)
                    End Try

                End If

                txtFirstName.Text = ""
                txtLastName.Text = ""
                txtMiddleIni.Text = ""
                cbCustomerSex.Text = ""
                txtContactNum.Text = ""
                cbProvince.Text = ""
                cbCity.Text = ""
                lblPostalCode.Text = ""

                panOrderInfo.Visible = False

                cbNone.Checked = True

                panLayer1.Enabled = True
                panLayer2.Enabled = True
                panLayer3.Enabled = True
                btnNextAd.Enabled = True


                lblServiceAvailed.Visible = False
                lblServiceFee.Visible = False
                lblAddon1.Visible = False
                lblAddon2.Visible = False
                lblAddon3.Visible = False
                lblAddon4.Visible = False
                lblAddon1Fee.Visible = False
                lblAddon2Fee.Visible = False
                lblAddon3Fee.Visible = False
                lblAddon4Fee.Visible = False
                lblTotal.Visible = False
                lblDateAdded.Visible = False


            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("PLEASE ENTER ALL FIELDS", "Incomplete fields", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub




    Private Sub btnChangeConfig_Click(sender As Object, e As EventArgs) Handles btnChangeConfig.Click
        ModifyAdminCreds()
        txtChangeConfigUs.Text = ""
        txtChangeConfigPass.Text = ""

        txtChangeConfigUs.Visible = False
        txtChangeConfigPass.Visible = False
        btnChangeConfig.Visible = False
    End Sub


    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure to cancel the order?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("Confirmed cancel", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            panOrderInfo.Visible = False

            cbNone.Checked = True

            panLayer1.Enabled = True
            panLayer2.Enabled = True
            panLayer3.Enabled = True
            btnNextAd.Enabled = True

            lblServiceAvailed.Visible = False
            lblServiceFee.Visible = False
            lblAddon1.Visible = False
            lblAddon2.Visible = False
            lblAddon3.Visible = False
            lblAddon4.Visible = False
            lblAddon1Fee.Visible = False
            lblAddon2Fee.Visible = False
            lblAddon3Fee.Visible = False
            lblAddon4Fee.Visible = False
            lblTotal.Visible = False
            lblDateAdded.Visible = False

        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult
        Dim reusable_id As Integer

        reusable_id = Integer.Parse(lblSmallUserID.Text.Trim())

        result = MessageBox.Show("Are you sure to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("Logged out successfully", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Set user account status
            SetUserOffline(reusable_id)
            Me.Close()
            LoginPage.Show()
        End If
    End Sub

    Private Sub btnHideUser_Click(sender As Object, e As EventArgs) Handles btnHideUser.Click
        If txtEditAdminUser.PasswordChar = "*" Then
            txtEditAdminUser.PasswordChar = "" ' Show the password

        Else
            txtEditAdminUser.PasswordChar = "*" ' Hide the password

        End If
    End Sub

    Private Sub btnHidePassword_Click(sender As Object, e As EventArgs) Handles btnHidePassword.Click
        If txtChangePassword.PasswordChar = "*" Then
            txtChangePassword.PasswordChar = "" ' Show the password

        Else
            txtChangePassword.PasswordChar = "*" ' Hide the password

        End If
    End Sub

    Private Sub btnConf_Click(sender As Object, e As EventArgs) Handles btnConf.Click
        If txtConfirmPassword.PasswordChar = "*" Then
            txtConfirmPassword.PasswordChar = "" ' Show the password

        Else
            txtConfirmPassword.PasswordChar = "*" ' Hide the password
        End If
    End Sub

    Private Sub btnAddService_Click(sender As Object, e As EventArgs) Handles btnAddService.Click

        If Not String.IsNullOrWhiteSpace(cbServiceName.Text.Trim()) AndAlso
       Not String.IsNullOrWhiteSpace(cbServiceCategory.Text.Trim()) AndAlso
       Not String.IsNullOrWhiteSpace(cbServiceStatus.Text.Trim()) AndAlso
       Not String.IsNullOrWhiteSpace(txtServiceFee.Text.Trim()) AndAlso
       Not String.IsNullOrWhiteSpace(cbServiceAvail.Text.Trim()) Then

            ' Try parsing the service fee
            Dim service_fee As Decimal
            If Not Decimal.TryParse(txtServiceFee.Text.Trim(), service_fee) Then
                MessageBox.Show("Please enter a valid number for the service fee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Now safely assign all other variables
            Dim service_name As String = cbServiceName.Text.Trim()
            Dim service_category As String = cbServiceCategory.Text.Trim()
            Dim service_status As String = cbServiceStatus.Text.Trim()
            Dim is_available As Boolean

            ' Parse Boolean safely too
            If Not Boolean.TryParse(cbServiceAvail.Text.Trim(), is_available) Then
                MessageBox.Show("Please enter a valid availability value (True/False).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim description As String = txtServiceDescription.Text.Trim()

            ' Proceed to insert only if all inputs are valid
            InsertServiceData(service_name, service_category, service_fee, is_available, service_status, description)
            LoadToDGV(services_query, dgvServices, db_name)

            ' Clear fields
            cbServiceName.Text = ""
            cbServiceCategory.Text = ""
            txtServiceFee.Text = ""
            cbServiceStatus.Text = ""
            cbServiceAvail.Text = ""
            txtServiceDescription.Text = ""

        Else
            MessageBox.Show("PLEASE ENTER ALL FIELDS", "Incomplete fields", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


    Private Sub cbServiceCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbServiceCategory.SelectedIndexChanged
        cbServiceName.Items.Clear()

        If cbServiceCategory.SelectedItem IsNot Nothing Then
            Select Case cbServiceCategory.SelectedItem.ToString()
                Case "Full Service"
                    ' Add all towns and city of Camarines Norte
                    cbServiceName.Items.Add("Wash, Dry, Fold")
                    cbServiceName.Items.Add("Comforters")

            ' Add more cases for other provinces as needed
                Case "Self Service"
                    cbServiceName.Items.Add("Wash")
                    cbServiceName.Items.Add("Dry")
                    cbServiceName.Items.Add("Wash and Dry")

            End Select
        End If

    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click


        If Not String.IsNullOrWhiteSpace(txtAddEmUserName.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(txtAddEmPassword.Text.Trim()) Then

            Dim employee_fname As String = txtAddEmFirst.Text.Trim()
            Dim employee_lname As String = txtAddEmLast.Text.Trim()
            Dim employee_contact As String = txtAddEmContact.Text.Trim()
            Dim employee_age As Integer = Integer.Parse(txtEmployeeAge.Text.Trim())
            Dim employee_sex As String = cbAddEmSex.Text.Trim()
            Dim employee_email As String = txtAddEmEmail.Text.Trim()
            Dim employee_city As String = cbAddCity.Text.Trim()
            Dim employee_province As String = cbAddProvince.Text.Trim()
            Dim employee_working_hours As String = cbAddWorkingHours.Text.Trim()
            Dim employee_shift As String = cbAddShift.Text.Trim()
            Dim user_name As String = txtAddEmUserName.Text.Trim()
            Dim user_pass As String = txtAddEmPassword.Text.Trim()

            If (txtAddEmPassword.Text.Trim() = txtAddConfirmPass.Text.Trim()) Then
                InsertEmployeeAcc(user_name, user_pass)
                MessageBox.Show("Employee account insterted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If Not String.IsNullOrWhiteSpace(txtAddEmFirst.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(txtAddEmLast.Text.Trim()) _
                AndAlso Not String.IsNullOrWhiteSpace(txtAddEmContact.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(txtAddEmEmail.Text.Trim()) _
                AndAlso Not String.IsNullOrWhiteSpace(cbAddCity.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(cbAddProvince.Text.Trim()) _
                AndAlso Not String.IsNullOrWhiteSpace(txtEmployeeAge.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(cbAddEmSex.Text.Trim()) _
                AndAlso Not String.IsNullOrWhiteSpace(cbAddWorkingHours.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(cbAddShift.Text.Trim()) Then

                    InsertEmployeeData(employee_fname, employee_lname, employee_contact, employee_age, employee_sex, employee_city, employee_province, employee_email, employee_working_hours, employee_shift)


                    txtAddEmFirst.Text = ""
                    txtAddEmLast.Text = ""
                    txtAddEmContact.Text = ""
                    txtEmployeeAge.Text = ""
                    cbAddEmSex.Text = ""
                    txtAddEmEmail.Text = ""
                    cbAddCity.Text = ""
                    cbAddProvince.Text = ""
                    cbAddWorkingHours.Text = ""
                    cbAddShift.Text = ""
                    txtAddEmUserName.Text = ""
                    txtAddEmPassword.Text = ""
                    txtAddConfirmPass.Text = ""

                    LoadToDGV(employees_query, dgvEmployee, db_name)
                    Exit Sub
                Else
                    MessageBox.Show("Please enter proper fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                MessageBox.Show("Password does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else
            MessageBox.Show("Please enter proper fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub

    Private Sub cbAddWorkingHours_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAddWorkingHours.SelectedIndexChanged
        cbAddShift.Items.Clear()

        If cbAddWorkingHours.SelectedItem IsNot Nothing Then
            Select Case cbAddWorkingHours.SelectedItem.ToString()
                Case "Full-time"
                    ' Add all towns and city of Camarines Norte
                    cbAddShift.Items.Add("Full-time")


            ' Add more cases for other provinces as needed
                Case "Part-time"
                    cbAddShift.Items.Add("Morning")
                    cbAddShift.Items.Add("Afternoon")

            End Select
        End If

    End Sub

    Private Sub btnAddEmPass_Click(sender As Object, e As EventArgs) Handles btnAddEmPass.Click
        If txtAddEmPassword.PasswordChar = "*" Then
            txtAddEmPassword.PasswordChar = "" ' Show the password

        Else
            txtAddEmPassword.PasswordChar = "*" ' Hide the password

        End If
    End Sub

    Private Sub btnConfirmPass_Click(sender As Object, e As EventArgs) Handles btnAddEmConfirm.Click
        If txtAddConfirmPass.PasswordChar = "*" Then
            txtAddConfirmPass.PasswordChar = "" ' Show the password

        Else
            txtAddConfirmPass.PasswordChar = "*" ' Hide the password

        End If
    End Sub

    Private Sub btnEmployeeDGVrefresh_Click(sender As Object, e As EventArgs) Handles btnEmployeeDGVrefresh.Click
        LoadToDGV(employees_query, dgvEmployee, db_name)
    End Sub

    Private Sub btnSelectEdit_Click(sender As Object, e As EventArgs) Handles btnSelectEdit.Click
        If dgvEmployee.SelectedRows.Count > 0 Then

            Dim selectedRow As DataGridViewRow = dgvEmployee.SelectedRows(0)

            lblEmployeeID.Text = selectedRow.Cells("employee_id").Value.ToString()
            lblInvisibleIDEDIT.Text = selectedRow.Cells("user_id").Value.ToString()
            Dim firstName As String = selectedRow.Cells("employee_fname").Value.ToString()
            Dim lastName As String = selectedRow.Cells("employee_lname").Value.ToString()
            Dim contact As String = selectedRow.Cells("employee_contact").Value.ToString()
            Dim email As String = selectedRow.Cells("email").Value.ToString()
            Dim age As String = selectedRow.Cells("employee_age").Value.ToString()
            Dim city As String = selectedRow.Cells("employee_city").Value.ToString()
            Dim province As String = selectedRow.Cells("employee_province").Value.ToString()
            Dim working_hours As String = selectedRow.Cells("working_hours").Value.ToString()
            Dim shift As String = selectedRow.Cells("shift").Value.ToString()
            Dim date_added As String = selectedRow.Cells("employment_date").Value.ToString()
            Dim status As String = selectedRow.Cells("status").Value.ToString()


            txtEmployeeFirstName.Text = firstName
            txtEmployeeLastName.Text = lastName
            txtContact.Text = contact
            txtEmail.Text = email
            txtEditEmAge.Text = age
            cbEmCityTown.Text = city
            cbEmProvince.Text = province
            cbEmWorkingHours.Text = working_hours
            cbEmShift.Text = shift
            lblEmployeeDateAdded.Text = date_added
            lblEmployeeStatus.Text = status

            lblEmployeeID.Visible = True
            lblEmployeeStatus.Visible = True
            lblEmployeeDateAdded.Visible = True

            MessageBox.Show("Employee data selected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Please select a row to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub btnEditEmployees_Click(sender As Object, e As EventArgs) Handles btnEditEmployees.Click

        Dim result As DialogResult

        If Not String.IsNullOrWhiteSpace(txtEmployeeFirstName.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(txtEmployeeLastName.Text.Trim()) _
                AndAlso Not String.IsNullOrWhiteSpace(txtContact.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(txtEmail.Text.Trim()) _
                AndAlso Not String.IsNullOrWhiteSpace(cbEmCityTown.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(cbEmProvince.Text.Trim()) _
                AndAlso Integer.TryParse(txtEditEmAge.Text.Trim(), Nothing) AndAlso Not String.IsNullOrWhiteSpace(cbEmWorkingHours.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(cbEmShift.Text.Trim()) Then
            Dim user_id As Integer = Integer.Parse(lblInvisibleIDEDIT.Text.Trim())
            Dim employee_fname As String = txtEmployeeFirstName.Text.Trim()
            Dim employee_lname As String = txtEmployeeLastName.Text.Trim()
            Dim employee_contact As String = txtContact.Text.Trim()
            Dim employee_age As Integer = Integer.Parse(txtEditEmAge.Text.Trim())
            Dim employee_email As String = txtEmail.Text.Trim()
            Dim employee_city As String = cbEmCityTown.Text.Trim()
            Dim employee_province As String = cbEmProvince.Text.Trim()
            Dim employee_working_hours As String = cbEmWorkingHours.Text.Trim()
            Dim employee_shift As String = cbEmShift.Text.Trim()
            Dim employee_user_name As String = txtEmUserName.Text.Trim()
            Dim employee_password As String = txtEmPassword.Text.Trim()
            If String.IsNullOrWhiteSpace(employee_user_name) OrElse String.IsNullOrWhiteSpace(employee_password) Then
                result = MessageBox.Show("Are you sure to apply changes without changing employee's account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    UpdateEmployeeData(user_id, employee_fname, employee_lname, employee_contact, employee_age, employee_city, employee_province, employee_email, employee_working_hours, employee_shift)
                    MessageBox.Show("Employee data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    lblInvisibleIDEDIT.Text = ""
                    txtEmployeeFirstName.Text = ""
                    txtEmployeeLastName.Text = ""
                    txtContact.Text = ""
                    txtEditEmAge.Text = ""
                    txtEmail.Text = ""
                    cbEmCityTown.Text = ""
                    cbEmProvince.Text = ""
                    cbEmWorkingHours.Text = ""
                    cbEmShift.Text = ""
                    txtEmUserName.Text = ""
                    txtEmPassword.Text = ""

                    lblEmployeeID.Visible = False
                    lblEmployeeStatus.Visible = False
                    lblEmployeeDateAdded.Visible = False

                    LoadToDGV(employees_query, dgvEmployee, db_name)
                    Exit Sub
                ElseIf result = DialogResult.No Then
                    Exit Sub
                End If

            ElseIf Not String.IsNullOrWhiteSpace(employee_user_name) OrElse Not String.IsNullOrWhiteSpace(employee_password) Then

                If (txtEmPassword.Text = txtEditConfirmPass.Text) Then
                    UpdateEmployeeAcc(user_id, employee_user_name, employee_password)
                    UpdateEmployeeData(user_id, employee_fname, employee_lname, employee_contact, employee_age, employee_city, employee_province, employee_email, employee_working_hours, employee_shift)
                    MessageBox.Show("Employee data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    lblInvisibleIDEDIT.Text = ""
                    txtEmployeeFirstName.Text = ""
                    txtEmployeeLastName.Text = ""
                    txtContact.Text = ""
                    txtEditEmAge.Text = ""
                    txtEmail.Text = ""
                    cbEmCityTown.Text = ""
                    cbEmProvince.Text = ""
                    cbEmWorkingHours.Text = ""
                    cbEmShift.Text = ""
                    txtEmUserName.Text = ""
                    txtEmPassword.Text = ""
                    lblEmployeeID.Visible = False
                    lblEmployeeStatus.Visible = False
                    lblEmployeeDateAdded.Visible = False
                    LoadToDGV(employees_query, dgvEmployee, db_name)
                    Exit Sub
                Else
                    MessageBox.Show("Please enter proper fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Please enter proper fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please select a row first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEditUserAcc_Click(sender As Object, e As EventArgs) Handles btnEditUserAcc.Click
        If txtEmPassword.PasswordChar = "*" Then
            txtEmPassword.PasswordChar = "" ' Show the password

        Else
            txtEmPassword.PasswordChar = "*" ' Hide the password

        End If

    End Sub

    Private Sub btnEditConfirm_Click(sender As Object, e As EventArgs) Handles btnEditConfirm.Click
        If txtEditConfirmPass.PasswordChar = "*" Then
            txtEditConfirmPass.PasswordChar = "" ' Show the password

        Else
            txtEditConfirmPass.PasswordChar = "*" ' Hide the password

        End If

    End Sub

    Private Sub btnSelectDelete_Click(sender As Object, e As EventArgs) Handles btnSelectDelete.Click
        If dgvEmployee.SelectedRows.Count > 0 Then

            Dim selectedRow As DataGridViewRow = dgvEmployee.SelectedRows(0)

            lblRemEmID.Text = selectedRow.Cells("employee_id").Value.ToString()
            lblRemEmInvi.Text = selectedRow.Cells("user_id").Value.ToString()
            Dim firstName As String = selectedRow.Cells("employee_fname").Value.ToString()
            Dim lastName As String = selectedRow.Cells("employee_lname").Value.ToString()
            Dim contact As String = selectedRow.Cells("employee_contact").Value.ToString()
            Dim email As String = selectedRow.Cells("email").Value.ToString()
            Dim date_added As String = selectedRow.Cells("employment_date").Value.ToString()
            Dim status As String = selectedRow.Cells("status").Value.ToString()


            lblRemEmID.Text = firstName + " " + lastName
            lblRemEmName.Text = lastName
            lblRemEmContact.Text = contact
            lblRemEmEmail.Text = email
            lblRemEmDate.Text = date_added
            lblRemEmStatus.Text = status

            lblRemEmID.Visible = True
            lblRemEmName.Visible = True
            lblRemEmContact.Visible = True
            lblRemEmEmail.Visible = True
            lblRemEmDate.Visible = True
            lblRemEmStatus.Visible = True


            MessageBox.Show("Employee data selected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Please select a row to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnClearEditFields_Click(sender As Object, e As EventArgs) Handles btnClearEditFields.Click
        lblInvisibleIDEDIT.Text = ""
        txtEmployeeFirstName.Text = ""
        txtEmployeeLastName.Text = ""
        txtContact.Text = ""
        txtEditEmAge.Text = ""
        txtEmail.Text = ""
        cbEmCityTown.Text = ""
        cbEmProvince.Text = ""
        cbEmWorkingHours.Text = ""
        cbEmShift.Text = ""
        txtEmUserName.Text = ""
        txtEmPassword.Text = ""
        lblEmployeeID.Visible = False
        lblEmployeeStatus.Visible = False
        lblEmployeeDateAdded.Visible = False
        MessageBox.Show("Cleared", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnClearAddEm_Click(sender As Object, e As EventArgs) Handles btnClearAddEm.Click
        txtAddEmFirst.Text = ""
        txtAddEmLast.Text = ""
        txtAddEmContact.Text = ""
        txtEmployeeAge.Text = ""
        cbAddEmSex.Text = ""
        txtAddEmEmail.Text = ""
        cbAddCity.Text = ""
        cbAddProvince.Text = ""
        cbAddWorkingHours.Text = ""
        cbAddShift.Text = ""

        txtAddEmUserName.Text = ""
        txtAddEmPassword.Text = ""
        txtAddConfirmPass.Text = ""
        MessageBox.Show("Cleared", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnRemoveEmployee_Click(sender As Object, e As EventArgs) Handles btnRemoveEmployee.Click


        If Not String.IsNullOrWhiteSpace(lblRemEmInvi.Text) AndAlso Not String.IsNullOrWhiteSpace(lblRemEmID.Text) AndAlso Not String.IsNullOrWhiteSpace(lblRemEmName.Text) _
            AndAlso Not String.IsNullOrWhiteSpace(lblRemEmContact.Text) AndAlso Not String.IsNullOrWhiteSpace(lblRemEmEmail.Text) AndAlso Not String.IsNullOrWhiteSpace(lblRemEmStatus.Text) _
            AndAlso Not String.IsNullOrWhiteSpace(lblRemEmDate.Text) Then

            If Not String.IsNullOrWhiteSpace(lblItemID.Text.Trim()) Then
                Dim result As DialogResult
                Dim user_id As Integer = Integer.Parse(lblRemEmInvi.Text.Trim())
                result = MessageBox.Show("Are you sure to delete this account?", "ACCOUNT DELETION", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    DeleteEmployeeAcc(user_id)
                    MessageBox.Show("Employee removed", "ACCOUNT DELETION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadToDGV(employees_query, dgvEmployee, db_name)

                    lblRemEmInvi.Text = ""
                    lblRemEmID.Text = ""
                    lblRemEmName.Text = ""
                    lblRemEmContact.Text = ""
                    lblRemEmEmail.Text = ""
                    lblRemEmStatus.Text = ""
                    lblRemEmDate.Text = ""
                    Exit Sub
                Else
                    Exit Sub
                End If
            Else
                MessageBox.Show("Please select an account first", "ACCOUNT DELETION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Please select an account first", "ACCOUNT DELETION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub



    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim search_term As String = "%" & txtSearch.Text & "%"

        Try
            openConn(db_name)

            Dim query As String = "SELECT * " &
                              "FROM employees " &
                              "WHERE employee_fname LIKE @search OR employee_lname LIKE @search OR employee_id LIKE @search"

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@search", "%" & search_term & "%")

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgvEmployee.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Error searching employees: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub cbItemName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbItemName.SelectedIndexChanged
        cbItemBrand.Items.Clear()

        If cbItemName.SelectedItem IsNot Nothing Then
            Select Case cbItemName.SelectedItem.ToString()
                Case "Gas"
                    cbItemBrand.Items.Add("Petron Gasul")
                    cbItemBrand.Items.Add("Solane")
                    cbItemBrand.Items.Add("Regasco")
                    cbItemBrand.Items.Add("Gasulite")

                Case "Detergent"
                    cbItemBrand.Items.Add("Surf")
                    cbItemBrand.Items.Add("Tide")
                    cbItemBrand.Items.Add("Ariel")
                    cbItemBrand.Items.Add("Champion")
                    cbItemBrand.Items.Add("Pride")

                Case "Fabric conditioner"
                    cbItemBrand.Items.Add("Downy")
                    cbItemBrand.Items.Add("Comfort")
                    cbItemBrand.Items.Add("Surf Fabcon")
                    cbItemBrand.Items.Add("Sta. Lucia")

                Case "Bleach"
                    cbItemBrand.Items.Add("Zonrox")
                    cbItemBrand.Items.Add("Clorox")
                    cbItemBrand.Items.Add("Mr. Muscle")
                    cbItemBrand.Items.Add("Lysol Bleach")

                Case "Plastic bags"
                    cbItemBrand.Items.Add("Generic")


                Case "Scotch tape"
                    cbItemBrand.Items.Add("Generic")


                Case "Alcohol"
                    cbItemBrand.Items.Add("Green Cross")
                    cbItemBrand.Items.Add("Doctor J")
                    cbItemBrand.Items.Add("Casino")
                    cbItemBrand.Items.Add("Philusa")
                    cbItemBrand.Items.Add("Family Guard")

                Case "Tissue"
                    cbItemBrand.Items.Add("Sanicare")
                    cbItemBrand.Items.Add("Kleenex")
                    cbItemBrand.Items.Add("Freeney")
                    cbItemBrand.Items.Add("Tisyu")
                    cbItemBrand.Items.Add("Soft & Clean")
                    cbItemBrand.Items.Add("Nice Day")

            End Select
        End If

    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If Not String.IsNullOrWhiteSpace(cbItemName.Text.Trim()) AndAlso
       Not String.IsNullOrWhiteSpace(cbItemBrand.Text.Trim()) AndAlso
       Not String.IsNullOrWhiteSpace(txtItemPrice.Text.Trim()) AndAlso
       Not String.IsNullOrWhiteSpace(txtItemCost.Text.Trim()) AndAlso
       Not String.IsNullOrWhiteSpace(txtRestockItem.Text.Trim()) Then

            Dim item_price As Decimal
            Dim item_cost As Decimal
            Dim quantity_restock As Integer

            If Not Decimal.TryParse(txtItemPrice.Text.Trim(), item_price) Then
                MessageBox.Show("Please enter a valid number for ITEM PRICE.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not Decimal.TryParse(txtItemCost.Text.Trim(), item_cost) Then
                MessageBox.Show("Please enter a valid number for ITEM COST.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not Integer.TryParse(txtRestockItem.Text.Trim(), quantity_restock) Then
                MessageBox.Show("Please enter a valid number for RESTOCK QUANTITY.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim item_name As String = cbItemName.Text.Trim()
            Dim item_brand As String = cbItemBrand.Text.Trim()
            Dim restock_date As Date = dateRestock.Value

            InsertInventoryData(item_name, item_brand, quantity_restock, item_price, item_cost, restock_date)

            ' Clear inputs
            cbItemName.Text = ""
            cbItemBrand.Text = ""
            txtItemPrice.Text = ""
            txtRestockItem.Text = ""
            txtItemCost.Text = ""

            LoadToDGV(inventory_query, dgvInventory, db_name)

        Else
            MessageBox.Show("Please complete all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub btnViewItem_Click(sender As Object, e As EventArgs) Handles btnViewItem.Click
        If dgvInventory.SelectedRows.Count > 0 Then

            Dim selectedRow As DataGridViewRow = dgvInventory.SelectedRows(0)

            lblItemID.Text = selectedRow.Cells("item_id").Value.ToString()
            Dim item_name As String = selectedRow.Cells("item_name").Value.ToString()
            Dim item_brand As String = selectedRow.Cells("item_brand").Value.ToString()
            Dim item_price As String = selectedRow.Cells("item_price").Value.ToString()
            Dim item_cost As String = selectedRow.Cells("item_cost").Value.ToString()
            Dim quantity_in_stock As String = selectedRow.Cells("current_quantity_in_stock").Value.ToString()
            Dim reorder_level As String = selectedRow.Cells("reorder_level").Value.ToString()
            Dim status As String = selectedRow.Cells("status").Value.ToString()
            Dim last_restock_date As String = selectedRow.Cells("last_restock_date").Value.ToString()
            Dim date_modified As String = selectedRow.Cells("date_modified").Value.ToString()

            cbItemName.Text = item_name
            cbItemBrand.Text = item_brand
            txtItemPrice.Text = item_price
            txtItemCost.Text = item_cost
            lblQuantityInStock.Text = quantity_in_stock
            lblReorderLevel.Text = reorder_level
            lblItemStatus.Text = status
            lblLastRestock.Text = last_restock_date
            lblDateModified.Text = date_modified


            lblItemID.Visible = True
            lblLastRestock.Visible = True
            lblQuantityInStock.Visible = True
            lblReorderLevel.Visible = True
            lblItemStatus.Visible = True

            MessageBox.Show("Item data selected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAddItem.Enabled = False
        Else
            MessageBox.Show("Please select a row to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnInventoryRefresh_Click(sender As Object, e As EventArgs) Handles btnInventoryRefresh.Click
        If btnSwitchOrdersTable.Text = "Switch to Inventory table" Then
            LoadToDGV(transac_order, dgvInventory, db_name)
            MessageBox.Show("Table refreshed", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf btnSwitchOrdersTable.Text = "Switch to Order transactions" Then
            LoadToDGV(inventory_query, dgvInventory, db_name)
            MessageBox.Show("Table refreshed", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRemoveFields.Click
        lblRemEmInvi.Text = ""
        lblRemEmID.Text = ""
        lblRemEmName.Text = ""
        lblRemEmContact.Text = ""
        lblRemEmEmail.Text = ""
        lblRemEmStatus.Text = ""
        lblRemEmDate.Text = ""
        MessageBox.Show("Cleared", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnDeleteOwnAccount_Click(sender As Object, e As EventArgs) Handles btnDeleteOwnAccount.Click
        'Dim result As DilogueResult
        'result = MessageBox.Show("Are you sure to delete your account? Progress will be lost", "ACCOUNT DELETION", MessageBoxButton.YesNo, MessageBoxIcon.Question)
        'If
        'DeleteAdminAcc()
        'ElSeIf
        'EndIf

    End Sub

    Private Sub btnUpdateItem_Click(sender As Object, e As EventArgs) Handles btnUpdateItem.Click
        If Not String.IsNullOrWhiteSpace(cbItemName.Text.Trim()) AndAlso
       Not String.IsNullOrWhiteSpace(cbItemBrand.Text.Trim()) AndAlso
       Not String.IsNullOrWhiteSpace(txtItemPrice.Text.Trim()) AndAlso
       Not String.IsNullOrWhiteSpace(txtItemCost.Text.Trim()) AndAlso
       Not String.IsNullOrWhiteSpace(txtRestockItem.Text.Trim()) Then

            Dim item_id As Integer
            If Not Integer.TryParse(lblItemID.Text.Trim(), item_id) Then
                MessageBox.Show("Invalid Item ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim restock_quantity As Integer
            Dim item_price As Decimal
            Dim item_cost As Decimal

            If Not Integer.TryParse(txtRestockItem.Text.Trim(), restock_quantity) Then
                MessageBox.Show("Please enter a valid number for RESTOCK QUANTITY.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not Decimal.TryParse(txtItemPrice.Text.Trim(), item_price) Then
                MessageBox.Show("Please enter a valid number for ITEM PRICE.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not Decimal.TryParse(txtItemCost.Text.Trim(), item_cost) Then
                MessageBox.Show("Please enter a valid number for ITEM COST.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim item_name As String = cbItemName.Text.Trim()
            Dim item_brand As String = cbItemBrand.Text.Trim()
            Dim restock_date As Date = dateRestock.Value

            UpdateInventoryData(item_id, item_name, restock_quantity, item_brand, item_cost, item_price, restock_date)
            LoadToDGV(inventory_query, dgvInventory, db_name)

            cbItemName.Text = ""
            cbItemBrand.Text = ""
            txtItemPrice.Text = ""
            txtItemCost.Text = ""
            lblQuantityInStock.Text = ""
            lblReorderLevel.Text = ""
            lblItemStatus.Text = ""
            lblDateModified.Text = ""

            lblItemID.Visible = False
            lblLastRestock.Visible = False
            lblQuantityInStock.Visible = False
            lblReorderLevel.Visible = False
            lblItemStatus.Visible = False

            btnAddItem.Enabled = True
        Else
            MessageBox.Show("Please select an item and complete all fields.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub btnRefreshServices_Click(sender As Object, e As EventArgs) Handles btnRefreshServices.Click

        If btnSwitchTables.Text = "Switch to Service table" Then
            LoadToDGV(transac_service, dgvServices, db_name)
            MessageBox.Show("Table refreshed", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf btnSwitchTables.Text = "Switch to Service transactions" Then
            LoadToDGV(services_query, dgvServices, db_name)
            MessageBox.Show("Table refreshed", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        If dgvInventory.SelectedRows.Count > 0 Then

            Dim selectedRow As DataGridViewRow = dgvInventory.SelectedRows(0)
            Dim item_id As Integer = selectedRow.Cells("item_id").Value
            Dim result As DialogResult = MessageBox.Show("Are you sure to delete this item row?", "ITEM DELETION", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                DeleteInventoryRow(item_id)
                LoadToDGV(inventory_query, dgvInventory, db_name)
                btnAddItem.Enabled = True
                Exit Sub

            Else
                Exit Sub
            End If


        Else
            MessageBox.Show("Please select a row to delete first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub btnClearItemFields_Click(sender As Object, e As EventArgs) Handles btnClearItemFields.Click
        cbItemName.Text = ""
        cbItemBrand.Text = ""
        txtItemPrice.Text = ""
        txtItemCost.Text = ""
        txtRestockItem.Text = ""
        lblQuantityInStock.Text = ""
        lblReorderLevel.Text = ""
        lblItemStatus.Text = ""
        lblDateModified.Text = ""

        lblItemID.Visible = False
        lblLastRestock.Visible = False
        lblQuantityInStock.Visible = False
        lblReorderLevel.Visible = False
        lblItemStatus.Visible = False
        btnAddItem.Enabled = True
        MessageBox.Show("Cleared", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnDeleteService_Click(sender As Object, e As EventArgs) Handles btnDeleteService.Click
        If dgvServices.SelectedRows.Count > 0 Then

            Dim selectedRow As DataGridViewRow = dgvServices.SelectedRows(0)
            Dim item_id As Integer = selectedRow.Cells("service_id").Value
            Dim result As DialogResult = MessageBox.Show("Are you sure to delete this service row?", "ITEM DELETION", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                DeleteServiceRow(item_id)
                LoadToDGV(services_query, dgvServices, db_name)
                btnAddService.Enabled = True
                Exit Sub

            Else
                Exit Sub
            End If


        Else
            MessageBox.Show("Please select a row to delete first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnViewService_Click(sender As Object, e As EventArgs) Handles btnViewService.Click
        If dgvServices.SelectedRows.Count > 0 Then

            Dim selectedRow As DataGridViewRow = dgvServices.SelectedRows(0)



            lblServiceID.Text = selectedRow.Cells("service_id").Value.ToString()
            Dim service_category As String = selectedRow.Cells("service_category").Value.ToString()
            Dim service_name As String = selectedRow.Cells("service_name").Value.ToString()
            Dim service_fee As String = selectedRow.Cells("service_fee").Value.ToString()
            Dim is_active As Boolean = Convert.ToBoolean(dgvServices.SelectedRows(0).Cells("is_available").Value)
            Dim is_available As String = is_active.ToString()
            Dim service_status As String = selectedRow.Cells("service_status").Value.ToString()
            Dim times_availed As String = selectedRow.Cells("times_availed").Value.ToString()
            Dim date_added As String = selectedRow.Cells("date_added").Value.ToString()
            Dim description As String = selectedRow.Cells("description").Value.ToString()
            Dim date_modified As String = selectedRow.Cells("date_modified").Value.ToString()

            cbServiceCategory.Text = service_category
            cbServiceName.Text = service_name
            txtServiceFee.Text = service_fee
            cbServiceAvail.Text = is_available
            cbServiceStatus.Text = service_status
            lblTimesAvailed.Text = times_availed
            lblServiceDateModified.Text = date_modified
            lblServiceDateAdded.Text = date_added
            txtServiceDescription.Text = description

            lblTimesAvailed.Visible = True
            lblServiceID.Visible = True
            lblServiceDateAdded.Visible = True
            lblServiceDateModified.Visible = True

            MessageBox.Show("Service data selected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAddService.Enabled = False
        Else
            MessageBox.Show("Please select a row to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnClearFields_Click(sender As Object, e As EventArgs) Handles btnClearFields.Click
        cbServiceCategory.Text = ""
        cbServiceName.Text = ""
        txtServiceFee.Text = ""
        cbServiceAvail.Text = ""
        cbServiceStatus.Text = ""
        lblTimesAvailed.Text = ""
        lblServiceDateModified.Text = ""
        lblServiceDateAdded.Text = ""
        txtServiceDescription.Text = ""

        lblTimesAvailed.Visible = False
        lblServiceID.Visible = False
        lblServiceDateAdded.Visible = False
        lblServiceDateModified.Visible = False
        btnAddService.Enabled = True
        MessageBox.Show("Cleared", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cbCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCity.SelectedIndexChanged
        If cbCity.SelectedItem IsNot Nothing Then
            Select Case cbCity.SelectedItem.ToString()
                Case "Basud"
                    lblPostalCode.Text = "4608"
                    lblPostalCode.Visible = True

                Case "Capalonga"
                    lblPostalCode.Text = "4607"
                    lblPostalCode.Visible = True

                Case "Daet"
                    lblPostalCode.Text = "4600"
                    lblPostalCode.Visible = True

                Case "Jose Panganiban"
                    lblPostalCode.Text = "4606"
                    lblPostalCode.Visible = True

                Case "Labo"
                    lblPostalCode.Text = "4604"
                    lblPostalCode.Visible = True

                Case "Mercedes"
                    lblPostalCode.Text = "4601"
                    lblPostalCode.Visible = True

                Case "Paracale"
                    lblPostalCode.Text = "4605"
                    lblPostalCode.Visible = True

                Case "San Lorenzo Ruiz"
                    lblPostalCode.Text = "4610"
                    lblPostalCode.Visible = True

                Case "San Vicente"
                    lblPostalCode.Text = "4609"
                    lblPostalCode.Visible = True

                Case "Santa Elena"
                    lblPostalCode.Text = "4611"
                    lblPostalCode.Visible = True

                Case "Talisay"
                    lblPostalCode.Text = "4602"
                    lblPostalCode.Visible = True

                Case "Vinzons"
                    lblPostalCode.Text = "4603"
                    lblPostalCode.Visible = True

            End Select
        End If

        ' Optionally, set the first item as the default selected item

    End Sub

    Private Sub btnUpdateService_Click(sender As Object, e As EventArgs) Handles btnUpdateService.Click
        If Not String.IsNullOrWhiteSpace(cbServiceCategory.Text.Trim()) AndAlso
       Not String.IsNullOrWhiteSpace(cbServiceName.Text.Trim()) AndAlso
       Not String.IsNullOrWhiteSpace(txtServiceFee.Text.Trim()) AndAlso
       Not String.IsNullOrWhiteSpace(cbServiceAvail.Text.Trim()) AndAlso
       Not String.IsNullOrWhiteSpace(cbServiceStatus.Text.Trim()) Then

            Dim service_id As Integer
            If Not Integer.TryParse(lblServiceID.Text.Trim(), service_id) Then
                MessageBox.Show("Invalid Service ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim service_fee As Decimal
            If Not Decimal.TryParse(txtServiceFee.Text.Trim(), service_fee) Then
                MessageBox.Show("Please enter a valid number for the service fee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim is_available As Boolean
            If Not Boolean.TryParse(cbServiceAvail.Text.Trim(), is_available) Then
                MessageBox.Show("Please enter a valid value for availability (True/False).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim service_category As String = cbServiceCategory.Text.Trim()
            Dim service_name As String = cbServiceName.Text.Trim()
            Dim service_status As String = cbServiceStatus.Text.Trim()
            Dim service_description As String = txtServiceDescription.Text.Trim()

            ' Proceed only if everything is valid
            UpdateServiceRow(service_id, service_name, service_category, service_fee, is_available, service_status, service_description)

            LoadToDGV(services_query, dgvServices, db_name)

            ' Clear fields and reset
            lblServiceID.Text = ""
            cbServiceCategory.Text = ""
            cbServiceName.Text = ""
            txtServiceFee.Text = ""
            cbServiceAvail.Text = ""
            cbServiceStatus.Text = ""
            txtServiceDescription.Text = ""

            lblTimesAvailed.Visible = False
            lblServiceID.Visible = False
            lblServiceDateAdded.Visible = False
            lblServiceDateModified.Visible = False
            btnAddService.Enabled = True

            UpdateServiceVisibility()

        Else
            MessageBox.Show("Please select a row and complete all fields.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub txtInventorySearch_TextChanged(sender As Object, e As EventArgs) Handles txtInventorySearch.TextChanged
        Dim search_term As String = "%" & txtInventorySearch.Text & "%"

        Select Case btnSwitchOrdersTable.Text.ToString()
            Case "Switch to Inventory table"
                Try
                    openConn(db_name)

                    Dim query As String = "SELECT * " &
                                      "FROM transactions_orders " &
                                      "WHERE transaction_id LIKE @search OR item_id LIKE @search OR user_id LIKE @search OR note LIKE @search OR sub_total LIKE @search"

                    cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@search", search_term)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    dgvInventory.DataSource = table

                Catch ex As Exception
                    MessageBox.Show("Error searching transaction: " & ex.Message)
                Finally
                    If conn.State = ConnectionState.Open Then conn.Close()
                End Try
            Case "Switch to Order transactions"
                Try
                    openConn(db_name)

                    Dim query As String = "SELECT * " &
                                      "FROM inventory " &
                                      "WHERE item_name LIKE @search OR item_brand LIKE @search OR status LIKE @search"

                    cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@search", search_term)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    dgvInventory.DataSource = table

                Catch ex As Exception
                    MessageBox.Show("Error searching item: " & ex.Message)
                Finally
                    If conn.State = ConnectionState.Open Then conn.Close()
                End Try
        End Select
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim search_term As String = "%" & TextBox2.Text & "%"

        If btnSwitchTables.Text = "Switch to Service transactions" Then
            Try
                openConn(db_name)

                Dim query As String = "SELECT * " &
                                  "FROM service " &
                                  "WHERE service_category LIKE @search OR service_name LIKE @search OR service_status LIKE @search"

                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@search", search_term)

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                dgvServices.DataSource = table

            Catch ex As Exception
                MessageBox.Show("Error searching service: " & ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        ElseIf btnSwitchTables.Text = "Switch to Service table" Then
            Try
                openConn(db_name)

                Dim query As String = "SELECT * " &
                                  "FROM transactions_services " &
                                  "WHERE transaction_id LIKE @search OR user_id LIKE @search OR service_id LIKE @search OR note LIKE @search"

                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@search", search_term)

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                dgvServices.DataSource = table

            Catch ex As Exception
                MessageBox.Show("Error searching transaction: " & ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End If


    End Sub

    Private Sub cbServiceAvail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbServiceAvail.SelectedIndexChanged
        cbServiceStatus.Items.Clear()
        If cbServiceAvail.SelectedItem IsNot Nothing Then
            Select Case cbServiceAvail.SelectedItem.ToString()
                Case "True"
                    ' Add all towns and city of Camarines Norte
                    cbServiceStatus.Items.Add("Available")


            ' Add more cases for other provinces as needed
                Case "False"
                    cbServiceStatus.Items.Add("Unavailable")
                    cbServiceStatus.Items.Add("Discontinued")
                    cbServiceStatus.Items.Add("Under development")

            End Select
        End If
    End Sub

    Private Sub btnInsertOwndata_Click(sender As Object, e As EventArgs) Handles btnInsertOwndata.Click
        Dim admin_id As Integer = Integer.Parse(lblEditOwnID.Text.Trim())
        Try
            openConn(db_name)
            Dim query As String = "SELECT user_name FROM useracc WHERE user_id = @user_id"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@user_id", admin_id)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtEditAdminUser.Text = reader("user_name").ToString()

                    Else
                        MessageBox.Show("No transaction found with that ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading transaction: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            WriteLog("Error loading transaction by ID: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try


        Try
            openConn(db_name)
            Dim query As String = "SELECT admin_fname, admin_lname, admin_contact, email FROM admins WHERE user_id = @user_id"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@user_id", admin_id)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtAdminEditFName.Text = reader("admin_fname").ToString()
                        txtAdminEditLName.Text = reader("admin_lname").ToString()
                        txtEditAdminContact.Text = reader("admin_contact").ToString()
                        txtEditAdminEmail.Text = reader("email").ToString()
                    Else
                        MessageBox.Show("No transaction found with that ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading transaction: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            WriteLog("Error loading transaction by ID: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnClearAccountFields_Click(sender As Object, e As EventArgs) Handles btnClearAccountFields.Click

    End Sub

    Private Sub btnConfirmChanges_Click(sender As Object, e As EventArgs) Handles btnConfirmChanges.Click
        Dim result As DialogResult

        If Not String.IsNullOrWhiteSpace(txtAdminEditFName.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(txtAdminEditLName.Text.Trim()) _
                AndAlso Not String.IsNullOrWhiteSpace(txtEditAdminContact.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(txtEditAdminEmail.Text.Trim()) Then
            Dim user_id As Integer = Integer.Parse(lblEditOwnID.Text.Trim())
            Dim admin_fname As String = txtAdminEditFName.Text.Trim()
            Dim admin_lname As String = txtAdminEditLName.Text.Trim()
            Dim admin_contact As String = txtEditAdminContact.Text.Trim()
            Dim admin_email As String = txtEditAdminEmail.Text.Trim()
            Dim admin_user_name As String = txtEditAdminUser.Text.Trim()
            Dim admin_password As String = txtChangePassword.Text.Trim()

            If String.IsNullOrWhiteSpace(admin_user_name) OrElse String.IsNullOrWhiteSpace(admin_password) Then
                result = MessageBox.Show("Are you sure to apply changes without changing admin's account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    UpdateAdminData(user_id, admin_fname, admin_lname, admin_contact, admin_email)
                    MessageBox.Show("Admin data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    txtAdminEditFName.Text = ""
                    txtAdminEditLName.Text = ""
                    txtEditAdminContact.Text = ""
                    txtEditAdminEmail.Text = ""
                    txtEditAdminUser.Text = ""
                    txtChangePassword.Text = ""


                    Exit Sub
                ElseIf result = DialogResult.No Then
                    Exit Sub
                End If

            ElseIf Not String.IsNullOrWhiteSpace(admin_user_name) OrElse Not String.IsNullOrWhiteSpace(admin_password) Then

                If txtChangePassword.Text.Trim() = txtConfirmPassword.Text.Trim() Then
                    UpdateAdminAcc(user_id, admin_user_name, admin_password)
                    MessageBox.Show("Admin account updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    UpdateAdminData(user_id, admin_fname, admin_lname, admin_contact, admin_email)
                    MessageBox.Show("Admin data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    txtAdminEditFName.Text = ""
                    txtAdminEditLName.Text = ""
                    txtEditAdminContact.Text = ""
                    txtEditAdminEmail.Text = ""
                    txtEditAdminUser.Text = ""
                    txtChangePassword.Text = ""

                    Exit Sub
                Else
                    MessageBox.Show("Please enter proper fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Please enter proper fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnInsertRow_Click(sender As Object, e As EventArgs)
        Dim user_id As Integer = Integer.Parse(lblEditOwnID.Text.Trim())
        Try
            openConn(db_name)

            Dim query As String = "INSERT INTO admins (user_id) VALUES (@user_id)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@user_id", user_id)

                cmd.ExecuteNonQuery()
                ' Optionally show confirmation or log
                WriteLog("Admin skeleton created for user_id: " & user_id)


            End Using


        Catch ex As Exception
            WriteLog("InsertAdminSkeleton error (Form_Load): " & ex.Message)
            MessageBox.Show("Failed to initialize admin record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnSwitchTables_Click(sender As Object, e As EventArgs) Handles btnSwitchTables.Click
        If btnSwitchTables.Text = "Switch to Service table" Then
            LoadToDGV(services_query, dgvServices, db_name)
            MessageBox.Show("Table switched to Services table", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSwitchTables.Text = "Switch to Service transactions"
            panServiceOptions.Enabled = True
            btnViewService.Enabled = True
        ElseIf btnSwitchTables.Text = "Switch to Service transactions" Then
            LoadToDGV(transac_service, dgvServices, db_name)
            MessageBox.Show("Table switched to Service transactions", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSwitchTables.Text = "Switch to Service table"
            panServiceOptions.Enabled = False
            btnViewService.Enabled = False
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSwitchOrdersTable.Click
        If btnSwitchOrdersTable.Text = "Switch to Inventory table" Then
            LoadToDGV(inventory_query, dgvInventory, db_name)
            MessageBox.Show("Table switched to Inventory table", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSwitchOrdersTable.Text = "Switch to Order transactions"
            panConfigureItem.Enabled = True
            btnViewItem.Enabled = True

        ElseIf btnSwitchOrdersTable.Text = "Switch to Order transactions" Then
            LoadToDGV(transac_order, dgvInventory, db_name)
            MessageBox.Show("Table switched to Order transactions", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSwitchOrdersTable.Text = "Switch to Inventory table"
            panConfigureItem.Enabled = False
            btnViewItem.Enabled = False
        End If
    End Sub

    Private Sub btnFinishedRefreshed_Click(sender As Object, e As EventArgs) Handles btnFinishedRefreshed.Click
        LoadToDGV(finished_query, dgvFinished, db_name)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadToDGV(pendings_query, dgvPending, db_name)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dgvPending.SelectedRows.Count > 0 Then

            Dim selectedRow As DataGridViewRow = dgvPending.SelectedRows(0)

            Dim transaction_id = selectedRow.Cells("transaction_id").Value.ToString()
            Dim customer_id As Integer = selectedRow.Cells("customer_id").Value
            Dim payment_received As Decimal = selectedRow.Cells("payment_received").Value
            Dim total_amount As String = selectedRow.Cells("total_payment").Value.ToString()
            Dim change As String = selectedRow.Cells("payment_change").Value.ToString()
            Dim user_id As Integer = If(IsDBNull(selectedRow.Cells("user_id").Value), -1, Convert.ToInt32(selectedRow.Cells("user_id").Value))

            Dim processed_by As String = GetUserName(Integer.Parse(user_id))
            Dim user_fname As String = GetUserFirst(customer_id)
            Dim user_lname As String = GetUserLast(customer_id)
            Dim contact As String = GetCustomerContact(customer_id)
            Dim service_name As String = GetServiceName(transaction_id)
            Dim service_category As String = GetServiceCategory(transaction_id)

            Dim service_availed As String = service_category & " " & service_name

            Dim addonsList As String() = GetAddonItemNames(transaction_id)
            Dim addons As Label() = {lblPendingAddon1, lblPendingAddon1, lblPendingAddon1, lblPendingAddon1}


            For i As Integer = 0 To addons.Length - 1
                addons(i).Text = addonsList(i)

            Next
            lblPendingOrderID.Text = transaction_id
            lblPendingFullName.Text = user_fname & " " & user_lname
            lblPendingContact.Text = contact
            lblPendingService.Text = service_availed
            lblPaymentReceived.Text = payment_received
            lblPendingChange.Text = change
            lblPendingTotal.Text = total_amount
            lblProcessedBy.Text = processed_by
            lblPendingTransacDateAdded.Text = selectedRow.Cells("transaction_date").Value.ToString()


            lblPendingAddon1.Text = addonsList(0)
            lblPendingAddon2.Text = addonsList(1)
            lblPendingAddon3.Text = addonsList(2)
            lblPendingAddon4.Text = addonsList(3)

            lblPendingAddon1.Visible = True
            lblPendingAddon2.Visible = True
            lblPendingAddon3.Visible = True
            lblPendingAddon4.Visible = True


            lblPendingOrderID.Visible = True
            lblPendingFullName.Visible = True
            lblPendingContact.Visible = True
            lblPendingService.Visible = True
            lblPaymentReceived.Visible = True
            lblPendingTotal.Visible = True
            lblPendingChange.Visible = True
            lblPendingChange.Visible = True
            lblProcessedBy.Visible = True
            lblPendingTransacDateAdded.Visible = True
            btnFinish.Visible = True
            btnCancel.Visible = True
            panPendingOrdersss.Enabled = True

            MessageBox.Show("Transaction data selected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Please select a row first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        If Not String.IsNullOrEmpty(lblPendingOrderID.Text.Trim()) Then
            Dim transaction_id As Integer = Integer.Parse(lblPendingOrderID.Text.Trim())

            UpdateTransaction(transaction_id)
            lblPendingOrderID.Text = ""
            lblPendingFullName.Text = ""
            lblPendingContact.Text = ""
            lblPendingService.Text = ""
            lblPaymentReceived.Text = ""
            lblPendingChange.Text = ""
            lblPendingTotal.Text = ""
            lblProcessedBy.Text = ""
            lblPendingTransacDateAdded.Text = ""


            lblPendingAddon1.Text = ""
            lblPendingAddon2.Text = ""
            lblPendingAddon3.Text = ""
            lblPendingAddon4.Text = ""

            lblPendingAddon1.Visible = False
            lblPendingAddon2.Visible = False
            lblPendingAddon3.Visible = False
            lblPendingAddon4.Visible = False


            lblPendingOrderID.Visible = False
            lblPendingFullName.Visible = False
            lblPendingContact.Visible = False
            lblPendingService.Visible = False
            lblPaymentReceived.Visible = False
            lblPendingTotal.Visible = False
            lblPendingChange.Visible = False
            lblPendingChange.Visible = False
            lblProcessedBy.Visible = False
            lblPendingTransacDateAdded.Visible = False
            panPendingOrdersss.Enabled = False

            LoadToDGV(pendings_query, dgvPending, db_name)

            MessageBox.Show("Transaction Completed!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim transaction_id As Integer = Integer.Parse(lblPendingOrderID.Text.Trim())

        CancelledTransaction(transaction_id)
        lblPendingOrderID.Text = ""
        lblPendingFullName.Text = ""
        lblPendingContact.Text = ""
        lblPendingService.Text = ""
        lblPaymentReceived.Text = ""
        lblPendingChange.Text = ""
        lblPendingTotal.Text = ""
        lblProcessedBy.Text = ""
        lblPendingTransacDateAdded.Text = ""


        lblPendingAddon1.Text = ""
        lblPendingAddon2.Text = ""
        lblPendingAddon3.Text = ""
        lblPendingAddon4.Text = ""

        lblPendingAddon1.Visible = False
        lblPendingAddon2.Visible = False
        lblPendingAddon3.Visible = False
        lblPendingAddon4.Visible = False


        lblPendingOrderID.Visible = False
        lblPendingFullName.Visible = False
        lblPendingContact.Visible = False
        lblPendingService.Visible = False
        lblPaymentReceived.Visible = False
        lblPendingTotal.Visible = False
        lblPendingChange.Visible = False
        lblPendingChange.Visible = False
        lblProcessedBy.Visible = False
        lblPendingTransacDateAdded.Visible = False
        panPendingOrdersss.Enabled = False

        LoadToDGV(pendings_query, dgvPending, db_name)
        MessageBox.Show("Transaction Cancelled", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnViewFinished_Click(sender As Object, e As EventArgs) Handles btnViewFinished.Click
        If dgvFinished.SelectedRows.Count > 0 Then

            Dim selectedRow As DataGridViewRow = dgvFinished.SelectedRows(0)

            Dim transaction_id = selectedRow.Cells("transaction_id").Value.ToString()
            Dim customer_id As Integer = selectedRow.Cells("customer_id").Value
            Dim payment_received As Decimal = selectedRow.Cells("payment_received").Value
            Dim total_amount As String = selectedRow.Cells("total_payment").Value.ToString()
            Dim change As String = selectedRow.Cells("payment_change").Value.ToString()
            Dim user_id As Integer = If(IsDBNull(selectedRow.Cells("user_id").Value), -1, Convert.ToInt32(selectedRow.Cells("user_id").Value))

            Dim processed_by As String = GetUserName(user_id)
            Dim user_fname As String = GetUserFirst(customer_id)
            Dim user_lname As String = GetUserLast(customer_id)
            Dim contact As String = GetCustomerContact(customer_id)
            Dim service_name As String = GetServiceName(transaction_id)
            Dim service_category As String = GetServiceCategory(transaction_id)

            Dim service_availed As String = service_category & " " & service_name

            Dim addonsList As String() = GetAddonItemNames(transaction_id)
            Dim addons As Label() = {lblFinishedAddon1, lblFinishedAddon2, lblFinishedAddon3, lblFinishedAddon4}


            For i As Integer = 0 To addons.Length - 1
                addons(i).Text = addonsList(i)

            Next
            lblFinishedID.Text = transaction_id
            lblFinishedFullName.Text = user_fname & " " & user_lname
            lblFinishedContact.Text = contact
            lblFinishedService.Text = service_availed
            lblFinishedPayment.Text = payment_received
            lblFinishedChange.Text = change
            lblFinishedAmount.Text = total_amount
            lblFinishedUser.Text = processed_by
            lblFinishedDate.Text = selectedRow.Cells("transaction_date").Value.ToString()


            lblFinishedAddon1.Text = addonsList(0)
            lblFinishedAddon2.Text = addonsList(1)
            lblFinishedAddon3.Text = addonsList(2)
            lblFinishedAddon4.Text = addonsList(3)

            lblFinishedAddon1.Visible = True
            lblFinishedAddon2.Visible = True
            lblFinishedAddon3.Visible = True
            lblFinishedAddon4.Visible = True


            lblFinishedID.Visible = True
            lblFinishedFullName.Visible = True
            lblFinishedContact.Visible = True
            lblFinishedService.Visible = True
            lblFinishedPayment.Visible = True
            lblFinishedChange.Visible = True
            lblFinishedAmount.Visible = True
            lblFinishedUser.Visible = True
            lblFinishedDate.Visible = True
            panFinished.Enabled = True

            MessageBox.Show("Transaction data selected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Please select a row first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        lblPendingOrderID.Text = ""
        lblPendingFullName.Text = ""
        lblPendingContact.Text = ""
        lblPendingService.Text = ""
        lblPaymentReceived.Text = ""
        lblPendingChange.Text = ""
        lblPendingTotal.Text = ""
        lblProcessedBy.Text = ""
        lblPendingTransacDateAdded.Text = ""


        lblPendingAddon1.Text = ""
        lblPendingAddon2.Text = ""
        lblPendingAddon3.Text = ""
        lblPendingAddon4.Text = ""

        lblPendingAddon1.Visible = False
        lblPendingAddon2.Visible = False
        lblPendingAddon3.Visible = False
        lblPendingAddon4.Visible = False


        lblPendingOrderID.Visible = False
        lblPendingFullName.Visible = False
        lblPendingContact.Visible = False
        lblPendingService.Visible = False
        lblPaymentReceived.Visible = False
        lblPendingTotal.Visible = False
        lblPendingChange.Visible = False
        lblPendingChange.Visible = False
        lblProcessedBy.Visible = False
        lblPendingTransacDateAdded.Visible = False
        panPendingOrdersss.Enabled = False
    End Sub

    Private Sub btnFinishedFields_Click(sender As Object, e As EventArgs) Handles btnFinishedFields.Click
        lblFinishedAddon1.Text = ""
        lblFinishedAddon2.Text = ""
        lblFinishedAddon3.Text = ""
        lblFinishedAddon4.Text = ""


        lblFinishedID.Text = ""
        lblFinishedFullName.Text = ""
        lblFinishedContact.Text = ""
        lblFinishedService.Text = ""
        lblFinishedPayment.Text = ""
        lblFinishedChange.Text = ""
        lblFinishedAmount.Text = ""
        lblFinishedUser.Text = ""
        lblFinishedDate.Text = ""

        lblFinishedAddon1.Visible = False
        lblFinishedAddon2.Visible = False
        lblFinishedAddon3.Visible = False
        lblFinishedAddon4.Visible = False


        lblFinishedID.Visible = False
        lblFinishedFullName.Visible = False
        lblFinishedContact.Visible = False
        lblFinishedService.Visible = False
        lblFinishedPayment.Visible = False
        lblFinishedChange.Visible = False
        lblFinishedAmount.Visible = False
        lblFinishedUser.Visible = False
        lblFinishedDate.Visible = False
        panFinished.Enabled = False
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        If cbFilter.SelectedItem IsNot Nothing Then
            Select Case cbFilter.SelectedItem.ToString()
                Case "All"
                    LoadToDGV(finished_query, dgvFinished, db_name)

                Case "Finished"
                    LoadToDGV(filter_finished_query, dgvFinished, db_name)

                Case "Cancelled"
                    LoadToDGV(filter_cancelled_query, dgvFinished, db_name)

                Case Else
                    ' Default case - fallback if no other case matches
                    MessageBox.Show("Invalid option selected.")
            End Select
        End If
    End Sub


    Private Sub txtSearchPending_TextChanged(sender As Object, e As EventArgs) Handles txtSearchPending.TextChanged
        Dim search_term As String = "%" & txtSearchPending.Text & "%"



        Try
            openConn(db_name)

            Dim query As String = "SELECT * " &
                      "FROM transactions " &
                      "WHERE transaction_status = 'Pending' AND " &
                      "(transaction_id LIKE @search OR customer_id LIKE @search OR user_id LIKE @search)"

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@search", search_term)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgvPending.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Error searching transaction: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

    End Sub

    Private Sub txtSearchFinished_TextChanged(sender As Object, e As EventArgs) Handles txtSearchFinished.TextChanged
        Dim search_term As String = "%" & txtSearchFinished.Text & "%"
        Try
            openConn(db_name)

            Dim query As String = "SELECT * " &
                      "FROM transactions " &
                      "WHERE transaction_status IN ('Finished', 'Cancelled') AND " &
                      "(transaction_id LIKE @search OR customer_id LIKE @search OR user_id LIKE @search)"

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@search", search_term)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgvFinished.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Error searching transaction: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub cbAddon1_CheckedChanged(sender As Object, e As EventArgs) Handles cbAddon1.CheckedChanged
        cbNone.Checked = False
        numAddon1.Value = 1
    End Sub

    Private Sub cbAddon2_CheckedChanged(sender As Object, e As EventArgs) Handles cbAddon2.CheckedChanged
        cbNone.Checked = False
        numAddon2.Value = +1
    End Sub

    Private Sub cbAddon3_CheckedChanged(sender As Object, e As EventArgs) Handles cbAddon3.CheckedChanged
        cbNone.Checked = False
        numAddon3.Value = +1
    End Sub

    Private Sub cbAddon4_CheckedChanged(sender As Object, e As EventArgs) Handles cbAddon4.CheckedChanged
        cbNone.Checked = False
        numAddon4.Value = +1
    End Sub

End Class