using FutureFlex.SQL;
using Guna.UI2.WinForms;
using Serilog;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureFlex
{
    public partial class frmNewLogin : Form
    {
        public frmNewLogin()
        {
            InitializeComponent();
            Log.Logger = new LoggerConfiguration()
.WriteTo.File(Application.StartupPath + "\\Logs\\log-.txt", rollingInterval: RollingInterval.Day)
.CreateLogger();
        }
        void Login()
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                Log.Information("พบผู้ใช้ไม่กรอกข้อมูล username หรือ password ไม่ครบ");
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบก่อนเข้าสู่ระบบ", "เข้าสู่ระบบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbEmployeeSQL.LOGIN(txtUsername.Text, txtPassword.Text))
            {
                Log.Information("เข้าสู่ระบบสำเร็จ");
                txtUsername.Clear();
                txtPassword.Clear();
                MessageBox.Show("เข้าสู่ระบบสำเร็จ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmMain frm = new frmMain();
                for (int i = 0; i < tbPrivilage.menuPrivilage.Count; i++)
                {
                    Log.Information($"== เมนูที่เปิด {tbPrivilage.menuPrivilage[i]}");
                    string menu = tbPrivilage.menuPrivilage[i];

                    foreach (var btn in frm.Controls.OfType<Guna2Button>())
                    {
                        if (menu == btn.Tag)
                        {
                            btn.Enabled = true;
                            Log.Information($"- ฟังชั่นที่เปิด {btn.Text}");
                        }
                    }
                }


                frm.Show();
                this.Hide();
            }
            else
            {
                Log.Information("พบผู้ใช้ไม่กรอกข้อมูล username หรือ password ไม่ถูกต้อง");
                txtUsername.Clear();
                txtPassword.Clear();
                MessageBox.Show("ผู้ใช้ หรือ รหัสผ่านไม่ถูกต้อง", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
        }

        private async void frmNewLogin_Load(object sender, System.EventArgs e)
        {
            Log.Information("=================================================================  Open program");

            // เช็คโปรแกรมว่ามีเปิดซ้ำหรือไม่
            if (Function.Function.CHECK_PROGRAM())
            {
                int x = (this.Width - gbConnection.Width) / 2;
                int y = (this.Height - gbConnection.Height) / 2;
                gbConnection.Location = new System.Drawing.Point(x, y);
                gbConnection.Show();
                gbConnection.Visible = true;
                // ทดสอบเชื่อมต่อฐานข้อมูล
                if (await server.ConnectDatabase())
                {
                    Log.Warning("เชื่อมต่อฐานข้อมูลสำเร็จ");
                    await Task.Delay(900);
                    label1.Text = "Connect success";
                    await Task.Delay(1000);
                    gbConnection.Visible = false;

                    btnLogin.Enabled = true;
                    txtUsername.Focus();
                }
                else
                {
                    Log.Warning("ไม่สามารถเชื่อมต่อฐานข้อมูลได้");
                    label1.Text = "Connect fail";
                    txtPassword.Enabled = false;
                    txtUsername.Enabled = false;
                    MessageBox.Show("ไม่สามารถเชื่อมต่อฐานข้อมูลได้", "Error connect database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Log.Warning("พบโปรแกรมเปิดอยู่");
                MessageBox.Show("มีโปรแกรมเปิดอยู่แล้ว", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Log.Information("=================================================================  Program is closing");
                Application.Exit();
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, System.EventArgs e)
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

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            Login();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Login();
        }

        private void frmNewLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                frmConnect frmConnect = new frmConnect();
                frmConnect.ShowDialog();
            }
        }
    }
}
