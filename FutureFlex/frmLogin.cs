using FutureFlex.SQL;
using Guna.UI2.WinForms;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureFlex
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            pnUsername.Visible = false;
            gbConnection.Visible = true;

        }

        void Login()
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบก่อนเข้าสู่ระบบ", "เข้าสู่ระบบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbEmployeeSQL.LOGIN(txtUsername.Text, txtPassword.Text))
            {
                txtUsername.Clear();
                txtPassword.Clear();
                MessageBox.Show("เข้าสู่ระบบสำเร็จ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmMain frm = new frmMain();
                for (int i = 0; i < tbPrivilage.menuPrivilage.Count; i++)
                {
                    string menu = tbPrivilage.menuPrivilage[i];

                    foreach (var btn in frm.Controls.OfType<Guna2Button>())
                    {
                        if (menu == btn.Tag)
                        {
                            btn.Enabled = true;
                        }
                    }
                }
                frm.Show();
                this.Hide();
            }
            else
            {
                txtUsername.Clear();
                txtPassword.Clear();
                MessageBox.Show("ผู้ใช้ หรือ รหัสผ่านไม่ถูกต้อง", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
        }

        private async void frmLogin_Load(object sender, EventArgs e)
        {
            // เช็คโปรแกรมว่ามีเปิดซ้ำหรือไม่
            if (Function.Function.CHECK_PROGRAM())
            {
                // ทดสอบเชื่อมต่อฐานข้อมูล
                if (await server.ConnectDatabase())
                {
                    await Task.Delay(900);
                    label1.Text = "Connect success";
                    await Task.Delay(1000);
                    gbConnection.Visible = false;
                    pnUsername.Visible = true;
                    txtUsername.Focus();
                }
                else
                {
                    label1.Text = "Connect fail";
                    MessageBox.Show("ไม่สามารถเชื่อมต่อฐานข้อมูลได้", "Error connect database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("มีโปรแกรมเปิดอยู่แล้ว", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '\0';
            }
            else if (cbShowPassword.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.PasswordChar = '*';
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {

        }


        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
