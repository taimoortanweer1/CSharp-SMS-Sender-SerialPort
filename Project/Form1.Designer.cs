namespace Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bttnConnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cbCOM = new System.Windows.Forms.ComboBox();
            this.bttnDisconnect = new System.Windows.Forms.Button();
            this.bttnSaveSend = new System.Windows.Forms.Button();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.rtbNumber = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bttnConnect
            // 
            this.bttnConnect.Location = new System.Drawing.Point(24, 20);
            this.bttnConnect.Name = "bttnConnect";
            this.bttnConnect.Size = new System.Drawing.Size(111, 39);
            this.bttnConnect.TabIndex = 0;
            this.bttnConnect.Text = "Connect Phone";
            this.bttnConnect.UseVisualStyleBackColor = true;
            this.bttnConnect.Click += new System.EventHandler(this.bttnConnect_Click);
            // 
            // cbCOM
            // 
            this.cbCOM.FormattingEnabled = true;
            this.cbCOM.Items.AddRange(new object[] {
            "Select Com Port",
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20",
            "COM21",
            "COM22",
            "COM23",
            "COM24"});
            this.cbCOM.Location = new System.Drawing.Point(24, 65);
            this.cbCOM.Name = "cbCOM";
            this.cbCOM.Size = new System.Drawing.Size(225, 21);
            this.cbCOM.TabIndex = 1;
            this.cbCOM.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bttnDisconnect
            // 
            this.bttnDisconnect.Location = new System.Drawing.Point(138, 20);
            this.bttnDisconnect.Name = "bttnDisconnect";
            this.bttnDisconnect.Size = new System.Drawing.Size(111, 39);
            this.bttnDisconnect.TabIndex = 2;
            this.bttnDisconnect.Text = "Disconnect Phone";
            this.bttnDisconnect.UseVisualStyleBackColor = true;
            this.bttnDisconnect.Click += new System.EventHandler(this.bttnDisconnect_Click);
            // 
            // bttnSaveSend
            // 
            this.bttnSaveSend.Location = new System.Drawing.Point(24, 266);
            this.bttnSaveSend.Name = "bttnSaveSend";
            this.bttnSaveSend.Size = new System.Drawing.Size(111, 39);
            this.bttnSaveSend.TabIndex = 3;
            this.bttnSaveSend.Text = "Save and Send Message";
            this.bttnSaveSend.UseVisualStyleBackColor = true;
            this.bttnSaveSend.Click += new System.EventHandler(this.bttnSaveSend_Click);
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(24, 164);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(225, 96);
            this.rtbMessage.TabIndex = 4;
            this.rtbMessage.Text = "Message";
            // 
            // rtbNumber
            // 
            this.rtbNumber.Location = new System.Drawing.Point(24, 130);
            this.rtbNumber.Name = "rtbNumber";
            this.rtbNumber.Size = new System.Drawing.Size(225, 28);
            this.rtbNumber.TabIndex = 5;
            this.rtbNumber.Text = "Phone Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 350);
            this.Controls.Add(this.rtbNumber);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.bttnSaveSend);
            this.Controls.Add(this.bttnDisconnect);
            this.Controls.Add(this.cbCOM);
            this.Controls.Add(this.bttnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnConnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cbCOM;
        private System.Windows.Forms.Button bttnDisconnect;
        private System.Windows.Forms.Button bttnSaveSend;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.RichTextBox rtbNumber;
    }
}

