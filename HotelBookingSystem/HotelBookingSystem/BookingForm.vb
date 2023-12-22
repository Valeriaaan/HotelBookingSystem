Public Class BookingForm

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

    Sub ShowRoomNumber()
        Dim AvailableRooms As New DataTable
        openCon()
        Try
            cmd.Connection = con
            ' Select rooms that have occupancy greater than or equal to the specified occupancy
            ' and are not already booked (roomID not in booking table)
            cmd.CommandText = "SELECT * FROM room WHERE occupancy >= @Occupancy AND roomID NOT IN (SELECT DISTINCT roomNo FROM booking)"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Occupancy", GuestNumberTextBox.Text)

            adapter.SelectCommand = cmd
            adapter.Fill(AvailableRooms)
            RoomIDComboBox.DataSource = AvailableRooms
            RoomIDComboBox.DisplayMember = "roomID"
            RoomIDComboBox.ValueMember = "roomID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Sub ShowEmployeeName()
        Dim EmployeeName As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM employee"
            adapter.SelectCommand = cmd
            adapter.Fill(EmployeeName)
            EmployeeNameComboBox.DataSource = EmployeeName
            EmployeeNameComboBox.DisplayMember = "firstname"
            EmployeeNameComboBox.ValueMember = "employeeID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub ShowGuestID()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT MAX(guestID) FROM guest"
            Dim result As Object = cmd.ExecuteScalar()

            If result Is DBNull.Value Then
                GuestIDComboBox.Items.Add("1")
                GuestIDComboBox.Text = "1"
            Else
                Dim finalId As Integer = CInt(result) + 1

                GuestIDComboBox.Items.Add(finalId.ToString())

                GuestIDComboBox.Text = finalId.ToString()
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BookRoomBtn_Click(sender As Object, e As EventArgs) Handles BookRoomBtn.Click
        If String.IsNullOrWhiteSpace(GuestFirstnameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(GuestLastnameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(GuestPhoneNumTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(GuestAddressTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(GuestNumberTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(SpecialRequestsTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(RoomTypeTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(RoomOccupancyTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(RoomPriceTextBox.Text) Then

            MsgBox("Please fill in all the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO guest (firstName, lastName, phoneNum, address) VALUES (@GuestFirstname, @GuestLastname, @GuestPhoneNum, @GuestAddress)"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@GuestFirstname", GuestFirstnameTextBox.Text)
            cmd.Parameters.AddWithValue("@GuestLastname", GuestLastnameTextBox.Text)
            cmd.Parameters.AddWithValue("@GuestPhoneNum", GuestPhoneNumTextBox.Text)
            cmd.Parameters.AddWithValue("@GuestAddress", GuestAddressTextBox.Text)

            If MsgBox("Are you sure you want to book this room?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()

                cmd.CommandText = "INSERT INTO booking (guestID, roomNo, arrivalDate, departureDate, numberofOccupancy, specialRequest, employeeID) VALUES (@GuestID, @RoomNo, @ArrivalDate, @DepartureDate, @NumberOfOccupancy, @SpecialRequests, @EmployeeID)"

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@GuestID", GuestIDComboBox.Text)
                cmd.Parameters.AddWithValue("@RoomNo", RoomIDComboBox.SelectedValue)
                cmd.Parameters.AddWithValue("@ArrivalDate", ArrivalDateDTP.Text)
                cmd.Parameters.AddWithValue("@DepartureDate", DepartureDateDTP.Text)
                cmd.Parameters.AddWithValue("@NumberOfOccupancy", (RoomOccupancyTextBox.Text))
                cmd.Parameters.AddWithValue("@SpecialRequests", SpecialRequestsTextBox.Text)
                cmd.Parameters.AddWithValue("@EmployeeID", EmployeeNameComboBox.SelectedValue)

                cmd.ExecuteNonQuery()

                MsgBox("Room has been booked!")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub RoomIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RoomIDComboBox.SelectedIndexChanged
        If RoomIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM room WHERE roomID = '" & RoomIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    RoomTypeTextBox.Text = reader.GetString("roomType")
                    RoomOccupancyTextBox.Text = reader.GetString("occupancy")
                    RoomPriceTextBox.Text = reader.GetString("roomPrice")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub GuestPhoneNumTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles GuestPhoneNumTextBox.KeyDown
        ' Check if the pressed key is not a digit, Backspace, or Delete
        If Not Char.IsDigit(ChrW(e.KeyCode)) AndAlso Not e.KeyCode = Keys.Back AndAlso Not e.KeyCode = Keys.Delete Then
            ' Ignore the key press
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub GuestNumberTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles GuestNumberTextBox.KeyDown
        ' Check if the pressed key is not a digit, Backspace, or Delete
        If Not Char.IsDigit(ChrW(e.KeyCode)) AndAlso Not e.KeyCode = Keys.Back AndAlso Not e.KeyCode = Keys.Delete Then
            ' Ignore the key press
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub GuestNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles GuestNumberTextBox.TextChanged
        ShowRoomNumber()
        RoomIDComboBox.SelectedIndex = -1

        RoomOccupancyTextBox.Clear()
        RoomTypeTextBox.Clear()
        RoomPriceTextBox.Clear()
    End Sub
End Class