Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Threading
Imports System.Data.OleDb

Public Partial Class Form1
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub bttnConnect_Click(sender As Object, e As EventArgs)
		Try
			If Me.serialPort1.IsOpen = False Then

				serialPort1.PortName = cbCOM.Text
				serialPort1.BaudRate = 9600
				serialPort1.DataBits = 8
				serialPort1.StopBits = System.IO.Ports.StopBits.One
				serialPort1.Parity = System.IO.Ports.Parity.None
				serialPort1.Open()
				MessageBox.Show(vbLf & "CONNECTED SUCESSFULLY" & vbLf, "Information")
			Else
				MessageBox.Show(vbLf & " ALREADY CONNECTED" & vbLf)
			End If
		Catch
			MessageBox.Show(vbLf & "Com Port connection fail", "Information")
		End Try

	End Sub

	Private Sub comboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

	End Sub

	Private Sub bttnDisconnect_Click(sender As Object, e As EventArgs)
		If Me.serialPort1.IsOpen Then

			serialPort1.Close()
		End If


	End Sub

	Private Sub bttnSaveSend_Click(sender As Object, e As EventArgs)
		Dim message As String
		Dim a As String = Char.ConvertFromUtf32(26)

		If Me.serialPort1.IsOpen Then
			'#Region "Message Sending"
			Try
				serialPort1.Write("AT+CMGF=1" & vbCr & vbLf)
				message = rtbMessage.Text
				serialPort1.Write("AT+CMGS=""" + rtbNumber.Text & """" & vbCr & vbLf)
				System.Threading.Thread.Sleep(1000)
				serialPort1.Write(message & a)
				Thread.Sleep(1000)


				MessageBox.Show(vbLf & "Message Sent" & vbLf, "Information")
			Catch
				MessageBox.Show("Message sending fail")
			End Try
			'#End Region

			'#Region "Database Insertion Block"
			Dim con As New OleDbConnection()
			Dim constring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb"
			con.ConnectionString = constring
			con.Open()
			Dim stb As New StringBuilder()
			stb.Append((("INSERT into Table1 (phone,message) " & " VALUES ('") + rtbNumber.Text & "','") + rtbMessage.Text & "')")

			Dim cmd As OleDbCommand = con.CreateCommand()
			cmd.CommandText = stb.ToString()
			cmd.CommandType = CommandType.Text
			cmd.ExecuteNonQuery()
			cmd.Dispose()
			con.Close()
				'#End Region
			MessageBox.Show("Insert Query Run Success Fully")
		Else
			MessageBox.Show("Phone Not Connected")
		End If
	End Sub
End Class
