Public Class RoomForm

    ' Add Section Start

    Sub AddClearTextBoxes()
        AddRoomTypeTextBox.Clear()
        AddRoomPriceTextBox.Clear()
        AddOccupancyTextBox.Clear()
    End Sub

    Private Sub RoomAddBtn_Click(sender As Object, e As EventArgs) Handles RoomAddBtn.Click
        If String.IsNullOrWhiteSpace(AddRoomTypeTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(AddRoomPriceTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(AddOccupancyTextBox.Text) Then

            MsgBox("Please fill in all the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO room (roomType, roomPrice, occupancy) VALUES (@RoomType, @RoomPrice, @Occupancy)"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@RoomType", AddRoomTypeTextBox.Text)
            cmd.Parameters.AddWithValue("@RoomPrice", AddRoomPriceTextBox.Text)
            cmd.Parameters.AddWithValue("@Occupancy", AddOccupancyTextBox.Text)

            If MsgBox("Do you want to save this room?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("New Room Added!")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        AddClearTextBoxes()
    End Sub

    ' Add Section End

    ' Update Section Start

    Sub UpdateClearTextBoxes()
        UpdateRoomTypeTextBox.Clear()
        UpdateRoomPriceTextBox.Clear()
        UpdateOccupancyTextBox.Clear()
    End Sub

    Sub UpdateShowRoomID()
        Dim UpdateRoomIDs As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM room"
            adapter.SelectCommand = cmd
            adapter.Fill(UpdateRoomIDs)

            UpdateRoomIDComboBox.DataSource = UpdateRoomIDs
            UpdateRoomIDComboBox.DisplayMember = "roomID"
            UpdateRoomIDComboBox.ValueMember = "roomID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UpdateRoomIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UpdateRoomIDComboBox.SelectedIndexChanged
        If UpdateRoomIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM room WHERE roomID = '" & UpdateRoomIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    UpdateRoomTypeTextBox.Text = reader.GetString("roomType")
                    UpdateRoomPriceTextBox.Text = reader.GetString("roomPrice")
                    UpdateOccupancyTextBox.Text = reader.GetString("occupancy")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub RoomUpdateBtn_Click(sender As Object, e As EventArgs) Handles RoomUpdateBtn.Click
        If String.IsNullOrWhiteSpace(UpdateRoomTypeTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(UpdateRoomPriceTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(UpdateOccupancyTextBox.Text) Then

            MsgBox("Please fill in all the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE room SET roomType = @RoomType, roomPrice = @RoomPrice, occupancy = @Occupancy WHERE roomID = @RoomID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@RoomID", UpdateRoomIDComboBox.SelectedValue)
            cmd.Parameters.AddWithValue("@RoomType", UpdateRoomTypeTextBox.Text)
            cmd.Parameters.AddWithValue("@RoomPrice", UpdateRoomPriceTextBox.Text)
            cmd.Parameters.AddWithValue("@Occupancy", UpdateOccupancyTextBox.Text)

            If MsgBox("Do you want to update room data?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("Room data updated!")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        UpdateClearTextBoxes()
        UpdateShowRoomID()
    End Sub

    ' Update Section End

    ' Delete Section Start

    Sub DeleteClearTextBoxes()
        UpdateRoomTypeTextBox.Clear()
        UpdateRoomPriceTextBox.Clear()
        UpdateOccupancyTextBox.Clear()
    End Sub

    Sub DeleteShowRoomID()
        Dim DeleteRoomIDs As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM room"
            adapter.SelectCommand = cmd
            adapter.Fill(DeleteRoomIDs)

            DeleteRoomIDComboBox.DataSource = DeleteRoomIDs
            DeleteRoomIDComboBox.DisplayMember = "roomID"
            DeleteRoomIDComboBox.ValueMember = "roomID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DeleteRoomIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DeleteRoomIDComboBox.SelectedIndexChanged
        If DeleteRoomIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM room WHERE roomID = '" & DeleteRoomIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    DeleteRoomTypeTextBox.Text = reader.GetString("roomType")
                    DeleteRoomPriceTextBox.Text = reader.GetString("roomPrice")
                    DeleteOccupancyTextBox.Text = reader.GetString("occupancy")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub RoomDeleteBtn_Click(sender As Object, e As EventArgs) Handles RoomDeleteBtn.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM room WHERE roomID = @RoomID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@RoomID", DeleteRoomIDComboBox.SelectedValue)

            If MsgBox("Are you sure you want to delete this room?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("Room Has Been Deleted.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        DeleteShowRoomID()
        DeleteClearTextBoxes()
    End Sub

    ' Delete Section End

    Private Sub UpdateOccupancyTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles UpdateOccupancyTextBox.KeyDown
        ' Check if the pressed key is not a digit or control key
        If Not (Char.IsDigit(ChrW(e.KeyCode)) OrElse e.Control) Then
            ' Ignore the key press
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub AddOccupancyTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles AddOccupancyTextBox.KeyDown
        ' Check if the pressed key is not a digit or control key
        If Not (Char.IsDigit(ChrW(e.KeyCode)) OrElse e.Control) Then
            ' Ignore the key press
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub AddRoomPriceTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AddRoomPriceTextBox.KeyPress
        ' Validate if the entered character is a digit or a decimal point
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "." OrElse Char.IsControl(e.KeyChar)) Then
            ' If not a digit or decimal point, ignore the key press
            e.Handled = True
        End If
    End Sub

    Private Sub UpdateRoomPriceTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UpdateRoomPriceTextBox.KeyPress
        ' Validate if the entered character is a digit or a decimal point
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "." OrElse Char.IsControl(e.KeyChar)) Then
            ' If not a digit or decimal point, ignore the key press
            e.Handled = True
        End If
    End Sub


End Class
