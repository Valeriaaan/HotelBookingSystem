<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeForm
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
        Me.EmployeeAddPanel = New System.Windows.Forms.Panel()
        Me.AddRoleTextBox = New System.Windows.Forms.TextBox()
        Me.AddLastnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddPhoneNumTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeAddBtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.AddFirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeUpdatePanel = New System.Windows.Forms.Panel()
        Me.UpdateRoleTextBox = New System.Windows.Forms.TextBox()
        Me.UpdateEmployeeIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UpdateLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UpdatePhoneNumTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeUpdateBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UpdateFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeDeletePanel = New System.Windows.Forms.Panel()
        Me.DeleteEmployeeIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DeleteRoleTextBox = New System.Windows.Forms.TextBox()
        Me.DeleteLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DeletePhoneNumTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeDeleteBtn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DeleteFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeAddPanel.SuspendLayout()
        Me.EmployeeUpdatePanel.SuspendLayout()
        Me.EmployeeDeletePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmployeeAddPanel
        '
        Me.EmployeeAddPanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.EmployeeAddPanel.Controls.Add(Me.AddRoleTextBox)
        Me.EmployeeAddPanel.Controls.Add(Me.AddLastnameTextBox)
        Me.EmployeeAddPanel.Controls.Add(Me.Label1)
        Me.EmployeeAddPanel.Controls.Add(Me.AddPhoneNumTextBox)
        Me.EmployeeAddPanel.Controls.Add(Me.EmployeeAddBtn)
        Me.EmployeeAddPanel.Controls.Add(Me.Label6)
        Me.EmployeeAddPanel.Controls.Add(Me.Label11)
        Me.EmployeeAddPanel.Controls.Add(Me.Label12)
        Me.EmployeeAddPanel.Controls.Add(Me.AddFirstnameTextBox)
        Me.EmployeeAddPanel.ForeColor = System.Drawing.Color.White
        Me.EmployeeAddPanel.Location = New System.Drawing.Point(1, 0)
        Me.EmployeeAddPanel.Name = "EmployeeAddPanel"
        Me.EmployeeAddPanel.Size = New System.Drawing.Size(790, 451)
        Me.EmployeeAddPanel.TabIndex = 72
        '
        'AddRoleTextBox
        '
        Me.AddRoleTextBox.Location = New System.Drawing.Point(362, 95)
        Me.AddRoleTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AddRoleTextBox.Name = "AddRoleTextBox"
        Me.AddRoleTextBox.Size = New System.Drawing.Size(252, 30)
        Me.AddRoleTextBox.TabIndex = 74
        '
        'AddLastnameTextBox
        '
        Me.AddLastnameTextBox.Location = New System.Drawing.Point(363, 197)
        Me.AddLastnameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AddLastnameTextBox.Name = "AddLastnameTextBox"
        Me.AddLastnameTextBox.Size = New System.Drawing.Size(253, 30)
        Me.AddLastnameTextBox.TabIndex = 73
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(174, 100)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 25)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Role"
        '
        'AddPhoneNumTextBox
        '
        Me.AddPhoneNumTextBox.Location = New System.Drawing.Point(363, 249)
        Me.AddPhoneNumTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AddPhoneNumTextBox.Name = "AddPhoneNumTextBox"
        Me.AddPhoneNumTextBox.Size = New System.Drawing.Size(253, 30)
        Me.AddPhoneNumTextBox.TabIndex = 69
        '
        'EmployeeAddBtn
        '
        Me.EmployeeAddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.EmployeeAddBtn.FlatAppearance.BorderSize = 0
        Me.EmployeeAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmployeeAddBtn.Location = New System.Drawing.Point(177, 310)
        Me.EmployeeAddBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeAddBtn.Name = "EmployeeAddBtn"
        Me.EmployeeAddBtn.Size = New System.Drawing.Size(438, 43)
        Me.EmployeeAddBtn.TabIndex = 66
        Me.EmployeeAddBtn.Text = "Add"
        Me.EmployeeAddBtn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(174, 252)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 25)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Phone number"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(174, 198)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 25)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Last Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(174, 152)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 25)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "First Name"
        '
        'AddFirstnameTextBox
        '
        Me.AddFirstnameTextBox.Location = New System.Drawing.Point(363, 149)
        Me.AddFirstnameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AddFirstnameTextBox.Name = "AddFirstnameTextBox"
        Me.AddFirstnameTextBox.Size = New System.Drawing.Size(252, 30)
        Me.AddFirstnameTextBox.TabIndex = 60
        '
        'EmployeeUpdatePanel
        '
        Me.EmployeeUpdatePanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.EmployeeUpdatePanel.Controls.Add(Me.UpdateRoleTextBox)
        Me.EmployeeUpdatePanel.Controls.Add(Me.UpdateEmployeeIDComboBox)
        Me.EmployeeUpdatePanel.Controls.Add(Me.Label7)
        Me.EmployeeUpdatePanel.Controls.Add(Me.UpdateLastNameTextBox)
        Me.EmployeeUpdatePanel.Controls.Add(Me.Label2)
        Me.EmployeeUpdatePanel.Controls.Add(Me.UpdatePhoneNumTextBox)
        Me.EmployeeUpdatePanel.Controls.Add(Me.EmployeeUpdateBtn)
        Me.EmployeeUpdatePanel.Controls.Add(Me.Label3)
        Me.EmployeeUpdatePanel.Controls.Add(Me.Label4)
        Me.EmployeeUpdatePanel.Controls.Add(Me.Label5)
        Me.EmployeeUpdatePanel.Controls.Add(Me.UpdateFirstNameTextBox)
        Me.EmployeeUpdatePanel.Location = New System.Drawing.Point(1, 1)
        Me.EmployeeUpdatePanel.Name = "EmployeeUpdatePanel"
        Me.EmployeeUpdatePanel.Size = New System.Drawing.Size(790, 451)
        Me.EmployeeUpdatePanel.TabIndex = 75
        '
        'UpdateRoleTextBox
        '
        Me.UpdateRoleTextBox.Location = New System.Drawing.Point(363, 125)
        Me.UpdateRoleTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UpdateRoleTextBox.Name = "UpdateRoleTextBox"
        Me.UpdateRoleTextBox.Size = New System.Drawing.Size(254, 30)
        Me.UpdateRoleTextBox.TabIndex = 77
        '
        'UpdateEmployeeIDComboBox
        '
        Me.UpdateEmployeeIDComboBox.FormattingEnabled = True
        Me.UpdateEmployeeIDComboBox.Location = New System.Drawing.Point(361, 71)
        Me.UpdateEmployeeIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UpdateEmployeeIDComboBox.Name = "UpdateEmployeeIDComboBox"
        Me.UpdateEmployeeIDComboBox.Size = New System.Drawing.Size(254, 33)
        Me.UpdateEmployeeIDComboBox.TabIndex = 76
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(174, 79)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 25)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Employee ID"
        '
        'UpdateLastNameTextBox
        '
        Me.UpdateLastNameTextBox.Location = New System.Drawing.Point(362, 224)
        Me.UpdateLastNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UpdateLastNameTextBox.Name = "UpdateLastNameTextBox"
        Me.UpdateLastNameTextBox.Size = New System.Drawing.Size(254, 30)
        Me.UpdateLastNameTextBox.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(174, 131)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 25)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Role"
        '
        'UpdatePhoneNumTextBox
        '
        Me.UpdatePhoneNumTextBox.Location = New System.Drawing.Point(363, 273)
        Me.UpdatePhoneNumTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UpdatePhoneNumTextBox.Name = "UpdatePhoneNumTextBox"
        Me.UpdatePhoneNumTextBox.Size = New System.Drawing.Size(254, 30)
        Me.UpdatePhoneNumTextBox.TabIndex = 69
        '
        'EmployeeUpdateBtn
        '
        Me.EmployeeUpdateBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.EmployeeUpdateBtn.FlatAppearance.BorderSize = 0
        Me.EmployeeUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmployeeUpdateBtn.ForeColor = System.Drawing.Color.White
        Me.EmployeeUpdateBtn.Location = New System.Drawing.Point(179, 336)
        Me.EmployeeUpdateBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeUpdateBtn.Name = "EmployeeUpdateBtn"
        Me.EmployeeUpdateBtn.Size = New System.Drawing.Size(438, 43)
        Me.EmployeeUpdateBtn.TabIndex = 66
        Me.EmployeeUpdateBtn.Text = "Update"
        Me.EmployeeUpdateBtn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(174, 278)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 25)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Phone number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(174, 229)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 25)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(174, 180)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 25)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "First Name"
        '
        'UpdateFirstNameTextBox
        '
        Me.UpdateFirstNameTextBox.Location = New System.Drawing.Point(363, 175)
        Me.UpdateFirstNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UpdateFirstNameTextBox.Name = "UpdateFirstNameTextBox"
        Me.UpdateFirstNameTextBox.Size = New System.Drawing.Size(254, 30)
        Me.UpdateFirstNameTextBox.TabIndex = 60
        '
        'EmployeeDeletePanel
        '
        Me.EmployeeDeletePanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.EmployeeDeletePanel.Controls.Add(Me.DeleteEmployeeIDComboBox)
        Me.EmployeeDeletePanel.Controls.Add(Me.Label8)
        Me.EmployeeDeletePanel.Controls.Add(Me.DeleteRoleTextBox)
        Me.EmployeeDeletePanel.Controls.Add(Me.DeleteLastNameTextBox)
        Me.EmployeeDeletePanel.Controls.Add(Me.Label9)
        Me.EmployeeDeletePanel.Controls.Add(Me.DeletePhoneNumTextBox)
        Me.EmployeeDeletePanel.Controls.Add(Me.EmployeeDeleteBtn)
        Me.EmployeeDeletePanel.Controls.Add(Me.Label10)
        Me.EmployeeDeletePanel.Controls.Add(Me.Label13)
        Me.EmployeeDeletePanel.Controls.Add(Me.Label14)
        Me.EmployeeDeletePanel.Controls.Add(Me.DeleteFirstNameTextBox)
        Me.EmployeeDeletePanel.Location = New System.Drawing.Point(0, 4)
        Me.EmployeeDeletePanel.Name = "EmployeeDeletePanel"
        Me.EmployeeDeletePanel.Size = New System.Drawing.Size(790, 451)
        Me.EmployeeDeletePanel.TabIndex = 77
        '
        'DeleteEmployeeIDComboBox
        '
        Me.DeleteEmployeeIDComboBox.FormattingEnabled = True
        Me.DeleteEmployeeIDComboBox.Location = New System.Drawing.Point(363, 73)
        Me.DeleteEmployeeIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DeleteEmployeeIDComboBox.Name = "DeleteEmployeeIDComboBox"
        Me.DeleteEmployeeIDComboBox.Size = New System.Drawing.Size(254, 33)
        Me.DeleteEmployeeIDComboBox.TabIndex = 76
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(173, 80)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 25)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Employee ID"
        '
        'DeleteRoleTextBox
        '
        Me.DeleteRoleTextBox.Enabled = False
        Me.DeleteRoleTextBox.Location = New System.Drawing.Point(363, 126)
        Me.DeleteRoleTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DeleteRoleTextBox.Name = "DeleteRoleTextBox"
        Me.DeleteRoleTextBox.Size = New System.Drawing.Size(254, 30)
        Me.DeleteRoleTextBox.TabIndex = 74
        '
        'DeleteLastNameTextBox
        '
        Me.DeleteLastNameTextBox.Enabled = False
        Me.DeleteLastNameTextBox.Location = New System.Drawing.Point(363, 224)
        Me.DeleteLastNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DeleteLastNameTextBox.Name = "DeleteLastNameTextBox"
        Me.DeleteLastNameTextBox.Size = New System.Drawing.Size(254, 30)
        Me.DeleteLastNameTextBox.TabIndex = 73
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(173, 131)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 25)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Role"
        '
        'DeletePhoneNumTextBox
        '
        Me.DeletePhoneNumTextBox.Enabled = False
        Me.DeletePhoneNumTextBox.Location = New System.Drawing.Point(363, 273)
        Me.DeletePhoneNumTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DeletePhoneNumTextBox.Name = "DeletePhoneNumTextBox"
        Me.DeletePhoneNumTextBox.Size = New System.Drawing.Size(254, 30)
        Me.DeletePhoneNumTextBox.TabIndex = 69
        '
        'EmployeeDeleteBtn
        '
        Me.EmployeeDeleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.EmployeeDeleteBtn.FlatAppearance.BorderSize = 0
        Me.EmployeeDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmployeeDeleteBtn.ForeColor = System.Drawing.Color.White
        Me.EmployeeDeleteBtn.Location = New System.Drawing.Point(179, 334)
        Me.EmployeeDeleteBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeDeleteBtn.Name = "EmployeeDeleteBtn"
        Me.EmployeeDeleteBtn.Size = New System.Drawing.Size(438, 43)
        Me.EmployeeDeleteBtn.TabIndex = 66
        Me.EmployeeDeleteBtn.Text = "Delete"
        Me.EmployeeDeleteBtn.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(173, 280)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 25)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Phone number"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(174, 229)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 25)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "Last Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(173, 180)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 25)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "First Name"
        '
        'DeleteFirstNameTextBox
        '
        Me.DeleteFirstNameTextBox.Enabled = False
        Me.DeleteFirstNameTextBox.Location = New System.Drawing.Point(363, 175)
        Me.DeleteFirstNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DeleteFirstNameTextBox.Name = "DeleteFirstNameTextBox"
        Me.DeleteFirstNameTextBox.Size = New System.Drawing.Size(254, 30)
        Me.DeleteFirstNameTextBox.TabIndex = 60
        '
        'EmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 451)
        Me.Controls.Add(Me.EmployeeUpdatePanel)
        Me.Controls.Add(Me.EmployeeAddPanel)
        Me.Controls.Add(Me.EmployeeDeletePanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "EmployeeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmployee"
        Me.EmployeeAddPanel.ResumeLayout(False)
        Me.EmployeeAddPanel.PerformLayout()
        Me.EmployeeUpdatePanel.ResumeLayout(False)
        Me.EmployeeUpdatePanel.PerformLayout()
        Me.EmployeeDeletePanel.ResumeLayout(False)
        Me.EmployeeDeletePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EmployeeAddPanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AddPhoneNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeAddBtn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents AddFirstnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddLastnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeUpdatePanel As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents UpdateLastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UpdatePhoneNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeUpdateBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents UpdateFirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UpdateEmployeeIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AddRoleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UpdateRoleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeDeletePanel As System.Windows.Forms.Panel
    Friend WithEvents DeleteEmployeeIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DeleteRoleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeleteLastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DeletePhoneNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeDeleteBtn As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DeleteFirstNameTextBox As System.Windows.Forms.TextBox
End Class
