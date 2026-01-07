Imports System.Data.OleDb
Imports System.Data

Public Class ucRegister

    Private ReadOnly connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UniClubDB BD.accdb"

    Private Sub ucRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub BtnSubmitRegistration_Click(sender As Object, e As EventArgs) Handles btnSubmitRegistration.Click
        ' Validate required fields
        If txtFullName.Text.Trim() = "" OrElse
       txtEmail.Text.Trim() = "" OrElse
       txtCourse.Text.Trim() = "" OrElse
       txtDepartment.Text.Trim() = "" Then

            MessageBox.Show("Please fill in all required fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Basic email check
        If Not txtEmail.Text.Contains("@") OrElse Not txtEmail.Text.Contains(".") Then
            MessageBox.Show("Please enter a valid email address", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Call the saved Access query named "AddMemberQuery".
        ' The saved query must accept parameters in the order provided below.
        ' Expected parameter order in the saved query: FullName, Email, Course, Department, PhoneNumber, JoinDate
        Try
            Dim sql As String = "INSERT INTO Members (FullName, Email, Course, Department, PhoneNumber, JoinDate) VALUES (?,?,?,?,?,?)"
            Using conn As New OleDbConnection(connString)
                Using cmd As New OleDbCommand("AddMemberQuery", conn)
                    cmd.CommandType = CommandType.StoredProcedure

                    ' OleDb for Access uses positional parameters; names here are for clarity only.
                    cmd.Parameters.AddWithValue("@MemberID", TextBox2.Text.Trim())
                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@Department", txtDepartment.Text.Trim())
                    cmd.Parameters.AddWithValue("@PhoneNumber", TextBox1.Text.Trim())
                    cmd.Parameters.AddWithValue("@Course", txtCourse.Text.Trim())
                    cmd.Parameters.AddWithValue("@JoinDate", DateTime.Now)

                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    conn.Close()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Member registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Clear form
                        txtFullName.Clear()
                        txtEmail.Clear()
                        txtCourse.Clear()
                        txtDepartment.Clear()
                        TextBox1.Clear()
                        TextBox2.Clear()
                    Else
                        MessageBox.Show("Registration failed: no rows were inserted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving member: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelRegistration_Click(sender As Object, e As EventArgs) Handles btnCancelRegistration.Click
        txtFullName.Clear()
        txtEmail.Clear()
        txtCourse.Clear()
        txtDepartment.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

End Class