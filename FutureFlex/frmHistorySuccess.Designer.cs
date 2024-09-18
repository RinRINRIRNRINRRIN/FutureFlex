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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorySuccess));
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.cl_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_numMeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wdt_pch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_net = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_machineOperator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_lot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.gbMain = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpStop = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblStructure = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblJobType = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPrint = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblPO = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbPO = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.bunifuButton3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtSearchGV = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Athiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetail.ColumnHeadersHeight = 45;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_status,
            this.cl_seq,
            this.cl_wgh_numMeter,
            this.wdt_pch,
            this.cl_wgh_net,
            this.cl_wgh_dateTime,
            this.cl_wgh_machineOperator,
            this.cl_wgh_employee,
            this.cl_lot});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Athiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetail.EnableHeadersVisualStyles = false;
            this.dgvDetail.GridColor = System.Drawing.Color.White;
            this.dgvDetail.Location = new System.Drawing.Point(216, 73);
            this.dgvDetail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Athiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetail.RowHeadersVisible = false;
            this.dgvDetail.RowTemplate.Height = 40;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(1198, 832);
            this.dgvDetail.TabIndex = 1;
            // 
            // cl_status
            // 
            this.cl_status.HeaderText = "ODOO";
            this.cl_status.Name = "cl_status";
            this.cl_status.ReadOnly = true;
            this.cl_status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl_seq
            // 
            this.cl_seq.DataPropertyName = "wdt_seq";
            this.cl_seq.HeaderText = "ลำดับ";
            this.cl_seq.Name = "cl_seq";
            this.cl_seq.ReadOnly = true;
            this.cl_seq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl_wgh_numMeter
            // 
            this.cl_wgh_numMeter.DataPropertyName = "wdt_meter_kg_in_roll";
            this.cl_wgh_numMeter.HeaderText = "จำนวนม้วน/กล่อง";
            this.cl_wgh_numMeter.Name = "cl_wgh_numMeter";
            this.cl_wgh_numMeter.ReadOnly = true;
            this.cl_wgh_numMeter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_wgh_numMeter.Width = 180;
            // 
            // wdt_pch
            // 
            this.wdt_pch.DataPropertyName = "wdt_pch";
            this.wdt_pch.HeaderText = "จำนวนใบ";
            this.wdt_pch.Name = "wdt_pch";
            this.wdt_pch.ReadOnly = true;
            this.wdt_pch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl_wgh_net
            // 
            this.cl_wgh_net.DataPropertyName = "wdt_net";
            this.cl_wgh_net.HeaderText = "น้ำหนัก";
            this.cl_wgh_net.Name = "cl_wgh_net";
            this.cl_wgh_net.ReadOnly = true;
            this.cl_wgh_net.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl_wgh_dateTime
            // 
            this.cl_wgh_dateTime.DataPropertyName = "wdt_date";
            this.cl_wgh_dateTime.HeaderText = "วันที่ชั่ง";
            this.cl_wgh_dateTime.Name = "cl_wgh_dateTime";
            this.cl_wgh_dateTime.ReadOnly = true;
            this.cl_wgh_dateTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_wgh_dateTime.Width = 170;
            // 
            // cl_wgh_machineOperator
            // 
            this.cl_wgh_machineOperator.DataPropertyName = "wdt_oparator";
            this.cl_wgh_machineOperator.HeaderText = "ผู้ควบคุมเครื่อง";
            this.cl_wgh_machineOperator.Name = "cl_wgh_machineOperator";
            this.cl_wgh_machineOperator.ReadOnly = true;
            this.cl_wgh_machineOperator.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_wgh_machineOperator.Width = 150;
            // 
            // cl_wgh_employee
            // 
            this.cl_wgh_employee.DataPropertyName = "wdt_employee";
            this.cl_wgh_employee.HeaderText = "พนักงานชั่ง";
            this.cl_wgh_employee.Name = "cl_wgh_employee";
            this.cl_wgh_employee.ReadOnly = true;
            this.cl_wgh_employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_wgh_employee.Width = 130;
            // 
            // cl_lot
            // 
            this.cl_lot.DataPropertyName = "wdt_lot";
            this.cl_lot.HeaderText = "Lot No.";
            this.cl_lot.Name = "cl_lot";
            this.cl_lot.ReadOnly = true;
            this.cl_lot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_lot.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "เลือก GV ที่ต้องการค้นหา";
            // 
            // gbMain
            // 
            this.gbMain.BorderColor = System.Drawing.Color.Navy;
            this.gbMain.BorderRadius = 6;
            this.gbMain.Controls.Add(this.txtSearchGV);
            this.gbMain.Controls.Add(this.bunifuButton3);
            this.gbMain.Controls.Add(this.label7);
            this.gbMain.Controls.Add(this.dtpStop);
            this.gbMain.Controls.Add(this.label5);
            this.gbMain.Controls.Add(this.dtpStart);
            this.gbMain.Controls.Add(this.lblStructure);
            this.gbMain.Controls.Add(this.label8);
            this.gbMain.Controls.Add(this.lblJobType);
            this.gbMain.Controls.Add(this.label6);
            this.gbMain.Controls.Add(this.btnExport);
            this.gbMain.Controls.Add(this.btnPrint);
            this.gbMain.Controls.Add(this.lblCustomer);
            this.gbMain.Controls.Add(this.lblProduct);
            this.gbMain.Controls.Add(this.lblPO);
            this.gbMain.Controls.Add(this.label4);
            this.gbMain.Controls.Add(this.label3);
            this.gbMain.Controls.Add(this.label2);
            this.gbMain.Controls.Add(this.cbbPO);
            this.gbMain.Controls.Add(this.guna2ControlBox1);
            this.gbMain.Controls.Add(this.dgvDetail);
            this.gbMain.Controls.Add(this.label1);
            this.gbMain.CustomBorderColor = System.Drawing.Color.Navy;
            this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMain.Font = new System.Drawing.Font("Athiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMain.ForeColor = System.Drawing.Color.White;
            this.gbMain.Location = new System.Drawing.Point(0, 0);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(1418, 920);
            this.gbMain.TabIndex = 21;
            this.gbMain.Text = "ค้นหาข้อมูล GV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 71;
            this.label7.Text = "วันที่สิ้นสุด :";
            // 
            // dtpStop
            // 
            this.dtpStop.BorderRadius = 4;
            this.dtpStop.Checked = true;
            this.dtpStop.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStop.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStop.Location = new System.Drawing.Point(7, 137);
            this.dtpStop.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStop.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStop.Name = "dtpStop";
            this.dtpStop.Size = new System.Drawing.Size(200, 36);
            this.dtpStop.TabIndex = 70;
            this.dtpStop.Value = new System.DateTime(2024, 9, 18, 14, 27, 32, 211);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 69;
            this.label5.Text = "วันที่เริ่มค้น :";
            // 
            // dtpStart
            // 
            this.dtpStart.BorderRadius = 4;
            this.dtpStart.Checked = true;
            this.dtpStart.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStart.Location = new System.Drawing.Point(6, 73);
            this.dtpStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 36);
            this.dtpStart.TabIndex = 68;
            this.dtpStart.Value = new System.DateTime(2024, 9, 18, 14, 27, 32, 211);
            // 
            // lblStructure
            // 
            this.lblStructure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStructure.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStructure.ForeColor = System.Drawing.Color.Black;
            this.lblStructure.Location = new System.Drawing.Point(17, 518);
            this.lblStructure.Name = "lblStructure";
            this.lblStructure.Size = new System.Drawing.Size(189, 81);
            this.lblStructure.TabIndex = 67;
            this.lblStructure.Text = ".......";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 488);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 66;
            this.label8.Text = "โครงสร้าง :";
            // 
            // lblJobType
            // 
            this.lblJobType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJobType.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobType.ForeColor = System.Drawing.Color.Black;
            this.lblJobType.Location = new System.Drawing.Point(17, 733);
            this.lblJobType.Name = "lblJobType";
            this.lblJobType.Size = new System.Drawing.Size(190, 75);
            this.lblJobType.TabIndex = 65;
            this.lblJobType.Text = ".......";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 708);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 64;
            this.label6.Text = "ขนาดงาน :";
            // 
            // btnExport
            // 
            this.btnExport.AllowAnimations = true;
            this.btnExport.AllowMouseEffects = true;
            this.btnExport.AllowToggling = false;
            this.btnExport.AnimationSpeed = 200;
            this.btnExport.AutoGenerateColors = false;
            this.btnExport.AutoRoundBorders = false;
            this.btnExport.AutoSizeLeftIcon = true;
            this.btnExport.AutoSizeRightIcon = true;
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.BackColor1 = System.Drawing.Color.White;
            this.btnExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExport.BackgroundImage")));
            this.btnExport.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExport.ButtonText = "Export";
            this.btnExport.ButtonTextMarginLeft = 0;
            this.btnExport.ColorContrastOnClick = 45;
            this.btnExport.ColorContrastOnHover = 45;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnExport.CustomizableEdges = borderEdges2;
            this.btnExport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExport.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExport.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExport.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExport.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnExport.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.Navy;
            this.btnExport.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExport.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnExport.IconMarginLeft = 11;
            this.btnExport.IconPadding = 10;
            this.btnExport.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExport.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExport.IconSize = 25;
            this.btnExport.IdleBorderColor = System.Drawing.Color.Navy;
            this.btnExport.IdleBorderRadius = 8;
            this.btnExport.IdleBorderThickness = 1;
            this.btnExport.IdleFillColor = System.Drawing.Color.White;
            this.btnExport.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnExport.IdleIconLeftImage")));
            this.btnExport.IdleIconRightImage = null;
            this.btnExport.IndicateFocus = false;
            this.btnExport.Location = new System.Drawing.Point(17, 867);
            this.btnExport.Name = "btnExport";
            this.btnExport.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExport.OnDisabledState.BorderRadius = 8;
            this.btnExport.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExport.OnDisabledState.BorderThickness = 1;
            this.btnExport.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExport.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExport.OnDisabledState.IconLeftImage = null;
            this.btnExport.OnDisabledState.IconRightImage = null;
            this.btnExport.onHoverState.BorderColor = System.Drawing.Color.Navy;
            this.btnExport.onHoverState.BorderRadius = 8;
            this.btnExport.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExport.onHoverState.BorderThickness = 1;
            this.btnExport.onHoverState.FillColor = System.Drawing.Color.Navy;
            this.btnExport.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnExport.onHoverState.IconLeftImage = null;
            this.btnExport.onHoverState.IconRightImage = null;
            this.btnExport.OnIdleState.BorderColor = System.Drawing.Color.Navy;
            this.btnExport.OnIdleState.BorderRadius = 8;
            this.btnExport.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExport.OnIdleState.BorderThickness = 1;
            this.btnExport.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnExport.OnIdleState.ForeColor = System.Drawing.Color.Navy;
            this.btnExport.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnExport.OnIdleState.IconLeftImage")));
            this.btnExport.OnIdleState.IconRightImage = null;
            this.btnExport.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExport.OnPressedState.BorderRadius = 8;
            this.btnExport.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExport.OnPressedState.BorderThickness = 1;
            this.btnExport.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExport.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnExport.OnPressedState.IconLeftImage = null;
            this.btnExport.OnPressedState.IconRightImage = null;
            this.btnExport.Size = new System.Drawing.Size(189, 43);
            this.btnExport.TabIndex = 63;
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExport.TextMarginLeft = 0;
            this.btnExport.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnExport.UseDefaultRadiusAndThickness = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AllowAnimations = true;
            this.btnPrint.AllowMouseEffects = true;
            this.btnPrint.AllowToggling = false;
            this.btnPrint.AnimationSpeed = 200;
            this.btnPrint.AutoGenerateColors = false;
            this.btnPrint.AutoRoundBorders = false;
            this.btnPrint.AutoSizeLeftIcon = true;
            this.btnPrint.AutoSizeRightIcon = true;
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackColor1 = System.Drawing.Color.White;
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrint.ButtonText = "พิมพ์";
            this.btnPrint.ButtonTextMarginLeft = 0;
            this.btnPrint.ColorContrastOnClick = 45;
            this.btnPrint.ColorContrastOnHover = 45;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnPrint.CustomizableEdges = borderEdges3;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrint.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPrint.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPrint.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPrint.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPrint.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Navy;
            this.btnPrint.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPrint.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPrint.IconMarginLeft = 11;
            this.btnPrint.IconPadding = 10;
            this.btnPrint.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPrint.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPrint.IconSize = 25;
            this.btnPrint.IdleBorderColor = System.Drawing.Color.Navy;
            this.btnPrint.IdleBorderRadius = 8;
            this.btnPrint.IdleBorderThickness = 1;
            this.btnPrint.IdleFillColor = System.Drawing.Color.White;
            this.btnPrint.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.IdleIconLeftImage")));
            this.btnPrint.IdleIconRightImage = null;
            this.btnPrint.IndicateFocus = false;
            this.btnPrint.Location = new System.Drawing.Point(17, 818);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPrint.OnDisabledState.BorderRadius = 8;
            this.btnPrint.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrint.OnDisabledState.BorderThickness = 1;
            this.btnPrint.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPrint.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPrint.OnDisabledState.IconLeftImage = null;
            this.btnPrint.OnDisabledState.IconRightImage = null;
            this.btnPrint.onHoverState.BorderColor = System.Drawing.Color.Navy;
            this.btnPrint.onHoverState.BorderRadius = 8;
            this.btnPrint.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrint.onHoverState.BorderThickness = 1;
            this.btnPrint.onHoverState.FillColor = System.Drawing.Color.Navy;
            this.btnPrint.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPrint.onHoverState.IconLeftImage = null;
            this.btnPrint.onHoverState.IconRightImage = null;
            this.btnPrint.OnIdleState.BorderColor = System.Drawing.Color.Navy;
            this.btnPrint.OnIdleState.BorderRadius = 8;
            this.btnPrint.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrint.OnIdleState.BorderThickness = 1;
            this.btnPrint.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnPrint.OnIdleState.ForeColor = System.Drawing.Color.Navy;
            this.btnPrint.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.OnIdleState.IconLeftImage")));
            this.btnPrint.OnIdleState.IconRightImage = null;
            this.btnPrint.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPrint.OnPressedState.BorderRadius = 8;
            this.btnPrint.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrint.OnPressedState.BorderThickness = 1;
            this.btnPrint.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPrint.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPrint.OnPressedState.IconLeftImage = null;
            this.btnPrint.OnPressedState.IconRightImage = null;
            this.btnPrint.Size = new System.Drawing.Size(189, 43);
            this.btnPrint.TabIndex = 62;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrint.TextMarginLeft = 0;
            this.btnPrint.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPrint.UseDefaultRadiusAndThickness = true;
            this.btnPrint.Visible = false;
            // 
            // lblCustomer
            // 
            this.lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustomer.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.Black;
            this.lblCustomer.Location = new System.Drawing.Point(17, 413);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(189, 75);
            this.lblCustomer.TabIndex = 61;
            this.lblCustomer.Text = ".......";
            // 
            // lblProduct
            // 
            this.lblProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProduct.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.Black;
            this.lblProduct.Location = new System.Drawing.Point(17, 624);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(190, 76);
            this.lblProduct.TabIndex = 60;
            this.lblProduct.Text = ".......";
            // 
            // lblPO
            // 
            this.lblPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPO.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPO.ForeColor = System.Drawing.Color.Black;
            this.lblPO.Location = new System.Drawing.Point(61, 353);
            this.lblPO.Name = "lblPO";
            this.lblPO.Size = new System.Drawing.Size(145, 25);
            this.lblPO.TabIndex = 59;
            this.lblPO.Text = ".......";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 599);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 58;
            this.label4.Text = "ชื่อสินค้า :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 57;
            this.label3.Text = "ชื่อลูกค้า :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "PO :";
            // 
            // cbbPO
            // 
            this.cbbPO.BackColor = System.Drawing.Color.Transparent;
            this.cbbPO.BorderColor = System.Drawing.Color.Navy;
            this.cbbPO.BorderRadius = 6;
            this.cbbPO.BorderThickness = 0;
            this.cbbPO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPO.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbPO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbPO.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPO.ForeColor = System.Drawing.Color.Black;
            this.cbbPO.ItemHeight = 30;
            this.cbbPO.Location = new System.Drawing.Point(8, 253);
            this.cbbPO.Name = "cbbPO";
            this.cbbPO.Size = new System.Drawing.Size(198, 36);
            this.cbbPO.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbbPO.TabIndex = 55;
            this.cbbPO.SelectedIndexChanged += new System.EventHandler(this.cbbPO_SelectedIndexChanged);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Navy;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1363, 5);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 12;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.gbMain;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // bunifuButton3
            // 
            this.bunifuButton3.AllowAnimations = true;
            this.bunifuButton3.AllowMouseEffects = true;
            this.bunifuButton3.AllowToggling = false;
            this.bunifuButton3.AnimationSpeed = 200;
            this.bunifuButton3.AutoGenerateColors = false;
            this.bunifuButton3.AutoRoundBorders = false;
            this.bunifuButton3.AutoSizeLeftIcon = true;
            this.bunifuButton3.AutoSizeRightIcon = true;
            this.bunifuButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton3.BackColor1 = System.Drawing.Color.White;
            this.bunifuButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton3.BackgroundImage")));
            this.bunifuButton3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.ButtonText = "ค้นหารายการ";
            this.bunifuButton3.ButtonTextMarginLeft = 0;
            this.bunifuButton3.ColorContrastOnClick = 45;
            this.bunifuButton3.ColorContrastOnHover = 45;
            this.bunifuButton3.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton3.CustomizableEdges = borderEdges1;
            this.bunifuButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton3.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton3.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton3.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton3.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton3.ForeColor = System.Drawing.Color.Navy;
            this.bunifuButton3.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton3.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton3.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton3.IconMarginLeft = 11;
            this.bunifuButton3.IconPadding = 10;
            this.bunifuButton3.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton3.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton3.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton3.IconSize = 25;
            this.bunifuButton3.IdleBorderColor = System.Drawing.Color.Navy;
            this.bunifuButton3.IdleBorderRadius = 8;
            this.bunifuButton3.IdleBorderThickness = 1;
            this.bunifuButton3.IdleFillColor = System.Drawing.Color.White;
            this.bunifuButton3.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton3.IdleIconLeftImage")));
            this.bunifuButton3.IdleIconRightImage = null;
            this.bunifuButton3.IndicateFocus = false;
            this.bunifuButton3.Location = new System.Drawing.Point(8, 183);
            this.bunifuButton3.Name = "bunifuButton3";
            this.bunifuButton3.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton3.OnDisabledState.BorderRadius = 8;
            this.bunifuButton3.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.OnDisabledState.BorderThickness = 1;
            this.bunifuButton3.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton3.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton3.OnDisabledState.IconLeftImage = null;
            this.bunifuButton3.OnDisabledState.IconRightImage = null;
            this.bunifuButton3.onHoverState.BorderColor = System.Drawing.Color.Navy;
            this.bunifuButton3.onHoverState.BorderRadius = 8;
            this.bunifuButton3.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.onHoverState.BorderThickness = 1;
            this.bunifuButton3.onHoverState.FillColor = System.Drawing.Color.Navy;
            this.bunifuButton3.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.onHoverState.IconLeftImage = null;
            this.bunifuButton3.onHoverState.IconRightImage = null;
            this.bunifuButton3.OnIdleState.BorderColor = System.Drawing.Color.Navy;
            this.bunifuButton3.OnIdleState.BorderRadius = 8;
            this.bunifuButton3.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.OnIdleState.BorderThickness = 1;
            this.bunifuButton3.OnIdleState.FillColor = System.Drawing.Color.White;
            this.bunifuButton3.OnIdleState.ForeColor = System.Drawing.Color.Navy;
            this.bunifuButton3.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton3.OnIdleState.IconLeftImage")));
            this.bunifuButton3.OnIdleState.IconRightImage = null;
            this.bunifuButton3.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton3.OnPressedState.BorderRadius = 8;
            this.bunifuButton3.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.OnPressedState.BorderThickness = 1;
            this.bunifuButton3.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton3.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.OnPressedState.IconLeftImage = null;
            this.bunifuButton3.OnPressedState.IconRightImage = null;
            this.bunifuButton3.Size = new System.Drawing.Size(199, 43);
            this.bunifuButton3.TabIndex = 72;
            this.bunifuButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton3.TextMarginLeft = 0;
            this.bunifuButton3.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton3.UseDefaultRadiusAndThickness = true;
            this.bunifuButton3.Click += new System.EventHandler(this.bunifuButton3_Click);
            // 
            // txtSearchGV
            // 
            this.txtSearchGV.BorderColor = System.Drawing.Color.Black;
            this.txtSearchGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchGV.DefaultText = "";
            this.txtSearchGV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchGV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchGV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchGV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchGV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchGV.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchGV.ForeColor = System.Drawing.Color.Black;
            this.txtSearchGV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchGV.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearchGV.IconRight")));
            this.txtSearchGV.Location = new System.Drawing.Point(7, 299);
            this.txtSearchGV.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtSearchGV.Name = "txtSearchGV";
            this.txtSearchGV.PasswordChar = '\0';
            this.txtSearchGV.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchGV.PlaceholderText = "เลขที่ GV";
            this.txtSearchGV.SelectedText = "";
            this.txtSearchGV.Size = new System.Drawing.Size(200, 38);
            this.txtSearchGV.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearchGV.TabIndex = 73;
            this.txtSearchGV.IconRightClick += new System.EventHandler(this.txtSearchGV_IconRightClick);
            // 
            // frmHistorySuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1418, 920);
            this.Controls.Add(this.gbMain);
            this.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmHistorySuccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHistorySuccess";
            this.Load += new System.EventHandler(this.frmHistorySuccess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox gbMain;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbPO;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblPO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExport;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPrint;
        private System.Windows.Forms.Label lblStructure;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblJobType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_numMeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn wdt_pch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_net;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_dateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_machineOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_lot;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStart;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStop;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton3;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchGV;
    }
}