namespace FutureFlex
{
    partial class frmHistorySuccess
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.cl_btnDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cl_wgh_GVNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_po = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_GVID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_county = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_side = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_weightPaper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_weightCore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_boxNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_joint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_numMeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_weightRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_machineOperator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_net = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_tare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_gross = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_statusOdoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.txtPO = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbMain = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.bunifuGroupBox1.SuspendLayout();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Athiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_btnDel,
            this.cl_wgh_GVNAME,
            this.cl_wgh_po,
            this.cl_wgh_id,
            this.cl_wgh_dateTime,
            this.cl_wgh_employee,
            this.cl_wgh_GVID,
            this.cl_wgh_county,
            this.cl_wgh_type,
            this.cl_wgh_side,
            this.cl_wgh_weightPaper,
            this.cl_wgh_weightCore,
            this.cl_wgh_boxNum,
            this.cl_wgh_joint,
            this.cl_wgh_numMeter,
            this.cl_wgh_weightRoll,
            this.cl_wgh_machineOperator,
            this.cl_wgh_net,
            this.cl_wgh_tare,
            this.cl_wgh_gross,
            this.cl_wgh_statusOdoo});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Athiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDetail.EnableHeadersVisualStyles = false;
            this.dgvDetail.GridColor = System.Drawing.Color.White;
            this.dgvDetail.Location = new System.Drawing.Point(287, 46);
            this.dgvDetail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Athiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(917, 801);
            this.dgvDetail.TabIndex = 1;
            this.dgvDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellContentClick);
            // 
            // cl_btnDel
            // 
            this.cl_btnDel.HeaderText = "";
            this.cl_btnDel.Name = "cl_btnDel";
            this.cl_btnDel.ReadOnly = true;
            this.cl_btnDel.Text = "DELETE";
            this.cl_btnDel.UseColumnTextForButtonValue = true;
            this.cl_btnDel.Visible = false;
            // 
            // cl_wgh_GVNAME
            // 
            this.cl_wgh_GVNAME.DataPropertyName = "wgh_GVNAME";
            this.cl_wgh_GVNAME.HeaderText = "เลขที่ GV";
            this.cl_wgh_GVNAME.Name = "cl_wgh_GVNAME";
            this.cl_wgh_GVNAME.ReadOnly = true;
            this.cl_wgh_GVNAME.Visible = false;
            this.cl_wgh_GVNAME.Width = 150;
            // 
            // cl_wgh_po
            // 
            this.cl_wgh_po.DataPropertyName = "wgh_po";
            this.cl_wgh_po.HeaderText = "เลขที่ PO";
            this.cl_wgh_po.Name = "cl_wgh_po";
            this.cl_wgh_po.ReadOnly = true;
            this.cl_wgh_po.Visible = false;
            this.cl_wgh_po.Width = 110;
            // 
            // cl_wgh_id
            // 
            this.cl_wgh_id.DataPropertyName = "wgh_id";
            this.cl_wgh_id.HeaderText = "wgh_id";
            this.cl_wgh_id.Name = "cl_wgh_id";
            this.cl_wgh_id.ReadOnly = true;
            this.cl_wgh_id.Visible = false;
            // 
            // cl_wgh_dateTime
            // 
            this.cl_wgh_dateTime.DataPropertyName = "wgh_dateTime";
            this.cl_wgh_dateTime.HeaderText = "วัน/เวลา";
            this.cl_wgh_dateTime.Name = "cl_wgh_dateTime";
            this.cl_wgh_dateTime.ReadOnly = true;
            this.cl_wgh_dateTime.Width = 170;
            // 
            // cl_wgh_employee
            // 
            this.cl_wgh_employee.DataPropertyName = "wgh_employee";
            this.cl_wgh_employee.HeaderText = "พนักงานชั่ง";
            this.cl_wgh_employee.Name = "cl_wgh_employee";
            this.cl_wgh_employee.ReadOnly = true;
            this.cl_wgh_employee.Width = 130;
            // 
            // cl_wgh_GVID
            // 
            this.cl_wgh_GVID.DataPropertyName = "wgh_GVID";
            this.cl_wgh_GVID.HeaderText = "wgh_GVID";
            this.cl_wgh_GVID.Name = "cl_wgh_GVID";
            this.cl_wgh_GVID.ReadOnly = true;
            this.cl_wgh_GVID.Visible = false;
            // 
            // cl_wgh_county
            // 
            this.cl_wgh_county.DataPropertyName = "wgh_county";
            this.cl_wgh_county.HeaderText = "เลือกประเทศ";
            this.cl_wgh_county.Name = "cl_wgh_county";
            this.cl_wgh_county.ReadOnly = true;
            this.cl_wgh_county.Width = 150;
            // 
            // cl_wgh_type
            // 
            this.cl_wgh_type.DataPropertyName = "wgh_type";
            this.cl_wgh_type.HeaderText = "เลือกประเภท";
            this.cl_wgh_type.Name = "cl_wgh_type";
            this.cl_wgh_type.ReadOnly = true;
            this.cl_wgh_type.Width = 150;
            // 
            // cl_wgh_side
            // 
            this.cl_wgh_side.DataPropertyName = "wgh_side";
            this.cl_wgh_side.HeaderText = "เลือกด้าน";
            this.cl_wgh_side.Name = "cl_wgh_side";
            this.cl_wgh_side.ReadOnly = true;
            this.cl_wgh_side.Width = 150;
            // 
            // cl_wgh_weightPaper
            // 
            this.cl_wgh_weightPaper.DataPropertyName = "wgh_weightPaper";
            this.cl_wgh_weightPaper.HeaderText = "นน.กระดาษ/แกน";
            this.cl_wgh_weightPaper.Name = "cl_wgh_weightPaper";
            this.cl_wgh_weightPaper.ReadOnly = true;
            this.cl_wgh_weightPaper.Width = 180;
            // 
            // cl_wgh_weightCore
            // 
            this.cl_wgh_weightCore.DataPropertyName = "wgh_weightCore";
            this.cl_wgh_weightCore.HeaderText = "นน.แกน";
            this.cl_wgh_weightCore.Name = "cl_wgh_weightCore";
            this.cl_wgh_weightCore.ReadOnly = true;
            this.cl_wgh_weightCore.Width = 120;
            // 
            // cl_wgh_boxNum
            // 
            this.cl_wgh_boxNum.DataPropertyName = "wgh_boxNum";
            this.cl_wgh_boxNum.HeaderText = "จำนวนกล่อง";
            this.cl_wgh_boxNum.Name = "cl_wgh_boxNum";
            this.cl_wgh_boxNum.ReadOnly = true;
            this.cl_wgh_boxNum.Width = 130;
            // 
            // cl_wgh_joint
            // 
            this.cl_wgh_joint.DataPropertyName = "wgh_joint";
            this.cl_wgh_joint.HeaderText = "รอยต่อ";
            this.cl_wgh_joint.Name = "cl_wgh_joint";
            this.cl_wgh_joint.ReadOnly = true;
            this.cl_wgh_joint.Width = 120;
            // 
            // cl_wgh_numMeter
            // 
            this.cl_wgh_numMeter.DataPropertyName = "wgh_numMeter";
            this.cl_wgh_numMeter.HeaderText = "จำนวนเมตร";
            this.cl_wgh_numMeter.Name = "cl_wgh_numMeter";
            this.cl_wgh_numMeter.ReadOnly = true;
            this.cl_wgh_numMeter.Width = 130;
            // 
            // cl_wgh_weightRoll
            // 
            this.cl_wgh_weightRoll.DataPropertyName = "wgh_weightRoll";
            this.cl_wgh_weightRoll.HeaderText = "นน.ม้วน";
            this.cl_wgh_weightRoll.Name = "cl_wgh_weightRoll";
            this.cl_wgh_weightRoll.ReadOnly = true;
            this.cl_wgh_weightRoll.Width = 120;
            // 
            // cl_wgh_machineOperator
            // 
            this.cl_wgh_machineOperator.DataPropertyName = "wgh_machineOperator";
            this.cl_wgh_machineOperator.HeaderText = "ผู้ควบคุมเครื่อง";
            this.cl_wgh_machineOperator.Name = "cl_wgh_machineOperator";
            this.cl_wgh_machineOperator.ReadOnly = true;
            this.cl_wgh_machineOperator.Width = 150;
            // 
            // cl_wgh_net
            // 
            this.cl_wgh_net.DataPropertyName = "wgh_net";
            this.cl_wgh_net.HeaderText = "NET";
            this.cl_wgh_net.Name = "cl_wgh_net";
            this.cl_wgh_net.ReadOnly = true;
            // 
            // cl_wgh_tare
            // 
            this.cl_wgh_tare.DataPropertyName = "wgh_tare";
            this.cl_wgh_tare.HeaderText = "TARE";
            this.cl_wgh_tare.Name = "cl_wgh_tare";
            this.cl_wgh_tare.ReadOnly = true;
            // 
            // cl_wgh_gross
            // 
            this.cl_wgh_gross.DataPropertyName = "wgh_gross";
            this.cl_wgh_gross.HeaderText = "GROSS";
            this.cl_wgh_gross.Name = "cl_wgh_gross";
            this.cl_wgh_gross.ReadOnly = true;
            // 
            // cl_wgh_statusOdoo
            // 
            this.cl_wgh_statusOdoo.DataPropertyName = "wgh_statusOdoo";
            this.cl_wgh_statusOdoo.HeaderText = "wgh_statusOdoo";
            this.cl_wgh_statusOdoo.Name = "cl_wgh_statusOdoo";
            this.cl_wgh_statusOdoo.ReadOnly = true;
            this.cl_wgh_statusOdoo.Visible = false;
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.Navy;
            this.bunifuGroupBox1.BorderRadius = 6;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.label3);
            this.bunifuGroupBox1.Controls.Add(this.guna2DateTimePicker2);
            this.bunifuGroupBox1.Controls.Add(this.label2);
            this.bunifuGroupBox1.Controls.Add(this.guna2DateTimePicker1);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(11, 112);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(264, 172);
            this.bunifuGroupBox1.TabIndex = 18;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Text = "ค้นหาจากวันที่";
            // 
            // txtPO
            // 
            this.txtPO.BorderColor = System.Drawing.Color.Navy;
            this.txtPO.BorderRadius = 6;
            this.txtPO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPO.DefaultText = "";
            this.txtPO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPO.Font = new System.Drawing.Font("Athiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPO.ForeColor = System.Drawing.Color.Black;
            this.txtPO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPO.Location = new System.Drawing.Point(10, 67);
            this.txtPO.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPO.Name = "txtPO";
            this.txtPO.PasswordChar = '\0';
            this.txtPO.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPO.PlaceholderText = "PO";
            this.txtPO.SelectedText = "";
            this.txtPO.Size = new System.Drawing.Size(264, 36);
            this.txtPO.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "เลือก PO ที่ต้องการพิมพ์";
            // 
            // gbMain
            // 
            this.gbMain.BorderColor = System.Drawing.Color.Navy;
            this.gbMain.BorderRadius = 6;
            this.gbMain.Controls.Add(this.guna2TextBox1);
            this.gbMain.Controls.Add(this.guna2ControlBox1);
            this.gbMain.Controls.Add(this.bunifuGroupBox1);
            this.gbMain.Controls.Add(this.txtPO);
            this.gbMain.Controls.Add(this.dgvDetail);
            this.gbMain.Controls.Add(this.label1);
            this.gbMain.CustomBorderColor = System.Drawing.Color.Navy;
            this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMain.Font = new System.Drawing.Font("Athiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMain.ForeColor = System.Drawing.Color.White;
            this.gbMain.Location = new System.Drawing.Point(0, 0);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(1224, 865);
            this.gbMain.TabIndex = 21;
            this.gbMain.Text = "พิมพ์ข้อมูล";
            this.gbMain.Click += new System.EventHandler(this.gbMain_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Navy;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1169, 5);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 12;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Navy;
            this.guna2TextBox1.BorderRadius = 6;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Athiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(4, 398);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.guna2TextBox1.PlaceholderText = "PO";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(264, 36);
            this.guna2TextBox1.TabIndex = 21;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.Teal;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(14, 53);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(229, 36);
            this.guna2DateTimePicker1.TabIndex = 22;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 7, 22, 12, 31, 14, 52);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "วันที่เริ่มต้น : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "วันที่สิ้นสุด : ";
            // 
            // guna2DateTimePicker2
            // 
            this.guna2DateTimePicker2.Checked = true;
            this.guna2DateTimePicker2.FillColor = System.Drawing.Color.Teal;
            this.guna2DateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker2.ForeColor = System.Drawing.Color.White;
            this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(14, 124);
            this.guna2DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(229, 36);
            this.guna2DateTimePicker2.TabIndex = 24;
            this.guna2DateTimePicker2.Value = new System.DateTime(2024, 7, 22, 12, 31, 14, 52);
            // 
            // frmHistorySuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1224, 865);
            this.Controls.Add(this.gbMain);
            this.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmHistorySuccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHistorySuccess";
            this.Load += new System.EventHandler(this.frmHistorySuccess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.bunifuGroupBox1.ResumeLayout(false);
            this.bunifuGroupBox1.PerformLayout();
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.DataGridViewButtonColumn cl_btnDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_GVNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_po;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_dateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_GVID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_county;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_side;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_weightPaper;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_weightCore;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_boxNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_joint;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_numMeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_weightRoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_machineOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_net;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_tare;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_gross;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_statusOdoo;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtPO;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox gbMain;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
    }
}