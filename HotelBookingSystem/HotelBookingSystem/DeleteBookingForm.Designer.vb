<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteBookingForm
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
        Me.BookingIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ArrivalDateDTP = New System.Windows.Forms.DateTimePicker()
        Me.DepartureDateDTP = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.EmployeeNameComboBox = New System.Windows.Forms.ComboBox()
        Me.RoomTypeTextBox = New System.Windows.Forms.TextBox()
        Me.RoomOccupancyTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.RoomPriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.RoomIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GuestNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SpecialRequestsTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GuestLastnameTextBox = New System.Windows.Forms.TextBox()
        Me.GuestPhoneNumTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GuestFirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GuestAddressTextBox = New System.Windows.Forms.TextBox()
        Me.CancelBookingBtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GuestIDComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BookingIDComboBox
        '
        Me.BookingIDComboBox.FormattingEnabled = True
        Me.BookingIDComboBox.Location = New System.Drawing.Point(369, 68)
        Me.BookingIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BookingIDComboBox.Name = "BookingIDComboBox"
        Me.BookingIDComboBox.Size = New System.Drawing.Size(254, 33)
        Me.BookingIDComboBox.TabIndex = 146
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 1085)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(874, 38)
        Me.Panel1.TabIndex = 145
        '
        'ArrivalDateDTP
        '
        Me.ArrivalDateDTP.Enabled = False
        Me.ArrivalDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ArrivalDateDTP.Location = New System.Drawing.Point(369, 174)
        Me.ArrivalDateDTP.Name = "ArrivalDateDTP"
        Me.ArrivalDateDTP.Size = New System.Drawing.Size(254, 30)
        Me.ArrivalDateDTP.TabIndex = 144
        '
        'DepartureDateDTP
        '
        Me.DepartureDateDTP.Enabled = False
        Me.DepartureDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DepartureDateDTP.Location = New System.Drawing.Point(370, 224)
        Me.DepartureDateDTP.Name = "DepartureDateDTP"
        Me.DepartureDateDTP.Size = New System.Drawing.Size(254, 30)
        Me.DepartureDateDTP.TabIndex = 143
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(210, 978)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(156, 25)
        Me.Label16.TabIndex = 142
        Me.Label16.Text = "Employee Name"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(164, 919)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(123, 25)
        Me.Label17.TabIndex = 141
        Me.Label17.Text = "Handled By"
        '
        'EmployeeNameComboBox
        '
        Me.EmployeeNameComboBox.Enabled = False
        Me.EmployeeNameComboBox.FormattingEnabled = True
        Me.EmployeeNameComboBox.Location = New System.Drawing.Point(375, 970)
        Me.EmployeeNameComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeNameComboBox.Name = "EmployeeNameComboBox"
        Me.EmployeeNameComboBox.Size = New System.Drawing.Size(254, 33)
        Me.EmployeeNameComboBox.TabIndex = 140
        '
        'RoomTypeTextBox
        '
        Me.RoomTypeTextBox.Enabled = False
        Me.RoomTypeTextBox.Location = New System.Drawing.Point(376, 757)
        Me.RoomTypeTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.RoomTypeTextBox.Name = "RoomTypeTextBox"
        Me.RoomTypeTextBox.Size = New System.Drawing.Size(253, 30)
        Me.RoomTypeTextBox.TabIndex = 139
        '
        'RoomOccupancyTextBox
        '
        Me.RoomOccupancyTextBox.Enabled = False
        Me.RoomOccupancyTextBox.Location = New System.Drawing.Point(376, 807)
        Me.RoomOccupancyTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.RoomOccupancyTextBox.Name = "RoomOccupancyTextBox"
        Me.RoomOccupancyTextBox.Size = New System.Drawing.Size(253, 30)
        Me.RoomOccupancyTextBox.TabIndex = 138
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(210, 812)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 25)
        Me.Label9.TabIndex = 137
        Me.Label9.Text = "Occupancy"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(210, 762)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 25)
        Me.Label10.TabIndex = 136
        Me.Label10.Text = "Room Type"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(210, 712)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(137, 25)
        Me.Label13.TabIndex = 135
        Me.Label13.Text = "Room Number"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(164, 653)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(180, 25)
        Me.Label14.TabIndex = 134
        Me.Label14.Text = "Room Information"
        '
        'RoomPriceTextBox
        '
        Me.RoomPriceTextBox.Enabled = False
        Me.RoomPriceTextBox.Location = New System.Drawing.Point(376, 857)
        Me.RoomPriceTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.RoomPriceTextBox.Name = "RoomPriceTextBox"
        Me.RoomPriceTextBox.Size = New System.Drawing.Size(255, 30)
        Me.RoomPriceTextBox.TabIndex = 133
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(210, 862)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 25)
        Me.Label15.TabIndex = 132
        Me.Label15.Text = "Price"
        '
        'RoomIDComboBox
        '
        Me.RoomIDComboBox.Enabled = False
        Me.RoomIDComboBox.FormattingEnabled = True
        Me.RoomIDComboBox.Location = New System.Drawing.Point(375, 704)
        Me.RoomIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RoomIDComboBox.Name = "RoomIDComboBox"
        Me.RoomIDComboBox.Size = New System.Drawing.Size(254, 33)
        Me.RoomIDComboBox.TabIndex = 131
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(205, 229)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 25)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "Departure Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(205, 179)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 25)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Arrival Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(205, 129)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 25)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "No. of Guest"
        '
        'GuestNumberTextBox
        '
        Me.GuestNumberTextBox.Enabled = False
        Me.GuestNumberTextBox.Location = New System.Drawing.Point(371, 124)
        Me.GuestNumberTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GuestNumberTextBox.Name = "GuestNumberTextBox"
        Me.GuestNumberTextBox.Size = New System.Drawing.Size(252, 30)
        Me.GuestNumberTextBox.TabIndex = 127
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(159, 31)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(162, 25)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "Booking Details"
        '
        'SpecialRequestsTextBox
        '
        Me.SpecialRequestsTextBox.Enabled = False
        Me.SpecialRequestsTextBox.Location = New System.Drawing.Point(371, 274)
        Me.SpecialRequestsTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.SpecialRequestsTextBox.Multiline = True
        Me.SpecialRequestsTextBox.Name = "SpecialRequestsTextBox"
        Me.SpecialRequestsTextBox.Size = New System.Drawing.Size(255, 78)
        Me.SpecialRequestsTextBox.TabIndex = 125
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(205, 279)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 25)
        Me.Label7.TabIndex = 124
        Me.Label7.Text = "Special Request"
        '
        'GuestLastnameTextBox
        '
        Me.GuestLastnameTextBox.Enabled = False
        Me.GuestLastnameTextBox.Location = New System.Drawing.Point(374, 490)
        Me.GuestLastnameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GuestLastnameTextBox.Name = "GuestLastnameTextBox"
        Me.GuestLastnameTextBox.Size = New System.Drawing.Size(253, 30)
        Me.GuestLastnameTextBox.TabIndex = 123
        '
        'GuestPhoneNumTextBox
        '
        Me.GuestPhoneNumTextBox.Enabled = False
        Me.GuestPhoneNumTextBox.Location = New System.Drawing.Point(374, 540)
        Me.GuestPhoneNumTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GuestPhoneNumTextBox.Name = "GuestPhoneNumTextBox"
        Me.GuestPhoneNumTextBox.Size = New System.Drawing.Size(253, 30)
        Me.GuestPhoneNumTextBox.TabIndex = 122
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(208, 545)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 25)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Phone number"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(208, 495)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 25)
        Me.Label11.TabIndex = 120
        Me.Label11.Text = "Last Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(208, 445)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 25)
        Me.Label12.TabIndex = 119
        Me.Label12.Text = "First Name"
        '
        'GuestFirstnameTextBox
        '
        Me.GuestFirstnameTextBox.Enabled = False
        Me.GuestFirstnameTextBox.Location = New System.Drawing.Point(374, 440)
        Me.GuestFirstnameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GuestFirstnameTextBox.Name = "GuestFirstnameTextBox"
        Me.GuestFirstnameTextBox.Size = New System.Drawing.Size(252, 30)
        Me.GuestFirstnameTextBox.TabIndex = 118
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(162, 386)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(182, 25)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "Guest Information"
        '
        'GuestAddressTextBox
        '
        Me.GuestAddressTextBox.Enabled = False
        Me.GuestAddressTextBox.Location = New System.Drawing.Point(374, 590)
        Me.GuestAddressTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GuestAddressTextBox.Name = "GuestAddressTextBox"
        Me.GuestAddressTextBox.Size = New System.Drawing.Size(255, 30)
        Me.GuestAddressTextBox.TabIndex = 116
        '
        'CancelBookingBtn
        '
        Me.CancelBookingBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.CancelBookingBtn.FlatAppearance.BorderSize = 0
        Me.CancelBookingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBookingBtn.ForeColor = System.Drawing.Color.White
        Me.CancelBookingBtn.Location = New System.Drawing.Point(213, 1042)
        Me.CancelBookingBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelBookingBtn.Name = "CancelBookingBtn"
        Me.CancelBookingBtn.Size = New System.Drawing.Size(416, 43)
        Me.CancelBookingBtn.TabIndex = 115
        Me.CancelBookingBtn.Text = "Cancel Booking"
        Me.CancelBookingBtn.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(208, 595)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 25)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "Address"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(208, 76)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(107, 25)
        Me.Label18.TabIndex = 147
        Me.Label18.Text = "Booking ID"
        '
        'GuestIDComboBox
        '
        Me.GuestIDComboBox.Enabled = False
        Me.GuestIDComboBox.FormattingEnabled = True
        Me.GuestIDComboBox.Location = New System.Drawing.Point(374, 386)
        Me.GuestIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GuestIDComboBox.Name = "GuestIDComboBox"
        Me.GuestIDComboBox.Size = New System.Drawing.Size(254, 33)
        Me.GuestIDComboBox.TabIndex = 148
        Me.GuestIDComboBox.Visible = False
        '
        'DeleteBookingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(895, 451)
        Me.ControlBox = False
        Me.Controls.Add(Me.GuestIDComboBox)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.BookingIDComboBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ArrivalDateDTP)
        Me.Controls.Add(Me.DepartureDateDTP)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.EmployeeNameComboBox)
        Me.Controls.Add(Me.RoomTypeTextBox)
        Me.Controls.Add(Me.RoomOccupancyTextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.RoomPriceTextBox)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.RoomIDComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GuestNumberTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SpecialRequestsTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GuestLastnameTextBox)
        Me.Controls.Add(Me.GuestPhoneNumTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GuestFirstnameTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GuestAddressTextBox)
        Me.Controls.Add(Me.CancelBookingBtn)
        Me.Controls.Add(Me.Label8)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "DeleteBookingForm"
        Me.Text = "DeleteBookingForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BookingIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ArrivalDateDTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents DepartureDateDTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents EmployeeNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RoomTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RoomOccupancyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents RoomPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents RoomIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GuestNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SpecialRequestsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GuestLastnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GuestPhoneNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GuestFirstnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GuestAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CancelBookingBtn As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GuestIDComboBox As System.Windows.Forms.ComboBox
End Class
