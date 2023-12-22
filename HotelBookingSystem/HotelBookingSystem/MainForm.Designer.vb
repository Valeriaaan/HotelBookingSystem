<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EmployeeNavPnl = New System.Windows.Forms.Panel()
        Me.EmployeeNavBtn = New System.Windows.Forms.Button()
        Me.RoomNavPnl = New System.Windows.Forms.Panel()
        Me.RoomNavBtn = New System.Windows.Forms.Button()
        Me.CancelBookingPnl = New System.Windows.Forms.Panel()
        Me.CancelBookingBtn = New System.Windows.Forms.Button()
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.BookingNavPnl = New System.Windows.Forms.Panel()
        Me.BookingNavBtn = New System.Windows.Forms.Button()
        Me.DashboardNavPnl = New System.Windows.Forms.Panel()
        Me.DashboardNavBtn = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LogoPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.ContentPanel = New System.Windows.Forms.Panel()
        Me.EmployeePanel = New System.Windows.Forms.Panel()
        Me.ExportEmployeeBtn = New System.Windows.Forms.Button()
        Me.EmployeeAddBtn = New System.Windows.Forms.Button()
        Me.EmployeeUpdateBtn = New System.Windows.Forms.Button()
        Me.EmployeeDeleteBtn = New System.Windows.Forms.Button()
        Me.EmployeeDGV = New System.Windows.Forms.DataGridView()
        Me.RoomPanel = New System.Windows.Forms.Panel()
        Me.ExportRoomBtn = New System.Windows.Forms.Button()
        Me.RoomAddBtn = New System.Windows.Forms.Button()
        Me.RoomUpdateBtn = New System.Windows.Forms.Button()
        Me.RoomDeleteBtn = New System.Windows.Forms.Button()
        Me.RoomDGV = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.EmployeeNavPnl.SuspendLayout()
        Me.RoomNavPnl.SuspendLayout()
        Me.CancelBookingPnl.SuspendLayout()
        Me.BookingNavPnl.SuspendLayout()
        Me.DashboardNavPnl.SuspendLayout()
        Me.EmployeePanel.SuspendLayout()
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoomPanel.SuspendLayout()
        CType(Me.RoomDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel1.Controls.Add(Me.EmployeeNavPnl)
        Me.Panel1.Controls.Add(Me.RoomNavPnl)
        Me.Panel1.Controls.Add(Me.CancelBookingPnl)
        Me.Panel1.Controls.Add(Me.LogoutBtn)
        Me.Panel1.Controls.Add(Me.BookingNavPnl)
        Me.Panel1.Controls.Add(Me.DashboardNavPnl)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.LogoPanel)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(237, 515)
        Me.Panel1.TabIndex = 2
        '
        'EmployeeNavPnl
        '
        Me.EmployeeNavPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.EmployeeNavPnl.Controls.Add(Me.EmployeeNavBtn)
        Me.EmployeeNavPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.EmployeeNavPnl.Location = New System.Drawing.Point(0, 405)
        Me.EmployeeNavPnl.Name = "EmployeeNavPnl"
        Me.EmployeeNavPnl.Size = New System.Drawing.Size(237, 55)
        Me.EmployeeNavPnl.TabIndex = 33
        '
        'EmployeeNavBtn
        '
        Me.EmployeeNavBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.EmployeeNavBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EmployeeNavBtn.FlatAppearance.BorderSize = 0
        Me.EmployeeNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmployeeNavBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeNavBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.EmployeeNavBtn.Image = Global.HotelBookingSystem.My.Resources.Resources.icons8_employee_28
        Me.EmployeeNavBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmployeeNavBtn.Location = New System.Drawing.Point(4, 0)
        Me.EmployeeNavBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeNavBtn.Name = "EmployeeNavBtn"
        Me.EmployeeNavBtn.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.EmployeeNavBtn.Size = New System.Drawing.Size(241, 55)
        Me.EmployeeNavBtn.TabIndex = 21
        Me.EmployeeNavBtn.Text = "  Employee"
        Me.EmployeeNavBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmployeeNavBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EmployeeNavBtn.UseVisualStyleBackColor = True
        '
        'RoomNavPnl
        '
        Me.RoomNavPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.RoomNavPnl.Controls.Add(Me.RoomNavBtn)
        Me.RoomNavPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.RoomNavPnl.Location = New System.Drawing.Point(0, 350)
        Me.RoomNavPnl.Name = "RoomNavPnl"
        Me.RoomNavPnl.Size = New System.Drawing.Size(237, 55)
        Me.RoomNavPnl.TabIndex = 32
        '
        'RoomNavBtn
        '
        Me.RoomNavBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.RoomNavBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RoomNavBtn.FlatAppearance.BorderSize = 0
        Me.RoomNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoomNavBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomNavBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.RoomNavBtn.Image = Global.HotelBookingSystem.My.Resources.Resources.icons8_bed_24__1_
        Me.RoomNavBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RoomNavBtn.Location = New System.Drawing.Point(4, 0)
        Me.RoomNavBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.RoomNavBtn.Name = "RoomNavBtn"
        Me.RoomNavBtn.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.RoomNavBtn.Size = New System.Drawing.Size(241, 55)
        Me.RoomNavBtn.TabIndex = 21
        Me.RoomNavBtn.Text = "  Room"
        Me.RoomNavBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RoomNavBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RoomNavBtn.UseVisualStyleBackColor = True
        '
        'CancelBookingPnl
        '
        Me.CancelBookingPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.CancelBookingPnl.Controls.Add(Me.CancelBookingBtn)
        Me.CancelBookingPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.CancelBookingPnl.Location = New System.Drawing.Point(0, 295)
        Me.CancelBookingPnl.Name = "CancelBookingPnl"
        Me.CancelBookingPnl.Size = New System.Drawing.Size(237, 55)
        Me.CancelBookingPnl.TabIndex = 31
        '
        'CancelBookingBtn
        '
        Me.CancelBookingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelBookingBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelBookingBtn.FlatAppearance.BorderSize = 0
        Me.CancelBookingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBookingBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBookingBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.CancelBookingBtn.Image = Global.HotelBookingSystem.My.Resources.Resources.icons8_booking_28
        Me.CancelBookingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelBookingBtn.Location = New System.Drawing.Point(4, 0)
        Me.CancelBookingBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelBookingBtn.Name = "CancelBookingBtn"
        Me.CancelBookingBtn.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.CancelBookingBtn.Size = New System.Drawing.Size(241, 55)
        Me.CancelBookingBtn.TabIndex = 21
        Me.CancelBookingBtn.Text = " Cancel Booking"
        Me.CancelBookingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelBookingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CancelBookingBtn.UseVisualStyleBackColor = True
        '
        'LogoutBtn
        '
        Me.LogoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LogoutBtn.FlatAppearance.BorderSize = 0
        Me.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.LogoutBtn.Image = Global.HotelBookingSystem.My.Resources.Resources.icons8_logout_24__1_
        Me.LogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutBtn.Location = New System.Drawing.Point(0, 460)
        Me.LogoutBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.LogoutBtn.Size = New System.Drawing.Size(237, 55)
        Me.LogoutBtn.TabIndex = 30
        Me.LogoutBtn.Text = "  Logout"
        Me.LogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.LogoutBtn.UseVisualStyleBackColor = True
        '
        'BookingNavPnl
        '
        Me.BookingNavPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.BookingNavPnl.Controls.Add(Me.BookingNavBtn)
        Me.BookingNavPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.BookingNavPnl.Location = New System.Drawing.Point(0, 240)
        Me.BookingNavPnl.Name = "BookingNavPnl"
        Me.BookingNavPnl.Size = New System.Drawing.Size(237, 55)
        Me.BookingNavPnl.TabIndex = 24
        '
        'BookingNavBtn
        '
        Me.BookingNavBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BookingNavBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BookingNavBtn.FlatAppearance.BorderSize = 0
        Me.BookingNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BookingNavBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingNavBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BookingNavBtn.Image = Global.HotelBookingSystem.My.Resources.Resources.icons8_booking_28
        Me.BookingNavBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BookingNavBtn.Location = New System.Drawing.Point(4, 0)
        Me.BookingNavBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.BookingNavBtn.Name = "BookingNavBtn"
        Me.BookingNavBtn.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.BookingNavBtn.Size = New System.Drawing.Size(241, 55)
        Me.BookingNavBtn.TabIndex = 21
        Me.BookingNavBtn.Text = " Booking"
        Me.BookingNavBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BookingNavBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BookingNavBtn.UseVisualStyleBackColor = True
        '
        'DashboardNavPnl
        '
        Me.DashboardNavPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.DashboardNavPnl.Controls.Add(Me.DashboardNavBtn)
        Me.DashboardNavPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.DashboardNavPnl.Location = New System.Drawing.Point(0, 185)
        Me.DashboardNavPnl.Name = "DashboardNavPnl"
        Me.DashboardNavPnl.Size = New System.Drawing.Size(237, 55)
        Me.DashboardNavPnl.TabIndex = 23
        '
        'DashboardNavBtn
        '
        Me.DashboardNavBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.DashboardNavBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DashboardNavBtn.FlatAppearance.BorderSize = 0
        Me.DashboardNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DashboardNavBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashboardNavBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.DashboardNavBtn.Image = Global.HotelBookingSystem.My.Resources.Resources.icons8_menu_24
        Me.DashboardNavBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardNavBtn.Location = New System.Drawing.Point(4, 0)
        Me.DashboardNavBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.DashboardNavBtn.Name = "DashboardNavBtn"
        Me.DashboardNavBtn.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.DashboardNavBtn.Size = New System.Drawing.Size(241, 55)
        Me.DashboardNavBtn.TabIndex = 21
        Me.DashboardNavBtn.Text = "  Dashboard"
        Me.DashboardNavBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardNavBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DashboardNavBtn.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 165)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(237, 20)
        Me.Panel5.TabIndex = 20
        '
        'LogoPanel
        '
        Me.LogoPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.LogoPanel.Location = New System.Drawing.Point(0, 43)
        Me.LogoPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.LogoPanel.Name = "LogoPanel"
        Me.LogoPanel.Size = New System.Drawing.Size(237, 122)
        Me.LogoPanel.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(237, 43)
        Me.Panel2.TabIndex = 17
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(237, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(809, 43)
        Me.Panel7.TabIndex = 25
        '
        'ContentPanel
        '
        Me.ContentPanel.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ContentPanel.Location = New System.Drawing.Point(247, 54)
        Me.ContentPanel.Name = "ContentPanel"
        Me.ContentPanel.Size = New System.Drawing.Size(790, 451)
        Me.ContentPanel.TabIndex = 26
        '
        'EmployeePanel
        '
        Me.EmployeePanel.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.EmployeePanel.Controls.Add(Me.ExportEmployeeBtn)
        Me.EmployeePanel.Controls.Add(Me.EmployeeAddBtn)
        Me.EmployeePanel.Controls.Add(Me.EmployeeUpdateBtn)
        Me.EmployeePanel.Controls.Add(Me.EmployeeDeleteBtn)
        Me.EmployeePanel.Controls.Add(Me.EmployeeDGV)
        Me.EmployeePanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeePanel.Location = New System.Drawing.Point(246, 54)
        Me.EmployeePanel.Name = "EmployeePanel"
        Me.EmployeePanel.Size = New System.Drawing.Size(790, 451)
        Me.EmployeePanel.TabIndex = 31
        '
        'ExportEmployeeBtn
        '
        Me.ExportEmployeeBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ExportEmployeeBtn.FlatAppearance.BorderSize = 0
        Me.ExportEmployeeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ExportEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExportEmployeeBtn.ForeColor = System.Drawing.Color.White
        Me.ExportEmployeeBtn.Location = New System.Drawing.Point(17, 341)
        Me.ExportEmployeeBtn.Name = "ExportEmployeeBtn"
        Me.ExportEmployeeBtn.Size = New System.Drawing.Size(757, 45)
        Me.ExportEmployeeBtn.TabIndex = 45
        Me.ExportEmployeeBtn.Text = "Export Data"
        Me.ExportEmployeeBtn.UseVisualStyleBackColor = False
        '
        'EmployeeAddBtn
        '
        Me.EmployeeAddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.EmployeeAddBtn.FlatAppearance.BorderSize = 0
        Me.EmployeeAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.EmployeeAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmployeeAddBtn.ForeColor = System.Drawing.Color.White
        Me.EmployeeAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmployeeAddBtn.Location = New System.Drawing.Point(17, 392)
        Me.EmployeeAddBtn.Name = "EmployeeAddBtn"
        Me.EmployeeAddBtn.Size = New System.Drawing.Size(250, 45)
        Me.EmployeeAddBtn.TabIndex = 44
        Me.EmployeeAddBtn.Text = "Add"
        Me.EmployeeAddBtn.UseVisualStyleBackColor = False
        '
        'EmployeeUpdateBtn
        '
        Me.EmployeeUpdateBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.EmployeeUpdateBtn.FlatAppearance.BorderSize = 0
        Me.EmployeeUpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.EmployeeUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmployeeUpdateBtn.ForeColor = System.Drawing.Color.White
        Me.EmployeeUpdateBtn.Location = New System.Drawing.Point(273, 392)
        Me.EmployeeUpdateBtn.Name = "EmployeeUpdateBtn"
        Me.EmployeeUpdateBtn.Size = New System.Drawing.Size(250, 45)
        Me.EmployeeUpdateBtn.TabIndex = 43
        Me.EmployeeUpdateBtn.Text = "Update"
        Me.EmployeeUpdateBtn.UseVisualStyleBackColor = False
        '
        'EmployeeDeleteBtn
        '
        Me.EmployeeDeleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.EmployeeDeleteBtn.FlatAppearance.BorderSize = 0
        Me.EmployeeDeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.EmployeeDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmployeeDeleteBtn.ForeColor = System.Drawing.Color.White
        Me.EmployeeDeleteBtn.Location = New System.Drawing.Point(524, 392)
        Me.EmployeeDeleteBtn.Name = "EmployeeDeleteBtn"
        Me.EmployeeDeleteBtn.Size = New System.Drawing.Size(250, 45)
        Me.EmployeeDeleteBtn.TabIndex = 42
        Me.EmployeeDeleteBtn.Text = "Delete"
        Me.EmployeeDeleteBtn.UseVisualStyleBackColor = False
        '
        'EmployeeDGV
        '
        Me.EmployeeDGV.AllowUserToAddRows = False
        Me.EmployeeDGV.AllowUserToDeleteRows = False
        Me.EmployeeDGV.AllowUserToResizeColumns = False
        Me.EmployeeDGV.AllowUserToResizeRows = False
        Me.EmployeeDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EmployeeDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.EmployeeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeDGV.Location = New System.Drawing.Point(17, 13)
        Me.EmployeeDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeDGV.Name = "EmployeeDGV"
        Me.EmployeeDGV.ReadOnly = True
        Me.EmployeeDGV.RowHeadersWidth = 21
        Me.EmployeeDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeeDGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.EmployeeDGV.RowTemplate.Height = 24
        Me.EmployeeDGV.Size = New System.Drawing.Size(757, 323)
        Me.EmployeeDGV.TabIndex = 41
        '
        'RoomPanel
        '
        Me.RoomPanel.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.RoomPanel.Controls.Add(Me.ExportRoomBtn)
        Me.RoomPanel.Controls.Add(Me.RoomAddBtn)
        Me.RoomPanel.Controls.Add(Me.RoomUpdateBtn)
        Me.RoomPanel.Controls.Add(Me.RoomDeleteBtn)
        Me.RoomPanel.Controls.Add(Me.RoomDGV)
        Me.RoomPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomPanel.Location = New System.Drawing.Point(245, 53)
        Me.RoomPanel.Name = "RoomPanel"
        Me.RoomPanel.Size = New System.Drawing.Size(790, 451)
        Me.RoomPanel.TabIndex = 46
        '
        'ExportRoomBtn
        '
        Me.ExportRoomBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ExportRoomBtn.FlatAppearance.BorderSize = 0
        Me.ExportRoomBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ExportRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExportRoomBtn.ForeColor = System.Drawing.Color.White
        Me.ExportRoomBtn.Location = New System.Drawing.Point(17, 341)
        Me.ExportRoomBtn.Name = "ExportRoomBtn"
        Me.ExportRoomBtn.Size = New System.Drawing.Size(757, 45)
        Me.ExportRoomBtn.TabIndex = 45
        Me.ExportRoomBtn.Text = "Export Data"
        Me.ExportRoomBtn.UseVisualStyleBackColor = False
        '
        'RoomAddBtn
        '
        Me.RoomAddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.RoomAddBtn.FlatAppearance.BorderSize = 0
        Me.RoomAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RoomAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoomAddBtn.ForeColor = System.Drawing.Color.White
        Me.RoomAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RoomAddBtn.Location = New System.Drawing.Point(17, 392)
        Me.RoomAddBtn.Name = "RoomAddBtn"
        Me.RoomAddBtn.Size = New System.Drawing.Size(250, 45)
        Me.RoomAddBtn.TabIndex = 44
        Me.RoomAddBtn.Text = "Add"
        Me.RoomAddBtn.UseVisualStyleBackColor = False
        '
        'RoomUpdateBtn
        '
        Me.RoomUpdateBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.RoomUpdateBtn.FlatAppearance.BorderSize = 0
        Me.RoomUpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RoomUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoomUpdateBtn.ForeColor = System.Drawing.Color.White
        Me.RoomUpdateBtn.Location = New System.Drawing.Point(271, 392)
        Me.RoomUpdateBtn.Name = "RoomUpdateBtn"
        Me.RoomUpdateBtn.Size = New System.Drawing.Size(250, 45)
        Me.RoomUpdateBtn.TabIndex = 43
        Me.RoomUpdateBtn.Text = "Update"
        Me.RoomUpdateBtn.UseVisualStyleBackColor = False
        '
        'RoomDeleteBtn
        '
        Me.RoomDeleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.RoomDeleteBtn.FlatAppearance.BorderSize = 0
        Me.RoomDeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RoomDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoomDeleteBtn.ForeColor = System.Drawing.Color.White
        Me.RoomDeleteBtn.Location = New System.Drawing.Point(524, 392)
        Me.RoomDeleteBtn.Name = "RoomDeleteBtn"
        Me.RoomDeleteBtn.Size = New System.Drawing.Size(250, 45)
        Me.RoomDeleteBtn.TabIndex = 42
        Me.RoomDeleteBtn.Text = "Delete"
        Me.RoomDeleteBtn.UseVisualStyleBackColor = False
        '
        'RoomDGV
        '
        Me.RoomDGV.AllowUserToAddRows = False
        Me.RoomDGV.AllowUserToDeleteRows = False
        Me.RoomDGV.AllowUserToResizeColumns = False
        Me.RoomDGV.AllowUserToResizeRows = False
        Me.RoomDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RoomDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.RoomDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RoomDGV.Location = New System.Drawing.Point(17, 13)
        Me.RoomDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.RoomDGV.Name = "RoomDGV"
        Me.RoomDGV.ReadOnly = True
        Me.RoomDGV.RowHeadersWidth = 21
        Me.RoomDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RoomDGV.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.RoomDGV.RowTemplate.Height = 24
        Me.RoomDGV.Size = New System.Drawing.Size(757, 323)
        Me.RoomDGV.TabIndex = 41
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1046, 515)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.EmployeePanel)
        Me.Controls.Add(Me.ContentPanel)
        Me.Controls.Add(Me.RoomPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMainfinal"
        Me.Panel1.ResumeLayout(False)
        Me.EmployeeNavPnl.ResumeLayout(False)
        Me.RoomNavPnl.ResumeLayout(False)
        Me.CancelBookingPnl.ResumeLayout(False)
        Me.BookingNavPnl.ResumeLayout(False)
        Me.DashboardNavPnl.ResumeLayout(False)
        Me.EmployeePanel.ResumeLayout(False)
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoomPanel.ResumeLayout(False)
        CType(Me.RoomDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BookingNavPnl As System.Windows.Forms.Panel
    Friend WithEvents BookingNavBtn As System.Windows.Forms.Button
    Friend WithEvents DashboardNavPnl As System.Windows.Forms.Panel
    Friend WithEvents DashboardNavBtn As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents LogoPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents ContentPanel As System.Windows.Forms.Panel
    Friend WithEvents EmployeePanel As System.Windows.Forms.Panel
    Friend WithEvents EmployeeAddBtn As System.Windows.Forms.Button
    Friend WithEvents EmployeeUpdateBtn As System.Windows.Forms.Button
    Friend WithEvents EmployeeDeleteBtn As System.Windows.Forms.Button
    Friend WithEvents EmployeeDGV As System.Windows.Forms.DataGridView
    Friend WithEvents RoomPanel As System.Windows.Forms.Panel
    Friend WithEvents RoomAddBtn As System.Windows.Forms.Button
    Friend WithEvents RoomUpdateBtn As System.Windows.Forms.Button
    Friend WithEvents RoomDeleteBtn As System.Windows.Forms.Button
    Friend WithEvents RoomDGV As System.Windows.Forms.DataGridView
    Friend WithEvents LogoutBtn As System.Windows.Forms.Button
    Friend WithEvents ExportRoomBtn As System.Windows.Forms.Button
    Friend WithEvents ExportEmployeeBtn As System.Windows.Forms.Button
    Friend WithEvents EmployeeNavPnl As System.Windows.Forms.Panel
    Friend WithEvents EmployeeNavBtn As System.Windows.Forms.Button
    Friend WithEvents RoomNavPnl As System.Windows.Forms.Panel
    Friend WithEvents RoomNavBtn As System.Windows.Forms.Button
    Friend WithEvents CancelBookingPnl As System.Windows.Forms.Panel
    Friend WithEvents CancelBookingBtn As System.Windows.Forms.Button
End Class
