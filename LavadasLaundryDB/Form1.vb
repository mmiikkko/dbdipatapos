Imports MySql.Data.MySqlClient
Imports System.DirectoryServices
Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices


Public Class LoginPage
    Dim userHint As String = "Username"
    Dim passwordHint As String = "Password"
    Private encryptionKey As String = "YourEncryptionKeyHere"
    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Para cute
        Me.KeyPreview = True
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        txtUserName.TabStop = False
        txtPassword.TabStop = False
        txtPassword.PasswordChar = "*"

        txtUserName.Text = userHint
        txtUserName.ForeColor = Color.Gray
        txtPassword.Text = passwordHint
        txtPassword.ForeColor = Color.Gray
        btnEye.Text = "👁"

        txtConfigUs.PasswordChar = "*"
        txtConfigPass.PasswordChar = "*"
        txtAdminPasswordConfig.PasswordChar = "*"

        ConnectToDatabase()
        UpdateServerStatus()

        If IsAdminEmpty() Then
            MessageBox.Show("Please add an admin.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            panAdmin.Visible = True
        End If

    End Sub

    'To update db connection
    Private Sub UpdateServerStatus()
        Try
            openConn(db_name)
            lblConfirmation.Text = "Server is running and connected."
            lblConfirmation.ForeColor = Color.Green
        Catch ex As Exception
            lblConfirmation.Text = "Server is down: " & ex.Message
            lblConfirmation.ForeColor = Color.Red
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    'Text file configuration
    Public Sub ModifyServer()
        Try
            Dim exFolder As String = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
            Dim filePath As String = Path.Combine(exFolder, "db_config.txt")

            If File.Exists(filePath) Then
                Dim currentContent As String = File.ReadAllText(filePath)

                Console.WriteLine("Current Content: " & currentContent)

                Dim newContent As String = "server= " & txtServer.Text & vbCrLf &
                                            "uid= " & txtUserConfig.Text & vbCrLf &
                                            "password= " & txtConfigPass.Text & vbCrLf &
                                            "database= " & txtDatabase.Text
                File.WriteAllText(filePath, newContent)



                MsgBox("File Successfully modified!" & filePath, MsgBoxStyle.Information)
            Else
                MsgBox("File not found: " & filePath, MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception

        End Try
    End Sub
    'Text file configuration

    Private Sub LoginPage_Click(sender As Object, e As EventArgs) Handles Me.Click
        txtUserName.TabStop = False
        txtPassword.TabStop = False
    End Sub

    Private Sub txtUserName_Enter(sender As Object, e As EventArgs) Handles txtUserName.Enter
        If txtUserName.Text = userHint Then
            txtUserName.Text = ""
            txtUserName.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUserName_Leave(sender As Object, e As EventArgs) Handles txtUserName.Leave
        If txtUserName.Text = "" Then
            txtUserName.Text = userHint
            txtUserName.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If txtPassword.Text = passwordHint Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = "" Then
            txtPassword.Text = passwordHint
            txtPassword.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub btnEye_Click(sender As Object, e As EventArgs) Handles btnEye.Click
        If txtPassword.PasswordChar = "*" Then
            txtPassword.PasswordChar = "" ' Show the password
            btnEye.Text = "👁" ' Change to open eye icon if needed
        Else
            txtPassword.PasswordChar = "*" ' Hide the password
            btnEye.Text = "👁" ' Change back to closed eye icon if needed
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim stUserName As String = txtUserName.Text.Trim()
        Dim stPassword As String = txtPassword.Text.Trim()

        Try
            openConn(db_name:=db_name)

            ' Step 1: Get the stored hashed password and role by username
            Dim query As String = "SELECT user_pass, role FROM useracc WHERE user_name = @user_name"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@user_name", stUserName)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim storedHash As String = reader("user_pass").ToString()
                        Dim role As String = reader("role").ToString()

                        ' Step 2: Verify password using BCrypt
                        If BCrypt.Net.BCrypt.Verify(stPassword, storedHash) Then
                            ' Login successful
                            If role = "admin" Then
                                OwnerPage.AdminUserName = stUserName
                                OwnerPage.Show()
                                Me.Hide()
                            ElseIf role = "employee" Then
                                EmployeePage.EmployeeUserName = stUserName
                                EmployeePage.Show()
                                Me.Hide()
                            End If
                        Else
                            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        ' Username not found
                        MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        ' Reset hints (optional UX)
        txtUserName.Text = userHint
        txtPassword.Text = passwordHint
        txtUserName.ForeColor = Color.Gray
        txtPassword.ForeColor = Color.Gray
    End Sub

    Private Sub employee_Click(sender As Object, e As EventArgs)
        Me.Hide()
        EmployeePage.Show()


    End Sub

    Public Function IsUserTableEmpty() As Boolean
        Try
            ' Assuming openConn opens a connection and conn is your MySQL connection
            openConn(db_name:=db_name)
            Dim query As String = "SELECT COUNT(*) FROM useracc"

            Using cmd As New MySqlCommand(query, conn)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count = 0 ' Return True if the table is empty
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return True ' Return True if there is an error (table is considered empty in case of error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Private Sub owner_Click(sender As Object, e As EventArgs)
        OwnerPage.AdminUserName = txtUserName.Text.Trim()
        OwnerPage.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Down Then
            panConfig.Visible = True
        ElseIf e.KeyCode = Keys.Escape Then
            panConfig.Visible = False
        End If
    End Sub

    Private Sub btnEnterConfig_Click(sender As Object, e As EventArgs) Handles btnEnterConfig.Click
        Try
            Dim exFolder As String = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
            Dim configFolder As String = Path.Combine(exFolder, "config_fold")
            Dim filePath As String = Path.Combine(configFolder, "config_creds.txt")

            If File.Exists(filePath) Then
                Dim lines() As String = File.ReadAllLines(filePath)

                If lines.Length >= 2 Then
                    Dim hashedUsername As String = lines(0).Trim()
                    Dim hashedPassword As String = lines(1).Trim()

                    Dim userValid As Boolean = BCrypt.Net.BCrypt.Verify(txtConfigUs.Text, hashedUsername)
                    Dim passValid As Boolean = BCrypt.Net.BCrypt.Verify(txtConfigPass.Text, hashedPassword)

                    If userValid AndAlso passValid Then
                        panConfigPanel.Visible = True
                    Else
                        MsgBox("Incorrect User and Password", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Invalid config format.", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Configuration file not found: " & filePath, MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        panConfig.Visible = False
        panConfigPanel.Visible = False

        txtConfigUs.Text = ""
        txtConfigPass.Text = ""
    End Sub

    Private Sub btnAdminRegister_Click(sender As Object, e As EventArgs) Handles btnAdminRegister.Click
        Dim adminUser As String = txtAdminConfig.Text.Trim()
        Dim adminPass As String = txtAdminPasswordConfig.Text.Trim()
        Dim user_id As Integer

        If String.IsNullOrWhiteSpace(adminUser) AndAlso String.IsNullOrWhiteSpace(adminPass) Then
            MsgBox("Please fill up entries.")
            Exit Sub
        Else
            InsertAdminAcc(adminUser, adminPass)
            user_id = GetLastInsertedIdFromAcc(adminUser)
            InsertFirstAdminData(user_id)
            MessageBox.Show("Admin inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            panAdmin.Visible = False
        End If



    End Sub

    Private Sub btnSecret_Click(sender As Object, e As EventArgs) Handles btnSecret.Click
        If txtAdminPasswordConfig.PasswordChar = "*" Then
            txtAdminPasswordConfig.PasswordChar = "" ' Show the password

        Else
            txtAdminPasswordConfig.PasswordChar = "*" ' Hide the password

        End If
    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        ModifyServer()
        ConnectToDatabase()
    End Sub

    Private Sub lblQuickSearch_Click(sender As Object, e As EventArgs) Handles lblQuickSearch.Click
        QuickView.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ConnectToDatabase()
    End Sub


End Class
