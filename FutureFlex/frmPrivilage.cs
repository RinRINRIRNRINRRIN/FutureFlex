using Bunifu.UI.WinForms;
using FutureFlex.SQL;
using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static FutureFlex.SQL.tbPrivilage;

namespace FutureFlex
{
    public partial class frmPrivilage : Form
    {
        public frmPrivilage()
        {
            InitializeComponent();
        }


        void CLEAR_CHECKBOX()
        {
            // เครียค่าให้ว่าง


            foreach (Guna2CheckBox cb in pnControl.Controls.OfType<Guna2CheckBox>())
            {
                cb.Checked = false;
            }

            foreach (BunifuToggleSwitch tgs in pnControl.Controls.OfType<BunifuToggleSwitch>())
            {
                tgs.Checked = false;
            }
        }

        BunifuSnackbar sk = new BunifuSnackbar();

        private void frmPrivilage_Load(object sender, EventArgs e)
        {
            cbbEmployList.Items.Add("--เลือกผู้ใช้งานที่ต้องการกำหนดสิทธิ์--");
            cbbEmployList.SelectedIndex = 0;
        }

        private void cbbEmployList_DropDown(object sender, EventArgs e)
        {
            DataTable tb = tbEmployeeSQL.SELECTDATA();
            cbbEmployList.Items.Clear();
            foreach (DataRow item in tb.Rows)
            {
                string user = $"{item["emp_username"]} | {item["emp_name"]}";
                cbbEmployList.Items.Add(user);
            }
        }

        private void cbbEmployList_DropDownClosed(object sender, EventArgs e)
        {
            if (cbbEmployList.Text == "")
            {
                cbbEmployList.Items.Clear();
                cbbEmployList.Items.Add("--เลือกผู้ใช้งานที่ต้องการกำหนดสิทธิ์--");
                cbbEmployList.SelectedIndex = 0;
            }
        }

        private void cbbEmployList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] a = cbbEmployList.Text.Split('|');
            if (!a[0].Contains("--"))
            {
                // ตรวจสอบหากผู้ใช้เลือก sa 
                if (a[0].Trim() == "sa")
                {
                    // เครียค่าให้ว่าง
                    cbbEmployList.Items.Clear();
                    cbbEmployList.Items.Add("--เลือกผู้ใช้งานที่ต้องการกำหนดสิทธิ์--");
                    cbbEmployList.SelectedIndex = 0;

                    CLEAR_CHECKBOX();
                    sk.Show(this, "ไม่สามารถแก้ไขสิทธิ์สูงสุด SA ได้", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                    return;
                }

                pnControl.Enabled = true;
                tbPrivilage.CheckPrivilage(a[0].Trim());

                for (int i = 0; i < tbPrivilage.menuPrivilage.Count; i++)
                {
                    string menu = tbPrivilage.menuPrivilage[i];
                    switch (menu)
                    {
                        case "weight":
                            if (weight.del == "True") { tgsWghDel.Checked = true; }
                            if (weight.edit == "True") { tgsWghEdit.Checked = true; }
                            break;
                        case "reprintJIT":
                            cbReprintJIT.Checked = true;
                            break;
                        case "history":
                            //menuPrivilage.Add("history");
                            //if (history.add == "true") { tgs};
                            //history.del = del;
                            //history.edit = edit;
                            break;
                        case "privilage":
                            cbPrivilage.Checked = true;
                            break;
                        case "setting":
                            cbSetting.Checked = true;
                            break;
                    }
                }
                return;
            }
            else
            {
                // ถ้าผู้ใช้ไม่เลือกอะไรเลย
                CLEAR_CHECKBOX();
            }
            //  CLEAR_CHECKBOX();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] user = cbbEmployList.Text.Split('|');
            if (tbPrivilage.DELETE(user[0].Trim()))
            {
                // เปิดสิทธิ์หน้าชั่ง
                if (tgsWghDel.Checked || tgsWghEdit.Checked)
                {
                    tbPrivilage.INSERT(user[0].Trim(), "weight", tgsWghDel.Checked.ToString(), tgsWghEdit.Checked.ToString());
                }
                // เปิดสิทธิ์หน้าแก้ไข
                if (cbSetting.Checked)
                {
                    tbPrivilage.INSERT(user[0].Trim(), "setting", "False", "False");
                }
                // เปิดสิทธิ์หน้ากำหนดสิทธื
                if (cbPrivilage.Checked)
                {
                    tbPrivilage.INSERT(user[0].Trim(), "privilage", "False", "False");
                }
                // เปิดสิทธิ์ Reprint
                if (cbReprintJIT.Checked)
                {
                    tbPrivilage.INSERT(user[0].Trim(), "reprintJIT", "False", "False");
                }
            }
            sk.Show(this, "กำหนดสิทธิ์การใช้งานสำเร็จ", BunifuSnackbar.MessageTypes.Success, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
        }
    }
}
