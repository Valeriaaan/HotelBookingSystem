<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ExportRoomBtn = New System.Windows.Forms.Button()
        Me.BookingsDGV = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.NumberOfBookingsLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.NumberOfEmployeesLabel = New System.Windows.Forms.Label()
        Me.NumberOfasdSuppliersLabel = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.NumberOfRoomsLabel = New System.Windows.Forms.Label()
        Me.asd = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ReportDGV = New System.Windows.Forms.DataGridView()
        CType(Me.BookingsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ReportDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExportRoomBtn
        '
        Me.ExportRoomBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ExportRoomBtn.FlatAppearance.BorderSize = 0
        Me.ExportRoomBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ExportRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExportRoomBtn.ForeColor = System.Drawing.Color.White
        Me.ExportRoomBtn.Location = New System.Drawing.Point(17, 388)
        Me.ExportRoomBtn.Name = "ExportRoomBtn"
        Me.ExportRoomBtn.Size = New System.Drawing.Size(757, 45)
        Me.ExportRoomBtn.TabIndex = 47
        Me.ExportRoomBtn.Text = "Generate Report"
        Me.ExportRoomBtn.UseVisualStyleBackColor = False
        '
        'BookingsDGV
        '
        Me.BookingsDGV.AllowUserToAddRows = False
        Me.BookingsDGV.AllowUserToDeleteRows = False
        Me.BookingsDGV.AllowUserToResizeColumns = False
        Me.BookingsDGV.AllowUserToResizeRows = False
        Me.BookingsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BookingsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.BookingsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BookingsDGV.Location = New System.Drawing.Point(17, 155)
        Me.BookingsDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.BookingsDGV.Name = "BookingsDGV"
        Me.BookingsDGV.ReadOnly = True
        Me.BookingsDGV.RowHeadersWidth = 21
        Me.BookingsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BookingsDGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BookingsDGV.RowTemplate.Height = 24
        Me.BookingsDGV.Size = New System.Drawing.Size(757, 226)
        Me.BookingsDGV.TabIndex = 46
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel5.Controls.Add(Me.NumberOfBookingsLabel)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.ForeColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(17, 18)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(240, 100)
        Me.Panel5.TabIndex = 48
        '
        'NumberOfBookingsLabel
        '
        Me.NumberOfBookingsLabel.AutoSize = True
        Me.NumberOfBookingsLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.NumberOfBookingsLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfBookingsLabel.Location = New System.Drawing.Point(0, 0)
        Me.NumberOfBookingsLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.NumberOfBookingsLabel.Name = "NumberOfBookingsLabel"
        Me.NumberOfBookingsLabel.Padding = New System.Windows.Forms.Padding(8)
        Me.NumberOfBookingsLabel.Size = New System.Drawing.Size(65, 75)
        Me.NumberOfBookingsLabel.TabIndex = 1
        Me.NumberOfBookingsLabel.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(8, 0, 8, 8)
        Me.Label1.Size = New System.Drawing.Size(183, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of Bookings"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel4.Controls.Add(Me.NumberOfEmployeesLabel)
        Me.Panel4.Controls.Add(Me.NumberOfasdSuppliersLabel)
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(534, 18)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(240, 100)
        Me.Panel4.TabIndex = 50
        '
        'NumberOfEmployeesLabel
        '
        Me.NumberOfEmployeesLabel.AutoSize = True
        Me.NumberOfEmployeesLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.NumberOfEmployeesLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfEmployeesLabel.Location = New System.Drawing.Point(0, 0)
        Me.NumberOfEmployeesLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.NumberOfEmployeesLabel.Name = "NumberOfEmployeesLabel"
        Me.NumberOfEmployeesLabel.Padding = New System.Windows.Forms.Padding(8)
        Me.NumberOfEmployeesLabel.Size = New System.Drawing.Size(65, 75)
        Me.NumberOfEmployeesLabel.TabIndex = 2
        Me.NumberOfEmployeesLabel.Text = "0"
        '
        'NumberOfasdSuppliersLabel
        '
        Me.NumberOfasdSuppliersLabel.AutoSize = True
        Me.NumberOfasdSuppliersLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NumberOfasdSuppliersLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfasdSuppliersLabel.Location = New System.Drawing.Point(0, 69)
        Me.NumberOfasdSuppliersLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.NumberOfasdSuppliersLabel.Name = "NumberOfasdSuppliersLabel"
        Me.NumberOfasdSuppliersLabel.Padding = New System.Windows.Forms.Padding(8, 0, 8, 8)
        Me.NumberOfasdSuppliersLabel.Size = New System.Drawing.Size(195, 31)
        Me.NumberOfasdSuppliersLabel.TabIndex = 1
        Me.NumberOfasdSuppliersLabel.Text = "Number of Employees"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel3.Controls.Add(Me.NumberOfRoomsLabel)
        Me.Panel3.Controls.Add(Me.asd)
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(278, 18)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(240, 100)
        Me.Panel3.TabIndex = 51
        '
        'NumberOfRoomsLabel
        '
        Me.NumberOfRoomsLabel.AutoSize = True
        Me.NumberOfRoomsLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.NumberOfRoomsLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfRoomsLabel.Location = New System.Drawing.Point(0, 0)
        Me.NumberOfRoomsLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.NumberOfRoomsLabel.Name = "NumberOfRoomsLabel"
        Me.NumberOfRoomsLabel.Padding = New System.Windows.Forms.Padding(8)
        Me.NumberOfRoomsLabel.Size = New System.Drawing.Size(65, 75)
        Me.NumberOfRoomsLabel.TabIndex = 2
        Me.NumberOfRoomsLabel.Text = "0"
        '
        'asd
        '
        Me.asd.AutoSize = True
        Me.asd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.asd.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asd.Location = New System.Drawing.Point(0, 69)
        Me.asd.Margin = New System.Windows.Forms.Padding(0)
        Me.asd.Name = "asd"
        Me.asd.Padding = New System.Windows.Forms.Padding(8, 0, 8, 8)
        Me.asd.Size = New System.Drawing.Size(166, 31)
        Me.asd.TabIndex = 1
        Me.asd.Text = "Number of Rooms"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 126)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(101, 25)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Bookings"
        '
        'ReportDGV
        '
        Me.ReportDGV.AllowUserToAddRows = False
        Me.ReportDGV.AllowUserToDeleteRows = False
        Me.ReportDGV.AllowUserToResizeColumns = False
        Me.ReportDGV.AllowUserToResizeRows = False
        Me.ReportDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ReportDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ReportDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReportDGV.Location = New System.Drawing.Point(743, 155)
        Me.ReportDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.ReportDGV.Name = "ReportDGV"
        Me.ReportDGV.ReadOnly = True
        Me.ReportDGV.RowHeadersWidth = 21
        Me.ReportDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReportDGV.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ReportDGV.RowTemplate.Height = 24
        Me.ReportDGV.Size = New System.Drawing.Size(31, 29)
        Me.ReportDGV.TabIndex = 56
        Me.ReportDGV.Visible = False
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(790, 451)
        Me.Controls.Add(Me.ReportDGV)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.ExportRoomBtn)
        Me.Controls.Add(Me.BookingsDGV)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "DashboardForm"
        Me.Text = "frmDashboard"
        CType(Me.BookingsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ReportDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExportRoomBtn As System.Windows.Forms.Button
    Friend WithEvents BookingsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents NumberOfBookingsLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents NumberOfEmployeesLabel As System.Windows.Forms.Label
    Friend WithEvents NumberOfasdSuppliersLabel As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents NumberOfRoomsLabel As System.Windows.Forms.Label
    Friend WithEvents asd As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ReportDGV As System.Windows.Forms.DataGridView
End Class
