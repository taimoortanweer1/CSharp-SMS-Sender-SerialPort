Partial Class Form1
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
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
		Me.bttnConnect = New System.Windows.Forms.Button()
		Me.serialPort1 = New System.IO.Ports.SerialPort(Me.components)
		Me.cbCOM = New System.Windows.Forms.ComboBox()
		Me.bttnDisconnect = New System.Windows.Forms.Button()
		Me.bttnSaveSend = New System.Windows.Forms.Button()
		Me.rtbMessage = New System.Windows.Forms.RichTextBox()
		Me.rtbNumber = New System.Windows.Forms.RichTextBox()
		Me.SuspendLayout()
		' 
		' bttnConnect
		' 
		Me.bttnConnect.Location = New System.Drawing.Point(24, 20)
		Me.bttnConnect.Name = "bttnConnect"
		Me.bttnConnect.Size = New System.Drawing.Size(111, 39)
		Me.bttnConnect.TabIndex = 0
		Me.bttnConnect.Text = "Connect Phone"
		Me.bttnConnect.UseVisualStyleBackColor = True
		AddHandler Me.bttnConnect.Click, New System.EventHandler(AddressOf Me.bttnConnect_Click)
		' 
		' cbCOM
		' 
		Me.cbCOM.FormattingEnabled = True
		Me.cbCOM.Items.AddRange(New Object() {"Select Com Port", "COM1", "COM2", "COM3", "COM4", "COM5", _
			"COM6", "COM7", "COM8", "COM9", "COM10", "COM11", _
			"COM12", "COM13", "COM14", "COM15", "COM16", "COM17", _
			"COM18", "COM19", "COM20", "COM21", "COM22", "COM23", _
			"COM24"})
		Me.cbCOM.Location = New System.Drawing.Point(24, 65)
		Me.cbCOM.Name = "cbCOM"
		Me.cbCOM.Size = New System.Drawing.Size(225, 21)
		Me.cbCOM.TabIndex = 1
		AddHandler Me.cbCOM.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBox1_SelectedIndexChanged)
		' 
		' bttnDisconnect
		' 
		Me.bttnDisconnect.Location = New System.Drawing.Point(138, 20)
		Me.bttnDisconnect.Name = "bttnDisconnect"
		Me.bttnDisconnect.Size = New System.Drawing.Size(111, 39)
		Me.bttnDisconnect.TabIndex = 2
		Me.bttnDisconnect.Text = "Disconnect Phone"
		Me.bttnDisconnect.UseVisualStyleBackColor = True
		AddHandler Me.bttnDisconnect.Click, New System.EventHandler(AddressOf Me.bttnDisconnect_Click)
		' 
		' bttnSaveSend
		' 
		Me.bttnSaveSend.Location = New System.Drawing.Point(24, 266)
		Me.bttnSaveSend.Name = "bttnSaveSend"
		Me.bttnSaveSend.Size = New System.Drawing.Size(111, 39)
		Me.bttnSaveSend.TabIndex = 3
		Me.bttnSaveSend.Text = "Save and Send Message"
		Me.bttnSaveSend.UseVisualStyleBackColor = True
		AddHandler Me.bttnSaveSend.Click, New System.EventHandler(AddressOf Me.bttnSaveSend_Click)
		' 
		' rtbMessage
		' 
		Me.rtbMessage.Location = New System.Drawing.Point(24, 164)
		Me.rtbMessage.Name = "rtbMessage"
		Me.rtbMessage.Size = New System.Drawing.Size(225, 96)
		Me.rtbMessage.TabIndex = 4
		Me.rtbMessage.Text = "Message"
		' 
		' rtbNumber
		' 
		Me.rtbNumber.Location = New System.Drawing.Point(24, 130)
		Me.rtbNumber.Name = "rtbNumber"
		Me.rtbNumber.Size = New System.Drawing.Size(225, 28)
		Me.rtbNumber.TabIndex = 5
		Me.rtbNumber.Text = "Phone Number"
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(286, 350)
		Me.Controls.Add(Me.rtbNumber)
		Me.Controls.Add(Me.rtbMessage)
		Me.Controls.Add(Me.bttnSaveSend)
		Me.Controls.Add(Me.bttnDisconnect)
		Me.Controls.Add(Me.cbCOM)
		Me.Controls.Add(Me.bttnConnect)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private bttnConnect As System.Windows.Forms.Button
	Private serialPort1 As System.IO.Ports.SerialPort
	Private cbCOM As System.Windows.Forms.ComboBox
	Private bttnDisconnect As System.Windows.Forms.Button
	Private bttnSaveSend As System.Windows.Forms.Button
	Private rtbMessage As System.Windows.Forms.RichTextBox
	Private rtbNumber As System.Windows.Forms.RichTextBox
End Class

