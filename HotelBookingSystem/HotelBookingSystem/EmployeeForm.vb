Public Class EmployeeForm

    ' Add Section Start

    Sub AddClearTextBoxes()
        AddRoleTextBox.Clear()
        AddFirstnameTextBox.Clear()
        AddLastnameTextBox.Clear()
        AddPhoneNumTextBox.Clear()
    End Sub

    Private Sub EmployeeAddBtn_Click(sender As Object, e As EventArgs) Handles EmployeeAddBtn.Click
        If String.IsNullOrWhiteSpace(AddRoleTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(AddFirstnameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(AddLastnameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(AddPhoneNumTextBox.Text) Then

            MsgBox("Please fill in all the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO employee (employeeRole, firstName, lastName, phoneNum) VALUES (@Role, @Firstname, @Lastname, @PhoneNumber)"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Role", AddRoleTextBox.Text)
            cmd.Parameters.AddWithValue("@Firstname", AddFirstnameTextBox.Text)
            cmd.Parameters.AddWithValue("@Lastname", AddLastnameTextBox.Text)
            cmd.Parameters.AddWithValue("@PhoneNumber", AddPhoneNumTextBox.Text)

            If MsgBox("Do you want to save this employee?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("New Employee Added!")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        AddClearTextBoxes()
    End Sub

    ' Add Section End

    ' Update Section Start

    Sub UpdateClearTextBoxes()
        UpdateRoleTextBox.Clear()
        UpdateFirstNameTextBox.Clear()
        UpdateLastNameTextBox.Clear()
        UpdatePhoneNumTextBox.Clear()
    End Sub

    Sub UpdateShowEmployeeID()
        Dim UpdateEmployeeIDs As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM employee"
            adapter.SelectCommand = cmd
            adapter.Fill(UpdateEmployeeIDs)

            UpdateEmployeeIDComboBox.DataSource = UpdateEmployeeIDs
            UpdateEmployeeIDComboBox.DisplayMember = "employeeID"
            UpdateEmployeeIDComboBox.ValueMember = "employeeID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UpdateEmployeeIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UpdateEmployeeIDComboBox.SelectedIndexChanged
        If UpdateEmployeeIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM employee WHERE employeeID = '" & UpdateEmployeeIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    UpdateRoleTextBox.Text = reader.GetString("employeeRole")
                    UpdateFirstNameTextBox.Text = reader.GetString("firstName")
                    UpdateLastNameTextBox.Text = reader.GetString("lastName")
                    UpdatePhoneNumTextBox.Text = reader.GetString("phoneNum")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub EmployeeUpdateBtn_Click(sender As Object, e As EventArgs) Handles EmployeeUpdateBtn.Click
        If String.IsNullOrWhiteSpace(UpdateRoleTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(UpdateFirstNameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(UpdateLastNameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(UpdatePhoneNumTextBox.Text) Then

            MsgBox("Please fill in all the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE employee SET employeeRole = @Role, firstName = @Firstname, lastName = @Lastname, phoneNum = @PhoneNumber WHERE employeeID = @EmployeeID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@EmployeeID", UpdateEmployeeIDComboBox.SelectedValue)
            cmd.Parameters.AddWithValue("@Role", UpdateRoleTextBox.Text)
            cmd.Parameters.AddWithValue("@Firstname", UpdateFirstNameTextBox.Text)
            cmd.Parameters.AddWithValue("@Lastname", UpdateLastNameTextBox.Text)
            cmd.Parameters.AddWithValue("@PhoneNumber", UpdatePhoneNumTextBox.Text)

            If MsgBox("Do you want to update employee data?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("Employee data updated!")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        UpdateClearTextBoxes()
    End Sub

    ' Update Section End

    ' Delete Section Start

    Sub DeleteClearTextBoxes()
        UpdateRoleTextBox.Clear()
        UpdateFirstNameTextBox.Clear()
        UpdateLastNameTextBox.Clear()
        UpdatePhoneNumTextBox.Clear()
    End Sub

    Sub DeleteShowEmployeeID()
        Dim DeleteEmployeeIDs As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM employee"
            adapter.SelectCommand = cmd
            adapter.Fill(DeleteEmployeeIDs)

            DeleteEmployeeIDComboBox.DataSource = DeleteEmployeeIDs
            DeleteEmployeeIDComboBox.DisplayMember = "employeeID"
            DeleteEmployeeIDComboBox.ValueMember = "employeeID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DeleteEmployeeIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DeleteEmployeeIDComboBox.SelectedIndexChanged
        If DeleteEmployeeIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM employee WHERE employeeID = '" & DeleteEmployeeIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    DeleteRoleTextBox.Text = reader.GetString("employeeRole")
                    DeleteFirstNameTextBox.Text = reader.GetString("firstName")
                    DeleteLastNameTextBox.Text = reader.GetString("lastName")
                    DeletePhoneNumTextBox.Text = reader.GetString("phoneNum")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub EmployeeDeleteBtn_Click(sender As Object, e As EventArgs) Handles EmployeeDeleteBtn.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM employee WHERE employeeID = @EmployeeID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@EmployeeID", DeleteEmployeeIDComboBox.SelectedValue)

            If MsgBox("Are you sure you want to delete this employee?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("Employee Has Been Deleted.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        DeleteShowEmployeeID()
    End Sub

    ' Delete Section End
End Class