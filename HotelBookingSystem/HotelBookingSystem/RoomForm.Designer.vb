<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomForm
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
        Me.RoomUpdatePanel = New System.Windows.Forms.Panel()
        Me.UpdateRoomTypeTextBox = New System.Windows.Forms.TextBox()
        Me.UpdateOccupancyTextBox = New System.Windows.Forms.TextBox()
        Me.RoomUpdateBtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UpdateRoomIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.UpdateRoomPriceTextBox = New System.Windows.Forms.TextBox()
        Me.RoomDeletePanel = New System.Windows.Forms.Panel()
        Me.DeleteRoomTypeTextBox = New System.Windows.Forms.TextBox()
        Me.DeleteOccupancyTextBox = New System.Windows.Forms.TextBox()
        Me.RoomDeleteBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DeleteRoomIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DeleteRoomPriceTextBox = New System.Windows.Forms.TextBox()
        Me.RoomAddPanel = New System.Windows.Forms.Panel()
        Me.AddRoomTypeTextBox = New System.Windows.Forms.TextBox()
        Me.AddOccupancyTextBox = New System.Windows.Forms.TextBox()
        Me.RoomAddBtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.AddRoomPriceTextBox = New System.Windows.Forms.TextBox()
        Me.RoomUpdatePanel.SuspendLayout()
        Me.RoomDeletePanel.SuspendLayout()
        Me.RoomAddPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'RoomUpdatePanel
        '
        Me.RoomUpdatePanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RoomUpdatePanel.Controls.Add(Me.UpdateRoomTypeTextBox)
        Me.RoomUpdatePanel.Controls.Add(Me.UpdateOccupancyTextBox)
        Me.RoomUpdatePanel.Controls.Add(Me.RoomUpdateBtn)
        Me.RoomUpdatePanel.Controls.Add(Me.Label7)
        Me.RoomUpdatePanel.Controls.Add(Me.UpdateRoomIDComboBox)
        Me.RoomUpdatePanel.Controls.Add(Me.Label8)
        Me.RoomUpdatePanel.Controls.Add(Me.Label9)
        Me.RoomUpdatePanel.Controls.Add(Me.Label10)
        Me.RoomUpdatePanel.Controls.Add(Me.UpdateRoomPriceTextBox)
        Me.RoomUpdatePanel.Location = New System.Drawing.Point(-3, 3)
        Me.RoomUpdatePanel.Name = "RoomUpdatePanel"
        Me.RoomUpdatePanel.Size = New System.Drawing.Size(790, 451)
        Me.RoomUpdatePanel.TabIndex = 3
        '
        'UpdateRoomTypeTextBox
        '
        Me.UpdateRoomTypeTextBox.Location = New System.Drawing.Point(351, 196)
        Me.UpdateRoomTypeTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UpdateRoomTypeTextBox.Name = "UpdateRoomTypeTextBox"
        Me.UpdateRoomTypeTextBox.Size = New System.Drawing.Size(255, 30)
        Me.UpdateRoomTypeTextBox.TabIndex = 71
        '
        'UpdateOccupancyTextBox
        '
        Me.UpdateOccupancyTextBox.Location = New System.Drawing.Point(351, 249)
        Me.UpdateOccupancyTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UpdateOccupancyTextBox.Name = "UpdateOccupancyTextBox"
        Me.UpdateOccupancyTextBox.Size = New System.Drawing.Size(255, 30)
        Me.UpdateOccupancyTextBox.TabIndex = 69
        '
        'RoomUpdateBtn
        '
        Me.RoomUpdateBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.RoomUpdateBtn.FlatAppearance.BorderSize = 0
        Me.RoomUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoomUpdateBtn.Location = New System.Drawing.Point(190, 311)
        Me.RoomUpdateBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.RoomUpdateBtn.Name = "RoomUpdateBtn"
        Me.RoomUpdateBtn.Size = New System.Drawing.Size(416, 43)
        Me.RoomUpdateBtn.TabIndex = 66
        Me.RoomUpdateBtn.Text = "Update"
        Me.RoomUpdateBtn.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(184, 100)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(137, 25)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Room Number"
        '
        'UpdateRoomIDComboBox
        '
        Me.UpdateRoomIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UpdateRoomIDComboBox.FormattingEnabled = True
        Me.UpdateRoomIDComboBox.Location = New System.Drawing.Point(351, 97)
        Me.UpdateRoomIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UpdateRoomIDComboBox.Name = "UpdateRoomIDComboBox"
        Me.UpdateRoomIDComboBox.Size = New System.Drawing.Size(254, 33)
        Me.UpdateRoomIDComboBox.TabIndex = 61
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(184, 252)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 25)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Occupancy"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(184, 202)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 25)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Room Type"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(184, 152)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 25)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Room Price"
        '
        'UpdateRoomPriceTextBox
        '
        Me.UpdateRoomPriceTextBox.Location = New System.Drawing.Point(351, 149)
        Me.UpdateRoomPriceTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UpdateRoomPriceTextBox.Name = "UpdateRoomPriceTextBox"
        Me.UpdateRoomPriceTextBox.Size = New System.Drawing.Size(254, 30)
        Me.UpdateRoomPriceTextBox.TabIndex = 60
        '
        'RoomDeletePanel
        '
        Me.RoomDeletePanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RoomDeletePanel.Controls.Add(Me.DeleteRoomTypeTextBox)
        Me.RoomDeletePanel.Controls.Add(Me.DeleteOccupancyTextBox)
        Me.RoomDeletePanel.Controls.Add(Me.RoomDeleteBtn)
        Me.RoomDeletePanel.Controls.Add(Me.Label1)
        Me.RoomDeletePanel.Controls.Add(Me.DeleteRoomIDComboBox)
        Me.RoomDeletePanel.Controls.Add(Me.Label2)
        Me.RoomDeletePanel.Controls.Add(Me.Label3)
        Me.RoomDeletePanel.Controls.Add(Me.Label4)
        Me.RoomDeletePanel.Controls.Add(Me.DeleteRoomPriceTextBox)
        Me.RoomDeletePanel.Location = New System.Drawing.Point(0, 3)
        Me.RoomDeletePanel.Name = "RoomDeletePanel"
        Me.RoomDeletePanel.Size = New System.Drawing.Size(790, 451)
        Me.RoomDeletePanel.TabIndex = 4
        '
        'DeleteRoomTypeTextBox
        '
        Me.DeleteRoomTypeTextBox.Enabled = False
        Me.DeleteRoomTypeTextBox.Location = New System.Drawing.Point(352, 198)
        Me.DeleteRoomTypeTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DeleteRoomTypeTextBox.Name = "DeleteRoomTypeTextBox"
        Me.DeleteRoomTypeTextBox.Size = New System.Drawing.Size(254, 30)
        Me.DeleteRoomTypeTextBox.TabIndex = 71
        '
        'DeleteOccupancyTextBox
        '
        Me.DeleteOccupancyTextBox.Enabled = False
        Me.DeleteOccupancyTextBox.Location = New System.Drawing.Point(352, 248)
        Me.DeleteOccupancyTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DeleteOccupancyTextBox.Name = "DeleteOccupancyTextBox"
        Me.DeleteOccupancyTextBox.Size = New System.Drawing.Size(254, 30)
        Me.DeleteOccupancyTextBox.TabIndex = 69
        '
        'RoomDeleteBtn
        '
        Me.RoomDeleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.RoomDeleteBtn.FlatAppearance.BorderSize = 0
        Me.RoomDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoomDeleteBtn.Location = New System.Drawing.Point(190, 312)
        Me.RoomDeleteBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.RoomDeleteBtn.Name = "RoomDeleteBtn"
        Me.RoomDeleteBtn.Size = New System.Drawing.Size(416, 43)
        Me.RoomDeleteBtn.TabIndex = 66
        Me.RoomDeleteBtn.Text = "Delete"
        Me.RoomDeleteBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(185, 99)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(137, 25)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Room Number"
        '
        'DeleteRoomIDComboBox
        '
        Me.DeleteRoomIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DeleteRoomIDComboBox.FormattingEnabled = True
        Me.DeleteRoomIDComboBox.Location = New System.Drawing.Point(352, 96)
        Me.DeleteRoomIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DeleteRoomIDComboBox.Name = "DeleteRoomIDComboBox"
        Me.DeleteRoomIDComboBox.Size = New System.Drawing.Size(254, 33)
        Me.DeleteRoomIDComboBox.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(185, 251)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 25)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Occupancy"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(185, 201)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 25)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Room Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(185, 151)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 25)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Room Price"
        '
        'DeleteRoomPriceTextBox
        '
        Me.DeleteRoomPriceTextBox.Enabled = False
        Me.DeleteRoomPriceTextBox.Location = New System.Drawing.Point(352, 148)
        Me.DeleteRoomPriceTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DeleteRoomPriceTextBox.Name = "DeleteRoomPriceTextBox"
        Me.DeleteRoomPriceTextBox.Size = New System.Drawing.Size(254, 30)
        Me.DeleteRoomPriceTextBox.TabIndex = 60
        '
        'RoomAddPanel
        '
        Me.RoomAddPanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RoomAddPanel.Controls.Add(Me.AddRoomTypeTextBox)
        Me.RoomAddPanel.Controls.Add(Me.AddOccupancyTextBox)
        Me.RoomAddPanel.Controls.Add(Me.RoomAddBtn)
        Me.RoomAddPanel.Controls.Add(Me.Label6)
        Me.RoomAddPanel.Controls.Add(Me.Label11)
        Me.RoomAddPanel.Controls.Add(Me.Label12)
        Me.RoomAddPanel.Controls.Add(Me.AddRoomPriceTextBox)
        Me.RoomAddPanel.Location = New System.Drawing.Point(-1, 0)
        Me.RoomAddPanel.Name = "RoomAddPanel"
        Me.RoomAddPanel.Size = New System.Drawing.Size(790, 451)
        Me.RoomAddPanel.TabIndex = 72
        '
        'AddRoomTypeTextBox
        '
        Me.AddRoomTypeTextBox.Location = New System.Drawing.Point(350, 170)
        Me.AddRoomTypeTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AddRoomTypeTextBox.Name = "AddRoomTypeTextBox"
        Me.AddRoomTypeTextBox.Size = New System.Drawing.Size(254, 30)
        Me.AddRoomTypeTextBox.TabIndex = 71
        '
        'AddOccupancyTextBox
        '
        Me.AddOccupancyTextBox.Location = New System.Drawing.Point(351, 220)
        Me.AddOccupancyTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AddOccupancyTextBox.Name = "AddOccupancyTextBox"
        Me.AddOccupancyTextBox.Size = New System.Drawing.Size(254, 30)
        Me.AddOccupancyTextBox.TabIndex = 69
        '
        'RoomAddBtn
        '
        Me.RoomAddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.RoomAddBtn.FlatAppearance.BorderSize = 0
        Me.RoomAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoomAddBtn.Location = New System.Drawing.Point(190, 287)
        Me.RoomAddBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.RoomAddBtn.Name = "RoomAddBtn"
        Me.RoomAddBtn.Size = New System.Drawing.Size(416, 43)
        Me.RoomAddBtn.TabIndex = 66
        Me.RoomAddBtn.Text = "Add"
        Me.RoomAddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.RoomAddBtn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(184, 223)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 25)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Occupancy"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(184, 173)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 25)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Room Type"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(184, 123)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 25)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "Room Price"
        '
        'AddRoomPriceTextBox
        '
        Me.AddRoomPriceTextBox.Location = New System.Drawing.Point(351, 120)
        Me.AddRoomPriceTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AddRoomPriceTextBox.Name = "AddRoomPriceTextBox"
        Me.AddRoomPriceTextBox.Size = New System.Drawing.Size(254, 30)
        Me.AddRoomPriceTextBox.TabIndex = 60
        '
        'RoomForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(790, 451)
        Me.Controls.Add(Me.RoomUpdatePanel)
        Me.Controls.Add(Me.RoomAddPanel)
        Me.Controls.Add(Me.RoomDeletePanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "RoomForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRoom"
        Me.RoomUpdatePanel.ResumeLayout(False)
        Me.RoomUpdatePanel.PerformLayout()
        Me.RoomDeletePanel.ResumeLayout(False)
        Me.RoomDeletePanel.PerformLayout()
        Me.RoomAddPanel.ResumeLayout(False)
        Me.RoomAddPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RoomUpdatePanel As System.Windows.Forms.Panel
    Friend WithEvents RoomUpdateBtn As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents UpdateRoomIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents UpdateRoomPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UpdateOccupancyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RoomDeletePanel As System.Windows.Forms.Panel
    Friend WithEvents DeleteOccupancyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RoomDeleteBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DeleteRoomIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DeleteRoomPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RoomAddPanel As System.Windows.Forms.Panel
    Friend WithEvents AddOccupancyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RoomAddBtn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents AddRoomPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddRoomTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeleteRoomTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UpdateRoomTypeTextBox As System.Windows.Forms.TextBox
End Class
