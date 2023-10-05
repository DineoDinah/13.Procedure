Public Class Form1
	Private Sub BtnSum_Click(sender As Object, e As EventArgs) Handles BtnSum.Click

		Dim FirstNumber, SecondNumber As Integer
		FirstNumber = Val(TextBox1.Text)
		SecondNumber = Val(TextBox2.Text)

		Sum(FirstNumber, SecondNumber)

	End Sub
	Sub sum(a As Integer, b As Integer)
		Dim total As Integer

		total = a + b

		TextBox3.Text = total
	End Sub
End Class
