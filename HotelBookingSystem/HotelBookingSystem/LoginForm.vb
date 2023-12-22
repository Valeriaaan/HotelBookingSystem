Imports MySql.Data.MySqlClient
Public Class LoginForm

    Private Sub ClearSignUpTextBoxes()
        SignUpUsernameTextBox.Clear()
        SignUpPasswordTextBox.Clear()
    End Sub

    Private Sub ClearSignInTextBoxes()
        SignInUsernameTextBox.Clear()
        SignInPasswordTextBox.Clear()
    End Sub

    ' Handles GoToSignUpBtn
    Private Sub GoToSignUpBtn_Click(sender As Object, e As EventArgs) Handles GoToSignUpBtn.Click
        SignInPanel.Visible = False
        SignUpPanel.Visible = True

        ClearSignUpTextBoxes()
        ClearSignInTextBoxes()
    End Sub

    ' Handles GoToSignInBtn
    Private Sub GoToSignInBtn_Click(sender As Object, e As EventArgs) Handles GoToSignInBtn.Click
        SignInPanel.Visible = True
        SignUpPanel.Visible = False

        ClearSignUpTextBoxes()
        ClearSignInTextBoxes()
    End Sub

    ' Sign In 
    Private Sub SignInBtn_Click(sender As Object, e As EventArgs) Handles SignInBtn.Click
        Try
            openCon()
            Using cmd As New MySqlCommand("SELECT * FROM user WHERE userName=@UserName AND userPassword=@UserPassword", con)

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@UserName", SignInUsernameTextBox.Text)
                cmd.Parameters.AddWithValue("@UserPassword", SignInPasswordTextBox.Text)

                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader
                    If reader.Read() Then
                        MsgBox("Login successful!")

                        ClearSignUpTextBoxes()
                        ClearSignInTextBoxes()

                        Dim MainForm As New MainForm
                        MainForm.Show()
                        Me.Hide()
                    Else
                        MsgBox("Invalid username or password. Please try again.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Sign Up   
    Private Sub SignUpBtn_Click(sender As Object, e As EventArgs) Handles SignUpBtn.Click
        If SignUpPasswordTextBox.Text.Length >= 8 Then
            Try
                openCon()
                Using cmd As New MySqlCommand("INSERT INTO user (userName, userPassword) VALUES (@UserName, @UserPassword)", con)

                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@UserName", SignUpUsernameTextBox.Text)
                    cmd.Parameters.AddWithValue("@UserPassword", SignUpPasswordTextBox.Text)

                    If MsgBox("Do you want to sign up with these credentials?", MsgBoxStyle.YesNo) = vbYes Then
                        cmd.ExecuteNonQuery()
                        MsgBox("Sign up Successful. Account Registered!")

                        ClearSignUpTextBoxes()
                        ClearSignInTextBoxes()

                        SignInPanel.Visible = True
                        SignUpPanel.Visible = False
                    End If
                End Using
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                con.Close()
            End Try
        Else
            MsgBox("Password must contain 8 or more characters. Please try again.")
        End If
    End Sub

End Class