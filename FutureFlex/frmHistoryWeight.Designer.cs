
namespace FutureFlex
{
    partial class frmHistoryWeight
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistoryWeight));
            this.label1 = new System.Windows.Forms.Label();
            this.cbbPO = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.cl_del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cl_edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cl_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_gv_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_gv_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_rtfg_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_rtfg_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_spl_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_spl_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wdt_seqNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_po = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_net = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_tare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_gross = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_lot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_oparator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_printed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_statusOdoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_county = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_side = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_paper_plastic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_core = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_joint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_meter_kg_in_roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_pch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wdt_numbox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wdt_numrollAll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wdt_numroll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_weightType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnPrint = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSend = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2RadioButton1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2RadioButton2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2RadioButton3 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.cbbJIT = new Guna.UI2.WinForms.Guna2ComboBox();
            this.msg = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.gbLoadData = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbLoadData.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "รายการที่ต้องการส่งไปหา odoo";
            // 
            // cbbPO
            // 
            this.cbbPO.BackColor = System.Drawing.Color.Transparent;
            this.cbbPO.BorderColor = System.Drawing.Color.Navy;
            this.cbbPO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPO.Enabled = false;
            this.cbbPO.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbPO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbPO.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPO.ForeColor = System.Drawing.Color.Black;
            this.cbbPO.ItemHeight = 30;
            this.cbbPO.Location = new System.Drawing.Point(11, 144);
            this.cbbPO.Name = "cbbPO";
            this.cbbPO.Size = new System.Drawing.Size(232, 36);
            this.cbbPO.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbbPO.TabIndex = 13;
            this.cbbPO.DropDown += new System.EventHandler(this.guna2ComboBox1_DropDown);
            this.cbbPO.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Navy;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1110, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 12;
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetail.ColumnHeadersHeight = 50;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_del,
            this.cl_edit,
            this.cl_id,
            this.cl_gv_name,
            this.cl_gv_id,
            this.cl_rtfg_name,
            this.cl_rtfg_id,
            this.cl_spl_name,
            this.cl_spl_id,
            this.cl_seq,
            this.cl_wdt_seqNew,
            this.cl_po,
            this.cl_net,
            this.cl_tare,
            this.cl_gross,
            this.cl_lot,
            this.cl_employee,
            this.cl_oparator,
            this.cl_printed,
            this.cl_statusOdoo,
            this.cl_county,
            this.cl_type,
            this.cl_side,
            this.cl_date,
            this.cl_wgh_paper_plastic,
            this.cl_core,
            this.cl_joint,
            this.cl_meter_kg_in_roll,
            this.cl_pch,
            this.cl_wdt_numbox,
            this.cl_wdt_numrollAll,
            this.cl_wdt_numroll,
            this.cl_weightType});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetail.EnableHeadersVisualStyles = false;
            this.dgvDetail.GridColor = System.Drawing.Color.White;
            this.dgvDetail.Location = new System.Drawing.Point(264, 3);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetail.RowHeadersVisible = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDetail.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetail.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dgvDetail.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDetail.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvDetail.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDetail.RowTemplate.Height = 30;
            this.dgvDetail.RowTemplate.ReadOnly = true;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDetail.Size = new System.Drawing.Size(869, 526);
            this.dgvDetail.TabIndex = 9;
            // 
            // cl_del
            // 
            this.cl_del.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cl_del.HeaderText = "";
            this.cl_del.Name = "cl_del";
            this.cl_del.ReadOnly = true;
            this.cl_del.Text = "ลบ";
            this.cl_del.UseColumnTextForButtonValue = true;
            this.cl_del.Visible = false;
            this.cl_del.Width = 60;
            // 
            // cl_edit
            // 
            this.cl_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cl_edit.HeaderText = "";
            this.cl_edit.Name = "cl_edit";
            this.cl_edit.ReadOnly = true;
            this.cl_edit.Text = "แก้ไข";
            this.cl_edit.UseColumnTextForButtonValue = true;
            this.cl_edit.Visible = false;
            this.cl_edit.Width = 60;
            // 
            // cl_id
            // 
            this.cl_id.DataPropertyName = "id";
            this.cl_id.HeaderText = "id";
            this.cl_id.Name = "cl_id";
            this.cl_id.ReadOnly = true;
            this.cl_id.Visible = false;
            // 
            // cl_gv_name
            // 
            this.cl_gv_name.DataPropertyName = "wdt_gv_name";
            this.cl_gv_name.HeaderText = "GV Name";
            this.cl_gv_name.Name = "cl_gv_name";
            this.cl_gv_name.ReadOnly = true;
            this.cl_gv_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_gv_name.Width = 150;
            // 
            // cl_gv_id
            // 
            this.cl_gv_id.DataPropertyName = "wdt_gv_id";
            this.cl_gv_id.HeaderText = "GV Id";
            this.cl_gv_id.Name = "cl_gv_id";
            this.cl_gv_id.ReadOnly = true;
            this.cl_gv_id.Visible = false;
            // 
            // cl_rtfg_name
            // 
            this.cl_rtfg_name.DataPropertyName = "wdt_rtfg_name";
            this.cl_rtfg_name.HeaderText = "RTFG Name";
            this.cl_rtfg_name.Name = "cl_rtfg_name";
            this.cl_rtfg_name.ReadOnly = true;
            this.cl_rtfg_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_rtfg_name.Width = 150;
            // 
            // cl_rtfg_id
            // 
            this.cl_rtfg_id.DataPropertyName = "wdt_rtfg_id";
            this.cl_rtfg_id.HeaderText = "RTFG_ID";
            this.cl_rtfg_id.Name = "cl_rtfg_id";
            this.cl_rtfg_id.ReadOnly = true;
            this.cl_rtfg_id.Visible = false;
            this.cl_rtfg_id.Width = 150;
            // 
            // cl_spl_name
            // 
            this.cl_spl_name.DataPropertyName = "wdt_spl_name";
            this.cl_spl_name.HeaderText = "SPL Name";
            this.cl_spl_name.Name = "cl_spl_name";
            this.cl_spl_name.ReadOnly = true;
            this.cl_spl_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_spl_name.Width = 150;
            // 
            // cl_spl_id
            // 
            this.cl_spl_id.DataPropertyName = "wdt_spl_id";
            this.cl_spl_id.HeaderText = "SPL ID";
            this.cl_spl_id.Name = "cl_spl_id";
            this.cl_spl_id.ReadOnly = true;
            this.cl_spl_id.Visible = false;
            // 
            // cl_seq
            // 
            this.cl_seq.DataPropertyName = "wdt_seqOrigin";
            this.cl_seq.HeaderText = "ลำดับ";
            this.cl_seq.Name = "cl_seq";
            this.cl_seq.ReadOnly = true;
            this.cl_seq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_seq.Width = 80;
            // 
            // cl_wdt_seqNew
            // 
            this.cl_wdt_seqNew.DataPropertyName = "wdt_seqNew";
            this.cl_wdt_seqNew.HeaderText = "wdt_seqNew";
            this.cl_wdt_seqNew.Name = "cl_wdt_seqNew";
            this.cl_wdt_seqNew.ReadOnly = true;
            this.cl_wdt_seqNew.Visible = false;
            // 
            // cl_po
            // 
            this.cl_po.DataPropertyName = "wdt_po";
            this.cl_po.HeaderText = "PO";
            this.cl_po.Name = "cl_po";
            this.cl_po.ReadOnly = true;
            this.cl_po.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_po.Visible = false;
            this.cl_po.Width = 150;
            // 
            // cl_net
            // 
            this.cl_net.DataPropertyName = "wdt_net";
            this.cl_net.HeaderText = "NET";
            this.cl_net.Name = "cl_net";
            this.cl_net.ReadOnly = true;
            this.cl_net.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl_tare
            // 
            this.cl_tare.DataPropertyName = "wdt_tare";
            this.cl_tare.HeaderText = "TARE";
            this.cl_tare.Name = "cl_tare";
            this.cl_tare.ReadOnly = true;
            this.cl_tare.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl_gross
            // 
            this.cl_gross.DataPropertyName = "wdt_gross";
            this.cl_gross.HeaderText = "GROSS";
            this.cl_gross.Name = "cl_gross";
            this.cl_gross.ReadOnly = true;
            this.cl_gross.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl_lot
            // 
            this.cl_lot.DataPropertyName = "wdt_lot";
            this.cl_lot.HeaderText = "LOT";
            this.cl_lot.Name = "cl_lot";
            this.cl_lot.ReadOnly = true;
            this.cl_lot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_lot.Width = 300;
            // 
            // cl_employee
            // 
            this.cl_employee.DataPropertyName = "wdt_employee";
            this.cl_employee.HeaderText = "ผู้ชั่ง";
            this.cl_employee.Name = "cl_employee";
            this.cl_employee.ReadOnly = true;
            this.cl_employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_employee.Visible = false;
            this.cl_employee.Width = 200;
            // 
            // cl_oparator
            // 
            this.cl_oparator.DataPropertyName = "wdt_oparator";
            this.cl_oparator.HeaderText = "ผู้คุมเครือง";
            this.cl_oparator.Name = "cl_oparator";
            this.cl_oparator.ReadOnly = true;
            this.cl_oparator.Visible = false;
            // 
            // cl_printed
            // 
            this.cl_printed.DataPropertyName = "wdt_printed";
            this.cl_printed.HeaderText = "printed";
            this.cl_printed.Name = "cl_printed";
            this.cl_printed.ReadOnly = true;
            this.cl_printed.Visible = false;
            // 
            // cl_statusOdoo
            // 
            this.cl_statusOdoo.DataPropertyName = "wdt_statusOdoo";
            this.cl_statusOdoo.HeaderText = "statusOdoo";
            this.cl_statusOdoo.Name = "cl_statusOdoo";
            this.cl_statusOdoo.ReadOnly = true;
            this.cl_statusOdoo.Visible = false;
            // 
            // cl_county
            // 
            this.cl_county.DataPropertyName = "wdt_country";
            this.cl_county.HeaderText = "ประเทศ";
            this.cl_county.Name = "cl_county";
            this.cl_county.ReadOnly = true;
            this.cl_county.Visible = false;
            // 
            // cl_type
            // 
            this.cl_type.DataPropertyName = "wdt_type";
            this.cl_type.HeaderText = "ประเภท";
            this.cl_type.Name = "cl_type";
            this.cl_type.ReadOnly = true;
            this.cl_type.Visible = false;
            // 
            // cl_side
            // 
            this.cl_side.DataPropertyName = "wdt_side";
            this.cl_side.HeaderText = "ด้าน";
            this.cl_side.Name = "cl_side";
            this.cl_side.ReadOnly = true;
            this.cl_side.Visible = false;
            // 
            // cl_date
            // 
            this.cl_date.DataPropertyName = "wdt_date";
            this.cl_date.HeaderText = "วันที่ชั่ง";
            this.cl_date.Name = "cl_date";
            this.cl_date.ReadOnly = true;
            this.cl_date.Visible = false;
            // 
            // cl_wgh_paper_plastic
            // 
            this.cl_wgh_paper_plastic.DataPropertyName = "wdt_wgh_paper_plastic";
            this.cl_wgh_paper_plastic.HeaderText = "น้ำหนักกระดาษ/น้ำหนักพลาสติก";
            this.cl_wgh_paper_plastic.Name = "cl_wgh_paper_plastic";
            this.cl_wgh_paper_plastic.ReadOnly = true;
            this.cl_wgh_paper_plastic.Visible = false;
            // 
            // cl_core
            // 
            this.cl_core.DataPropertyName = "wdt_wgh_core_total";
            this.cl_core.HeaderText = "น้ำหนักแกน";
            this.cl_core.Name = "cl_core";
            this.cl_core.ReadOnly = true;
            this.cl_core.Visible = false;
            // 
            // cl_joint
            // 
            this.cl_joint.DataPropertyName = "wdt_wgh_joint";
            this.cl_joint.HeaderText = "จำนวนรอยต่อ";
            this.cl_joint.Name = "cl_joint";
            this.cl_joint.ReadOnly = true;
            this.cl_joint.Visible = false;
            // 
            // cl_meter_kg_in_roll
            // 
            this.cl_meter_kg_in_roll.DataPropertyName = "wdt_meter_kg_in_roll";
            this.cl_meter_kg_in_roll.HeaderText = "จำนวนเมตร";
            this.cl_meter_kg_in_roll.Name = "cl_meter_kg_in_roll";
            this.cl_meter_kg_in_roll.ReadOnly = true;
            this.cl_meter_kg_in_roll.Visible = false;
            // 
            // cl_pch
            // 
            this.cl_pch.DataPropertyName = "wdt_pch";
            this.cl_pch.HeaderText = "จำนวนใบ";
            this.cl_pch.Name = "cl_pch";
            this.cl_pch.ReadOnly = true;
            this.cl_pch.Visible = false;
            // 
            // cl_wdt_numbox
            // 
            this.cl_wdt_numbox.DataPropertyName = "wdt_numbox";
            this.cl_wdt_numbox.HeaderText = "จำนวนกล่อง";
            this.cl_wdt_numbox.Name = "cl_wdt_numbox";
            this.cl_wdt_numbox.ReadOnly = true;
            this.cl_wdt_numbox.Visible = false;
            // 
            // cl_wdt_numrollAll
            // 
            this.cl_wdt_numrollAll.DataPropertyName = "wdt_numrollAll";
            this.cl_wdt_numrollAll.HeaderText = "จำนวนม้วน(ทั้งหมด)";
            this.cl_wdt_numrollAll.Name = "cl_wdt_numrollAll";
            this.cl_wdt_numrollAll.ReadOnly = true;
            this.cl_wdt_numrollAll.Visible = false;
            // 
            // cl_wdt_numroll
            // 
            this.cl_wdt_numroll.DataPropertyName = "wdt_numroll";
            this.cl_wdt_numroll.HeaderText = "จำนวนมัวนต่อLOT";
            this.cl_wdt_numroll.Name = "cl_wdt_numroll";
            this.cl_wdt_numroll.ReadOnly = true;
            this.cl_wdt_numroll.Visible = false;
            // 
            // cl_weightType
            // 
            this.cl_weightType.DataPropertyName = "wdt_weightType";
            this.cl_weightType.HeaderText = "WeightType";
            this.cl_weightType.Name = "cl_weightType";
            this.cl_weightType.ReadOnly = true;
            this.cl_weightType.Visible = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.Teal;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.Teal;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Athiti Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(450, 51);
            this.label4.TabIndex = 23;
            this.label4.Text = "รายการที่ต้องส่งข้อมูลไปหา odoo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(5, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(557, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "รายการที่ีมีการชั่งเสร็จแล้วไม่ว่าจะเป็น JIT หรือ PO จะต้องตรวจสอบก่อนส่งข้อมูลไป" +
    "ที่ ODOO";
            // 
            // btnSearch
            // 
            this.btnSearch.Animated = true;
            this.btnSearch.BorderRadius = 2;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor2 = System.Drawing.Color.MidnightBlue;
            this.btnSearch.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSearch.Location = new System.Drawing.Point(3, 385);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(255, 43);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "ค้นหารายการเพิ่มเติม";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Animated = true;
            this.btnPrint.BorderRadius = 2;
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.FillColor2 = System.Drawing.Color.MidnightBlue;
            this.btnPrint.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnPrint.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnPrint.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnPrint.Location = new System.Drawing.Point(3, 434);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(255, 43);
            this.btnPrint.TabIndex = 26;
            this.btnPrint.Text = "พิมพ์ข้อมูลก่อนส่ง ODOO";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSend
            // 
            this.btnSend.Animated = true;
            this.btnSend.BorderRadius = 2;
            this.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSend.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSend.FillColor = System.Drawing.Color.SlateBlue;
            this.btnSend.FillColor2 = System.Drawing.Color.DarkBlue;
            this.btnSend.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSend.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.btnSend.HoverState.FillColor2 = System.Drawing.Color.ForestGreen;
            this.btnSend.Location = new System.Drawing.Point(3, 483);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(255, 43);
            this.btnSend.TabIndex = 27;
            this.btnSend.Text = "ส่งข้อมูลหา ODOO";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // guna2RadioButton1
            // 
            this.guna2RadioButton1.AutoSize = true;
            this.guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton1.CheckedState.BorderThickness = 0;
            this.guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton1.CheckedState.InnerOffset = -4;
            this.guna2RadioButton1.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.guna2RadioButton1.Location = new System.Drawing.Point(13, 9);
            this.guna2RadioButton1.Name = "guna2RadioButton1";
            this.guna2RadioButton1.Size = new System.Drawing.Size(113, 29);
            this.guna2RadioButton1.TabIndex = 28;
            this.guna2RadioButton1.Tag = "GV";
            this.guna2RadioButton1.Text = "ส่งข้อมูล GV";
            this.guna2RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2RadioButton1.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton1.CheckedChanged += new System.EventHandler(this.SelectGVorRTFG);
            // 
            // guna2RadioButton2
            // 
            this.guna2RadioButton2.AutoSize = true;
            this.guna2RadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton2.CheckedState.BorderThickness = 0;
            this.guna2RadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton2.CheckedState.InnerOffset = -4;
            this.guna2RadioButton2.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.guna2RadioButton2.Location = new System.Drawing.Point(12, 44);
            this.guna2RadioButton2.Name = "guna2RadioButton2";
            this.guna2RadioButton2.Size = new System.Drawing.Size(132, 29);
            this.guna2RadioButton2.TabIndex = 29;
            this.guna2RadioButton2.Tag = "RTFG";
            this.guna2RadioButton2.Text = "ส่งข้อมูล RTFG";
            this.guna2RadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2RadioButton2.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton2.CheckedChanged += new System.EventHandler(this.SelectGVorRTFG);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2RadioButton3);
            this.panel1.Controls.Add(this.cbbJIT);
            this.panel1.Controls.Add(this.guna2RadioButton2);
            this.panel1.Controls.Add(this.guna2RadioButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbbPO);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 247);
            this.panel1.TabIndex = 30;
            // 
            // guna2RadioButton3
            // 
            this.guna2RadioButton3.AutoSize = true;
            this.guna2RadioButton3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton3.CheckedState.BorderThickness = 0;
            this.guna2RadioButton3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton3.CheckedState.InnerOffset = -4;
            this.guna2RadioButton3.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.guna2RadioButton3.Location = new System.Drawing.Point(13, 79);
            this.guna2RadioButton3.Name = "guna2RadioButton3";
            this.guna2RadioButton3.Size = new System.Drawing.Size(133, 29);
            this.guna2RadioButton3.TabIndex = 31;
            this.guna2RadioButton3.Tag = "SPL";
            this.guna2RadioButton3.Text = "ส่งข้อมูล SPLIT";
            this.guna2RadioButton3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2RadioButton3.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton3.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton3.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton3.CheckedChanged += new System.EventHandler(this.SelectGVorRTFG);
            // 
            // cbbJIT
            // 
            this.cbbJIT.BackColor = System.Drawing.Color.Transparent;
            this.cbbJIT.BorderColor = System.Drawing.Color.Navy;
            this.cbbJIT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbJIT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbJIT.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbJIT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbJIT.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbJIT.ForeColor = System.Drawing.Color.Black;
            this.cbbJIT.ItemHeight = 30;
            this.cbbJIT.Location = new System.Drawing.Point(11, 186);
            this.cbbJIT.Name = "cbbJIT";
            this.cbbJIT.Size = new System.Drawing.Size(234, 36);
            this.cbbJIT.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbbJIT.TabIndex = 30;
            this.cbbJIT.Visible = false;
            this.cbbJIT.SelectedIndexChanged += new System.EventHandler(this.cbbJIT_SelectedIndexChanged);
            // 
            // msg
            // 
            this.msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msg.Caption = null;
            this.msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.msg.Parent = this;
            this.msg.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.msg.Text = null;
            // 
            // gbLoadData
            // 
            this.gbLoadData.BorderColor = System.Drawing.Color.Navy;
            this.gbLoadData.BorderRadius = 4;
            this.gbLoadData.Controls.Add(this.label2);
            this.gbLoadData.Controls.Add(this.guna2CircleProgressBar1);
            this.gbLoadData.CustomBorderColor = System.Drawing.Color.Navy;
            this.gbLoadData.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.gbLoadData.Font = new System.Drawing.Font("Athiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLoadData.ForeColor = System.Drawing.Color.White;
            this.gbLoadData.Location = new System.Drawing.Point(711, 3);
            this.gbLoadData.Name = "gbLoadData";
            this.gbLoadData.Size = new System.Drawing.Size(406, 96);
            this.gbLoadData.TabIndex = 86;
            this.gbLoadData.Text = "กำลังโหลดข้อมูล";
            this.gbLoadData.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Athiti Medium", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(105, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 39);
            this.label2.TabIndex = 56;
            this.label2.Text = "กำลังส่งข้อมูลหา Odoo";
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.Animated = true;
            this.guna2CircleProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2CircleProgressBar1.FillThickness = 15;
            this.guna2CircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(14, 12);
            this.guna2CircleProgressBar1.Minimum = 0;
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.Navy;
            this.guna2CircleProgressBar1.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2CircleProgressBar1.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2CircleProgressBar1.ProgressThickness = 15;
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(71, 71);
            this.guna2CircleProgressBar1.TabIndex = 0;
            this.guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.Value = 50;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.dgvDetail);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Location = new System.Drawing.Point(10, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 537);
            this.panel2.TabIndex = 87;
            // 
            // frmHistoryWeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1158, 619);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbLoadData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2ControlBox1);
            this.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmHistoryWeight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ประวัติการชั่ง";
            this.Load += new System.EventHandler(this.frmHistoryWeight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbLoadData.ResumeLayout(false);
            this.gbLoadData.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDetail;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbPO;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
        private Guna.UI2.WinForms.Guna2GradientButton btnPrint;
        private Guna.UI2.WinForms.Guna2GradientButton btnSend;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton2;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbJIT;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton3;
        private Guna.UI2.WinForms.Guna2MessageDialog msg;
        private System.Windows.Forms.DataGridViewButtonColumn cl_del;
        private System.Windows.Forms.DataGridViewButtonColumn cl_edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_gv_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_gv_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_rtfg_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_rtfg_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_spl_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_spl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wdt_seqNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_po;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_net;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_tare;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_gross;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_lot;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_oparator;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_printed;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_statusOdoo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_county;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_side;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_paper_plastic;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_core;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_joint;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_meter_kg_in_roll;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_pch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wdt_numbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wdt_numrollAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wdt_numroll;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_weightType;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GroupBox gbLoadData;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
    }
}