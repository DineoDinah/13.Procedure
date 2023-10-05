<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Label1 = New Label()
		TextBox1 = New TextBox()
		TextBox2 = New TextBox()
		TextBox3 = New TextBox()
		BtnSum = New Button()
		Label2 = New Label()
		Label3 = New Label()
		SuspendLayout()
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(133, 39)
		Label1.Name = "Label1"
		Label1.Size = New Size(63, 25)
		Label1.TabIndex = 1
		Label1.Text = "Label1"
		' 
		' TextBox1
		' 
		TextBox1.Location = New Point(294, 30)
		TextBox1.Name = "TextBox1"
		TextBox1.Size = New Size(150, 31)
		TextBox1.TabIndex = 2
		' 
		' TextBox2
		' 
		TextBox2.Location = New Point(294, 67)
		TextBox2.Name = "TextBox2"
		TextBox2.Size = New Size(150, 31)
		TextBox2.TabIndex = 2
		' 
		' TextBox3
		' 
		TextBox3.Location = New Point(294, 144)
		TextBox3.Name = "TextBox3"
		TextBox3.Size = New Size(150, 31)
		TextBox3.TabIndex = 2
		' 
		' BtnSum
		' 
		BtnSum.Location = New Point(72, 144)
		BtnSum.Name = "BtnSum"
		BtnSum.Size = New Size(112, 34)
		BtnSum.TabIndex = 0
		BtnSum.Text = "Sum"
		BtnSum.UseVisualStyleBackColor = True
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(59, 39)
		Label2.Name = "Label2"
		Label2.Size = New Size(160, 25)
		Label2.TabIndex = 1
		Label2.Text = "Enter First Number"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(59, 86)
		Label3.Name = "Label3"
		Label3.Size = New Size(186, 25)
		Label3.TabIndex = 1
		Label3.Text = "Enter Second Number"
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(TextBox3)
		Controls.Add(TextBox2)
		Controls.Add(TextBox1)
		Controls.Add(Label3)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Controls.Add(BtnSum)
		Name = "Form1"
		Text = "Form1"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents BtnSum As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
End Class
