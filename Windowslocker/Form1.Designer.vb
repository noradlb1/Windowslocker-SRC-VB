Namespace Windowslocker
	Partial Public Class Form1
	   ''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
            Me.SuspendLayout()
            '
            'timer1
            '
            '
            'richTextBox1
            '
            Me.richTextBox1.Location = New System.Drawing.Point(-1, -2)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.Size = New System.Drawing.Size(1153, 730)
            Me.richTextBox1.TabIndex = 0
            Me.richTextBox1.Text = ""
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1647, 1061)
            Me.ControlBox = False
            Me.Controls.Add(Me.richTextBox1)
            Me.Name = "Form1"
            Me.Opacity = 0.04R
            Me.Text = "Form1"
            Me.TopMost = True
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents timer1 As System.Windows.Forms.Timer
		Private richTextBox1 As System.Windows.Forms.RichTextBox
	End Class
End Namespace

