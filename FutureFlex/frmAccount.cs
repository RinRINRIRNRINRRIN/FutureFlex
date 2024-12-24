using Bunifu.UI.WinForms;
using FutureFlex.SQL;
using Guna.UI2.WinForms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FutureFlex
{
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }


        BunifuSnackbar sk = new BunifuSnackbar();

        private void frmPrivilage_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < tbPrivilage.menuPrivilage.Count; i++)
            {
                if (tbPrivilage.menuPrivilage[i] == "account")
                {
                    btnAddEmployee.Visible = true;
                    break;
                }

            }

            // เช็คว่ามีสิทธ์ หรือไม่
            if (tbPrivilage.account.add == "False")
            {
                btnAddEmployee.Enabled = false;
            }

            txtFullName.Text = tbEmployeeSQL.emp_name;
            txtUsername.Text = tbEmployeeSQL.emp_username;
            txtPassword.Text = tbEmployeeSQL.emp_password;
        }


        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void BTN_CLICK(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;

            switch (btn.Tag)
            {
                case "employee":
                    frmPrivilage frmPrivilage = new frmPrivilage();
                    frmPrivilage.ShowDialog();
                    break;
                case "save":
                    // ตรวจสอบค่าว่าง
                    foreach (var txt in panel1.Controls.OfType<Guna2TextBox>())
                    {
                        if (txt.Text == "")
                        {
                            sk.Show(this, "กรุณากรอกข้อมูลให้ตรบก่อนการบันทึก", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                            return;
                        }
                    }

                    // เช็คว่ารหัสตรงหรือไม่
                    if (txtPassword.Text != txtCMPassword.Text)
                    {
                        sk.Show(this, "รหัสผ่านไม่ตรง", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                        return;
                    }

                    //บันทึก
                    if (tbEmployeeSQL.UPDATE(txtFullName.Text, txtUsername.Text, txtCMPassword.Text, tbEmployeeSQL.emp_username))
                    {
                        MessageBox.Show("แก้ไชข้อมูลผู้ใชงานสำเร็จ ระบบจะปิดโปรแกรมเพื่อให้ login เข้าใช้งานใหม่อีกครั้ง", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }

                    break;
                case "cancel":
                    panel1.Enabled = false;
                    panel2.Visible = false;
                    break;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbEmployeeSQL.emp_username == "sa")
            {
                MessageBox.Show("ไม่สามารถแก้ไขสิทธิ์ข้อมูลผู้ใช้ได้", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            panel1.Enabled = true;
            panel2.Visible = true;
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '\0';

                txtCMPassword.UseSystemPasswordChar = false;
                txtCMPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.PasswordChar = '*';

                txtCMPassword.UseSystemPasswordChar = true;
                txtCMPassword.PasswordChar = '*';
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // ตรวจสอบค่าว่าง
            foreach (var txt in panel1.Controls.OfType<Guna2TextBox>())
            {
                if (txt.Text == "")
                {
                    sk.Show(this, "กรุณากรอกข้อมูลให้ตรบก่อนการบันทึก", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                    return;
                }
            }

            // เช็คว่ารหัสตรงหรือไม่
            if (txtPassword.Text != txtCMPassword.Text)
            {
                sk.Show(this, "รหัสผ่านไม่ตรง", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                return;
            }

            //บันทึก
            if (tbEmployeeSQL.UPDATE(txtFullName.Text, txtUsername.Text, txtCMPassword.Text, tbEmployeeSQL.emp_username))
            {
                MessageBox.Show("แก้ไชข้อมูลผู้ใชงานสำเร็จ ระบบจะปิดโปรแกรมเพื่อให้ login เข้าใช้งานใหม่อีกครั้ง", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel2.Visible = false;
        }
    }
}
