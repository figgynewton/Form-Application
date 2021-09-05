Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDouble.Click
        MsgBox(txtInput.Text * 2)
        txtInput.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnHalf.Click
        MsgBox(txtInput.Text / 2)
        txtInput.Text = ""
    End Sub
End Class

