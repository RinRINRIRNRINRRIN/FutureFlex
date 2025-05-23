﻿namespace FutureFlex
{
    partial class frmReprintJIT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReprintJIT));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbPO = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPrint = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLot = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblQRCODE = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.cl_print = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cl_wdt_seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wdt_gv_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wdt_po = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wdt_net = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wdt_tare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wdt_gross = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wdt_lot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wdt_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wdt_meter_kg_in_roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_structure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_typeSuccess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wdt_wgh_paper_plastic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wdt_wgh_core_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wdt_numroll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wdt_numrollAll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wdt_numbox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wdt_pch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wdt_print = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_customer_productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.msg = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 21);
            this.label2.TabIndex = 55;
            this.label2.Text = "เลือก PO ที่ต้องการ reprint";
            // 
            // cbbPO
            // 
            this.cbbPO.BackColor = System.Drawing.Color.Transparent;
            this.cbbPO.BorderColor = System.Drawing.Color.Navy;
            this.cbbPO.BorderRadius = 6;
            this.cbbPO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPO.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbPO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbPO.Font = new System.Drawing.Font("Athiti Medium", 18F, System.Drawing.FontStyle.Bold);
            this.cbbPO.ForeColor = System.Drawing.Color.Black;
            this.cbbPO.ItemHeight = 30;
            this.cbbPO.Location = new System.Drawing.Point(10, 135);
            this.cbbPO.Name = "cbbPO";
            this.cbbPO.Size = new System.Drawing.Size(630, 36);
            this.cbbPO.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbbPO.TabIndex = 54;
            this.cbbPO.DropDown += new System.EventHandler(this.cbbPO_DropDown);
            this.cbbPO.SelectedIndexChanged += new System.EventHandler(this.cbbPO_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Athiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 33);
            this.label1.TabIndex = 53;
            this.label1.Text = "DATA : ";
            // 
            // cbPrint
            // 
            this.cbPrint.AllowBindingControlAnimation = true;
            this.cbPrint.AllowBindingControlColorChanges = false;
            this.cbPrint.AllowBindingControlLocation = true;
            this.cbPrint.AllowCheckBoxAnimation = false;
            this.cbPrint.AllowCheckmarkAnimation = true;
            this.cbPrint.AllowOnHoverStates = true;
            this.cbPrint.AutoCheck = true;
            this.cbPrint.BackColor = System.Drawing.Color.Transparent;
            this.cbPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbPrint.BackgroundImage")));
            this.cbPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cbPrint.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.cbPrint.BorderRadius = 12;
            this.cbPrint.Checked = true;
            this.cbPrint.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.cbPrint.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbPrint.CustomCheckmarkImage = null;
            this.cbPrint.Location = new System.Drawing.Point(652, 154);
            this.cbPrint.MinimumSize = new System.Drawing.Size(17, 17);
            this.cbPrint.Name = "cbPrint";
            this.cbPrint.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cbPrint.OnCheck.BorderRadius = 12;
            this.cbPrint.OnCheck.BorderThickness = 2;
            this.cbPrint.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.cbPrint.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.cbPrint.OnCheck.CheckmarkThickness = 2;
            this.cbPrint.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.cbPrint.OnDisable.BorderRadius = 12;
            this.cbPrint.OnDisable.BorderThickness = 2;
            this.cbPrint.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbPrint.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.cbPrint.OnDisable.CheckmarkThickness = 2;
            this.cbPrint.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.cbPrint.OnHoverChecked.BorderRadius = 12;
            this.cbPrint.OnHoverChecked.BorderThickness = 2;
            this.cbPrint.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.cbPrint.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.cbPrint.OnHoverChecked.CheckmarkThickness = 2;
            this.cbPrint.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.cbPrint.OnHoverUnchecked.BorderRadius = 12;
            this.cbPrint.OnHoverUnchecked.BorderThickness = 1;
            this.cbPrint.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbPrint.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.cbPrint.OnUncheck.BorderRadius = 12;
            this.cbPrint.OnUncheck.BorderThickness = 1;
            this.cbPrint.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbPrint.Size = new System.Drawing.Size(17, 17);
            this.cbPrint.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.cbPrint.TabIndex = 52;
            this.cbPrint.ThreeState = false;
            this.cbPrint.ToolTipText = null;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(647, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 97);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "   พิมพ์";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.ForeColor = System.Drawing.Color.Black;
            this.radioButton4.Location = new System.Drawing.Point(6, 56);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(186, 29);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "โชว์หน้าต่างตั้งค่าก่อนพิมพ์";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.Black;
            this.radioButton3.Location = new System.Drawing.Point(6, 25);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(172, 29);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.Text = "พิมพ์โดยไม่ โชว์หน้าต่าง";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(691, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // txtLot
            // 
            this.txtLot.BorderColor = System.Drawing.Color.Navy;
            this.txtLot.BorderRadius = 6;
            this.txtLot.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLot.DefaultText = "";
            this.txtLot.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLot.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLot.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLot.Font = new System.Drawing.Font("Athiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLot.ForeColor = System.Drawing.Color.Black;
            this.txtLot.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLot.IconRight = ((System.Drawing.Image)(resources.GetObject("txtLot.IconRight")));
            this.txtLot.Location = new System.Drawing.Point(123, 179);
            this.txtLot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLot.MaxLength = 30;
            this.txtLot.Name = "txtLot";
            this.txtLot.PasswordChar = '\0';
            this.txtLot.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtLot.PlaceholderText = "คลิ๊กที่นี้เพื่ออ่าน Barcode";
            this.txtLot.SelectedText = "";
            this.txtLot.Size = new System.Drawing.Size(517, 39);
            this.txtLot.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtLot.TabIndex = 6;
            this.txtLot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLot.IconRightClick += new System.EventHandler(this.txtLot_IconRightClick);
            this.txtLot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLot_KeyDown);
            // 
            // lblQRCODE
            // 
            this.lblQRCODE.AutoSize = true;
            this.lblQRCODE.Font = new System.Drawing.Font("Athiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQRCODE.ForeColor = System.Drawing.Color.Black;
            this.lblQRCODE.Location = new System.Drawing.Point(10, 179);
            this.lblQRCODE.Name = "lblQRCODE";
            this.lblQRCODE.Size = new System.Drawing.Size(112, 33);
            this.lblQRCODE.TabIndex = 5;
            this.lblQRCODE.Text = "QRCODE : ";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.White;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Navy;
            this.guna2ControlBox1.Location = new System.Drawing.Point(803, 9);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 3;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetail.ColumnHeadersHeight = 50;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_print,
            this.cl_wdt_seq,
            this.cl_wdt_gv_name,
            this.cl_wdt_po,
            this.cl_wdt_net,
            this.cl_wdt_tare,
            this.cl_wdt_gross,
            this.cl_wdt_lot,
            this.cl_wdt_type,
            this.cl_wdt_meter_kg_in_roll,
            this.cl_wgh_product,
            this.cl_wgh_productID,
            this.cl_wgh_customer,
            this.cl_wgh_structure,
            this.cl_wgh_typeSuccess,
            this.cl_wdt_wgh_paper_plastic,
            this.cl_wdt_wgh_core_total,
            this.cl_wdt_numroll,
            this.cl_wdt_numrollAll,
            this.cl_wdt_numbox,
            this.cl_wdt_pch,
            this.cl_wgh_date,
            this.cl_wdt_print,
            this.cl_wgh_operator,
            this.cl_wgh_customer_productID});
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
            this.dgvDetail.Location = new System.Drawing.Point(13, 264);
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
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDetail.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetail.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dgvDetail.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDetail.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvDetail.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDetail.RowTemplate.Height = 30;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDetail.Size = new System.Drawing.Size(835, 628);
            this.dgvDetail.TabIndex = 1;
            this.dgvDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellContentClick);
            // 
            // cl_print
            // 
            this.cl_print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cl_print.HeaderText = "";
            this.cl_print.Name = "cl_print";
            this.cl_print.ReadOnly = true;
            this.cl_print.Text = "ปริ้น";
            this.cl_print.UseColumnTextForButtonValue = true;
            this.cl_print.Width = 130;
            // 
            // cl_wdt_seq
            // 
            this.cl_wdt_seq.DataPropertyName = "wdt_seqNew";
            this.cl_wdt_seq.HeaderText = "ลำดับ";
            this.cl_wdt_seq.Name = "cl_wdt_seq";
            this.cl_wdt_seq.ReadOnly = true;
            this.cl_wdt_seq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_wdt_seq.Width = 80;
            // 
            // cl_wdt_gv_name
            // 
            this.cl_wdt_gv_name.DataPropertyName = "wdt_gv_name";
            this.cl_wdt_gv_name.HeaderText = "GVID";
            this.cl_wdt_gv_name.Name = "cl_wdt_gv_name";
            this.cl_wdt_gv_name.ReadOnly = true;
            this.cl_wdt_gv_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_wdt_gv_name.Visible = false;
            this.cl_wdt_gv_name.Width = 150;
            // 
            // cl_wdt_po
            // 
            this.cl_wdt_po.DataPropertyName = "wdt_po";
            this.cl_wdt_po.HeaderText = "PO";
            this.cl_wdt_po.Name = "cl_wdt_po";
            this.cl_wdt_po.ReadOnly = true;
            this.cl_wdt_po.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_wdt_po.Visible = false;
            this.cl_wdt_po.Width = 150;
            // 
            // cl_wdt_net
            // 
            this.cl_wdt_net.DataPropertyName = "wdt_net";
            this.cl_wdt_net.HeaderText = "NET";
            this.cl_wdt_net.Name = "cl_wdt_net";
            this.cl_wdt_net.ReadOnly = true;
            this.cl_wdt_net.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl_wdt_tare
            // 
            this.cl_wdt_tare.DataPropertyName = "wdt_tare";
            this.cl_wdt_tare.HeaderText = "TARE";
            this.cl_wdt_tare.Name = "cl_wdt_tare";
            this.cl_wdt_tare.ReadOnly = true;
            this.cl_wdt_tare.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl_wdt_gross
            // 
            this.cl_wdt_gross.DataPropertyName = "wdt_gross";
            this.cl_wdt_gross.HeaderText = "GROSS";
            this.cl_wdt_gross.Name = "cl_wdt_gross";
            this.cl_wdt_gross.ReadOnly = true;
            this.cl_wdt_gross.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl_wdt_lot
            // 
            this.cl_wdt_lot.DataPropertyName = "wdt_lot";
            this.cl_wdt_lot.HeaderText = "LOT";
            this.cl_wdt_lot.Name = "cl_wdt_lot";
            this.cl_wdt_lot.ReadOnly = true;
            this.cl_wdt_lot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_wdt_lot.Width = 300;
            // 
            // cl_wdt_type
            // 
            this.cl_wdt_type.DataPropertyName = "wdt_type";
            this.cl_wdt_type.HeaderText = "wdt_type";
            this.cl_wdt_type.Name = "cl_wdt_type";
            this.cl_wdt_type.ReadOnly = true;
            this.cl_wdt_type.Visible = false;
            // 
            // cl_wdt_meter_kg_in_roll
            // 
            this.cl_wdt_meter_kg_in_roll.DataPropertyName = "wdt_meter_kg_in_roll";
            this.cl_wdt_meter_kg_in_roll.HeaderText = "wdt_meter_kg_in_roll";
            this.cl_wdt_meter_kg_in_roll.Name = "cl_wdt_meter_kg_in_roll";
            this.cl_wdt_meter_kg_in_roll.ReadOnly = true;
            this.cl_wdt_meter_kg_in_roll.Visible = false;
            // 
            // cl_wgh_product
            // 
            this.cl_wgh_product.DataPropertyName = "wgh_product";
            this.cl_wgh_product.HeaderText = "wgh_product";
            this.cl_wgh_product.Name = "cl_wgh_product";
            this.cl_wgh_product.ReadOnly = true;
            this.cl_wgh_product.Visible = false;
            // 
            // cl_wgh_productID
            // 
            this.cl_wgh_productID.DataPropertyName = "wgh_productID";
            this.cl_wgh_productID.HeaderText = "wgh_productID";
            this.cl_wgh_productID.Name = "cl_wgh_productID";
            this.cl_wgh_productID.ReadOnly = true;
            this.cl_wgh_productID.Visible = false;
            // 
            // cl_wgh_customer
            // 
            this.cl_wgh_customer.DataPropertyName = "wgh_customer";
            this.cl_wgh_customer.HeaderText = "wgh_customer";
            this.cl_wgh_customer.Name = "cl_wgh_customer";
            this.cl_wgh_customer.ReadOnly = true;
            this.cl_wgh_customer.Visible = false;
            // 
            // cl_wgh_structure
            // 
            this.cl_wgh_structure.DataPropertyName = "wgh_structure";
            this.cl_wgh_structure.HeaderText = "wgh_structure";
            this.cl_wgh_structure.Name = "cl_wgh_structure";
            this.cl_wgh_structure.ReadOnly = true;
            this.cl_wgh_structure.Visible = false;
            // 
            // cl_wgh_typeSuccess
            // 
            this.cl_wgh_typeSuccess.DataPropertyName = "wgh_typeSuccess";
            this.cl_wgh_typeSuccess.HeaderText = "wgh_typeSuccess";
            this.cl_wgh_typeSuccess.Name = "cl_wgh_typeSuccess";
            this.cl_wgh_typeSuccess.ReadOnly = true;
            this.cl_wgh_typeSuccess.Visible = false;
            // 
            // cl_wdt_wgh_paper_plastic
            // 
            this.cl_wdt_wgh_paper_plastic.DataPropertyName = "wdt_wgh_paper_plastic";
            this.cl_wdt_wgh_paper_plastic.HeaderText = "wdt_wgh_paper_plastic";
            this.cl_wdt_wgh_paper_plastic.Name = "cl_wdt_wgh_paper_plastic";
            this.cl_wdt_wgh_paper_plastic.ReadOnly = true;
            this.cl_wdt_wgh_paper_plastic.Visible = false;
            // 
            // cl_wdt_wgh_core_total
            // 
            this.cl_wdt_wgh_core_total.DataPropertyName = "wdt_wgh_core_total";
            this.cl_wdt_wgh_core_total.HeaderText = "wdt_wgh_core_total";
            this.cl_wdt_wgh_core_total.Name = "cl_wdt_wgh_core_total";
            this.cl_wdt_wgh_core_total.ReadOnly = true;
            this.cl_wdt_wgh_core_total.Visible = false;
            // 
            // cl_wdt_numroll
            // 
            this.cl_wdt_numroll.DataPropertyName = "wdt_numroll";
            this.cl_wdt_numroll.HeaderText = "wdt_numroll";
            this.cl_wdt_numroll.Name = "cl_wdt_numroll";
            this.cl_wdt_numroll.ReadOnly = true;
            this.cl_wdt_numroll.Visible = false;
            // 
            // cl_wdt_numrollAll
            // 
            this.cl_wdt_numrollAll.DataPropertyName = "wdt_numrollAll";
            this.cl_wdt_numrollAll.HeaderText = "wdt_numrollAll";
            this.cl_wdt_numrollAll.Name = "cl_wdt_numrollAll";
            this.cl_wdt_numrollAll.ReadOnly = true;
            this.cl_wdt_numrollAll.Visible = false;
            // 
            // cl_wdt_numbox
            // 
            this.cl_wdt_numbox.DataPropertyName = "wdt_numbox";
            this.cl_wdt_numbox.HeaderText = "wdt_numbox";
            this.cl_wdt_numbox.Name = "cl_wdt_numbox";
            this.cl_wdt_numbox.ReadOnly = true;
            this.cl_wdt_numbox.Visible = false;
            // 
            // cl_wdt_pch
            // 
            this.cl_wdt_pch.DataPropertyName = "wdt_pch";
            this.cl_wdt_pch.HeaderText = "wdt_pch";
            this.cl_wdt_pch.Name = "cl_wdt_pch";
            this.cl_wdt_pch.ReadOnly = true;
            this.cl_wdt_pch.Visible = false;
            // 
            // cl_wgh_date
            // 
            this.cl_wgh_date.DataPropertyName = "wgh_date";
            this.cl_wgh_date.HeaderText = "wgh_date";
            this.cl_wgh_date.Name = "cl_wgh_date";
            this.cl_wgh_date.ReadOnly = true;
            this.cl_wgh_date.Visible = false;
            // 
            // cl_wdt_print
            // 
            this.cl_wdt_print.DataPropertyName = "wdt_printed";
            this.cl_wdt_print.HeaderText = "wdt_print";
            this.cl_wdt_print.Name = "cl_wdt_print";
            this.cl_wdt_print.ReadOnly = true;
            this.cl_wdt_print.Visible = false;
            // 
            // cl_wgh_operator
            // 
            this.cl_wgh_operator.DataPropertyName = "wdt_oparator";
            this.cl_wgh_operator.HeaderText = "wgh_operator";
            this.cl_wgh_operator.Name = "cl_wgh_operator";
            this.cl_wgh_operator.ReadOnly = true;
            this.cl_wgh_operator.Visible = false;
            // 
            // cl_wgh_customer_productID
            // 
            this.cl_wgh_customer_productID.DataPropertyName = "wgh_customer_productID";
            this.cl_wgh_customer_productID.HeaderText = "wgh_customer_productID";
            this.cl_wgh_customer_productID.Name = "cl_wgh_customer_productID";
            this.cl_wgh_customer_productID.ReadOnly = true;
            this.cl_wgh_customer_productID.Visible = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.Teal;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.Teal;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(5, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 25);
            this.label9.TabIndex = 57;
            this.label9.Text = "ปริ้นรายการ JIT เป็นรายการ PO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Athiti Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(5, -3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 51);
            this.label10.TabIndex = 56;
            this.label10.Text = "REPRINT JIT";
            // 
            // msg
            // 
            this.msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msg.Caption = null;
            this.msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.msg.Parent = this.printPreviewDialog1;
            this.msg.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.msg.Text = null;
            // 
            // bunifuSnackbar1
            // 
            this.bunifuSnackbar1.AllowDragging = false;
            this.bunifuSnackbar1.AllowMultipleViews = true;
            this.bunifuSnackbar1.ClickToClose = true;
            this.bunifuSnackbar1.DoubleClickToClose = true;
            this.bunifuSnackbar1.DurationAfterIdle = 3000;
            this.bunifuSnackbar1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bunifuSnackbar1.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.bunifuSnackbar1.ErrorOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.FadeCloseIcon = false;
            this.bunifuSnackbar1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bunifuSnackbar1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.bunifuSnackbar1.InformationOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.Margin = 10;
            this.bunifuSnackbar1.MaximumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.MaximumViews = 7;
            this.bunifuSnackbar1.MessageRightMargin = 15;
            this.bunifuSnackbar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.ShowBorders = false;
            this.bunifuSnackbar1.ShowCloseIcon = false;
            this.bunifuSnackbar1.ShowIcon = true;
            this.bunifuSnackbar1.ShowShadows = true;
            this.bunifuSnackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bunifuSnackbar1.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.bunifuSnackbar1.SuccessOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ViewsMargin = 7;
            this.bunifuSnackbar1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bunifuSnackbar1.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.bunifuSnackbar1.WarningOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ZoomCloseIcon = true;
            // 
            // frmReprintJIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 904);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvDetail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbPO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPrint);
            this.Controls.Add(this.lblQRCODE);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtLot);
            this.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmReprintJIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReprintJIT";
            this.Load += new System.EventHandler(this.frmReprintJIT_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label lblQRCODE;
        private System.Windows.Forms.DataGridView dgvDetail;
        private Guna.UI2.WinForms.Guna2TextBox txtLot;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuCheckBox cbPrint;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbPO;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewButtonColumn cl_print;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wdt_seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wdt_gv_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wdt_po;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wdt_net;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wdt_tare;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wdt_gross;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wdt_lot;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wdt_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wdt_meter_kg_in_roll;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_structure;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_typeSuccess;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wdt_wgh_paper_plastic;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wdt_wgh_core_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wdt_numroll;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wdt_numrollAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wdt_numbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wdt_pch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wdt_print;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_operator;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_customer_productID;
        private Guna.UI2.WinForms.Guna2MessageDialog msg;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
    }
}