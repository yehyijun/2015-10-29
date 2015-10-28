Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnlg_click(sender As Object, e As EventArgs) Handles btnlg.Click
        If txtusername.Text = "" And txtpassword.Text = "" Then
            txtusername.BackColor = Color.MistyRose
            txtpassword.BackColor = Color.MistyRose
        End If

        If txtusername.Text = "login" Then
            txtusername.BackColor = Color.White
        Else
            txtusername.BackColor = Color.MistyRose
        End If

        If txtpassword.Text = "abc123" Then
            txtpassword.BackColor = Color.White
        Else
            txtpassword.BackColor = Color.MistyRose
        End If

        If txtusername.Text = "login" And txtpassword.Text = "abc123" Then
            MessageBox.Show("帳號密碼正確")
            Application.Exit()
        End If
    End Sub

    Private Sub btnexit_click(sender As Object, e As EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub

End Class
