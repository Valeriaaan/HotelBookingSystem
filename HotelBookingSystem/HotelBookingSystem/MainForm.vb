Imports System.Runtime.InteropServices

Public Class MainForm
    Dim exFile As Object
    Dim EmployeeExportTable As New DataTable
    Dim RoomExportTable As New DataTable
    Dim row As Integer

    Private Sub frmMainfinal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenContenPanel()

    End Sub

    Sub ShowRoomTable()
        Dim RoomTable As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT roomID as 'Room Number', roomType as 'Type', roomPrice as 'Price', occupancy as 'Occupancy' FROM room"
            adapter.SelectCommand = cmd
            RoomTable.Clear()

            adapter.Fill(RoomTable)
            RoomDGV.DataSource = RoomTable

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub ShowEmployeeTable()
        Dim EmployeeTable As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT employeeID as 'ID', firstName as 'First Name', lastName as 'Last Name', employeeRole as 'Role', PhoneNum as 'Phone Number' FROM employee"
            adapter.SelectCommand = cmd
            EmployeeTable.Clear()

            adapter.Fill(EmployeeTable)
            EmployeeDGV.DataSource = EmployeeTable

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub OpenContenPanel()
        ContentPanel.Visible = True
        EmployeePanel.Visible = False
        RoomPanel.Visible = False
    End Sub

    Sub SetBtnColor()
        DashboardNavBtn.BackColor = Color.FromArgb(44, 54, 79)
        BookingNavBtn.BackColor = Color.FromArgb(44, 54, 79)
        EmployeeNavBtn.BackColor = Color.FromArgb(44, 54, 79)
        RoomNavBtn.BackColor = Color.FromArgb(44, 54, 79)
        CancelBookingBtn.BackColor = Color.FromArgb(44, 54, 79)
    End Sub

    Private Sub DashboardNavBtn_Click(sender As Object, e As EventArgs) Handles DashboardNavBtn.Click
        OpenContenPanel()
        SetBtnColor()
        DashboardNavPnl.BackColor = Color.FromArgb(34, 176, 140)
        BookingNavPnl.BackColor = Color.FromArgb(44, 54, 79)
        EmployeeNavPnl.BackColor = Color.FromArgb(44, 54, 79)
        RoomNavPnl.BackColor = Color.FromArgb(44, 54, 79)
        CancelBookingPnl.BackColor = Color.FromArgb(44, 54, 79)

        With DashboardForm
            .TopLevel = False
            ContentPanel.Controls.Add(DashboardForm)

            .GetReportData()
            .ShowBookingTable()
            .ShowRowCount("booking", .NumberOfBookingsLabel)
            .ShowRowCount("room", .NumberOfRoomsLabel)
            .ShowRowCount("employee", .NumberOfEmployeesLabel)

            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BookingNavBtn_Click(sender As Object, e As EventArgs) Handles BookingNavBtn.Click
        OpenContenPanel()
        SetBtnColor()
        DashboardNavPnl.BackColor = Color.FromArgb(44, 54, 79)
        BookingNavPnl.BackColor = Color.FromArgb(34, 176, 140)
        EmployeeNavPnl.BackColor = Color.FromArgb(44, 54, 79)
        RoomNavPnl.BackColor = Color.FromArgb(44, 54, 79)
        CancelBookingPnl.BackColor = Color.FromArgb(44, 54, 79)

        With BookingForm
            .TopLevel = False
            ContentPanel.Controls.Add(BookingForm)

            .ShowEmployeeName()
            .ShowRoomNumber()
            .ShowGuestID()
            .ClearForm()

            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub CancelBookingBtn_Click(sender As Object, e As EventArgs) Handles CancelBookingBtn.Click
        SetBtnColor()
        DashboardNavPnl.BackColor = Color.FromArgb(44, 54, 79)
        BookingNavPnl.BackColor = Color.FromArgb(44, 54, 79)
        EmployeeNavPnl.BackColor = Color.FromArgb(44, 54, 79)
        RoomNavPnl.BackColor = Color.FromArgb(44, 54, 79)
        CancelBookingPnl.BackColor = Color.FromArgb(34, 176, 140)

        With DeleteBookingForm
            .TopLevel = False
            ContentPanel.Controls.Add(DeleteBookingForm)

            .ShowBookingID()


            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub RoomNavBtn_Click(sender As Object, e As EventArgs) Handles RoomNavBtn.Click
        SetBtnColor()
        DashboardNavPnl.BackColor = Color.FromArgb(44, 54, 79)
        BookingNavPnl.BackColor = Color.FromArgb(44, 54, 79)
        EmployeeNavPnl.BackColor = Color.FromArgb(44, 54, 79)
        RoomNavPnl.BackColor = Color.FromArgb(34, 176, 140)
        CancelBookingPnl.BackColor = Color.FromArgb(44, 54, 79)

        ContentPanel.Visible = False
        EmployeePanel.Visible = False
        RoomPanel.Visible = True
        ShowRoomTable()
    End Sub

    Private Sub EmployeeNavBtn_Click(sender As Object, e As EventArgs) Handles EmployeeNavBtn.Click
        SetBtnColor()
        DashboardNavPnl.BackColor = Color.FromArgb(44, 54, 79)
        BookingNavPnl.BackColor = Color.FromArgb(44, 54, 79)
        EmployeeNavPnl.BackColor = Color.FromArgb(34, 176, 140)
        RoomNavPnl.BackColor = Color.FromArgb(44, 54, 79)
        CancelBookingPnl.BackColor = Color.FromArgb(44, 54, 79)

        ContentPanel.Visible = False
        EmployeePanel.Visible = True
        RoomPanel.Visible = False
        ShowEmployeeTable()
    End Sub

    ' Room Section Start

    Private Sub ExportRoomBtn_Click(sender As Object, e As EventArgs) Handles ExportRoomBtn.Click
        Try
            exFile = CreateObject("Excel.Application")

            Dim workbook As Object = exFile.Workbooks.Open("C:\Users\Acer\OneDrive\Documents\Visual Studio 2013\Projects\HotelBookingSystem\room.xlsx")

            Dim worksheet As Object = DirectCast(workbook.Sheets(1), Object)

            For colIndex As Integer = 1 To RoomDGV.Columns.Count
                worksheet.Cells(2, colIndex).Value = RoomDGV.Columns(colIndex - 1).HeaderText
            Next

            row = 2
            For rowIndex As Integer = 0 To RoomDGV.Rows.Count - 1
                For colIndex As Integer = 1 To RoomDGV.Columns.Count
                    worksheet.Cells(row, colIndex).Value = RoomDGV.Rows(rowIndex).Cells(colIndex - 1).Value.ToString()
                Next
                row += 1
            Next

            exFile.Visible = True

            ' Release Excel objects to free up resources
            Marshal.ReleaseComObject(worksheet)
            Marshal.ReleaseComObject(workbook)
            Marshal.ReleaseComObject(exFile)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub RoomAddBtn_Click(sender As Object, e As EventArgs) Handles RoomAddBtn.Click
        OpenContenPanel()
        With RoomForm
            .TopLevel = False
            ContentPanel.Controls.Add(RoomForm)

            .RoomAddPanel.Visible = True
            .RoomUpdatePanel.Visible = False
            .RoomDeletePanel.Visible = False

            .AddClearTextBoxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub RoomUpdateBtn_Click(sender As Object, e As EventArgs) Handles RoomUpdateBtn.Click
        OpenContenPanel()
        With RoomForm
            .TopLevel = False
            ContentPanel.Controls.Add(RoomForm)

            .RoomAddPanel.Visible = False
            .RoomUpdatePanel.Visible = True
            .RoomDeletePanel.Visible = False

            .UpdateShowRoomID()
            .UpdateClearTextBoxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub RoomDeleteBtn_Click(sender As Object, e As EventArgs) Handles RoomDeleteBtn.Click
        OpenContenPanel()
        With RoomForm
            .TopLevel = False
            ContentPanel.Controls.Add(RoomForm)

            .RoomAddPanel.Visible = False
            .RoomUpdatePanel.Visible = False
            .RoomDeletePanel.Visible = True

            .DeleteShowRoomID()
            .DeleteClearTextBoxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Room Section End


    ' Employee Section Start

    Private Sub ExportEmployeeBtn_Click(sender As Object, e As EventArgs) Handles ExportEmployeeBtn.Click
        Try
            exFile = CreateObject("Excel.Application")

            Dim workbook As Object = exFile.Workbooks.Open("C:\Users\Acer\OneDrive\Documents\Visual Studio 2013\Projects\HotelBookingSystem\employee.xlsx")

            Dim worksheet As Object = DirectCast(workbook.Sheets(1), Object)

            For colIndex As Integer = 1 To EmployeeDGV.Columns.Count
                worksheet.Cells(2, colIndex).Value = EmployeeDGV.Columns(colIndex - 1).HeaderText
            Next

            row = 2
            For rowIndex As Integer = 0 To EmployeeDGV.Rows.Count - 1
                For colIndex As Integer = 1 To EmployeeDGV.Columns.Count
                    worksheet.Cells(row, colIndex).Value = EmployeeDGV.Rows(rowIndex).Cells(colIndex - 1).Value.ToString()
                Next
                row += 1
            Next

            exFile.Visible = True

            ' Release Excel objects to free up resources
            Marshal.ReleaseComObject(worksheet)
            Marshal.ReleaseComObject(workbook)
            Marshal.ReleaseComObject(exFile)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub EmployeeAddBtn_Click(sender As Object, e As EventArgs) Handles EmployeeAddBtn.Click
        OpenContenPanel()
        With EmployeeForm
            .TopLevel = False
            ContentPanel.Controls.Add(EmployeeForm)

            .EmployeeAddPanel.Visible = True
            .EmployeeUpdatePanel.Visible = False
            .EmployeeDeletePanel.Visible = False

            .AddClearTextBoxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub EmployeeUpdateBtn_Click(sender As Object, e As EventArgs) Handles EmployeeUpdateBtn.Click
        OpenContenPanel()
        With EmployeeForm
            .TopLevel = False
            ContentPanel.Controls.Add(EmployeeForm)

            .EmployeeAddPanel.Visible = False
            .EmployeeUpdatePanel.Visible = True
            .EmployeeDeletePanel.Visible = False

            .UpdateShowEmployeeID()
            .UpdateClearTextBoxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub EmployeeDeleteBtn_Click(sender As Object, e As EventArgs) Handles EmployeeDeleteBtn.Click
        OpenContenPanel()
        With EmployeeForm
            .TopLevel = False
            ContentPanel.Controls.Add(EmployeeForm)

            .EmployeeAddPanel.Visible = False
            .EmployeeUpdatePanel.Visible = False
            .EmployeeDeletePanel.Visible = True

            .DeleteShowEmployeeID()
            .DeleteClearTextBoxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Employee Section End

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ' Close the current form and show the login form
            Dim loginForm As New LoginForm()
            Me.Close()
            loginForm.Show()
        End If
    End Sub

End Class