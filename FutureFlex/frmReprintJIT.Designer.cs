namespace FutureFlex
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtPO = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.cl_wgh_seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_GVID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_lot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_GVNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_county = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_side = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_net = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_tare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_gross = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_weightCore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_joint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_numMeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_weightRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_machineOperator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_po = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_weightPaper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_boxNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_weightBlade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_machineOparator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_statusOdoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblQRCODE = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            this.bunifuGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.White;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Navy;
            this.guna2GroupBox1.BorderRadius = 6;
            this.guna2GroupBox1.Controls.Add(this.lblQRCODE);
            this.guna2GroupBox1.Controls.Add(this.txtPO);
            this.guna2GroupBox1.Controls.Add(this.guna2ControlBox1);
            this.guna2GroupBox1.Controls.Add(this.bunifuGroupBox1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Navy;
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(822, 797);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Reprint JIT";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Navy;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Navy;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(766, 5);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 3;
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BackColor = System.Drawing.Color.White;
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.Navy;
            this.bunifuGroupBox1.BorderRadius = 6;
            this.bunifuGroupBox1.BorderThickness = 2;
            this.bunifuGroupBox1.Controls.Add(this.dgvDetail);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(12, 146);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(795, 639);
            this.bunifuGroupBox1.TabIndex = 2;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Text = "รายละเอียด";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2GroupBox1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM12";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
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
            this.txtPO.Font = new System.Drawing.Font("Athiti Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPO.ForeColor = System.Drawing.Color.Black;
            this.txtPO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPO.Location = new System.Drawing.Point(14, 47);
            this.txtPO.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPO.Name = "txtPO";
            this.txtPO.PasswordChar = '\0';
            this.txtPO.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPO.PlaceholderText = "กรอกเลขที่ PO (กด Enter เพื่อค้นหา)";
            this.txtPO.SelectedText = "";
            this.txtPO.Size = new System.Drawing.Size(786, 52);
            this.txtPO.TabIndex = 4;
            this.txtPO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetail.ColumnHeadersHeight = 35;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_wgh_seq,
            this.cl_wgh_GVID,
            this.cl_wgh_lot,
            this.cl_wgh_id,
            this.cl_wgh_GVNAME,
            this.cl_wgh_county,
            this.cl_wgh_type,
            this.cl_wgh_side,
            this.cl_wgh_net,
            this.cl_wgh_tare,
            this.cl_wgh_gross,
            this.cl_wgh_weightCore,
            this.cl_wgh_joint,
            this.cl_wgh_numMeter,
            this.cl_wgh_weightRoll,
            this.cl_wgh_machineOperator,
            this.cl_wgh_dateTime,
            this.cl_wgh_po,
            this.cl_wgh_weightPaper,
            this.cl_wgh_boxNum,
            this.cl_wgh_weightBlade,
            this.cl_wgh_machineOparator,
            this.cl_wgh_statusOdoo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetail.EnableHeadersVisualStyles = false;
            this.dgvDetail.GridColor = System.Drawing.Color.White;
            this.dgvDetail.Location = new System.Drawing.Point(14, 30);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDetail.Size = new System.Drawing.Size(772, 603);
            this.dgvDetail.TabIndex = 1;
            // 
            // cl_wgh_seq
            // 
            this.cl_wgh_seq.DataPropertyName = "wgh_seq";
            this.cl_wgh_seq.HeaderText = "ลำดับ";
            this.cl_wgh_seq.Name = "cl_wgh_seq";
            this.cl_wgh_seq.ReadOnly = true;
            this.cl_wgh_seq.Width = 80;
            // 
            // cl_wgh_GVID
            // 
            this.cl_wgh_GVID.DataPropertyName = "wgh_GVID";
            this.cl_wgh_GVID.HeaderText = "GV";
            this.cl_wgh_GVID.Name = "cl_wgh_GVID";
            this.cl_wgh_GVID.ReadOnly = true;
            this.cl_wgh_GVID.Width = 180;
            // 
            // cl_wgh_lot
            // 
            this.cl_wgh_lot.DataPropertyName = "wgh_lot";
            this.cl_wgh_lot.HeaderText = "Lot";
            this.cl_wgh_lot.Name = "cl_wgh_lot";
            this.cl_wgh_lot.ReadOnly = true;
            this.cl_wgh_lot.Width = 200;
            // 
            // cl_wgh_id
            // 
            this.cl_wgh_id.DataPropertyName = "wgh_id";
            this.cl_wgh_id.HeaderText = "wgh_id";
            this.cl_wgh_id.Name = "cl_wgh_id";
            this.cl_wgh_id.ReadOnly = true;
            this.cl_wgh_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_wgh_id.Visible = false;
            // 
            // cl_wgh_GVNAME
            // 
            this.cl_wgh_GVNAME.DataPropertyName = "wgh_GVNAME";
            this.cl_wgh_GVNAME.HeaderText = "wgh_GVNAME";
            this.cl_wgh_GVNAME.Name = "cl_wgh_GVNAME";
            this.cl_wgh_GVNAME.ReadOnly = true;
            this.cl_wgh_GVNAME.Visible = false;
            // 
            // cl_wgh_county
            // 
            this.cl_wgh_county.DataPropertyName = "wgh_county";
            this.cl_wgh_county.HeaderText = "เลือกประเทศ";
            this.cl_wgh_county.Name = "cl_wgh_county";
            this.cl_wgh_county.ReadOnly = true;
            this.cl_wgh_county.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_wgh_county.Visible = false;
            this.cl_wgh_county.Width = 140;
            // 
            // cl_wgh_type
            // 
            this.cl_wgh_type.DataPropertyName = "wgh_type";
            this.cl_wgh_type.HeaderText = "ประเภท";
            this.cl_wgh_type.Name = "cl_wgh_type";
            this.cl_wgh_type.ReadOnly = true;
            this.cl_wgh_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_wgh_type.Visible = false;
            // 
            // cl_wgh_side
            // 
            this.cl_wgh_side.DataPropertyName = "wgh_side";
            this.cl_wgh_side.HeaderText = "ด้าน";
            this.cl_wgh_side.Name = "cl_wgh_side";
            this.cl_wgh_side.ReadOnly = true;
            this.cl_wgh_side.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_wgh_side.Visible = false;
            this.cl_wgh_side.Width = 80;
            // 
            // cl_wgh_net
            // 
            this.cl_wgh_net.DataPropertyName = "wgh_net";
            this.cl_wgh_net.HeaderText = "NET WGH";
            this.cl_wgh_net.Name = "cl_wgh_net";
            this.cl_wgh_net.ReadOnly = true;
            this.cl_wgh_net.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl_wgh_tare
            // 
            this.cl_wgh_tare.DataPropertyName = "wgh_tare";
            this.cl_wgh_tare.HeaderText = "TARE WGH";
            this.cl_wgh_tare.Name = "cl_wgh_tare";
            this.cl_wgh_tare.ReadOnly = true;
            this.cl_wgh_tare.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl_wgh_gross
            // 
            this.cl_wgh_gross.DataPropertyName = "wgh_gross";
            this.cl_wgh_gross.HeaderText = "GROSS WGH";
            this.cl_wgh_gross.Name = "cl_wgh_gross";
            this.cl_wgh_gross.ReadOnly = true;
            this.cl_wgh_gross.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl_wgh_weightCore
            // 
            this.cl_wgh_weightCore.DataPropertyName = "wgh_weightCore";
            this.cl_wgh_weightCore.HeaderText = "wgh_weightCore";
            this.cl_wgh_weightCore.Name = "cl_wgh_weightCore";
            this.cl_wgh_weightCore.ReadOnly = true;
            this.cl_wgh_weightCore.Visible = false;
            // 
            // cl_wgh_joint
            // 
            this.cl_wgh_joint.DataPropertyName = "wgh_joint";
            this.cl_wgh_joint.HeaderText = "wgh_joint";
            this.cl_wgh_joint.Name = "cl_wgh_joint";
            this.cl_wgh_joint.ReadOnly = true;
            this.cl_wgh_joint.Visible = false;
            // 
            // cl_wgh_numMeter
            // 
            this.cl_wgh_numMeter.DataPropertyName = "wgh_numMeter";
            this.cl_wgh_numMeter.HeaderText = "wgh_numMeter";
            this.cl_wgh_numMeter.Name = "cl_wgh_numMeter";
            this.cl_wgh_numMeter.ReadOnly = true;
            this.cl_wgh_numMeter.Visible = false;
            // 
            // cl_wgh_weightRoll
            // 
            this.cl_wgh_weightRoll.DataPropertyName = "wgh_weightRoll";
            this.cl_wgh_weightRoll.HeaderText = "wgh_weightRoll";
            this.cl_wgh_weightRoll.Name = "cl_wgh_weightRoll";
            this.cl_wgh_weightRoll.ReadOnly = true;
            this.cl_wgh_weightRoll.Visible = false;
            // 
            // cl_wgh_machineOperator
            // 
            this.cl_wgh_machineOperator.DataPropertyName = "wgh_machineOperator";
            this.cl_wgh_machineOperator.HeaderText = "wgh_machineOperator";
            this.cl_wgh_machineOperator.Name = "cl_wgh_machineOperator";
            this.cl_wgh_machineOperator.ReadOnly = true;
            this.cl_wgh_machineOperator.Visible = false;
            // 
            // cl_wgh_dateTime
            // 
            this.cl_wgh_dateTime.DataPropertyName = "wgh_dateTime";
            this.cl_wgh_dateTime.HeaderText = "wgh_dateTime";
            this.cl_wgh_dateTime.Name = "cl_wgh_dateTime";
            this.cl_wgh_dateTime.ReadOnly = true;
            this.cl_wgh_dateTime.Visible = false;
            // 
            // cl_wgh_po
            // 
            this.cl_wgh_po.DataPropertyName = "wgh_po";
            this.cl_wgh_po.HeaderText = "wgh_po";
            this.cl_wgh_po.Name = "cl_wgh_po";
            this.cl_wgh_po.ReadOnly = true;
            this.cl_wgh_po.Visible = false;
            // 
            // cl_wgh_weightPaper
            // 
            this.cl_wgh_weightPaper.DataPropertyName = "wgh_weightPaper";
            this.cl_wgh_weightPaper.HeaderText = "wgh_weightPaper";
            this.cl_wgh_weightPaper.Name = "cl_wgh_weightPaper";
            this.cl_wgh_weightPaper.ReadOnly = true;
            this.cl_wgh_weightPaper.Visible = false;
            // 
            // cl_wgh_boxNum
            // 
            this.cl_wgh_boxNum.DataPropertyName = "wgh_boxNum";
            this.cl_wgh_boxNum.HeaderText = "wgh_boxNum";
            this.cl_wgh_boxNum.Name = "cl_wgh_boxNum";
            this.cl_wgh_boxNum.ReadOnly = true;
            this.cl_wgh_boxNum.Visible = false;
            // 
            // cl_wgh_weightBlade
            // 
            this.cl_wgh_weightBlade.DataPropertyName = "wgh_weightBlade";
            this.cl_wgh_weightBlade.HeaderText = "wgh_weightBlade";
            this.cl_wgh_weightBlade.Name = "cl_wgh_weightBlade";
            this.cl_wgh_weightBlade.ReadOnly = true;
            this.cl_wgh_weightBlade.Visible = false;
            // 
            // cl_wgh_machineOparator
            // 
            this.cl_wgh_machineOparator.DataPropertyName = "wgh_machineOparator";
            this.cl_wgh_machineOparator.HeaderText = "wgh_machineOparator";
            this.cl_wgh_machineOparator.Name = "cl_wgh_machineOparator";
            this.cl_wgh_machineOparator.ReadOnly = true;
            this.cl_wgh_machineOparator.Visible = false;
            // 
            // cl_wgh_statusOdoo
            // 
            this.cl_wgh_statusOdoo.DataPropertyName = "wgh_statusOdoo";
            this.cl_wgh_statusOdoo.HeaderText = "wgh_statusOdoo";
            this.cl_wgh_statusOdoo.Name = "cl_wgh_statusOdoo";
            this.cl_wgh_statusOdoo.ReadOnly = true;
            this.cl_wgh_statusOdoo.Visible = false;
            // 
            // lblQRCODE
            // 
            this.lblQRCODE.AutoSize = true;
            this.lblQRCODE.Font = new System.Drawing.Font("Athiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQRCODE.ForeColor = System.Drawing.Color.Black;
            this.lblQRCODE.Location = new System.Drawing.Point(12, 109);
            this.lblQRCODE.Name = "lblQRCODE";
            this.lblQRCODE.Size = new System.Drawing.Size(112, 33);
            this.lblQRCODE.TabIndex = 5;
            this.lblQRCODE.Text = "QRCODE : ";
            // 
            // frmReprintJIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 797);
            this.Controls.Add(this.guna2GroupBox1);
            this.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmReprintJIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReprintJIT";
            this.Load += new System.EventHandler(this.frmReprintJIT_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.bunifuGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.IO.Ports.SerialPort serialPort1;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtPO;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_GVID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_lot;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_GVNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_county;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_side;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_net;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_tare;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_gross;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_weightCore;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_joint;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_numMeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_weightRoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_machineOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_dateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_po;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_weightPaper;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_boxNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_weightBlade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_machineOparator;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_statusOdoo;
        private System.Windows.Forms.Label lblQRCODE;
    }
}