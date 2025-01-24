using FutureFlex.Function;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureFlex
{
    public partial class frmTcpClientServer : Form
    {
        public frmTcpClientServer()
        {
            InitializeComponent();
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            switch (btnConnect.Text)
            {
                case "Connect":
                    btnConnect.Enabled = false;
                    if (await func_tcpClient.Connect())
                    {

                        btnConnect.Text = "Disconnect";
                        _ = Task.Run(() =>
                        {
                            GetMessage();
                        });
                    }
                    else
                    {
                        MessageBox.Show(func_tcpClient.ERR);
                    }
                    btnConnect.Enabled = true;
                    break;
                case "Disconnect":
                    if (await func_tcpClient.Disconnect())
                    {
                        btnConnect.Text = "Connect";
                    }
                    else
                    {
                        MessageBox.Show(func_tcpClient.ERR);
                    }
                    break;
            }
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        async void GetMessage()
        {
            string old_data = "";
            while (true)
            {
                if (func_tcpClient.ConnectState)
                {
                    string message = func_tcpClient.ReceiveData;
                    if (message != null)
                    {
                        BeginInvoke(new MethodInvoker(delegate ()
                        {
                            richTextBox1.SelectionColor = Color.Blue;
                            richTextBox1.AppendText(message);
                            richTextBox1.ScrollToCaret();
                        }));
                        func_tcpClient.ReceiveData = null;
                    }
                }
                else
                {
                    if (btnConnect.Text == "Disconnect")
                    {
                        MessageBox.Show("Server is offline");
                        BeginInvoke(new MethodInvoker(delegate ()
                        {
                            btnConnect.Text = "Connect";
                        }));
                    }
                    return;
                }


                await Task.Delay(500);
            }
        }

        private async void guna2TextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMessage.Text != "")
                {
                    if (await func_tcpClient.SendDataAsync(txtMessage.Text))
                    {
                        richTextBox1.SelectionColor = Color.Red;
                        richTextBox1.AppendText($"Me : {txtMessage.Text}");
                        richTextBox1.ScrollToCaret();
                        txtMessage.Clear();
                    }
                }
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
