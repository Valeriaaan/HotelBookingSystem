Public Class DeleteBookingForm

    Sub ClearForm()
        GuestFirstnameTextBox.Clear()
        GuestLastnameTextBox.Clear()
        GuestPhoneNumTextBox.Clear()
        GuestAddressTextBox.Clear()

        GuestNumberTextBox.Clear()
        SpecialRequestsTextBox.Clear()

        RoomTypeTextBox.Clear()
        RoomOccupancyTextBox.Clear()
        RoomPriceTextBox.Clear()

        RoomIDComboBox.SelectedIndex = -1
        EmployeeNameComboBox.SelectedIndex = -1
    End Sub

    Private Sub CancelBookingBtn_Click(sender As Object, e As EventArgs) Handles CancelBookingBtn.Click
        If BookingIDComboBox.SelectedIndex > -1 Then
            Try
                openCon()
                cmd.Connection = con

                If MsgBox("Are you sure you want to cancel this booking?", MsgBoxStyle.YesNo) = vbYes Then
                    cmd.CommandText = "DELETE FROM booking WHERE bookingID = @BookingID"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@BookingID", BookingIDComboBox.SelectedValue)
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "DELETE FROM guest WHERE guestID = @GuestID"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@GuestID", GuestIDComboBox.Text)
                    cmd.ExecuteNonQuery()

                    MsgBox("Booking has been canceled!")
                    ClearForm()
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        Else
            MsgBox("Please select a booking to cancel.")
        End If
    End Sub


    Sub ShowBookingID()
        Dim BookingID As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM booking"
            adapter.SelectCommand = cmd
            adapter.Fill(BookingID)
            BookingIDComboBox.DataSource = BookingID
            BookingIDComboBox.DisplayMember = "bookingID"
            BookingIDComboBox.ValueMember = "bookingID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BookingIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BookingIDComboBox.SelectedIndexChanged
        If BookingIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT b.*, g.*, r.* FROM booking b " &
                                  "INNER JOIN guest g ON b.guestID = g.guestID " &
                                  "INNER JOIN room r ON b.roomNo = r.roomID " &
                                  "WHERE b.bookingID = @BookingID"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@BookingID", BookingIDComboBox.SelectedValue)

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    RoomIDComboBox.Text = reader("roomNo").ToString()
                    ArrivalDateDTP.Value = Convert.ToDateTime(reader("arrivalDate"))
                    DepartureDateDTP.Value = Convert.ToDateTime(reader("departureDate"))
                    GuestNumberTextBox.Text = reader("numberofOccupancy").ToString()
                    SpecialRequestsTextBox.Text = reader("specialRequest").ToString()
                    EmployeeNameComboBox.Text = reader("employeeID").ToString()
                    GuestFirstnameTextBox.Text = reader("firstName").ToString()
                    GuestLastnameTextBox.Text = reader("lastName").ToString()
                    GuestPhoneNumTextBox.Text = reader("phoneNum").ToString()
                    GuestAddressTextBox.Text = reader("address").ToString()
                    RoomTypeTextBox.Text = reader("roomType").ToString()
                    RoomOccupancyTextBox.Text = reader("occupancy").ToString()
                    RoomPriceTextBox.Text = reader("roomPrice").ToString()

                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

End Class