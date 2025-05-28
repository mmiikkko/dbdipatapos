Imports MySql.Data.MySqlClient
Imports System.DirectoryServices
Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices


Public Class QuickView


    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        LoginPage.Show()
        Me.Hide()

        lblPendingOrderID.Text = ""
        lblPendingFullName.Text = ""
        lblPendingContact.Text = ""
        lblPendingService.Text = ""
        lblPaymentReceived.Text = ""
        lblPendingChange.Text = ""
        lblPendingTotal.Text = ""
        lblProcessedBy.Text = ""
        lblPendingTransacDateAdded.Text = ""
        txtQuickSearch.Text = ""

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
        lblTransactionStatus.Visible = False
    End Sub

    Private Sub QuickView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnQuickSearch.Click
        Dim search_term As String = "%" & txtQuickSearch.Text.Trim() & "%"

        Try
            openConn(db_name)

            Dim query As String = "SELECT * FROM transactions " &
                              "WHERE transaction_status IN ('Pending', 'Finished', 'Cancelled') AND " &
                              "(transaction_id LIKE @search OR customer_id LIKE @search OR user_id LIKE @search) " &
                              "LIMIT 1"

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@search", search_term)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim transaction_id As String = reader("transaction_id").ToString()
                Dim customer_id As Integer = reader("customer_id")
                Dim payment_received As Decimal = reader("payment_received")
                Dim total_amount As Decimal = reader("total_payment")
                Dim payment_change As Decimal = reader("payment_change")
                Dim user_id As Integer = If(IsDBNull(reader("user_id")), -1, Convert.ToInt32(reader("user_id")))
                Dim transaction_date As String = reader("transaction_date").ToString()
                Dim transaction_status As String = reader("transaction_status").ToString()

                ' Additional info via helper functions
                Dim fullName As String = GetUserFirst(customer_id) & " " & GetUserMi(customer_id) & " " & GetUserLast(customer_id)
                Dim contact As String = GetCustomerContact(customer_id)
                Dim service_name As String = GetServiceName(transaction_id)
                Dim service_category As String = GetServiceCategory(transaction_id)
                Dim processed_by As String = GetUserName(user_id)
                Dim addonsList As String() = GetAddonItemNames(transaction_id)

                ' Populate labels
                lblPendingOrderID.Text = transaction_id
                lblPendingFullName.Text = fullName
                lblPendingContact.Text = contact
                lblPendingService.Text = service_category & " " & service_name
                lblPaymentReceived.Text = payment_received.ToString("C")
                lblPendingTotal.Text = total_amount.ToString("C")
                lblPendingChange.Text = payment_change.ToString("C")
                lblProcessedBy.Text = processed_by
                lblPendingTransacDateAdded.Text = transaction_date
                lblTransactionStatus.Text = transaction_status
                Select Case transaction_status
                    Case "Pending"
                        lblTransactionStatus.ForeColor = Color.Orange
                    Case "Finished"
                        lblTransactionStatus.ForeColor = Color.Green
                    Case "Cancelled"
                        lblTransactionStatus.ForeColor = Color.Red
                End Select

                ' Add-ons
                Dim addonLabels As Label() = {lblPendingAddon1, lblPendingAddon2, lblPendingAddon3, lblPendingAddon4}
                For i As Integer = 0 To addonLabels.Length - 1
                    addonLabels(i).Text = If(i < addonsList.Length, addonsList(i), "")
                    addonLabels(i).Visible = True
                Next

                ' Show the rest of the panel
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
                panPendingOrdersss.Enabled = True
                lblTransactionStatus.Visible = True

                MessageBox.Show("Transaction found!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No matching transaction found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try


    End Sub

    Private Sub btnQuickSearchClear_Click(sender As Object, e As EventArgs) Handles btnQuickSearchClear.Click
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
        lblTransactionStatus.Visible = False
    End Sub
End Class