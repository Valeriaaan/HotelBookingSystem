Imports System.Runtime.InteropServices

Public Class DashboardForm
    Dim exFile As Object
    Dim ReportTable As New DataTable
    Dim row As Integer

    Sub ShowBookingTable()
        Dim BookingTable As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT b.bookingID as 'ID', CONCAT(g.firstName, ' ', g.lastName) as 'Guest', r.roomType as 'Room Type', b.roomNo as 'Room Number', b.arrivalDate as 'Arrival Date', b.departureDate as 'Departure Date', b.numberOfOccupancy as 'Number Of Occupancy', b.specialRequest as 'Special Request', b.employeeID as 'Employee ID' FROM booking b INNER JOIN guest g ON b.guestID = g.guestID INNER JOIN room r ON b.roomNo = r.roomID"
            adapter.SelectCommand = cmd
            BookingTable.Clear()

            adapter.Fill(BookingTable)
            BookingsDGV.DataSource = BookingTable

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Sub GetReportData()
        Dim ReportTable As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT b.bookingID as 'ID', CONCAT(g.firstName, ' ', g.lastName) as 'Guest', b.arrivalDate as 'Arrival Date', b.departureDate as 'Departure Date', b.numberOfOccupancy as 'Number Of Occupancy', r.roomType as 'Room Type' FROM booking b INNER JOIN guest g ON b.guestID = g.guestID INNER JOIN room r ON b.roomNo = r.roomID"
            adapter.SelectCommand = cmd
            ReportTable.Clear()

            adapter.Fill(ReportTable)
            ReportDGV.DataSource = ReportTable

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub ExportRoomBtn_Click(sender As Object, e As EventArgs) Handles ExportRoomBtn.Click

        Try
            ' Create a new Excel application using late binding
            Dim exFile As Object = CreateObject("Excel.Application")

            ' Open the existing Excel workbook
            Dim workbook As Object = exFile.Workbooks.Open("C:\Users\Acer\OneDrive\Documents\Visual Studio 2013\Projects\HotelBookingSystem\report.xlsx")

            ' Get the first worksheet in the workbook
            Dim worksheet As Object = DirectCast(workbook.Sheets(1), Object)

            ' Set the header row in the Excel worksheet
            For colIndex As Integer = 1 To ReportDGV.Columns.Count
                worksheet.Cells(4, colIndex).Value = ReportDGV.Columns(colIndex - 1).HeaderText
            Next

            ' Populate the Excel worksheet with data from the DataGridView
            row = 5
            For rowIndex As Integer = 0 To ReportDGV.Rows.Count - 1
                For colIndex As Integer = 1 To ReportDGV.Columns.Count
                    worksheet.Cells(row, colIndex).Value = ReportDGV.Rows(rowIndex).Cells(colIndex - 1).Value.ToString()
                Next
                row += 1
            Next

            ' Set the date in the Excel worksheet
            worksheet.Cells(2, 1) = "Date: " & FormatDateTime(Now(), DateFormat.LongDate)

            ' Make the Excel application visible to the user
            exFile.Visible = True

            ' Release Excel objects to free up resources
            Marshal.ReleaseComObject(worksheet)
            Marshal.ReleaseComObject(workbook)
            Marshal.ReleaseComObject(exFile)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Sub ShowRowCount(TableName, LabelName)
        Dim count As Integer = 0
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT COUNT(*) FROM " & TableName
            count = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                LabelName.Text = count.ToString()
            Else
                LabelName.Text = "0"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

End Class