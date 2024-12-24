using FutureFlex.SQL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
namespace FutureFlex
{
    public partial class frmConnect : Form
    {
        public frmConnect()
        {
            InitializeComponent();
        }


        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        bool isChange = false;
        string _key = "";
        string _server = "";
        string _database = "";
        string _id = "";


        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isNull = false;
            // Check text empty
            foreach (TextBox txt in gbOdoo.Controls.OfType<TextBox>())
            {
                if (txt.Text == "")
                {
                    isNull = true;
                }
            }


            foreach (TextBox txt in gbSerer.Controls.OfType<TextBox>())
            {
                if (txt.Text == "")
                {
                    isNull = true;
                }
            }

            if (isNull)
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบก่อนบันทึก");
                return;
            }

            config.AppSettings.Settings["SERVER_LOCAL"].Value = txtHost.Text;
            config.AppSettings.Settings["PORT_LOCAL"].Value = txtPort.Text;
            config.AppSettings.Settings["USER_LOCAL"].Value = txtUser.Text;
            config.AppSettings.Settings["PASS_LOCAL"].Value = txtPassword.Text;
            config.AppSettings.Settings["DB_LOCAL"].Value = txtDatabase.Text;
            config.Save(ConfigurationSaveMode.Modified);

            string sql = "UPDATE tbOdoo" +
                " SET od_key = @od_key," +
                " od_server = @od_server," +
                " od_database = @od_database" +
                " WHERE od_id = @od_id";

            SqlCommand cmd = new SqlCommand(sql, server.con);
            cmd.Parameters.Add(new SqlParameter("@od_key", txtKey.Text));
            cmd.Parameters.Add(new SqlParameter("@od_server", txtURL.Text));
            cmd.Parameters.Add(new SqlParameter("@od_database", txtbase.Text));
            cmd.Parameters.Add(new SqlParameter("@od_id", _id));
            cmd.ExecuteNonQuery();

            isChange = true;
            MessageBox.Show("แก้ไขโข้อมูลโปรแกรมสำเร็จ");
            Application.Exit();
        }

        private void frmConnect_Load(object sender, EventArgs e)
        {
            try
            {
                // แสดงข้อมูลจาก config
                txtHost.Text = ConfigurationManager.AppSettings["SERVER_LOCAL"];
                txtPort.Text = ConfigurationManager.AppSettings["PORT_LOCAL"];
                txtUser.Text = ConfigurationManager.AppSettings["USER_LOCAL"];
                txtPassword.Text = ConfigurationManager.AppSettings["PASS_LOCAL"];
                txtDatabase.Text = ConfigurationManager.AppSettings["DB_LOCAL"];


                // ดึงข้อมูลจาก tbodoo
                string sql = "SELECT * FROM tbOdoo";
                SqlDataAdapter da = new SqlDataAdapter(sql, server.con);
                DataTable tb = new DataTable();
                da.Fill(tb);

                if (tb.Rows.Count != 0)
                {
                    foreach (DataRow rw in tb.Rows)
                    {
                        _id = rw["od_id"].ToString();
                        _key = rw["od_key"].ToString();
                        _server = rw["od_server"].ToString();
                        _database = rw["od_database"].ToString();
                        break;
                    }
                }

                txtbase.Text = _database;
                txtURL.Text = _server;
                txtKey.Text = _key;
            }
            catch (Exception)
            {

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isChange)
            {
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }

        private void frmConnect_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
