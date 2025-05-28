Imports System.IO
Imports System.Text
Imports System.Security
Imports System.Security.Cryptography
Imports ST = System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto.Generators
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.VisualBasic.ApplicationServices
Module modDB
    Public myadocon, conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public cmdRead As MySqlDataReader
    Public db_server As String
    Public db_uid As String
    Public db_pwd As String
    Public db_name As String
    Public strConnection As String = "server=" & db_server & ";uid=" & db_uid & ";password=" & db_pwd & ";database=" & db_name & ";" & "allowuservariables='True';"

    Public Structure LoggedUser
        Dim id As Integer
        Dim name As String
        Dim position As String
        Dim username As String
        Dim password As String
        Dim type As Integer
    End Structure

    Public Structure UserInfo
        Public UserID As Integer
        Public DateCreated As Date
    End Structure

    Public Sub UpdateConnectionString()
        Try
            Dim config As String = System.IO.Directory.GetCurrentDirectory & "\db_config.txt"
            Dim text As String = Nothing
            If System.IO.File.Exists(config) Then
                Using reader As System.IO.StreamReader = New System.IO.StreamReader(config)

                    text = reader.ReadToEnd
                End Using
                Dim arr_text() As String = Split(text, vbCrLf)

                strConnection = "server=" & Split(arr_text(0), "=")(1) & ";uid=" & Split(arr_text(1), "=")(1) & ";password=" & Split(arr_text(2), "=")(1) & ";database=" & Split(arr_text(3), "=")(1) & ";" & "allowuservariables='True';"
            Else
                MsgBox("Do not exist")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub ConnectToDatabase()
        Try
            ' Call UpdateConnectionString() to update the connection string based on the config file
            UpdateConnectionString()

            ' Check if the connection string was successfully created
            If Not String.IsNullOrEmpty(strConnection) Then
                ' Try to open the connection
                conn.ConnectionString = strConnection
                conn.Open()

                ' If connection is successful
                MsgBox("Database connected successfully.", MsgBoxStyle.Information)
            Else
                ' If the connection string is empty, show an error message
                MsgBox("Connection string is invalid.", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            ' Handle any connection errors
            MsgBox("Connection failed: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Public Sub openConn(ByVal db_name As String)
        Try
            With conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = strConnection
                .Open()
            End With
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub readQuery(ByVal sql As String)
        Try
            openConn(db_name)
            With cmd
                .Connection = conn
                .CommandText = sql
                cmdRead = .ExecuteReader
            End With
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Function isConnectedToLocalServer() As Boolean
        Dim result As Boolean = False
        Try
            myadocon = New MySqlConnection
            myadocon.ConnectionString = strConnection
            Try
                myadocon.Open()
                If myadocon.State = ConnectionState.Open Then
                    result = True
                Else
                    result = False
                End If
            Catch ex As Exception
                Return False
            End Try
            If myadocon.State = ConnectionState.Open Then
                myadocon.Close()
            End If
        Catch
            Return False
        End Try
        Return result
    End Function
    Public Sub WriteAllText(filePath As String, newContent As String)
        Try
            System.IO.File.WriteAllText(filePath, newContent)
            MsgBox("Configuration saved successfully.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Error saving configuration: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Build the connection string dynamically based on the database name
    Public Function GetConnectionString(ByVal databaseName As String) As String
        Return "server=" & db_server & ";uid=" & db_uid & ";password=" & db_pwd & ";database=" & databaseName & ";allowuservariables=True;"
    End Function

    ' Structure for logged user details

    ' Open a connection using a specified database name
    'Public Sub openConn(ByVal databaseName As String)
    '    Try
    '        With conn
    '            If .State = ConnectionState.Open Then .Close()
    '            .ConnectionString = GetConnectionString(databaseName)
    '            .Open()
    '        End With
    '    Catch ex As Exception
    '        MsgBox("Error opening connection: " & ex.Message, MsgBoxStyle.Critical)
    '    End Try
    'End Sub

    ' Insert user data into the Users table

    Public Function InsertAdminAcc(ByVal adminUser As String, ByVal adminPass As String)
        Try
            openConn(db_name)

            ' Hash password before storing
            Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(adminPass)
            Dim query As String = "INSERT INTO useracc (user_name, user_pass, role)" &
                "VALUES (@user_name, @user_pass, @role)"
            cmd = New MySqlCommand(query, conn)


            cmd.Parameters.AddWithValue("@user_name", adminUser)
            cmd.Parameters.AddWithValue("@user_pass", hashedPassword)
            cmd.Parameters.AddWithValue("@role", "admin")

            If cmd.ExecuteNonQuery() > 0 Then
                WriteLog("User data inserted successfully for " & adminUser)
                Return True
            Else
                WriteLog("Failed to insert user data for " & adminUser)
                Return False
            End If
        Catch ex As Exception
            WriteLog("Error inserting user data: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function UpdateAdminAcc(ByVal admin_id As Integer, ByVal adminUser As String, ByVal adminPass As String) As Boolean
        Try
            openConn(db_name)

            ' Hash password before updating
            Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(adminPass)
            Dim query As String = "UPDATE useracc SET user_pass = @user_pass, user_name = @user_name WHERE user_id = @user_id"
            cmd = New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@user_pass", hashedPassword)
            cmd.Parameters.AddWithValue("@user_id", admin_id)
            cmd.Parameters.AddWithValue("@user_name", adminUser)

            If cmd.ExecuteNonQuery() > 0 Then
                WriteLog("User data updated successfully for " & adminUser)
                Return True
            Else
                WriteLog("No records updated for user " & adminUser)
                Return False
            End If
        Catch ex As Exception
            WriteLog("Error updating user data: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function DeleteAdminAcc(ByVal userID As Integer) As Boolean
        Try
            openConn(db_name)

            Dim query As String = "DELETE FROM useracc WHERE user_id = @user_id AND role = 'admin'"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@user_id", userID)

            If cmd.ExecuteNonQuery() > 0 Then
                WriteLog("Admin account deleted successfully for " & userID)
                Return True
            Else
                WriteLog("No admin account found to delete for " & userID)
                Return False
            End If
        Catch ex As Exception
            WriteLog("Error deleting admin account: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function SearchAccount(ByVal user_name As String)
        Dim userInfo As New UserInfo With {.UserID = -1, .DateCreated = Date.MinValue}

        Try
            openConn(db_name) ' assumes global conn, cmd, db_name are declared

            Dim query As String = "SELECT user_id, date_added FROM useracc WHERE user_name = @user_name LIMIT 1"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@user_name", user_name)

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    userInfo.UserID = CInt(reader("user_id"))
                    userInfo.DateCreated = CDate(reader("date_added"))
                End If
            End Using
        Catch ex As Exception
            WriteLog("Error: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        Return userInfo
    End Function

    Public Function InsertFirstAdminData(ByVal user_id As Integer)
        Try
            openConn(db_name)
            Dim query As String = "INSERT INTO admins (user_id, date_added) VALUES (@user_id, @date_added)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@user_id", user_id)
            cmd.Parameters.AddWithValue("@date_added", Date.Now.ToString("MMMM dd, yyyy"))
            If cmd.ExecuteNonQuery() > 0 Then
                WriteLog("First admin data inserted successfully for user ID: " & user_id)
                Return True
            Else
                WriteLog("Failed to insert first admin data for user ID: " & user_id)
                Return False
            End If
        Catch ex As Exception
            WriteLog("Error inserting first admin data: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function InsertAdminData(ByVal admin_fname As String, ByVal admin_lname As String, ByVal admin_contact As String,
                                   ByVal admin_city As String, ByVal admin_province As String, ByVal email As String)
        Dim fullName As String = admin_fname & " " & admin_lname

        Try
            openConn(db_name)

            ' Hash password before storing
            Dim query As String = "INSERT INTO admins (admin_fname, admin_lname, admin_contact, admin_city, admin_province, email, date_added)" &
                "VALUES (@admin_fname, @admin_lname, @admin_contact, @admin_city, @admin_province, @email, @date_added)"
            cmd = New MySqlCommand(query, conn)


            cmd.Parameters.AddWithValue("@admin_fname", admin_fname)
            cmd.Parameters.AddWithValue("@admin_lname", admin_lname)
            cmd.Parameters.AddWithValue("@admin_contact", admin_contact)
            cmd.Parameters.AddWithValue("@admin_city", admin_city)
            cmd.Parameters.AddWithValue("@admin_province", admin_province)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@date_added", Date.Now.ToString("MMMM dd, yyyy"))

            If cmd.ExecuteNonQuery() > 0 Then
                WriteLog("User data inserted successfully for " & fullName)
                Return True
            Else
                WriteLog("Failed to insert user data for " & fullName)
                Return False
            End If
        Catch ex As Exception
            WriteLog("Error inserting user data: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function UpdateAdminData(ByVal user_id As Integer, ByVal first_name As String, ByVal last_name As String, ByVal contact As String, ByVal email As String)
        Dim full_name As String = first_name & " " & last_name

        Try
            openConn(db_name)

            ' Hash password before updating
            Dim query As String = "UPDATE admins SET admin_fname = @admin_fname, admin_lname = @admin_lname, admin_contact = @admin_contact, email = @email WHERE user_id = @user_id"
            cmd = New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@admin_fname", first_name)
            cmd.Parameters.AddWithValue("@admin_lname", last_name)
            cmd.Parameters.AddWithValue("@admin_contact", contact)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@user_id", user_id)


            If cmd.ExecuteNonQuery() > 0 Then
                WriteLog("Admin data updated successfully for " & full_name)
                Return True
            Else
                WriteLog("No records updated for user " & full_name)
                Return False
            End If
        Catch ex As Exception
            WriteLog("Error updating user data: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function InsertEmployeeAcc(ByVal user_name As String, ByVal user_pass As String)
        Try
            openConn(db_name)

            ' Hash password before storing
            Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(user_pass)
            Dim account_query As String = "INSERT INTO useracc (user_name, user_pass, role)" &
                "VALUES (@user_name, @user_pass, @role)"

            cmd = New MySqlCommand(account_query, conn)
            cmd.Parameters.AddWithValue("@user_name", user_name)
            cmd.Parameters.AddWithValue("@user_pass", hashedPassword)
            cmd.Parameters.AddWithValue("@role", "employee")

            If cmd.ExecuteNonQuery() > 0 Then

                WriteLog("User account inserted successfully for " & user_name)
                Return True
            Else
                WriteLog("Failed to insert user account for " & user_name)
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Database error:" & ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            WriteLog("Error inserting user data: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function UpdateEmployeeAcc(ByVal employee_id As Integer, ByVal employee_acc As String, ByVal employee_pass As String) As Boolean
        Try
            openConn(db_name)

            ' Hash password before updating
            Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(employee_pass)
            Dim query As String = "UPDATE useracc SET user_pass = @user_pass, user_name = @user_name WHERE user_id = @user_id"
            cmd = New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@user_pass", hashedPassword)
            cmd.Parameters.AddWithValue("@user_id", employee_id)
            cmd.Parameters.AddWithValue("@user_name", employee_acc)

            If cmd.ExecuteNonQuery() > 0 Then
                WriteLog("User data updated successfully for " & employee_acc)
                Return True
            Else
                WriteLog("No records updated for user " & employee_acc)
                Return False
            End If
        Catch ex As Exception
            WriteLog("Error updating user data: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function DeleteEmployeeAcc(ByVal userID As Integer) As Boolean
        Try
            openConn(db_name)

            Dim query As String = "DELETE FROM useracc WHERE user_id = @user_id AND role = 'employee'; COMMIT;"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@user_id", userID)

            If cmd.ExecuteNonQuery() > 0 Then
                WriteLog("Employee account deleted successfully for " & userID)
                Return True
            Else
                WriteLog("No employee account found to delete for " & userID)
                Return False
            End If
        Catch ex As Exception
            WriteLog("Error deleting employee account: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function InsertEmployeeData(ByVal employee_fname As String, ByVal employee_lname As String, ByVal employee_contact As String,
                                       ByVal employee_age As Integer, ByVal employee_sex As String, ByVal employee_city As String, ByVal employee_province As String,
                                       ByVal email As String, ByVal working_hours As String, ByVal shift As String)
        Dim fullname As String = employee_fname & " " & employee_lname
        Try
            openConn(db_name)

            Dim user_id As Integer = CInt(cmd.LastInsertedId)
            ' Hash password before storing
            Dim account_query As String = "INSERT employees (user_id, employee_fname, employee_lname, employee_contact, employee_age, employee_sex, employee_city, employee_province, email, working_hours, shift)" &
                "VALUES (@user_id, @employee_fname, @employee_lname, @employee_contact, @employee_age, @employee_sex, @employee_city, @employee_province, @email, @working_hours, @shift); COMMIT;"

            cmd = New MySqlCommand(account_query, conn)
            cmd.Parameters.AddWithValue("@user_id", user_id)
            cmd.Parameters.AddWithValue("@employee_fname", employee_fname)
            cmd.Parameters.AddWithValue("@employee_lname", employee_lname)
            cmd.Parameters.AddWithValue("@employee_contact", employee_contact)
            cmd.Parameters.AddWithValue("@employee_age", employee_age)
            cmd.Parameters.AddWithValue("@employee_sex", employee_sex)
            cmd.Parameters.AddWithValue("@employee_city", employee_city)
            cmd.Parameters.AddWithValue("@employee_province", employee_province)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@working_hours", working_hours)
            cmd.Parameters.AddWithValue("@shift", shift)

            If cmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Employee data insterted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                WriteLog("User account inserted successfully for " & fullname)
                Return True
            Else
                MessageBox.Show("Unable to insert data.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                WriteLog("Failed to insert employee data for " & fullname)
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Database error:" & ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            WriteLog("Error inserting user data: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function UpdateEmployeeData(ByVal user_id As Integer, ByVal employee_fname As String, ByVal employee_lname As String, ByVal employee_contact As String,
                                       ByVal employee_age As Integer, ByVal employee_city As String, ByVal employee_province As String,
                                       ByVal email As String, ByVal working_hours As String, ByVal shift As String)
        Dim fullname As String = employee_fname & " " & employee_lname
        Try
            openConn(db_name)


            ' Hash password before storing
            Dim account_query As String = "UPDATE employees SET employee_fname = @employee_fname, employee_lname = @employee_lname, employee_contact = @employee_contact, " &
                                          "employee_age = @employee_age, employee_city = @employee_city, employee_province = @employee_province, " &
                                          "email = @email, working_hours = @working_hours, shift = @shift WHERE user_id = @user_id; COMMIT;"

            cmd = New MySqlCommand(account_query, conn)
            cmd.Parameters.AddWithValue("@user_id", user_id)
            cmd.Parameters.AddWithValue("@employee_fname", employee_fname)
            cmd.Parameters.AddWithValue("@employee_lname", employee_lname)
            cmd.Parameters.AddWithValue("@employee_contact", employee_contact)
            cmd.Parameters.AddWithValue("@employee_age", employee_age)
            cmd.Parameters.AddWithValue("@employee_city", employee_city)
            cmd.Parameters.AddWithValue("@employee_province", employee_province)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@working_hours", working_hours)
            cmd.Parameters.AddWithValue("@shift", shift)

            If cmd.ExecuteNonQuery() > 0 Then
                WriteLog("User account inserted successfully for " & fullname)
                Return True
            Else
                WriteLog("Failed to insert employee data for " & fullname)
                Return False
            End If
        Catch ex As Exception
            WriteLog("Error inserting user data: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function


    ' Load data into DataGridView using a specified database name
    Public Function LoadToDGV(ByVal query As String, ByVal dgv As DataGridView, ByVal databaseName As String) As Integer
        Try
            openConn(databaseName)  ' Connect to specified database
            Using cmd = New MySqlCommand(query, conn)
                Using cmdRead = cmd.ExecuteReader()
                    Dim dt As DataTable = New DataTable()
                    dt.Load(cmdRead)
                    dgv.DataSource = dt
                    dgv.Refresh()
                End Using
            End Using
            Return dgv.Rows.Count
        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message, MsgBoxStyle.Critical)
            Return 0
        Finally
            conn.Close()  ' Ensure connection is closed after loading data
        End Try
    End Function

    ' Encrypt a string using AES encryption
    'Public Function Encrypt(text As String, key As String) As String
    '    Dim keyBytes = Encoding.UTF8.GetBytes(key.PadRight(32))
    '    Dim aes As New AesManaged() With {.Key = keyBytes, .IV = keyBytes.Take(16).ToArray()}
    '    Dim encryptor = aes.CreateEncryptor()

    '    Using ms As New MemoryStream()
    '        Using cs As New CryptoStream(ms, encryptor, CryptoStreamMode.Write)
    '            Using sw As New StreamWriter(cs)
    '                sw.Write(text)
    '            End Using
    '        End Using
    '        Return Convert.ToBase64String(ms.ToArray())
    '    End Using
    'End Function

    '' Decrypt a string using AES decryption
    'Public Function Decrypt(cipherText As String, key As String) As String
    '    Dim keyBytes = Encoding.UTF8.GetBytes(key.PadRight(32))
    '    Dim aes As New AesManaged() With {.Key = keyBytes, .IV = keyBytes.Take(16).ToArray()}
    '    Dim decryptor = aes.CreateDecryptor()

    '    Using ms As New MemoryStream(Convert.FromBase64String(cipherText))
    '        Using cs As New CryptoStream(ms, decryptor, CryptoStreamMode.Read)
    '            Using sr As New StreamReader(cs)
    '                Return sr.ReadToEnd()
    '            End Using
    '        End Using
    '    End Using
    'End Function

    'Hashing using BCrypt
    Public Function HashPassword(plainTextPassword As String) As String
        Return BCrypt.Net.BCrypt.HashPassword(plainTextPassword)
    End Function

    'Dehashing
    Public Function VerifyPassword(plainTextPassword As String, hashedPassword As String) As Boolean
        Return BCrypt.Net.BCrypt.Verify(plainTextPassword, hashedPassword)
    End Function

    ' Write logs to a text file
    Public Sub WriteLog(ByVal logMessage As String)
        Dim logPath As String = "logs\app_log.txt" 'UPDATED PATH
        Try
            Using writer As New StreamWriter(logPath, True)
                writer.WriteLine(DateTime.Now.ToString() & " - " & logMessage)
            End Using
        Catch ex As Exception
            MsgBox("Error writing to log: " & ex.Message, MsgBoxStyle.Critical)
        End Try
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

    Public Function IsAdminEmpty() As Boolean
        Try
            ' Open your connection (make sure openConn sets up “conn”)
            openConn(db_name:=db_name)

            ' Only count rows where role = 'admin'
            Dim query As String = "SELECT COUNT(*) FROM useracc WHERE role = @role"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@role", "admin")
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return (count = 0)   ' True if there’s at least one admin
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True ' Return True if there is an error (table is considered empty in case of error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function InsertCustomerData(ByVal customer_fname As String, ByVal customer_lname As String, ByVal customer_minitial As String,
                                       ByVal customer_sex As String, ByVal customer_contact As String, ByVal customer_city As String,
                                       ByVal customer_province As String, ByVal postal_code As String)
        Dim fullname = customer_fname & " " & customer_lname
        Dim newCustomerId As Integer = -1

        Try
            openConn(db_name)
            Dim query As String = "INSERT INTO customer (customer_fname, customer_minitial, customer_lname, customer_sex, customer_contact, customer_city, customer_province, postal_code) " &
                              "VALUES (@customer_fname, @customer_minitial, @customer_lname, @customer_sex, @customer_contact, @customer_city, @customer_province, @postal_code); " &
                              "SELECT LAST_INSERT_ID();
                              COMMIT;"


            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@customer_fname", customer_fname)
                cmd.Parameters.AddWithValue("@customer_lname", customer_lname)
                cmd.Parameters.AddWithValue("@customer_minitial", customer_minitial)
                cmd.Parameters.AddWithValue("@customer_sex", customer_sex)
                cmd.Parameters.AddWithValue("@customer_contact", customer_contact)
                cmd.Parameters.AddWithValue("@customer_city", customer_city)
                cmd.Parameters.AddWithValue("@customer_province", customer_province)
                cmd.Parameters.AddWithValue("@postal_code", postal_code)

                newCustomerId = Convert.ToInt32(cmd.ExecuteScalar()) ' Get the last inserted ID
                WriteLog("New customer inserted with ID: " & newCustomerId)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            WriteLog("Error inserting item: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        Return newCustomerId
    End Function

    Public Function InsertInventoryData(ByVal item_name As String, ByVal item_brand As String, ByVal quantity_restock As Integer, ByVal item_price As Decimal,
                                   ByVal item_cost As Decimal, ByVal next_restock_date As Date) As Boolean
        Try
            openConn(db_name)
            Dim query As String = "INSERT INTO inventory (item_name, item_brand, restock_quantity, item_price, item_cost, restock_date, status) " &
                              "VALUES (@item_name, @item_brand, @restock_quantity, @item_price, @item_cost, @restock_date, @status);
                                COMMIT;"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@item_name", item_name)
                cmd.Parameters.AddWithValue("@item_brand", item_brand)
                cmd.Parameters.AddWithValue("@restock_quantity", quantity_restock)
                cmd.Parameters.AddWithValue("@item_price", item_price)
                cmd.Parameters.AddWithValue("@item_cost", item_cost)
                cmd.Parameters.AddWithValue("@restock_date", next_restock_date)
                cmd.Parameters.AddWithValue("@status", "Available")
                cmd.Parameters.AddWithValue("@date_modified", Date.Now.ToString("yyyy mm, dd"))

                If cmd.ExecuteNonQuery() > 0 Then
                    WriteLog("Item " & item_name & " inserted successfully.")
                    MessageBox.Show("Item inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return True
                Else
                    WriteLog("Insert failed for item: " & item_name)
                    MessageBox.Show("Insert failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            WriteLog("Error inserting item: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function UpdateInventoryData(ByVal item_id As Integer, ByVal item_name As String, ByVal restock_quantity As Integer, ByVal item_brand As String, ByVal item_cost As Decimal, ByVal item_price As Decimal,
                                         ByVal restock_date As Date)

        Try
            openConn(db_name)
            Dim query As String = "UPDATE inventory SET item_name = @item_name, restock_quantity = @restock_quantity, item_brand = @item_brand, " &
                "item_cost = @item_cost, item_price = @item_price, restock_date = @restock_date WHERE item_id = @item_id;
                COMMIT;"


            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@item_id", item_id)
            cmd.Parameters.AddWithValue("@item_name", item_name)
            cmd.Parameters.AddWithValue("@restock_quantity", restock_quantity)
            cmd.Parameters.AddWithValue("@item_brand", item_brand)
            cmd.Parameters.AddWithValue("@item_cost", item_cost)
            cmd.Parameters.AddWithValue("@item_price", item_price)
            cmd.Parameters.AddWithValue("@restock_date", restock_date)

            If cmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Item data updated successfully for item " & item_id, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                WriteLog("Item data updated successfully for item " & item_id)
                Return True
            Else
                MessageBox.Show("No records updated for item " & item_id, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                WriteLog("No records updated for item " & item_id)
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating item data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            WriteLog("Error updating item data: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function DeleteInventoryRow(ByVal item_id As Integer)
        Try
            openConn(db_name)

            Dim query As String = "DELETE FROM inventory WHERE item_id = @item_id; COMMIT;  "
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@item_id", item_id)
            If cmd.ExecuteNonQuery() > 0 Then
                WriteLog("Item deleted successfully for " & item_id)
                MessageBox.Show("Item deleted successfully for " & item_id, "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Else
                WriteLog("No item found to delete for item " & item_id)
                MessageBox.Show("No item found to delete for item " & item_id, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting item: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            WriteLog("Error deleting item: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function InsertServiceData(ByVal service_name As String, ByVal service_category As String, ByVal service_fee As Decimal,
                                       ByVal is_available As Boolean, ByVal service_status As String, ByVal description As String)
        Try
            openConn(db_name)
            Dim query As String = "INSERT INTO service (service_category, service_name, service_fee, is_available, service_status, description) " &
                              "VALUES (@service_category, @service_name, @service_fee, @is_available, @service_status, @description);
                                COMMIT;"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@service_category", service_category)
                cmd.Parameters.AddWithValue("@service_name", service_name)
                cmd.Parameters.AddWithValue("@service_fee", service_fee)
                cmd.Parameters.AddWithValue("@is_available", is_available)
                cmd.Parameters.AddWithValue("@service_status", service_status)
                cmd.Parameters.AddWithValue("@description", description)


                If cmd.ExecuteNonQuery() > 0 Then
                    WriteLog("Service " & service_name & " inserted successfully.")
                    MessageBox.Show("Service inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return True
                Else
                    WriteLog("Insert failed for service: " & service_name)
                    MessageBox.Show("Insert failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            WriteLog("Error inserting item: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

    End Function


    Public Function UpdateServiceRow(ByVal service_id As Integer, ByVal service_name As String, ByVal service_category As String, ByVal service_fee As Decimal,
                                       ByVal is_available As Boolean, ByVal service_status As String, ByVal description As String)
        Try
            openConn(db_name)
            Dim query As String = "UPDATE service SET service_name = @service_name, service_category = @service_category, service_fee = @service_fee, " &
                "is_available = @is_available, service_status = @service_status, description = @description WHERE service_id = @service_id; COMMIT;"

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@service_id", service_id)
            cmd.Parameters.AddWithValue("@service_name", service_name)
            cmd.Parameters.AddWithValue("@service_category", service_category)
            cmd.Parameters.AddWithValue("@service_fee", service_fee)
            cmd.Parameters.AddWithValue("@is_available", is_available)
            cmd.Parameters.AddWithValue("@service_status", service_status)
            cmd.Parameters.AddWithValue("@description", description)

            If cmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Service data updated successfully for item " & service_id, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                WriteLog("Service data updated successfully for item " & service_id)
                Return True
            Else
                MessageBox.Show("No records updated for service " & service_id, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                WriteLog("No records updated for service " & service_id)
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating service data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            WriteLog("Error updating service data: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function DeleteServiceRow(ByVal item_id As Integer)
        Try
            openConn(db_name)

            Dim query As String = "DELETE FROM service WHERE service_id = @service_id; COMMIT;"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@service_id", item_id)
            If cmd.ExecuteNonQuery() > 0 Then
                WriteLog("Service deleted successfully for " & item_id)
                MessageBox.Show("Service deleted successfully for " & item_id, "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Else
                WriteLog("No service found to delete for item " & item_id)
                MessageBox.Show("No service found to delete for item " & item_id, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting service: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            WriteLog("Error deleting service: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function InsertTransaction(ByVal customer_id As Integer, ByVal user_id As Integer, ByVal payment_received As Decimal, ByVal payment_method As String)
        Dim newTransactionId As Integer = -1
        Try
            openConn(db_name)
            Dim query As String = "INSERT INTO transactions (customer_id, user_id, payment_received, payment_method) " &
                              "VALUES (@customer_id, @user_id, @payment_received, @payment_method); " &
                              "SELECT LAST_INSERT_ID();
                              COMMIT;"


            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@customer_id", customer_id)
                cmd.Parameters.AddWithValue("@user_id", user_id)
                cmd.Parameters.AddWithValue("@payment_received", payment_received)
                cmd.Parameters.AddWithValue("@payment_method", payment_method)


                newTransactionId = Convert.ToInt32(cmd.ExecuteScalar())
                WriteLog("Transaction inserted successfully with ID: " & newTransactionId)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            WriteLog("Error inserting transaction: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        Return newTransactionId
    End Function



    Public Function InsertTransactionOrders(ByVal transaction_id As Integer, ByVal user_id As Integer, ByVal quantity As Integer, ByVal note As String, ByVal item_name As String)
        Dim change_item_name As String
        Dim item_id As Integer

        If item_name = "Ariel/Breeze/Tide" Then change_item_name = "Detergent"
        If item_name = "Regular Bleach" Then change_item_name = "Regular Bleach"
        If item_name = "Colored Safe Bleach" Then change_item_name = "Colored Bleach"
        If item_name = "Fabric Conditioner" Then change_item_name = "Fabric conditioner"

        item_id = GetItemID(change_item_name)

        Try
            openConn(db_name)
            Dim query As String = "INSERT INTO transactions_orders (transaction_id, user_id, quantity, item_id, note) " &
                              "VALUES (@transaction_id, @user_id, @quantity, @item_id, @note);
                              COMMIT;"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@transaction_id", transaction_id)
                cmd.Parameters.AddWithValue("@user_id", user_id)
                cmd.Parameters.AddWithValue("@item_id", item_id)
                cmd.Parameters.AddWithValue("@quantity", quantity)
                cmd.Parameters.AddWithValue("@note", note)


                If cmd.ExecuteNonQuery() > 0 Then
                    WriteLog("Order " & item_name & " inserted successfully.")
                    MessageBox.Show("Transaction Service inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return True
                Else
                    WriteLog("Insert failed for order: " & item_name)
                    MessageBox.Show("Insert failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            WriteLog("Error inserting transaction order: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function InsertTransactionService(ByVal transaction_id As Integer, ByVal user_id As Integer, ByVal sub_total As Decimal, ByVal service_id As Integer, ByVal is_colored As Boolean, ByVal load_weight As Integer, ByVal note As String, ByVal service_name As String)
        Try
            openConn(db_name)
            Dim query As String = "INSERT INTO transactions_services (transaction_id, user_id, service_id, colored, load_weight,sub_total, note) " &
                              "VALUES (@transaction_id, @user_id, @service_id, @colored, @load_weight, @sub_total, @note);
                              COMMIT;"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@transaction_id", transaction_id)
                cmd.Parameters.AddWithValue("@user_id", user_id)
                cmd.Parameters.AddWithValue("@service_id", service_id)
                cmd.Parameters.AddWithValue("@colored", is_colored)
                cmd.Parameters.AddWithValue("@load_weight", load_weight)
                cmd.Parameters.AddWithValue("@sub_total", sub_total)
                cmd.Parameters.AddWithValue("@note", note)


                If cmd.ExecuteNonQuery() > 0 Then
                    WriteLog("Transaction Service " & service_name & " inserted successfully.")
                    Return True
                Else
                    WriteLog("Insert failed for service transaction: " & service_name)
                    MessageBox.Show("Insert failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            WriteLog("Error inserting transaction: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function GetLastInsertedId(ByVal first_name As String, ByVal last_name As String) As Integer
        Dim full_name As String = first_name & " " & last_name

        Try
            openConn(db_name)

            Dim query As String = "SELECT customer_id FROM customer " &
                              "WHERE customer_fname = @first_name AND customer_lname = @last_name LIMIT 1"

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@customer_fname", first_name)
            cmd.Parameters.AddWithValue("@customer_lname", last_name)

            Dim result As Object = cmd.ExecuteScalar()

            If result IsNot Nothing Then
                WriteLog("Customer ID retrieved for: " & full_name)
                Return Convert.ToInt32(result)
            Else
                WriteLog("No matching customer found for: " & full_name)
                Return -1 ' Not found
            End If

        Catch ex As Exception
            WriteLog("Error retrieving customer ID: " & ex.Message)
            Return -1
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

    End Function

    Public Function GetLastInsertedIdFromAcc(ByVal user_name As String) As Integer
        Dim user_id As Integer = -1

        Try
            openConn(db_name)

            Dim query As String = "SELECT user_id FROM useracc " &
                              "WHERE user_name = @user_name LIMIT 1"

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@user_name", user_name)

            Dim result As Object = cmd.ExecuteScalar()

            If result IsNot Nothing Then
                WriteLog("User ID retrieved for: " & user_name)
                Return Convert.ToInt32(result)
            Else
                WriteLog("No matching users found for: " & user_name)
                Return -1 ' Not found
            End If

        Catch ex As Exception
            WriteLog("Error retrieving customer ID: " & ex.Message)
            Return -1
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        Return user_id
    End Function
    Public Function GetServiceID(ByVal service_name As String, ByVal service_category As String)
        Dim serviceId As Integer = -1
        Try
            openConn(db_name)

            Dim query As String = "
            SELECT service_id 
            FROM service 
            WHERE service_name = @service_name AND service_category = @service_category 
            LIMIT 1;"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@service_name", service_name)
                cmd.Parameters.AddWithValue("@service_category", service_category)

                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    serviceId = Convert.ToInt32(result)
                    WriteLog("Service ID retrieved: " & serviceId)
                Else
                    WriteLog("Service not found: " & service_name & " - " & service_category)
                End If
            End Using

        Catch ex As Exception
            WriteLog("Error retrieving service ID: " & ex.Message)
            MessageBox.Show("Error retrieving service ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        Return serviceId
    End Function

    Public Function GetTransaction(ByVal transaction_id As Integer) As String
        Dim userName As Integer = 0
        Try
            openConn(db_name)
            Dim query As String = "SELECT transaction_id FROM transactions WHERE transaction_id = @transaction_id LIMIT 1;"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@transaction_id", transaction_id)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then userName = result.ToString()
            End Using
        Catch ex As Exception
            WriteLog("Error retrieving transaction ID: " & ex.Message)
            MessageBox.Show("Error retrieving transaction ID: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
        Return userName
    End Function

    Public Function GetUserName(ByVal user_id As Integer) As String
        If user_id = -1 Then
            Return "N/A"
        End If

        Dim userName As String = "Unknown"
        Try
            openConn(db_name)
            Dim query As String = "SELECT user_name FROM useracc WHERE user_id = @user_id LIMIT 1;"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@user_id", user_id)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then userName = result.ToString()
            End Using
        Catch ex As Exception
            WriteLog("Error retrieving user name: " & ex.Message)
            MessageBox.Show("Error retrieving user name: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
        Return userName
    End Function



    Public Function GetUserFirst(ByVal user_id As Integer) As String
        Dim userName As String = "Unknown"
        Try
            openConn(db_name)
            Dim query As String = "SELECT customer_fname FROM customer WHERE customer_id = @customer_id LIMIT 1;"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@customer_id", user_id)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then userName = result.ToString()
            End Using
        Catch ex As Exception
            WriteLog("Error retrieving user name: " & ex.Message)
            MessageBox.Show("Error retrieving user name: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
        Return userName
    End Function

    Public Function GetUserLast(ByVal user_id As Integer) As String
        Dim userName As String = "Unknown"
        Try
            openConn(db_name)
            Dim query As String = "SELECT customer_lname FROM customer WHERE customer_id = @customer_id LIMIT 1;"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@customer_id", user_id)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then userName = result.ToString()
            End Using
        Catch ex As Exception
            WriteLog("Error retrieving user name: " & ex.Message)
            MessageBox.Show("Error retrieving user name: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
        Return userName
    End Function

    Public Function GetUserMi(ByVal user_id As Integer) As String
        Dim userName As String = "Unknown"
        Try
            openConn(db_name)
            Dim query As String = "SELECT customer_minitial FROM customer WHERE customer_id = @customer_id LIMIT 1;"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@customer_id", user_id)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then userName = result.ToString()
            End Using
        Catch ex As Exception
            WriteLog("Error retrieving user name: " & ex.Message)
            MessageBox.Show("Error retrieving user name: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
        Return userName
    End Function


    Public Function GetCustomerContact(ByVal customer_id As Integer) As String
        Dim contact As String = "N/A"
        Try
            openConn(db_name)
            Dim query As String = "SELECT customer_contact FROM customer WHERE customer_id = @customer_id LIMIT 1;"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@customer_id", customer_id)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then contact = result.ToString()
            End Using
        Catch ex As Exception
            WriteLog("Error retrieving customer contact: " & ex.Message)
            MessageBox.Show("Error retrieving customer contact: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
        Return contact
    End Function

    Public Function GetServiceName(ByVal transaction_id As Integer) As String
        Dim serviceDetails As String = ""
        Try
            openConn(db_name)
            Dim query As String = "
            SELECT s.service_name
        FROM service s
        INNER JOIN transactions_services ts ON s.service_id = ts.service_id
        WHERE ts.transaction_id = @transaction_id;
        "
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@transaction_id", transaction_id)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim name As String = reader("service_name").ToString()
                        serviceDetails = name
                    End While
                End Using
            End Using
        Catch ex As Exception
            WriteLog("Error retrieving service details: " & ex.Message)
            MessageBox.Show("Error retrieving service details: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
        Return serviceDetails
    End Function

    Public Function GetServiceCategory(ByVal transaction_id As Integer) As String
        Dim serviceDetails As String = ""
        Try
            openConn(db_name)
            Dim query As String = "
            SELECT s.service_category
        FROM service s
        INNER JOIN transactions_services ts ON s.service_id = ts.service_id
        WHERE ts.transaction_id = @transaction_id;
        "
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@transaction_id", transaction_id)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim category As String = reader("service_category").ToString()
                        serviceDetails = category
                    End While

                End Using
            End Using
        Catch ex As Exception
            WriteLog("Error retrieving service details: " & ex.Message)
            MessageBox.Show("Error retrieving service details: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
        Return serviceDetails
    End Function

    Public Function GetAddonItemNames(transaction_id As Integer) As String()
        Dim itemNames As New List(Of String)()

        Try
            openConn(db_name)

            Dim query As String = "SELECT i.item_name " &
                              "FROM transactions_orders t " &
                              "INNER JOIN inventory i ON t.item_id = i.item_id " &
                              "WHERE t.transaction_id = @transaction_id " &
                              "LIMIT 4"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@transaction_id", transaction_id)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        itemNames.Add(reader("item_name").ToString())
                    End While
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error retrieving addon item names: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            WriteLog("Error retrieving addon item names: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        ' Ensure the result always has 4 items (fill with empty strings if less)
        While itemNames.Count < 4
            itemNames.Add("")
        End While

        Return itemNames.ToArray()
    End Function

    Public Function GetItemID(ByVal item_name As String)
        Dim item_id As Integer = -1
        Try
            openConn(db_name)

            Dim query As String = "
            SELECT item_id 
            FROM inventory 
            WHERE item_name = @item_name 
            LIMIT 1;"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@item_name", item_name)

                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    item_id = Convert.ToInt32(result)
                    WriteLog("Item ID retrieved: " & item_id)
                Else
                    WriteLog("Item not found: " & item_name)
                End If
            End Using

        Catch ex As Exception
            WriteLog("Error retrieving item ID: " & ex.Message)
            MessageBox.Show("Error retrieving item ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        Return item_id
    End Function

    Public Function GetSubTotal(ByVal service_name As String, ByVal service_category As String)
        Dim serviceId As Decimal = -1
        Try
            openConn(db_name)

            Dim query As String = "
            SELECT service_fee 
            FROM service 
            WHERE service_name = @service_name AND service_category = @service_category 
            LIMIT 1;"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@service_name", service_name)
                cmd.Parameters.AddWithValue("@service_category", service_category)

                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    serviceId = Convert.ToDecimal(result)
                    WriteLog("Service fee retrieved: " & serviceId)
                Else
                    WriteLog("Service not found: " & service_name & " - " & service_category)
                End If
            End Using

        Catch ex As Exception
            WriteLog("Error retrieving service ID: " & ex.Message)
            MessageBox.Show("Error retrieving service ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        Return serviceId
    End Function

    Public Function GetItemPrice(ByVal item_name As String)

        Dim change_item_name As String

        Dim serviceId As Decimal = -1

        If item_name = "Ariel/Breeze/Tide" Then change_item_name = "Detergent"
        If item_name = "Regular Bleach" Then change_item_name = "Regular Bleach"
        If item_name = "Colored Safe Bleach" Then change_item_name = "Colored Bleach"
        If item_name = "Fabric Conditioner" Then change_item_name = "Fabric conditioner"

        Try
            openConn(db_name)

            Dim query As String = "
            SELECT item_price 
            FROM inventory 
            WHERE item_name = @item_name
            LIMIT 1;"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@item_name", change_item_name)

                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    serviceId = Convert.ToDecimal(result)
                    WriteLog("Item price retrieved: " & serviceId)
                Else
                    WriteLog("Item not found: " & item_name)
                End If
            End Using

        Catch ex As Exception
            WriteLog("Error retrieving item ID: " & ex.Message)
            MessageBox.Show("Error retrieving item ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        Return serviceId
    End Function

    Public Function UpdateTransaction(ByVal transaction_id As Integer)
        Dim transaction_status As String = "Finished"
        Dim is_completed As Boolean = True

        Try
            openConn(db_name)

            ' Hash password before updating
            Dim query As String = "UPDATE transactions SET transaction_status = @transaction_status, is_completed = @is_completed, completion_date = @completion_date WHERE transaction_id = @transaction_id"
            cmd = New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@transaction_status", transaction_status)
            cmd.Parameters.AddWithValue("@is_completed", is_completed)
            cmd.Parameters.AddWithValue("@completion_date", Date.Now)
            cmd.Parameters.AddWithValue("@transaction_id", transaction_id)

            If cmd.ExecuteNonQuery() > 0 Then
                WriteLog("Transaction completed for: " & transaction_id)
                Return True
            Else
                WriteLog("Transaction failed: " & transaction_id)
                Return False
            End If
        Catch ex As Exception
            WriteLog("Error updating transaction data: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function CancelledTransaction(ByVal transaction_id As Integer)
        Dim transaction_status As String = "Cancelled"
        Dim is_completed As Boolean = True

        Try
            openConn(db_name)

            ' Hash password before updating
            Dim query As String = "UPDATE transactions SET transaction_status = @transaction_status, is_completed = @is_completed, completion_date = @completion_date WHERE transaction_id = @transaction_id"
            cmd = New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@transaction_status", transaction_status)
            cmd.Parameters.AddWithValue("@is_completed", is_completed)
            cmd.Parameters.AddWithValue("@completion_date", Date.Now)
            cmd.Parameters.AddWithValue("@transaction_id", transaction_id)

            If cmd.ExecuteNonQuery() > 0 Then
                WriteLog("Transaction cancelled for: " & transaction_id)
                Return True
            Else
                WriteLog("Transaction cancellation failed: " & transaction_id)
                Return False
            End If
        Catch ex As Exception
            WriteLog("Error updating transaction data: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function CheckStock(itemName As String, requiredQty As Integer) As Boolean
        Try
            openConn(db_name)
            Dim query As String = "SELECT current_quantity FROM inventory WHERE item_name = @itemName;"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@itemName", itemName)
                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    Return Convert.ToInt32(result) >= requiredQty
                Else
                    ' Item not found in inventory
                    MessageBox.Show("Item not found in inventory: " & itemName, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking stock for item '" & itemName & "': " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function SetUserOnline(userId As Integer)
        Try
            openConn(db_name)

            Dim query As String = "UPDATE useracc SET status = 'Online' WHERE user_id = @user_id"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@user_id", userId)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Failed to update user status: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function SetUserOffline(userId As Integer)
        Try
            openConn(db_name)

            Dim query As String = "UPDATE useracc SET status = 'Offline' WHERE user_id = @user_id"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@user_id", userId)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Failed to update user status: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function GetServiceStatus(ByVal service_name As String)
        Try
            openConn(db_name)
            Dim query As String = "SELECT service_status FROM service WHERE service_name = @service_name LIMIT 1;"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@service_name", service_name)
                Dim result As String = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    Return True
                Else
                    WriteLog("Service not found: " & service_name)
                    Return False
                End If
            End Using
        Catch ex As Exception
            WriteLog("Error retrieving service status: " & ex.Message)
            MessageBox.Show("Error retrieving service status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "Error"
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function GetMostTransactionFinished() As String
        Try
            openConn(db_name)

            Dim query As String = "
            SELECT full_name FROM (
            SELECT CONCAT(a.admin_fname, ' ', a.admin_lname) AS full_name, COUNT(t.transaction_id) AS transactions_completed
            FROM transactions t
            JOIN admins a ON t.user_id = a.user_id
            WHERE t.completion_date >= CURDATE() - INTERVAL 7 DAY
            GROUP BY t.user_id

            UNION ALL

            SELECT CONCAT(e.employee_fname, ' ', e.employee_lname) AS full_name, COUNT(t.transaction_id) AS transactions_completed
            FROM transactions t
            JOIN employees e ON t.user_id = e.user_id
            WHERE t.completion_date >= CURDATE() - INTERVAL 7 DAY
            GROUP BY t.user_id
            ) AS combined
            ORDER BY transactions_completed DESC
            LIMIT 1;
            "

            Using cmd As New MySqlCommand(query, conn)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    Return result.ToString()
                Else
                    Return "No Data"
                End If
            End Using

        Catch ex As Exception
            WriteLog("Error in GetMostTransactionFinished: " & ex.Message)
            Return "Error"
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function


    Public Function GetServiceTimesAvailed() As String
        Try
            openConn(db_name)

            Dim query As String = "
            SELECT s.service_name, COUNT(ts.service_id) AS times_availed
            FROM transactions_services ts
            JOIN service s ON ts.service_id = s.service_id
            WHERE ts.completion_date >= CURDATE() - INTERVAL 7 DAY
            GROUP BY ts.service_id
            ORDER BY times_availed DESC
            LIMIT 1;
        "

            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim name As String = reader("service_name").ToString()
                        Dim count As Integer = Convert.ToInt32(reader("times_availed"))
                        Return $"{name} - {count} orders"
                    Else
                        Return "No data"
                    End If
                End Using
            End Using

        Catch ex As Exception
            WriteLog("Error in GetServiceTimesAvailed: " & ex.Message)
            Return "Error"
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Public Function GetTotalCustomersLastWeek() As String
        Dim totalCustomer As Integer = 0
        Try
            openConn(db_name)

            ' MySQL query to get distinct customers from last week's Monday to Sunday
            Dim query As String = "
            SELECT COUNT(DISTINCT customer_id) AS total_customers
            FROM transactions
            WHERE transaction_date >= DATE_SUB(CURDATE(), INTERVAL (WEEKDAY(CURDATE()) + 7) DAY)
              AND transaction_date < DATE_SUB(CURDATE(), INTERVAL WEEKDAY(CURDATE()) DAY);
        "

            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim total As Integer = Convert.ToInt32(reader("total_customers"))
                        totalCustomer = total
                    Else
                        Return "No data"
                    End If
                End Using
            End Using

        Catch ex As Exception
            WriteLog("Error in GetTotalCustomersLastWeek: " & ex.Message)
            Return "Error"
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        Return totalCustomer.ToString()
    End Function


    Public Function GetItemTimesAvailed() As String
        Try
            openConn(db_name)

            Dim query As String = "
            SELECT i.item_name, COUNT(to2.item_id) AS times_availed
            FROM transactions_orders to2
            JOIN inventory i ON to2.item_id = i.item_id
            WHERE to2.completion_date >= CURDATE() - INTERVAL 7 DAY
            GROUP BY to2.item_id
            ORDER BY times_availed DESC
            LIMIT 1;
        "

            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim name As String = reader("item_name").ToString()
                        Dim count As Integer = Convert.ToInt32(reader("times_availed"))
                        Return $"{name} - {count} orders"
                    Else
                        Return "No data"
                    End If
                End Using
            End Using

        Catch ex As Exception
            WriteLog("Error in GetItemTimesAvailed: " & ex.Message)
            Return "Error"
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function


    Public Function GetServices() As Dictionary(Of String, Integer)
        Dim results As New Dictionary(Of String, Integer)

        Try
            openConn(db_name)
            Dim query As String = "
            SELECT s.service_name, COUNT(*) AS total_availed
            FROM transactions_services ts
            INNER JOIN service s ON s.service_id = ts.service_id
            WHERE ts.completion_date >= CURDATE() - INTERVAL 7 DAY
            GROUP BY s.service_name
            ORDER BY total_availed DESC
            LIMIT 5;
        "

            Using cmd As New MySqlCommand(query, conn)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        results.Add(reader("service_name").ToString(), Convert.ToInt32(reader("total_availed")))
                    End While
                End Using
            End Using
        Catch ex As Exception
            WriteLog("Error loading chart data: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Return results
    End Function

    Public Function GetItem() As Dictionary(Of String, Integer)
        Dim results As New Dictionary(Of String, Integer)
        Try
            openConn(db_name)
            Dim query As String = "
            SELECT i.item_name, COUNT(*) AS total_availed
            FROM transactions_orders ts
            INNER JOIN inventory i ON i.item_id = ts.item_id
            WHERE ts.completion_date >= CURDATE() - INTERVAL 7 DAY
            GROUP BY i.item_name
            ORDER BY total_availed DESC
            LIMIT 5;
        "

            Using cmd As New MySqlCommand(query, conn)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        results.Add(reader("item_name").ToString(), Convert.ToInt32(reader("total_availed")))
                    End While
                End Using
            End Using
        Catch ex As Exception
            WriteLog("Error loading chart data: " & ex.Message)

        Finally
            conn.Close()
        End Try

        Return results
    End Function


    Public Function GetAdminID(ByVal user_id As Integer) As Integer
        Dim adminId As Integer = -1
        Try
            openConn(db_name)

            Dim query As String = "SELECT admin_id FROM admins WHERE user_id = @user_id LIMIT 1;"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@user_id", user_id)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    adminId = Convert.ToInt32(result)
                    WriteLog("Admin ID retrieved: " & adminId)
                Else
                    WriteLog("Admin not found for user ID: " & user_id)
                End If
            End Using
        Catch ex As Exception
            WriteLog("Error retrieving admin ID: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        Return adminId
    End Function

    Public Function GetAdminFullName(ByVal admin_id As Integer) As String
        Dim fullName As String = "Unknown"
        Try
            openConn(db_name)

            Dim query As String = "SELECT admin_fname, admin_lname FROM admins WHERE admin_id = @admin_id LIMIT 1;"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@admin_id", admin_id)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        fullName = reader("admin_fname").ToString() & " " & reader("admin_lname").ToString()
                        WriteLog("Admin full name retrieved: " & fullName)
                    Else
                        WriteLog("Admin not found for admin ID: " & admin_id)
                    End If
                End Using
            End Using
        Catch ex As Exception
            WriteLog("Error retrieving admin full name: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        Return fullName
    End Function

End Module


