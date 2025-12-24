Public Class ucEvents

    Private EventsList As New List(Of String)
    Private lstEvents As Object

    Private Sub ucEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAddEvent_Click(sender As Object, e As EventArgs)

        If txtEventName.Text = "" Or txtVenue.Text = "" Then
            MessageBox.Show("Please fill all fields")
            Exit Sub
        End If

        Dim eventDetails =
            txtEventName.Text & " | " &
            DateTimePicker1.Value.ToShortDateString & " | " &
            txtVenue.Text

        EventsList.Add(eventDetails)
        lstEvents.Items.Add(eventDetails)

        MessageBox.Show("Event added successfully")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        txtEventName.Clear
        txtVenue.Clear
        DateTimePicker1.Value = Date.Now
    End Sub

    Private Sub lblCourse_Click(sender As Object, e As EventArgs) Handles lblSpeaker.Click

    End Sub

    Private Sub btnAddEvent_Click_1(sender As Object, e As EventArgs) Handles btnAddEvent.Click


        If txtEventName.Text.Trim() = "" Or
       txtVenue.Text.Trim() = "" Or
       txtLocation.Text.Trim() = "" Then

            MessageBox.Show("Please fill in all fields.",
                        "Missing Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            Exit Sub
        End If


        MessageBox.Show("Event saved successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)
    End Sub

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEventName.Clear()
        txtVenue.Clear()
        txtLocation.Clear()
        DateTimePicker1.Value = Date.Now
    End Sub
End Class
