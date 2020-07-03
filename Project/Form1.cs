using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.serialPort1.IsOpen == false)
                {
   
                    serialPort1.PortName = cbCOM.Text;
                    serialPort1.BaudRate = 9600;
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = System.IO.Ports.StopBits.One;
                    serialPort1.Parity = System.IO.Ports.Parity.None;
                    serialPort1.Open();
                    MessageBox.Show("\nCONNECTED SUCESSFULLY\n", "Information");                    
                }
                else
                {
                    MessageBox.Show("\n ALREADY CONNECTED\n");
                }
            }
            catch
            {
                MessageBox.Show("\nCom Port connection fail", "Information");
            }
   
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bttnDisconnect_Click(object sender, EventArgs e)
        {
                if (this.serialPort1.IsOpen)
                {
                    serialPort1.Close();

                }

            
        }

        private void bttnSaveSend_Click(object sender, EventArgs e)
        {
            string message;
            string a = char.ConvertFromUtf32(26);

            if (this.serialPort1.IsOpen)
            {
                #region Message Sending
                try
                {
                    serialPort1.Write("AT+CMGF=1\r\n");
                    message = rtbMessage.Text;
                    serialPort1.Write("AT+CMGS=\"" + rtbNumber.Text + "\"\r\n");
                    System.Threading.Thread.Sleep(1000);
                    serialPort1.Write(message + a);                    
                    Thread.Sleep(1000);
                    MessageBox.Show("\nMessage Sent\n", "Information");

                    
                }
                catch
                {
                    MessageBox.Show("Message sending fail");
                }
                #endregion

                #region Database Insertion Block
                OleDbConnection con = new OleDbConnection();
                string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";
                con.ConnectionString = constring;
                con.Open();
                StringBuilder stb = new StringBuilder();
                stb.Append("INSERT into Table1 (phone,message) " + " VALUES ('" + rtbNumber.Text + "','" + rtbMessage.Text  + "')");
                
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = stb.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Insert Query Run Success Fully");
                #endregion
            }
            else
            {
                MessageBox.Show("Phone Not Connected");
            }
        }
    }
}
