using FutureFlex.SQL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FutureFlex.command
{
    class tbForSendSQL
    {
        #region "LOCAL VARIABLE"
        //============================================================================================  Local variable

        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable tb;

        string sqlstr = "";
        //============================================================================================  Local variable
        #endregion




        #region"SELECT DATA"
        public DataTable SELECTDATA(string query) // ใช้ที่ frmWeightNew ตอนมีการชั่งเท่านั้น
        {
            try
            {
                sqlstr = "SELECT * FROM tbForSend WHERE fs_jobno = '" + query + "' ORDER BY fs_id DESC";
                da = new SqlDataAdapter(sqlstr, server.con);
                tb = new DataTable();
                da.Fill(tb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return tb;
            }
            return tb;
        }


        public DataTable SELECTDATA1() // ใช้ที่ frmHistoryWeight ค้นหาทั้งหมด
        {
            try
            {
                sqlstr = "SELECT a.fs_id,a.fs_jobno,a.fs_po,a.fs_date FROM tbForSend a";
                da = new SqlDataAdapter(sqlstr, server.con);
                tb = new DataTable();
                da.Fill(tb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return tb;
            }
            return tb;
        }
        #endregion





        #region"INSERT DATA"

        public bool INSERTDATA1(string fs_county, string fs_type, string fs_side, string fs_jobno, string fs_po, string fs_company, string fs_product, string fs_structure, string fs_dimensionW, string fs_dimensionL, string fs_wghPaper, string fs_wghCors, string fs_seam, string fs_num, string fs_unit, string fs_kg, string emp_name, string fs_date, string fs_netWgh, string fs_tareWgh, string fs_grossWgh)
        {
            try
            {
                if (fs_dimensionL == "")
                {
                    Convert.ToInt32(fs_dimensionL = "0");
                }
                if (fs_wghPaper == "")
                {
                    Convert.ToInt32(fs_wghPaper = "0");
                }
                if (fs_wghCors == "")
                {
                    Convert.ToInt32(fs_wghCors = "0");
                }
                if (fs_seam == "")
                {
                    Convert.ToInt32(fs_seam = "0");
                }
                if (fs_kg == "")
                {
                    Convert.ToInt32(fs_kg = "0");
                }


                sqlstr = "INSERT INTO tbForSend" +
                    "       (fs_county,fs_type,fs_side,fs_staff,fs_seq,fs_jobno,fs_po,fs_company,fs_product,fs_netwgh,fs_tarewgh,fs_grosswgh,fs_structure,fs_dimensionW,fs_dimensionL,fs_wghPaper,fs_wghCors,fs_seam,fs_num,fs_unit,fs_kg,fs_date,fs_status,fs_statusOdoo,fs_approve)" +
                    "VALUES(@fs_county,@fs_type,@fs_side,@fs_staff,@fs_seq,@fs_jobno,@fs_po,@fs_company,@fs_product,@fs_netwgh,@fs_tarewgh,@fs_grosswgh,@fs_structure,@fs_dimensionW,@fs_dimensionL,@fs_wghPaper,@fs_wghCors,@fs_seam,@fs_num,@fs_unit,@fs_kg,@fs_date,@fs_status,@fs_statusOdoo,@fs_approve)";

                cmd = new SqlCommand(sqlstr, server.con);
                //cmd.Parameters.Add(new SqlParameter("@fs_county", fs_county));
                //cmd.Parameters.Add(new SqlParameter("@fs_type", fs_type));
                //cmd.Parameters.Add(new SqlParameter("@fs_side", fs_side));
                //cmd.Parameters.Add(new SqlParameter("@fs_staff", emp_name));
                //cmd.Parameters.Add(new SqlParameter("@fs_jobno", fs_jobno));
                //cmd.Parameters.Add(new SqlParameter("@fs_po", fs_po));
                //cmd.Parameters.Add(new SqlParameter("@fs_company", fs_company));
                //cmd.Parameters.Add(new SqlParameter("@fs_product", fs_product));
                //cmd.Parameters.Add(new SqlParameter("@fs_netwgh", Convert.ToDecimal(fs_netWgh)));
                //cmd.Parameters.Add(new SqlParameter("@fs_tarewgh", Convert.ToDecimal(fs_tareWgh)));
                //cmd.Parameters.Add(new SqlParameter("@fs_grosswgh", Convert.ToDecimal(fs_grossWgh)));
                //cmd.Parameters.Add(new SqlParameter("@fs_structure", fs_structure));
                //cmd.Parameters.Add(new SqlParameter("@fs_dimensionW", Convert.ToInt32(fs_dimensionW)));
                //cmd.Parameters.Add(new SqlParameter("@fs_dimensionL", Convert.ToInt32(fs_dimensionL)));
                //cmd.Parameters.Add(new SqlParameter("@fs_wghPaper", fs_wghPaper));
                //cmd.Parameters.Add(new SqlParameter("@fs_wghCors", fs_wghCors));
                //cmd.Parameters.Add(new SqlParameter("@fs_seam", fs_seam));
                //cmd.Parameters.Add(new SqlParameter("@fs_num", Convert.ToInt32(fs_num)));
                //cmd.Parameters.Add(new SqlParameter("@fs_unit", Convert.ToInt32(fs_unit)));
                //cmd.Parameters.Add(new SqlParameter("@fs_kg", Convert.ToDecimal(fs_kg)));
                //cmd.Parameters.Add(new SqlParameter("@fs_date", Convert.ToDateTime(fs_date)));
                //cmd.Parameters.Add(new SqlParameter("@fs_status", 1));
                //cmd.Parameters.Add(new SqlParameter("@fs_statusOdoo", 0));

                cmd.Parameters.AddWithValue("@fs_county", fs_county);
                cmd.Parameters.AddWithValue("@fs_type", fs_type);
                cmd.Parameters.AddWithValue("@fs_side", fs_side);
                cmd.Parameters.AddWithValue("@fs_staff", emp_name);
                cmd.Parameters.AddWithValue("@fs_jobno", fs_jobno);
                cmd.Parameters.AddWithValue("@fs_po", fs_po);
                cmd.Parameters.AddWithValue("@fs_company", fs_company);
                cmd.Parameters.AddWithValue("@fs_product", fs_product);
                cmd.Parameters.AddWithValue("@fs_netwgh", fs_netWgh);
                cmd.Parameters.AddWithValue("@fs_tarewgh", fs_tareWgh);
                cmd.Parameters.AddWithValue("@fs_grosswgh", fs_grossWgh);
                cmd.Parameters.AddWithValue("@fs_structure", fs_structure);
                cmd.Parameters.AddWithValue("@fs_dimensionW", fs_dimensionW);
                cmd.Parameters.AddWithValue("@fs_dimensionL", fs_dimensionL);
                cmd.Parameters.AddWithValue("@fs_wghPaper", fs_wghPaper);
                cmd.Parameters.AddWithValue("@fs_wghCors", fs_wghCors);
                cmd.Parameters.AddWithValue("@fs_seam", fs_seam);
                cmd.Parameters.AddWithValue("@fs_num", fs_num);
                cmd.Parameters.AddWithValue("@fs_unit", fs_unit);
                cmd.Parameters.AddWithValue("@fs_kg", fs_kg);
                cmd.Parameters.AddWithValue("@fs_status", 1);
                cmd.Parameters.AddWithValue("@fs_statusOdoo", 0);
                cmd.Parameters.AddWithValue("@fs_date", fs_date);
                cmd.Parameters.AddWithValue("@fs_approve", 1);


                string sqlstrSeq = "SELECT COUNT(*) as countd FROM tbForSend WHERE fs_jobno ='" + fs_jobno + "' AND fs_status = 1";
                tb = new DataTable();
                da = new SqlDataAdapter(sqlstrSeq, server.con);
                da.Fill(tb);
                int fs_seq;

                foreach (DataRow rw in tb.Rows)
                {
                    fs_seq = Convert.ToInt32(rw[0].ToString()) + 1;
                    //cmd.Parameters.Add(new SqlParameter("@fs_seq", fs_seq));
                    cmd.Parameters.AddWithValue("@fs_seq", fs_seq);
                    //cmd.Parameters.Add(new SqlParameter("@fs_seq", fs_seq));
                }

                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        #endregion

        #region"UPDATE DATA"
        #endregion

        #region"DELETE DATA"

        public bool DELETEDATA(int fs_id)
        {
            try
            {
                sqlstr = "DELETE FROM tbForSend WHERE fs_id = " + fs_id + "";

                cmd = new SqlCommand(sqlstr, server.con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return false;
            }
            return true;
        }
        #endregion

        #region"GET DATA"
        #endregion
    }
}
