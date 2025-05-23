﻿using Bunifu.UI.WinForms;
using FutureFlex.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FutureFlex
{
    public partial class frmHistorySuccess : Form
    {
        public frmHistorySuccess()
        {
            InitializeComponent();
            dtpStart.CustomFormat = "dd/MM/yyyy";
            dtpStop.CustomFormat = "dd/MM/yyyy";
        }


        BunifuSnackbar sc = new BunifuSnackbar();



        private void frmHistorySuccess_Load(object sender, EventArgs e)
        {
            btnSearch.DefaultCellStyle.ForeColor = Color.Black;

            dtpStart.Value = DateTime.Now;
            dtpStop.Value = DateTime.Now;
        }


        void Showdata(DataTable tb)
        {
            foreach (DataRow rw in tb.Rows)
            {
                lblCustomer.Text = rw["wgh_customer"].ToString();
                lblProduct.Text = rw["wgh_product"].ToString();
                lblPO.Text = rw["wdt_po"].ToString();
                lblStructure.Text = rw["wgh_structure"].ToString();
                lblJobType.Text = rw["wgh_typeSuccess"].ToString();

                string _status = rw["wdt_statusOdoo"].ToString();
                string _seq = rw["wdt_seqNew"].ToString();
                string _numBox = rw["wdt_numBox"].ToString();
                string _numRoll = rw["wdt_numRoll"].ToString();
                string _numPch = rw["wdt_pch"].ToString();
                string _net = rw["wdt_net"].ToString();
                string _oparator = rw["wdt_oparator"].ToString();
                string _employee = rw["wdt_employee"].ToString();
                string[] _date = rw["wdt_date"].ToString().Split(' ');
                string _lot = rw["wdt_lot"].ToString();

                string num = "";
                if (_numBox == "0")
                {
                    num = _numRoll;
                }
                else if (_numRoll == "0")
                {
                    num = _numBox;
                }

                string _state = "";
                if (_status == "NOT SEND")
                {
                    _state = "ยังไม่ส่ง";
                }
                else if (_status == "SEND")
                {
                    _state = "ส่งแล้ว";
                }

                btnSearch.Rows.Add(_state, _seq, num, _numPch, _net, _date[0], _oparator, _employee, _lot);
            }

            foreach (DataGridViewRow rw in btnSearch.Rows)
            {
                string _status = rw.Cells["cl_status"].Value.ToString();
                switch (_status)
                {
                    case "ยังไม่ส่ง":
                        rw.Cells["cl_status"].Style.ForeColor = Color.Red;
                        break;
                    case "ส่งแล้ว":
                        rw.Cells["cl_status"].Style.ForeColor = Color.Green;
                        break;
                }
                rw.Cells["cl_status"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                rw.Cells["cl_status"].Style.Font = new Font("Athiti", 10, FontStyle.Bold);
            }
        }

        private void cbbPO_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSearch.Rows.Clear();
            DataTable tb = tbWeightDetail.SELECT_GV(cbbPO.Text);
            Showdata(tb);

        }



        private void txtSearchGV_IconRightClick(object sender, EventArgs e)
        {
            btnSearch.Rows.Clear();
            DataTable tb = tbWeightDetail.SELECT_GV($"GV-{txtSearchGV.Text}");
            Showdata(tb);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string dtstart = dtpStart.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.CreateSpecificCulture("EN-en"));
            string dtstop = dtpStop.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.CreateSpecificCulture("EN-en"));

            DataTable tb = tbWeightDetail.SELECT_DATE(dtstart, dtstop);

            List<string> gv = new List<string>();
            cbbPO.Items.Clear();
            foreach (DataRow rw in tb.Rows)
            {
                bool isHave = false;
                string _gv = rw["wdt_gv_name"].ToString();

                for (int i = 0; i < gv.Count; i++)
                {
                    if (_gv == gv[i])
                    {
                        isHave = true;
                        break;
                    }
                }

                if (!isHave)
                {
                    gv.Add(_gv);
                    cbbPO.Items.Add(_gv);
                }
            }
        }
    }
}
