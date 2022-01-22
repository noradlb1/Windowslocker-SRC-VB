Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Windowslocker
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()

			Me.TopMost = True
			Me.FormBorderStyle = FormBorderStyle.None
			Me.WindowState = FormWindowState.Maximized
			Me.KeyPreview = True

		End Sub

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick


		   ' if (this.WindowState == FormWindowState.Normal)
			'{
			 '   this.WindowState = FormWindowState.Maximized;
			'}

			'this.Activate();
		End Sub
		Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
			If _altF4Pressed Then
				If e.CloseReason = CloseReason.UserClosing Then
					e.Cancel = True
				End If
				_altF4Pressed = False
			End If
		End Sub

		Private _altF4Pressed As Boolean
		Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			If e.Alt AndAlso e.KeyCode = Keys.F4 Then
				_altF4Pressed = True
			End If
		End Sub
	End Class
End Namespace
