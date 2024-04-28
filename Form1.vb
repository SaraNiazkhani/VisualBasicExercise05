Public Class Form1
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Dim num As Integer
        num = Val(NumTextBox.Text)

        If (num < 0) Then
            OutPutLabel.Text = "The number is negative"
        ElseIf (num < 10) Then
            OutPutLabel.Text = "The number is less than 10"
        ElseIf (10 <= num < 20) Then
            OutPutLabel.Text = "The number is less than 20 and more than 10"
        ElseIf (20 <= num < 50) Then
            OutPutLabel.Text = "The number is less than 50 and more than 20"
        Else
            OutPutLabel.Text = "The number is less than 50"
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        OutPutLabel.Text = "End"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
