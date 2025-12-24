Public Class ucRegister

    Private Sub ucRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub BtnSubmitRegistration_Click(sender As Object, e As EventArgs) Handles btnSubmitRegistration.Click

        If txtFullName.Text = "" Or txtEmail.Text = "" Or txtCourse.Text = "" Or txtDepartment.Text = "" Then
            MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        MessageBox.Show("Member registered successfully!", "Success")

    End Sub
    Private Sub btnCancelRegistration_Click(sender As Object, e As EventArgs) Handles btnCancelRegistration.Click


        txtFullName.Clear()
        txtEmail.Clear()
        txtCourse.Clear()
        txtDepartment.Clear()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub picRegisterIcon_Click(sender As Object, e As EventArgs) Handles picRegisterIcon.Click

    End Sub
End Class
