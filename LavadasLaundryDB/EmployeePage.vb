Imports System.Drawing.Printing
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient

Public Class EmployeePage

    Public receiptFromEmployee As New PrintDocument

    Dim pendings_query As String = "SELECT * FROM transactions WHERE transaction_status = 'Pending'"
    Dim finished_query As String = "SELECT * FROM transactions WHERE transaction_status IN ('Finished', 'Cancelled')"
    Dim filter_finished_query As String = "SELECT * FROM transactions WHERE transaction_status = 'Finished'"
    Dim filter_cancelled_query As String = "SELECT * FROM transactions WHERE transaction_status = 'Cancelled'"

    'Checkbox handler
    Public Property EmployeeUserName As String
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

    Private placeHolderText As String = "placeholder"
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




    Private Sub EmployeePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbNone.Checked = True
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy")

        numLoadWeight.Maximum = 8
        numLoadWeight.Minimum = 1
        numAddon1.Minimum = 0
        numAddon2.Minimum = 0
        numAddon3.Minimum = 0
        numAddon4.Minimum = 0

        panPendingOrdersss.Enabled = False
        lblPendingOrderID.Visible = False

        lblPendingFullName.Visible = False
        lblPendingContact.Visible = False
        lblPendingService.Visible = False

        lblPendingAddon1.Visible = False
        lblPendingAddon2.Visible = False
        lblPendingAddon3.Visible = False
        lblPendingAddon4.Visible = False

        lblPendingAddon1.Visible = False
        lblPendingAddon2.Visible = False
        lblPendingAddon3.Visible = False
        lblPendingAddon4.Visible = False

        lblPendingTotal.Visible = False

        btnCancel.Visible = False
        btnFinish.Visible = False

        'For setting who's logged in
        Dim user_name As String = EmployeeUserName
        Dim userInfo As UserInfo = SearchAccount(user_name)
        Dim reusable_id As Integer

        lblCurrentUser.Text = user_name
        If userInfo.UserID > 0 Then
            lblCurrEmployeeID.Text = userInfo.UserID.ToString()
            reusable_id = userInfo.UserID
            'SET ACCOUNT STATUS TO ONLINE
            SetUserOnline(reusable_id)
        End If


        Dim pendings_query As String = "SELECT * FROM transactions WHERE transaction_status = 'pending'"
        Dim finished_query As String = "SELECT * FROM transactions WHERE transaction_status IN ('completed', 'cancelled')"

        LoadToDGV(pendings_query, dgvPending, db_name)
        LoadToDGV(finished_query, dgvFinished, db_name)
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

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim result As DialogResult
        Dim selectedAddons As New List(Of (Name As String, Price As Decimal, Quantity As Integer))
        Dim servicePrice As Decimal = 0D

        If rbFullService.Checked OrElse rbSelfService.Checked AndAlso Not String.IsNullOrWhiteSpace(cbColored.Text.Trim()) Then
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

                                panFullService.Visible = False
                                panSelfService.Visible = False


                                rbFullService.Checked = False
                                rbSelfService.Checked = False
                                cbAddon1.Checked = False
                                cbAddon2.Checked = False
                                cbAddon3.Checked = False
                                cbAddon4.Checked = False
                                cbNone.Checked = False

                                rbFullService.Enabled = False
                                rbSelfService.Enabled = False
                                cbAddon1.Enabled = False
                                cbAddon2.Enabled = False
                                cbAddon3.Enabled = False
                                cbAddon4.Enabled = False
                                cbNone.Enabled = False
                                numLoadWeight.Enabled = False
                                btnNext.Enabled = False
                                numAddon1.Enabled = False
                                numAddon2.Enabled = False
                                numAddon3.Enabled = False
                                numAddon4.Enabled = False
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


                            rbFullService.Checked = False
                            rbSelfService.Checked = False
                            cbAddon1.Checked = False
                            cbAddon2.Checked = False
                            cbAddon3.Checked = False
                            cbAddon4.Checked = False
                            cbNone.Checked = False

                            rbFullService.Enabled = False
                            rbSelfService.Enabled = False
                            cbAddon1.Enabled = False
                            cbAddon2.Enabled = False
                            cbAddon3.Enabled = False
                            cbAddon4.Enabled = False
                            cbNone.Enabled = False
                            numLoadWeight.Enabled = False
                            btnNext.Enabled = False
                            numAddon1.Enabled = False
                            numAddon2.Enabled = False
                            numAddon3.Enabled = False
                            numAddon4.Enabled = False

                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("PLEASE ENTER ALL FIELDS", "Incomplete fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                Else
                    MessageBox.Show("PLEASE ENTER ALL FIELDS", "Incomplete fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("Please select if colored or not", "Incomplete fields", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

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

    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        Dim result As DialogResult

        If Not String.IsNullOrWhiteSpace(txtFirstName.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(txtLastName.Text.Trim()) _
        AndAlso Not String.IsNullOrWhiteSpace(cbCustomerSex.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(txtAmountPaid.Text.Trim()) _
        AndAlso Not String.IsNullOrWhiteSpace(cbProvince.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(cbCity.Text.Trim()) _
        AndAlso Not String.IsNullOrWhiteSpace(cbPaymentMethod.Text.Trim()) AndAlso Not String.IsNullOrWhiteSpace(lblPostalCode.Text.Trim()) Then
            Try

                'Fields for Customer
                Dim user_id As Integer = Integer.Parse(lblCurrEmployeeID.Text.Trim())
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

                panOrderInfo.Visible = False

                cbNone.Checked = True

                rbFullService.Enabled = True
                rbSelfService.Enabled = True
                cbAddon1.Enabled = True
                cbAddon2.Enabled = True
                cbAddon3.Enabled = True
                cbAddon4.Enabled = True
                cbNone.Enabled = True
                numLoadWeight.Enabled = True
                btnNext.Enabled = True
                numAddon1.Enabled = True
                numAddon2.Enabled = True
                numAddon3.Enabled = True
                numAddon4.Enabled = True

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


                MessageBox.Show("Transaction inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                result = MessageBox.Show("Do you want to generate receipt?", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

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

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("PLEASE ENTER ALL FIELDS", "Incomplete fields", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure to cancel the order?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("Confirmed cancel", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            panOrderInfo.Visible = False

            cbNone.Checked = True

            rbFullService.Enabled = True
            rbSelfService.Enabled = True
            cbAddon1.Enabled = True
            cbAddon2.Enabled = True
            cbAddon3.Enabled = True
            cbAddon4.Enabled = True
            cbNone.Enabled = True
            numLoadWeight.Enabled = True
            btnNext.Enabled = True
            numAddon1.Enabled = True
            numAddon2.Enabled = True
            numAddon3.Enabled = True
            numAddon4.Enabled = True

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

        reusable_id = Integer.Parse(lblCurrEmployeeID.Text.Trim())
        result = MessageBox.Show("Are you sure to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("Logged out successfully", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SetUserOffline(reusable_id)
            Me.Close()
            LoginPage.Show()
        End If

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
    End Sub

    Private Sub btnPendingTransactionRow_Click(sender As Object, e As EventArgs) Handles btnPendingTransactionRow.Click
        If dgvPending.SelectedRows.Count > 0 Then

            Dim selectedRow As DataGridViewRow = dgvPending.SelectedRows(0)

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

    Private Sub btnClearPendingFields_Click(sender As Object, e As EventArgs) Handles btnClearPendingFields.Click
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadToDGV(finished_query, dgvFinished, db_name)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadToDGV(pendings_query, dgvPending, db_name)
    End Sub

    Private Sub btnClearFinishedFields_Click(sender As Object, e As EventArgs) Handles btnClearFinishedFields.Click
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


End Class