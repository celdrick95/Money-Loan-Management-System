Imports System.Data.OleDb

Public Class frmAccount

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        con.Open()

        Dim daLogin As New OleDbDataAdapter("SELECT * FROM LoginInfo WHERE Username='" & txtUsername.Text &
                                            "' AND Password='" & txtPassword.Text & "'", con)
        Dim dtLogin As New DataTable

        daLogin.Fill(dtLogin)

        If dtLogin.Rows.Count > 0 Then
            Me.Hide()
            frmMoneyLoan.Show()
        Else
            MessageBox.Show("Access denied.", "Log-in", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()
        End If
        con.Close()

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class