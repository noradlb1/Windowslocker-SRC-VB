Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Threading
Imports System.Runtime.InteropServices
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Windowslocker
	Friend NotInheritable Class Program

		Private Sub New()
		End Sub

		''' <summary>Returns true if the current application has focus, false otherwise</summary>
		Public Shared Function ApplicationIsActivated() As Boolean
			Dim activatedHandle = GetForegroundWindow()
			If activatedHandle <> IntPtr.Zero Then

				Dim procId = Process.GetCurrentProcess().Id
				Dim activeProcId As Integer
				GetWindowThreadProcessId(activatedHandle, activeProcId)

				Return activeProcId = procId
			End If
			Return False ' No window is currently activated
		End Function


		<DllImport("user32.dll", CharSet:=CharSet.Auto, ExactSpelling:=True)>
		Private Shared Function GetForegroundWindow() As IntPtr
		End Function

		<DllImport("user32.dll", CharSet := CharSet.Auto, SetLastError := True)> _
		Private Shared Function GetWindowThreadProcessId(ByVal handle As IntPtr, ByRef processId As Integer) As Integer
		End Function
		Private Shared Sub checker()

			If ApplicationIsActivated() Then
				Console.WriteLine(False)
			End If
			System.Threading.Thread.Sleep(1000)
		End Sub
		Private Shared Sub tbN1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
			Dim sKeys As String = "1234567890ABCDEF"
			If Not sKeys.Contains(e.KeyChar.ToString().ToUpper()) Then
				e.Handled = True
			End If
		End Sub
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Dim t As New Thread(AddressOf checker)
			t.Start()

			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())

		End Sub
	End Class
End Namespace
