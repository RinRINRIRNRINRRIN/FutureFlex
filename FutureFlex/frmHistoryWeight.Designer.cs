
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistoryWeight));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbMain = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2NotificationPaint1 = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cl_btnDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cl_btnSend = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cl_wgh_GVNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_GVID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_po = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.BorderColor = System.Drawing.Color.Navy;
            this.gbMain.BorderRadius = 6;
            this.gbMain.Controls.Add(this.label4);
            this.gbMain.Controls.Add(this.label3);
            this.gbMain.Controls.Add(this.label2);
            this.gbMain.Controls.Add(this.label1);
            this.gbMain.Controls.Add(this.bunifuButton1);
            this.gbMain.Controls.Add(this.dgvDetail);
            this.gbMain.CustomBorderColor = System.Drawing.Color.Navy;
            this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMain.Font = new System.Drawing.Font("Athiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMain.ForeColor = System.Drawing.Color.White;
            this.gbMain.Location = new System.Drawing.Point(0, 0);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(1436, 572);
            this.gbMain.TabIndex = 1;
            this.gbMain.Text = "ประวัติการชั่ง";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "เลือกข้อูล";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.White;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "ส่งข้อมูล ODOO";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges2;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton1.ForeColor = System.Drawing.Color.Green;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Green;
            this.bunifuButton1.IdleBorderRadius = 8;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.White;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(12, 515);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 8;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.Green;
            this.bunifuButton1.onHoverState.BorderRadius = 8;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.Green;
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.Green;
            this.bunifuButton1.OnIdleState.BorderRadius = 8;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.Green;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 8;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(165, 43);
            this.bunifuButton1.TabIndex = 2;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
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
            this.cl_btnSend,
            this.cl_wgh_GVNAME,
            this.cl_wgh_id,
            this.cl_wgh_dateTime,
            this.cl_wgh_employee,
            this.cl_wgh_GVID,
            this.cl_wgh_po,
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
            this.dgvDetail.Location = new System.Drawing.Point(183, 43);
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
            this.dgvDetail.Size = new System.Drawing.Size(1250, 515);
            this.dgvDetail.TabIndex = 1;
            this.dgvDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellContentClick);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2NotificationPaint1
            // 
            this.guna2NotificationPaint1.Alignment = Guna.UI2.WinForms.Enums.CustomContentAlignment.TopRight;
            this.guna2NotificationPaint1.FillColor = System.Drawing.Color.Red;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "ความหมายสี";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Green;
            this.label3.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "ส่งข้อมูล สำเร็จ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "ส่งข้อมูล ไม่สำเร็จ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cl_btnDel
            // 
            this.cl_btnDel.HeaderText = "";
            this.cl_btnDel.Name = "cl_btnDel";
            this.cl_btnDel.ReadOnly = true;
            this.cl_btnDel.Text = "DELETE";
            this.cl_btnDel.UseColumnTextForButtonValue = true;
            // 
            // cl_btnSend
            // 
            this.cl_btnSend.HeaderText = "";
            this.cl_btnSend.Name = "cl_btnSend";
            this.cl_btnSend.ReadOnly = true;
            this.cl_btnSend.Text = "SEND";
            this.cl_btnSend.UseColumnTextForButtonValue = true;
            // 
            // cl_wgh_GVNAME
            // 
            this.cl_wgh_GVNAME.DataPropertyName = "wgh_GVNAME";
            this.cl_wgh_GVNAME.HeaderText = "เลขที่ GV";
            this.cl_wgh_GVNAME.Name = "cl_wgh_GVNAME";
            this.cl_wgh_GVNAME.ReadOnly = true;
            this.cl_wgh_GVNAME.Width = 150;
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
            // cl_wgh_po
            // 
            this.cl_wgh_po.DataPropertyName = "wgh_po";
            this.cl_wgh_po.HeaderText = "เลขที่ PO";
            this.cl_wgh_po.Name = "cl_wgh_po";
            this.cl_wgh_po.ReadOnly = true;
            this.cl_wgh_po.Width = 110;
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
            // frmHistoryWeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1436, 572);
            this.Controls.Add(this.gbMain);
            this.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmHistoryWeight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ประวัติการชั่ง";
            this.Load += new System.EventHandler(this.frmHistoryWeight_Load);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbMain;
        private System.Windows.Forms.DataGridView dgvDetail;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Guna.UI2.WinForms.Guna2NotificationPaint guna2NotificationPaint1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewButtonColumn cl_btnDel;
        private System.Windows.Forms.DataGridViewButtonColumn cl_btnSend;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_GVNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_dateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_GVID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_po;
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
    }
}