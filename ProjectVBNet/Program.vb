Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

NotInheritable Class Program
	Private Sub New()
	End Sub
	''' <summary>
	''' The main entry point for the application.
	''' </summary>
    <STAThread()> _
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Form1())
    End Sub
End Class
