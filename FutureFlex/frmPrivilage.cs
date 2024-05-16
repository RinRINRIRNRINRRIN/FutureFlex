using Bunifu.UI.WinForms;
using FutureFlex.SQL;
using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureFlex
{
    public partial class frmPrivilage : Form
    {
        public frmPrivilage()
        {
            InitializeComponent();
            this.Size = new Size(879, 564);
        }

        string emp_username = null; // ตัวแปรสำหรับเก็บ username เมื่อกด ลบ แก้ไข กำหนดสิทธิ์

        BunifuSnackbar sk = new BunifuSnackbar();  //Notify Control


        async Task SHOW_CENTER_SCREEN(Guna2GroupBox gb)
        {
            int x = (gbMain.Width - gb.Width) / 2;
            int y = (gbMain.Height - gb.Height) / 2;
            gb.Location = new System.Drawing.Point(x, y);
            gnTran.ShowSync(gb);
            await Task.Delay(100);
        }



        private void frmPrivilage_Load(object sender, EventArgs e)
        {
            dgvEmployee.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Athiti", 12, System.Drawing.FontStyle.Regular);
            dgvEmployee.DefaultCellStyle.Font = new System.Drawing.Font("Athiti", 12, System.Drawing.FontStyle.Regular);
            dgvEmployee.DefaultCellStyle.ForeColor = Color.Black;
            dgvEmployee.Columns["cl_emp_state"].Visible = false;
            dgvEmployee.RowTemplate.Height = 30;
            cbbType.SelectedIndex = 0;

            dgvEmployee.DataSource = tbEmployeeSQL.SELECTDATA();
        }

        private async void btnAddAccount_Click(object sender, EventArgs e)
        {
            pnDetail.Visible = false;
            await SHOW_CENTER_SCREEN(gbEmployee);
        }

        private void BTN_CLOSE(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            switch (btn.Tag)
            {

                case "employee":
                    foreach (var txt in gbEmployee.Controls.OfType<Guna2TextBox>())
                    {
                        txt.Clear();
                    }
                    emp_username = null;
                    gbEmployee.Visible = false;
                    pnDetail.Visible = true;
                    break;
                case "privilage":

                    foreach (var cb in gbPrivilage.Controls.OfType<Guna2CheckBox>())
                    {
                        cb.Checked = false;
                    }

                    foreach (var tgs in gbPrivilage.Controls.OfType<BunifuToggleSwitch>())
                    {
                        tgs.Checked = false;
                    }
                    gbPrivilage.Visible = false;
                    pnDetail.Visible = true;
                    break;
            }
        }

        private void BTN_SAVE(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;

            switch (btn.Tag)
            {
                case "employee":
                    // เช็คค่าว่างก่อนการบันทึก
                    foreach (Guna2TextBox txt in gbEmployee.Controls.OfType<Guna2TextBox>())
                    {
                        if (txt.Text == "")
                        {
                            sk.Show(this, "กรุณากรอกข้อมูลให้ครบก่อนการบันทึก", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                            return;
                        }
                    }

                    // เช็คว่ารหัสตรงกันไหม
                    if (txtPassword.Text != txtCMPassword.Text)
                    {
                        sk.Show(this, "รหัสผ่าน ไม่ตรงกัน โปรดตรวจสอบ", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                        return;
                    }

                    // เช็คว่าเป็น INSERT OR UPDATE
                    if (emp_username == null) // INSERT
                    {
                        // บันทึก
                        if (tbEmployeeSQL.INSERTDATA(txtFullname.Text, txtUsername.Text, txtCMPassword.Text))
                        {
                            // เครียค่า
                            foreach (Guna2TextBox txt in gbEmployee.Controls.OfType<Guna2TextBox>())
                            {
                                txt.Clear();
                            }

                            gbEmployee.Visible = false;
                            pnDetail.Visible = true;
                            dgvEmployee.DataSource = tbEmployeeSQL.SELECTDATA();

                            sk.Show(this, "เพิ่มข้อมูลผู้ใช้สำเร็จ", BunifuSnackbar.MessageTypes.Success, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                        }
                        else
                        {
                            sk.Show(this, tbEmployeeSQL.ERR, BunifuSnackbar.MessageTypes.Error, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                        }
                    }
                    else // UPDATE
                    {
                        if (tbEmployeeSQL.UPDATE(txtFullname.Text, txtUsername.Text, txtCMPassword.Text, emp_username))
                        {
                            gbEmployee.Visible = false;
                            pnDetail.Visible = true;
                            dgvEmployee.DataSource = tbEmployeeSQL.SELECTDATA();

                            sk.Show(this, "แก้ไขข้อมูลผู้ใช้ สำเร็จ", BunifuSnackbar.MessageTypes.Success, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                            emp_username = null;
                        }
                        else
                        {
                            sk.Show(this, tbEmployeeSQL.ERR, BunifuSnackbar.MessageTypes.Error, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                        }


                    }

                    break;
                case "privilage":

                    if (tbPrivilage.DELETE(emp_username))
                    {
                        // เปิดสิทธิ์หน้าชั่ง
                        if (tgsWghDel.Checked || tgsWghEdit.Checked)
                        {
                            if (!tbPrivilage.INSERT(emp_username, "weight", "False", tgsWghDel.Checked.ToString(), tgsWghEdit.Checked.ToString()))
                            {
                                tbPrivilage.DELETE(emp_username);
                            }
                        }
                        // เปิดสิทธิ์หน้าแก้ไข
                        if (cbSetting.Checked)
                        {
                            if (!tbPrivilage.INSERT(emp_username, "setting", "False", "False", "False"))
                            {
                                tbPrivilage.DELETE(emp_username);
                            }
                        }
                        // เปิดสิทธิ์หน้ากำหนดสิทธื
                        if (cbAccount.Checked)
                        {
                            if (!tbPrivilage.INSERT(emp_username, "account", tgsAccAdd.Checked.ToString(), tgsAccDel.Checked.ToString(), tgsAccEdit.Checked.ToString()))
                            {
                                tbPrivilage.DELETE(emp_username);
                            }
                        }
                        // เปิดสิทธิ์ Reprint
                        if (cbReprintJIT.Checked)
                        {
                            if (!tbPrivilage.INSERT(emp_username, "reprintJIT", "False", "False", "False"))
                            {
                                tbPrivilage.DELETE(emp_username);
                            }
                        }

                        if (tgsAccPri.Checked)
                        {
                            if (!tbPrivilage.INSERT(emp_username, "privilage", "False", "False", "False"))
                            {
                                tbPrivilage.DELETE(emp_username);
                            }
                        }

                        if (cbHistory.Checked)
                        {
                            if (!tbPrivilage.INSERT(emp_username, "history", "False", "False", "False"))
                            {
                                tbPrivilage.DELETE(emp_username);
                            }
                        }
                    }

                    gbPrivilage.Visible = false;
                    pnDetail.Visible = true;
                    emp_username = null;

                    sk.Show(this, "กำหนดสิทธิ์การใช้งานสำเร็จ", BunifuSnackbar.MessageTypes.Success, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                    break;
            }
        }

        private async void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string columnName = dgvEmployee.Columns[e.ColumnIndex].Name.ToString();
                string fullName = dgvEmployee.Rows[e.RowIndex].Cells["cl_emp_name"].Value.ToString();
                string username = dgvEmployee.Rows[e.RowIndex].Cells["cl_emp_username"].Value.ToString();
                string password = dgvEmployee.Rows[e.RowIndex].Cells["cl_emp_password"].Value.ToString();

                switch (columnName)
                {
                    case "cl_del":
                        if (username == "sa")
                        {
                            sk.Show(this, "ไม่สามารถ ลบ, แก้ไข หรือ กำหนสิทธื์การใช้งาน กับสิทธิ์สุงสุดของระบบได้ได้", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                            return;
                        }

                        DialogResult dialog = MessageBox.Show($"คุณต้องการลบผู้ใช้ {fullName} ออกจากระบบหรือไม่", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            if (tbEmployeeSQL.DELETE(username))
                            {
                                sk.Show(this, $"ลบผู้ใช้ {fullName} ออกจากระบบสำเร็จ", BunifuSnackbar.MessageTypes.Success, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                                dgvEmployee.DataSource = tbEmployeeSQL.SELECTDATA();
                            }
                            else
                            {
                                sk.Show(this, tbEmployeeSQL.ERR, BunifuSnackbar.MessageTypes.Error, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                                return;
                            }
                        }
                        break;
                    case "cl_edit":
                        if (username == "sa")
                        {
                            sk.Show(this, "ไม่สามารถ ลบ, แก้ไข หรือ กำหนสิทธื์การใช้งาน กับสิทธิ์สุงสุดของระบบได้ได้", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                            return;
                        }
                        emp_username = username;
                        pnDetail.Visible = false;

                        txtFullname.Text = fullName;
                        txtUsername.Text = username;
                        txtPassword.Text = password;

                        await SHOW_CENTER_SCREEN(gbEmployee);
                        break;
                    case "cl_privilage":
                        if (username == "sa")
                        {
                            sk.Show(this, "ไม่สามารถ ลบ, แก้ไข หรือ กำหนสิทธื์การใช้งาน กับสิทธิ์สุงสุดของระบบได้ได้", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                            return;
                        }

                        pnDetail.Visible = false;
                        await SHOW_CENTER_SCREEN(gbPrivilage);
                        emp_username = username;
                        // เช็คว่ามีสิทธิ์ในระบบหรือไม่
                        if (tbPrivilage.CheckPrivilage(emp_username))
                        {
                            DataTable tb = new DataTable();
                            for (int i = 0; i < tbPrivilage.menuPrivilage.Count; i++)
                            {
                                string _menuName = tbPrivilage.menuPrivilage[i];
                                switch (_menuName)
                                {
                                    case "account":
                                        cbAccount.Checked = true;
                                        tb = tbPrivilage.CheckPrivilageMenu(emp_username, _menuName);
                                        if (tb.Rows.Count != 0)
                                        {
                                            foreach (DataRow rw in tb.Rows)
                                            {
                                                string add = rw["pri_add"].ToString();
                                                string edit = rw["pri_edit"].ToString();
                                                string del = rw["pri_del"].ToString();

                                                if (add == "True")
                                                {
                                                    tgsAccAdd.Checked = true;
                                                }
                                                if (edit == "True")
                                                {
                                                    tgsWghDel.Checked = true;
                                                }

                                                if (del == "True")
                                                {
                                                    tgsWghEdit.Checked = true;
                                                }
                                            }
                                        }
                                        break;
                                    case "privilage":
                                        tgsAccPri.Checked = true;
                                        break;
                                    case "setting":
                                        cbSetting.Checked = true;
                                        break;
                                    case "weight":
                                        cbWeight.Checked = true;
                                        tb = tbPrivilage.CheckPrivilageMenu(emp_username, _menuName);
                                        if (tb.Rows.Count != 0)
                                        {
                                            foreach (DataRow rw in tb.Rows)
                                            {
                                                string edit = rw["pri_edit"].ToString();
                                                string del = rw["pri_del"].ToString();

                                                if (edit == "True")
                                                {
                                                    tgsWghDel.Checked = true;
                                                }

                                                if (del == "True")
                                                {
                                                    tgsWghEdit.Checked = true;
                                                }
                                            }
                                        }
                                        break;
                                    case "reprintJIT":
                                        cbReprintJIT.Checked = true;
                                        break;
                                    case "history":
                                        cbHistory.Checked = true;
                                        break;
                                }
                            }
                        }
                        break;
                }
            }
            catch (Exception)
            {

            }
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

        private void CHECKBOX_CHECKED(object sender, EventArgs e)
        {
            Guna2CheckBox cb = sender as Guna2CheckBox;

            switch (cb.Tag)
            {
                case "account":
                    if (cb.Checked == false)
                    {
                        tgsAccAdd.Checked = false;
                        tgsAccDel.Checked = false;
                        tgsAccEdit.Checked = false;
                        tgsAccPri.Checked = false;
                    }
                    else if (cb.Checked == true)
                    {
                        DataTable tb = tbPrivilage.CheckPrivilageMenu(emp_username, cb.Tag.ToString());
                        if (tb.Rows.Count != 0)
                        {
                            foreach (DataRow rw in tb.Rows)
                            {
                                string add = rw["pri_add"].ToString();
                                string edit = rw["pri_edit"].ToString();
                                string del = rw["pri_del"].ToString();

                                if (add == "True")
                                {
                                    tgsAccAdd.Checked = true;
                                }

                                if (edit == "True")
                                {
                                    tgsAccEdit.Checked = true;
                                }

                                if (del == "True")
                                {
                                    tgsAccDel.Checked = true;
                                }
                            }
                        }
                        tb = tbPrivilage.CheckPrivilageMenu(emp_username, "privilage");
                        if (tb.Rows.Count != 0)
                        {
                            tgsAccPri.Checked = true;
                        }
                    }
                    break;
                case "setting":
                    break;
                case "weight":
                    if (cb.Checked == false)
                    {
                        tgsWghDel.Checked = false;
                        tgsWghEdit.Checked = false;
                    }
                    else if (cb.Checked == true)
                    {
                        DataTable tb = tbPrivilage.CheckPrivilageMenu(emp_username, cb.Tag.ToString());
                        if (tb.Rows.Count != 0)
                        {
                            foreach (DataRow rw in tb.Rows)
                            {
                                string edit = rw["pri_edit"].ToString();
                                string del = rw["pri_del"].ToString();

                                if (edit == "True")
                                {
                                    tgsWghDel.Checked = true;
                                }

                                if (del == "True")
                                {
                                    tgsWghEdit.Checked = true;
                                }
                            }
                        }
                    }
                    break;
                case "reprintJIT":
                    break;
                case "history":
                    break;
            }
        }

        private void TOGLE_CHECK(object sender, BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            BunifuToggleSwitch tgs = sender as BunifuToggleSwitch;
            if (tgs.Checked)
            {
                switch (tgs.Tag)
                {
                    case "weight":
                        cbWeight.Checked = true;
                        break;
                    case "account":
                        cbAccount.Checked = true;
                        break;
                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSearch.Text != "")
                {
                    string columnName = null;
                    switch (cbbType.SelectedIndex)
                    {
                        case 0:
                            columnName = "emp_username";
                            break;
                        case 1:
                            columnName = "emp_name";
                            break;
                    }

                    dgvEmployee.DataSource = tbEmployeeSQL.SEARCH_DATA(columnName, txtSearch.Text);
                }
                else
                {
                    sk.Show(this, "กรุณากรอกข้อมูลเพื่อทำการค้นหา", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                }
            }
        }

        private void txtSearch_IconLeftClick(object sender, EventArgs e)
        {
            dgvEmployee.DataSource = tbEmployeeSQL.SELECTDATA();
        }
    }
}
