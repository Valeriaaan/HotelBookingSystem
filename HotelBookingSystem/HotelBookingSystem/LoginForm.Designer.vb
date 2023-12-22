<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SignUpPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GoToSignInBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SignUpBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SignUpPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.SignUpUsernameTextBox = New System.Windows.Forms.TextBox()
        Me.SignInPanel = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GoToSignUpBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SignInBtn = New System.Windows.Forms.Button()
        Me.LoginNameLabel = New System.Windows.Forms.Label()
        Me.LoginPasswordLabel = New System.Windows.Forms.Label()
        Me.SignInPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.SignInUsernameTextBox = New System.Windows.Forms.TextBox()
        Me.SignUpPanel.SuspendLayout()
        Me.SignInPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'SignUpPanel
        '
        Me.SignUpPanel.Controls.Add(Me.Label1)
        Me.SignUpPanel.Controls.Add(Me.GoToSignInBtn)
        Me.SignUpPanel.Controls.Add(Me.Label2)
        Me.SignUpPanel.Controls.Add(Me.SignUpBtn)
        Me.SignUpPanel.Controls.Add(Me.Label3)
        Me.SignUpPanel.Controls.Add(Me.Label4)
        Me.SignUpPanel.Controls.Add(Me.SignUpPasswordTextBox)
        Me.SignUpPanel.Controls.Add(Me.SignUpUsernameTextBox)
        Me.SignUpPanel.Location = New System.Drawing.Point(12, 12)
        Me.SignUpPanel.Name = "SignUpPanel"
        Me.SignUpPanel.Size = New System.Drawing.Size(487, 427)
        Me.SignUpPanel.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(148, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(192, 25)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Create an Account"
        '
        'GoToSignInBtn
        '
        Me.GoToSignInBtn.BackColor = System.Drawing.SystemColors.Control
        Me.GoToSignInBtn.FlatAppearance.BorderSize = 0
        Me.GoToSignInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GoToSignInBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GoToSignInBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GoToSignInBtn.Location = New System.Drawing.Point(106, 352)
        Me.GoToSignInBtn.Name = "GoToSignInBtn"
        Me.GoToSignInBtn.Size = New System.Drawing.Size(279, 40)
        Me.GoToSignInBtn.TabIndex = 52
        Me.GoToSignInBtn.Text = "Login to your account."
        Me.GoToSignInBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(228, 313)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(29, 25)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "or"
        '
        'SignUpBtn
        '
        Me.SignUpBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.SignUpBtn.FlatAppearance.BorderSize = 0
        Me.SignUpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.SignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignUpBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SignUpBtn.ForeColor = System.Drawing.Color.White
        Me.SignUpBtn.Location = New System.Drawing.Point(106, 262)
        Me.SignUpBtn.Name = "SignUpBtn"
        Me.SignUpBtn.Size = New System.Drawing.Size(279, 40)
        Me.SignUpBtn.TabIndex = 50
        Me.SignUpBtn.Text = "Register"
        Me.SignUpBtn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(101, 81)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(102, 25)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(101, 161)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(98, 25)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Password"
        '
        'SignUpPasswordTextBox
        '
        Me.SignUpPasswordTextBox.Location = New System.Drawing.Point(106, 202)
        Me.SignUpPasswordTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.SignUpPasswordTextBox.Name = "SignUpPasswordTextBox"
        Me.SignUpPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.SignUpPasswordTextBox.Size = New System.Drawing.Size(279, 30)
        Me.SignUpPasswordTextBox.TabIndex = 47
        '
        'SignUpUsernameTextBox
        '
        Me.SignUpUsernameTextBox.Location = New System.Drawing.Point(106, 119)
        Me.SignUpUsernameTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.SignUpUsernameTextBox.Name = "SignUpUsernameTextBox"
        Me.SignUpUsernameTextBox.Size = New System.Drawing.Size(279, 30)
        Me.SignUpUsernameTextBox.TabIndex = 46
        '
        'SignInPanel
        '
        Me.SignInPanel.Controls.Add(Me.Label6)
        Me.SignInPanel.Controls.Add(Me.GoToSignUpBtn)
        Me.SignInPanel.Controls.Add(Me.Label5)
        Me.SignInPanel.Controls.Add(Me.SignInBtn)
        Me.SignInPanel.Controls.Add(Me.LoginNameLabel)
        Me.SignInPanel.Controls.Add(Me.LoginPasswordLabel)
        Me.SignInPanel.Controls.Add(Me.SignInPasswordTextBox)
        Me.SignInPanel.Controls.Add(Me.SignInUsernameTextBox)
        Me.SignInPanel.Location = New System.Drawing.Point(12, 12)
        Me.SignInPanel.Name = "SignInPanel"
        Me.SignInPanel.Size = New System.Drawing.Size(487, 427)
        Me.SignInPanel.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(132, 34)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(222, 25)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Login to your Account"
        '
        'GoToSignUpBtn
        '
        Me.GoToSignUpBtn.BackColor = System.Drawing.SystemColors.Control
        Me.GoToSignUpBtn.FlatAppearance.BorderSize = 0
        Me.GoToSignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GoToSignUpBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GoToSignUpBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GoToSignUpBtn.Location = New System.Drawing.Point(106, 353)
        Me.GoToSignUpBtn.Name = "GoToSignUpBtn"
        Me.GoToSignUpBtn.Size = New System.Drawing.Size(279, 40)
        Me.GoToSignUpBtn.TabIndex = 52
        Me.GoToSignUpBtn.Text = "Create an Account."
        Me.GoToSignUpBtn.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(228, 314)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(29, 25)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "or"
        '
        'SignInBtn
        '
        Me.SignInBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.SignInBtn.FlatAppearance.BorderSize = 0
        Me.SignInBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.SignInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignInBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SignInBtn.ForeColor = System.Drawing.Color.White
        Me.SignInBtn.Location = New System.Drawing.Point(106, 263)
        Me.SignInBtn.Name = "SignInBtn"
        Me.SignInBtn.Size = New System.Drawing.Size(279, 40)
        Me.SignInBtn.TabIndex = 50
        Me.SignInBtn.Text = "Login"
        Me.SignInBtn.UseVisualStyleBackColor = False
        '
        'LoginNameLabel
        '
        Me.LoginNameLabel.AutoSize = True
        Me.LoginNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.LoginNameLabel.Location = New System.Drawing.Point(101, 82)
        Me.LoginNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LoginNameLabel.Name = "LoginNameLabel"
        Me.LoginNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LoginNameLabel.Size = New System.Drawing.Size(102, 25)
        Me.LoginNameLabel.TabIndex = 49
        Me.LoginNameLabel.Text = "Username"
        '
        'LoginPasswordLabel
        '
        Me.LoginPasswordLabel.AutoSize = True
        Me.LoginPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.LoginPasswordLabel.Location = New System.Drawing.Point(101, 162)
        Me.LoginPasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LoginPasswordLabel.Name = "LoginPasswordLabel"
        Me.LoginPasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LoginPasswordLabel.Size = New System.Drawing.Size(98, 25)
        Me.LoginPasswordLabel.TabIndex = 48
        Me.LoginPasswordLabel.Text = "Password"
        '
        'SignInPasswordTextBox
        '
        Me.SignInPasswordTextBox.Location = New System.Drawing.Point(106, 203)
        Me.SignInPasswordTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.SignInPasswordTextBox.Name = "SignInPasswordTextBox"
        Me.SignInPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.SignInPasswordTextBox.Size = New System.Drawing.Size(279, 30)
        Me.SignInPasswordTextBox.TabIndex = 47
        '
        'SignInUsernameTextBox
        '
        Me.SignInUsernameTextBox.Location = New System.Drawing.Point(106, 120)
        Me.SignInUsernameTextBox.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.SignInUsernameTextBox.Name = "SignInUsernameTextBox"
        Me.SignInUsernameTextBox.Size = New System.Drawing.Size(279, 30)
        Me.SignInUsernameTextBox.TabIndex = 46
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 451)
        Me.Controls.Add(Me.SignInPanel)
        Me.Controls.Add(Me.SignUpPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.SignUpPanel.ResumeLayout(False)
        Me.SignUpPanel.PerformLayout()
        Me.SignInPanel.ResumeLayout(False)
        Me.SignInPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SignUpPanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GoToSignInBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SignUpBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SignUpPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SignUpUsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SignInPanel As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GoToSignUpBtn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SignInBtn As System.Windows.Forms.Button
    Friend WithEvents LoginNameLabel As System.Windows.Forms.Label
    Friend WithEvents LoginPasswordLabel As System.Windows.Forms.Label
    Friend WithEvents SignInPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SignInUsernameTextBox As System.Windows.Forms.TextBox
End Class
