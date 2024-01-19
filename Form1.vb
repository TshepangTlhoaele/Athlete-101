Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declaration of variables
        Dim height, weight, bmi As Double
        weight = Val(TextBox1.Text)
        height = Val(TextBox2.Text)

        bmi = weight / (height) ^ 2 'BMI formula

        TextBox3.Text = bmi

        If bmi < 18 Then
            TextBox4.Text = "You are underweight"
        ElseIf 18 <= bmi And bmi < 26 Then
            TextBox4.Text = "You are normal"
        Else
            TextBox4.Text = "You are overweight"
        End If
    End Sub
End Class
