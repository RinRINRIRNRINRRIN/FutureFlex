namespace FutureFlex
{
    partial class frmSPLList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSPLList));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.msg = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.gbWeightPoOrJit = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtPO = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSPL = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCheck = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2RadioButton2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2RadioButton1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbData = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.cl_rtfg = new System.Windows.Forms.DataGridViewImageColumn();
            this.cl_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_partner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_uom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbLoadData = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.gbWeightPoOrJit.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.gbLoadData.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.Teal;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.Teal;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // msg
            // 
            this.msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msg.Caption = null;
            this.msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.msg.Parent = null;
            this.msg.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.msg.Text = null;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.White;
            this.label43.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label43.ForeColor = System.Drawing.Color.Navy;
            this.label43.Location = new System.Drawing.Point(10, 48);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(121, 25);
            this.label43.TabIndex = 67;
            this.label43.Text = "สินค้าที่จะแบ่งม้วน\r\n";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.White;
            this.label42.Font = new System.Drawing.Font("Athiti Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label42.ForeColor = System.Drawing.Color.Navy;
            this.label42.Location = new System.Drawing.Point(7, 3);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(320, 51);
            this.label42.TabIndex = 66;
            this.label42.Text = "รายการสินค้าที่แบ่งม้วน";
            // 
            // gbWeightPoOrJit
            // 
            this.gbWeightPoOrJit.BorderColor = System.Drawing.Color.SteelBlue;
            this.gbWeightPoOrJit.BorderRadius = 4;
            this.gbWeightPoOrJit.Controls.Add(this.txtPO);
            this.gbWeightPoOrJit.Controls.Add(this.txtSPL);
            this.gbWeightPoOrJit.Controls.Add(this.btnCheck);
            this.gbWeightPoOrJit.Controls.Add(this.guna2RadioButton2);
            this.gbWeightPoOrJit.Controls.Add(this.guna2RadioButton1);
            this.gbWeightPoOrJit.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(76)))), ((int)(((byte)(183)))));
            this.gbWeightPoOrJit.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWeightPoOrJit.ForeColor = System.Drawing.Color.White;
            this.gbWeightPoOrJit.Location = new System.Drawing.Point(339, 175);
            this.gbWeightPoOrJit.Name = "gbWeightPoOrJit";
            this.gbWeightPoOrJit.Size = new System.Drawing.Size(279, 267);
            this.gbWeightPoOrJit.TabIndex = 83;
            this.gbWeightPoOrJit.Text = "ชั่งแบ่งเพื่อเก็บ หรือ ชั่งเพื่อขาย";
            this.gbWeightPoOrJit.Visible = false;
            // 
            // txtPO
            // 
            this.txtPO.BorderColor = System.Drawing.Color.Navy;
            this.txtPO.BorderRadius = 8;
            this.txtPO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPO.DefaultText = "";
            this.txtPO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPO.Enabled = false;
            this.txtPO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPO.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPO.ForeColor = System.Drawing.Color.Black;
            this.txtPO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPO.IconRightSize = new System.Drawing.Size(30, 30);
            this.txtPO.Location = new System.Drawing.Point(54, 72);
            this.txtPO.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtPO.Name = "txtPO";
            this.txtPO.PasswordChar = '\0';
            this.txtPO.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPO.PlaceholderText = "เลขที่ PO";
            this.txtPO.SelectedText = "";
            this.txtPO.Size = new System.Drawing.Size(195, 40);
            this.txtPO.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPO.TabIndex = 71;
            this.txtPO.Tag = "PO";
            this.txtPO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJobNo_KeyDown);
            // 
            // txtSPL
            // 
            this.txtSPL.BorderColor = System.Drawing.Color.Navy;
            this.txtSPL.BorderRadius = 8;
            this.txtSPL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSPL.DefaultText = "";
            this.txtSPL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSPL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSPL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSPL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSPL.Enabled = false;
            this.txtSPL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSPL.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSPL.ForeColor = System.Drawing.Color.Black;
            this.txtSPL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSPL.IconRightSize = new System.Drawing.Size(30, 30);
            this.txtSPL.Location = new System.Drawing.Point(52, 168);
            this.txtSPL.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtSPL.Name = "txtSPL";
            this.txtSPL.PasswordChar = '\0';
            this.txtSPL.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSPL.PlaceholderText = "เลขที่ SPLIT";
            this.txtSPL.SelectedText = "";
            this.txtSPL.Size = new System.Drawing.Size(195, 40);
            this.txtSPL.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSPL.TabIndex = 70;
            this.txtSPL.Tag = "JIT";
            this.txtSPL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSPL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJobNo_KeyDown);
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheck.Animated = true;
            this.btnCheck.BorderRadius = 6;
            this.btnCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheck.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheck.FillColor2 = System.Drawing.Color.MidnightBlue;
            this.btnCheck.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnCheck.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCheck.Location = new System.Drawing.Point(6, 224);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(267, 35);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "คืนสินค้า";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // guna2RadioButton2
            // 
            this.guna2RadioButton2.AutoSize = true;
            this.guna2RadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton2.CheckedState.BorderThickness = 0;
            this.guna2RadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton2.CheckedState.InnerOffset = -4;
            this.guna2RadioButton2.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2RadioButton2.ForeColor = System.Drawing.Color.Black;
            this.guna2RadioButton2.Location = new System.Drawing.Point(28, 132);
            this.guna2RadioButton2.Name = "guna2RadioButton2";
            this.guna2RadioButton2.Size = new System.Drawing.Size(160, 29);
            this.guna2RadioButton2.TabIndex = 1;
            this.guna2RadioButton2.Tag = "JIT";
            this.guna2RadioButton2.Text = "ชั่งสินค้าเพื่อเก็บ (JIT)";
            this.guna2RadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2RadioButton2.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton2.CheckedChanged += new System.EventHandler(this.guna2RadioButton1_CheckedChanged);
            // 
            // guna2RadioButton1
            // 
            this.guna2RadioButton1.AutoSize = true;
            this.guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton1.CheckedState.BorderThickness = 0;
            this.guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton1.CheckedState.InnerOffset = -4;
            this.guna2RadioButton1.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2RadioButton1.ForeColor = System.Drawing.Color.Black;
            this.guna2RadioButton1.Location = new System.Drawing.Point(30, 44);
            this.guna2RadioButton1.Name = "guna2RadioButton1";
            this.guna2RadioButton1.Size = new System.Drawing.Size(158, 29);
            this.guna2RadioButton1.TabIndex = 0;
            this.guna2RadioButton1.Tag = "PO";
            this.guna2RadioButton1.Text = "ชั่งสินค้าเพื่อขาย (PO)";
            this.guna2RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2RadioButton1.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton1.CheckedChanged += new System.EventHandler(this.guna2RadioButton1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbData);
            this.panel1.Location = new System.Drawing.Point(6, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 535);
            this.panel1.TabIndex = 84;
            this.panel1.Visible = false;
            // 
            // gbData
            // 
            this.gbData.BorderColor = System.Drawing.Color.SteelBlue;
            this.gbData.Controls.Add(this.guna2GradientButton1);
            this.gbData.Controls.Add(this.dgvDetail);
            this.gbData.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(76)))), ((int)(((byte)(183)))));
            this.gbData.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbData.ForeColor = System.Drawing.Color.White;
            this.gbData.Location = new System.Drawing.Point(3, 7);
            this.gbData.Name = "gbData";
            this.gbData.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.gbData.Size = new System.Drawing.Size(1057, 521);
            this.gbData.TabIndex = 68;
            this.gbData.Text = "รายการ SPLIT";
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 6;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.MidnightBlue;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GradientButton1.Location = new System.Drawing.Point(937, 4);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(115, 30);
            this.guna2GradientButton1.TabIndex = 72;
            this.guna2GradientButton1.Text = "ย้อนกลับ";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
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
            this.dgvDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetail.CausesValidation = false;
            this.dgvDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(76)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(76)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetail.ColumnHeadersHeight = 50;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_rtfg,
            this.cl_id,
            this.cl_name,
            this.cl_partner,
            this.cl_product,
            this.cl_uom});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetail.GridColor = System.Drawing.Color.White;
            this.dgvDetail.Location = new System.Drawing.Point(2, 40);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Info;
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
            this.dgvDetail.RowTemplate.Height = 45;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDetail.Size = new System.Drawing.Size(1053, 479);
            this.dgvDetail.TabIndex = 68;
            this.dgvDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellContentClick);
            // 
            // cl_rtfg
            // 
            this.cl_rtfg.HeaderText = "";
            this.cl_rtfg.Image = ((System.Drawing.Image)(resources.GetObject("cl_rtfg.Image")));
            this.cl_rtfg.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.cl_rtfg.Name = "cl_rtfg";
            this.cl_rtfg.ReadOnly = true;
            this.cl_rtfg.Width = 50;
            // 
            // cl_id
            // 
            this.cl_id.DataPropertyName = "id";
            this.cl_id.HeaderText = "ID";
            this.cl_id.Name = "cl_id";
            this.cl_id.ReadOnly = true;
            this.cl_id.Visible = false;
            // 
            // cl_name
            // 
            this.cl_name.DataPropertyName = "name";
            this.cl_name.HeaderText = "GV Name";
            this.cl_name.Name = "cl_name";
            this.cl_name.ReadOnly = true;
            this.cl_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_name.Width = 200;
            // 
            // cl_partner
            // 
            this.cl_partner.DataPropertyName = "partner_name";
            this.cl_partner.HeaderText = "Partner";
            this.cl_partner.Name = "cl_partner";
            this.cl_partner.ReadOnly = true;
            this.cl_partner.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_partner.Width = 350;
            // 
            // cl_product
            // 
            this.cl_product.DataPropertyName = "product_name";
            this.cl_product.HeaderText = "Product Name";
            this.cl_product.Name = "cl_product";
            this.cl_product.ReadOnly = true;
            this.cl_product.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_product.Width = 350;
            // 
            // cl_uom
            // 
            this.cl_uom.DataPropertyName = "uom";
            this.cl_uom.HeaderText = "UOM";
            this.cl_uom.Name = "cl_uom";
            this.cl_uom.ReadOnly = true;
            this.cl_uom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gbLoadData
            // 
            this.gbLoadData.BorderColor = System.Drawing.Color.Navy;
            this.gbLoadData.BorderRadius = 4;
            this.gbLoadData.Controls.Add(this.label4);
            this.gbLoadData.Controls.Add(this.guna2CircleProgressBar1);
            this.gbLoadData.CustomBorderColor = System.Drawing.Color.Navy;
            this.gbLoadData.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.gbLoadData.Font = new System.Drawing.Font("Athiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLoadData.ForeColor = System.Drawing.Color.White;
            this.gbLoadData.Location = new System.Drawing.Point(534, 20);
            this.gbLoadData.Name = "gbLoadData";
            this.gbLoadData.Size = new System.Drawing.Size(406, 96);
            this.gbLoadData.TabIndex = 85;
            this.gbLoadData.Text = "กำลังโหลดข้อมูล";
            this.gbLoadData.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Athiti Medium", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(105, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 39);
            this.label4.TabIndex = 56;
            this.label4.Text = "กำลังโหลดข้อมูล............";
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
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Navy;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1031, 4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 86;
            // 
            // frmSPLList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 617);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.gbLoadData);
            this.Controls.Add(this.gbWeightPoOrJit);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmSPLList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSPLList";
            this.Load += new System.EventHandler(this.frmSPLList_Load);
            this.gbWeightPoOrJit.ResumeLayout(false);
            this.gbWeightPoOrJit.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.gbLoadData.ResumeLayout(false);
            this.gbLoadData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2MessageDialog msg;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private Guna.UI2.WinForms.Guna2GroupBox gbWeightPoOrJit;
        private Guna.UI2.WinForms.Guna2TextBox txtPO;
        private Guna.UI2.WinForms.Guna2TextBox txtSPL;
        private Guna.UI2.WinForms.Guna2GradientButton btnCheck;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton2;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GroupBox gbData;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.DataGridViewImageColumn cl_rtfg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_partner;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_uom;
        private Guna.UI2.WinForms.Guna2GroupBox gbLoadData;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}