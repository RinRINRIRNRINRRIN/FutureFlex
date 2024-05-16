namespace FutureFlex
{
    partial class frmPrivilage
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
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState4 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState5 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState6 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState1 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState2 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState3 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrivilage));
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnControl = new System.Windows.Forms.Panel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.tgsWghEdit = new Bunifu.UI.WinForms.BunifuToggleSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbEmployList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.cbSetting = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbWeight = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbPrivilage = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbReprintJIT = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbHistory = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tgsWghDel = new Bunifu.UI.WinForms.BunifuToggleSwitch();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddAccount = new Bunifu.UI.WinForms.BunifuImageButton();
            this.guna2GroupBox1.SuspendLayout();
            this.pnControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Navy;
            this.guna2GroupBox1.BorderRadius = 6;
            this.guna2GroupBox1.Controls.Add(this.btnAddAccount);
            this.guna2GroupBox1.Controls.Add(this.guna2ControlBox1);
            this.guna2GroupBox1.Controls.Add(this.pnControl);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.cbbEmployList);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Navy;
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Athiti Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(454, 329);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "สิทธิ์การใช้งานโปรแกรม";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Navy;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(400, 7);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 15;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.label3);
            this.pnControl.Controls.Add(this.tgsWghDel);
            this.pnControl.Controls.Add(this.label1);
            this.pnControl.Controls.Add(this.cbHistory);
            this.pnControl.Controls.Add(this.cbReprintJIT);
            this.pnControl.Controls.Add(this.cbPrivilage);
            this.pnControl.Controls.Add(this.tgsWghEdit);
            this.pnControl.Controls.Add(this.cbWeight);
            this.pnControl.Controls.Add(this.cbSetting);
            this.pnControl.Controls.Add(this.btnSave);
            this.pnControl.Enabled = false;
            this.pnControl.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnControl.Location = new System.Drawing.Point(12, 124);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(428, 191);
            this.pnControl.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BorderColor = System.Drawing.Color.Green;
            this.btnSave.BorderRadius = 6;
            this.btnSave.BorderThickness = 1;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Green;
            this.btnSave.Location = new System.Drawing.Point(52, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(332, 32);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "บันทึก";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tgsWghEdit
            // 
            this.tgsWghEdit.Animation = 5;
            this.tgsWghEdit.BackColor = System.Drawing.Color.Transparent;
            this.tgsWghEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tgsWghEdit.BackgroundImage")));
            this.tgsWghEdit.Checked = false;
            this.tgsWghEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tgsWghEdit.InnerCirclePadding = 3;
            this.tgsWghEdit.Location = new System.Drawing.Point(364, 75);
            this.tgsWghEdit.Margin = new System.Windows.Forms.Padding(16, 38, 16, 38);
            this.tgsWghEdit.Name = "tgsWghEdit";
            this.tgsWghEdit.Size = new System.Drawing.Size(40, 20);
            this.tgsWghEdit.TabIndex = 3;
            this.tgsWghEdit.ThumbMargin = 3;
            toggleState4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            toggleState4.BackColorInner = System.Drawing.Color.White;
            toggleState4.BorderColor = System.Drawing.Color.Red;
            toggleState4.BorderColorInner = System.Drawing.Color.White;
            toggleState4.BorderRadius = 17;
            toggleState4.BorderRadiusInner = 11;
            toggleState4.BorderThickness = 1;
            toggleState4.BorderThicknessInner = 1;
            this.tgsWghEdit.ToggleStateDisabled = toggleState4;
            toggleState5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            toggleState5.BackColorInner = System.Drawing.Color.White;
            toggleState5.BorderColor = System.Drawing.Color.Red;
            toggleState5.BorderColorInner = System.Drawing.Color.White;
            toggleState5.BorderRadius = 17;
            toggleState5.BorderRadiusInner = 11;
            toggleState5.BorderThickness = 1;
            toggleState5.BorderThicknessInner = 1;
            this.tgsWghEdit.ToggleStateOff = toggleState5;
            toggleState6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            toggleState6.BackColorInner = System.Drawing.Color.White;
            toggleState6.BorderColor = System.Drawing.Color.Green;
            toggleState6.BorderColorInner = System.Drawing.Color.White;
            toggleState6.BorderRadius = 17;
            toggleState6.BorderRadiusInner = 11;
            toggleState6.BorderThickness = 1;
            toggleState6.BorderThicknessInner = 1;
            this.tgsWghEdit.ToggleStateOn = toggleState6;
            this.tgsWghEdit.Value = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Athiti Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "รายชื่อพนักงาน";
            // 
            // cbbEmployList
            // 
            this.cbbEmployList.BackColor = System.Drawing.Color.Transparent;
            this.cbbEmployList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbbEmployList.BorderRadius = 6;
            this.cbbEmployList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbEmployList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEmployList.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbEmployList.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbEmployList.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEmployList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbEmployList.ItemHeight = 30;
            this.cbbEmployList.Location = new System.Drawing.Point(12, 82);
            this.cbbEmployList.Name = "cbbEmployList";
            this.cbbEmployList.Size = new System.Drawing.Size(376, 36);
            this.cbbEmployList.TabIndex = 5;
            this.cbbEmployList.DropDown += new System.EventHandler(this.cbbEmployList_DropDown);
            this.cbbEmployList.SelectedIndexChanged += new System.EventHandler(this.cbbEmployList_SelectedIndexChanged);
            this.cbbEmployList.DropDownClosed += new System.EventHandler(this.cbbEmployList_DropDownClosed);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2GroupBox1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // cbSetting
            // 
            this.cbSetting.Animated = true;
            this.cbSetting.AutoSize = true;
            this.cbSetting.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.cbSetting.CheckedState.BorderRadius = 6;
            this.cbSetting.CheckedState.BorderThickness = 1;
            this.cbSetting.CheckedState.FillColor = System.Drawing.Color.Green;
            this.cbSetting.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSetting.ForeColor = System.Drawing.Color.Black;
            this.cbSetting.Location = new System.Drawing.Point(13, 45);
            this.cbSetting.Name = "cbSetting";
            this.cbSetting.Size = new System.Drawing.Size(137, 29);
            this.cbSetting.TabIndex = 17;
            this.cbSetting.Tag = "setting";
            this.cbSetting.Text = "เมนู ตั้งค่าระบบ";
            this.cbSetting.UncheckedState.BorderColor = System.Drawing.Color.Green;
            this.cbSetting.UncheckedState.BorderRadius = 6;
            this.cbSetting.UncheckedState.BorderThickness = 1;
            this.cbSetting.UncheckedState.FillColor = System.Drawing.Color.White;
            // 
            // cbWeight
            // 
            this.cbWeight.Animated = true;
            this.cbWeight.AutoSize = true;
            this.cbWeight.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.cbWeight.CheckedState.BorderRadius = 6;
            this.cbWeight.CheckedState.BorderThickness = 1;
            this.cbWeight.CheckedState.FillColor = System.Drawing.Color.Green;
            this.cbWeight.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWeight.ForeColor = System.Drawing.Color.Black;
            this.cbWeight.Location = new System.Drawing.Point(310, 10);
            this.cbWeight.Name = "cbWeight";
            this.cbWeight.Size = new System.Drawing.Size(107, 29);
            this.cbWeight.TabIndex = 18;
            this.cbWeight.Tag = "weight";
            this.cbWeight.Text = "เมนู การชั่ง";
            this.cbWeight.UncheckedState.BorderColor = System.Drawing.Color.Green;
            this.cbWeight.UncheckedState.BorderRadius = 6;
            this.cbWeight.UncheckedState.BorderThickness = 1;
            this.cbWeight.UncheckedState.FillColor = System.Drawing.Color.White;
            // 
            // cbPrivilage
            // 
            this.cbPrivilage.Animated = true;
            this.cbPrivilage.AutoSize = true;
            this.cbPrivilage.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.cbPrivilage.CheckedState.BorderRadius = 6;
            this.cbPrivilage.CheckedState.BorderThickness = 1;
            this.cbPrivilage.CheckedState.FillColor = System.Drawing.Color.Green;
            this.cbPrivilage.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrivilage.ForeColor = System.Drawing.Color.Black;
            this.cbPrivilage.Location = new System.Drawing.Point(13, 10);
            this.cbPrivilage.Name = "cbPrivilage";
            this.cbPrivilage.Size = new System.Drawing.Size(209, 29);
            this.cbPrivilage.TabIndex = 19;
            this.cbPrivilage.Tag = "account";
            this.cbPrivilage.Text = "เมนู กำหนดสิทธิ์การใช้งาน";
            this.cbPrivilage.UncheckedState.BorderColor = System.Drawing.Color.Green;
            this.cbPrivilage.UncheckedState.BorderRadius = 6;
            this.cbPrivilage.UncheckedState.BorderThickness = 1;
            this.cbPrivilage.UncheckedState.FillColor = System.Drawing.Color.White;
            // 
            // cbReprintJIT
            // 
            this.cbReprintJIT.Animated = true;
            this.cbReprintJIT.AutoSize = true;
            this.cbReprintJIT.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.cbReprintJIT.CheckedState.BorderRadius = 6;
            this.cbReprintJIT.CheckedState.BorderThickness = 1;
            this.cbReprintJIT.CheckedState.FillColor = System.Drawing.Color.Green;
            this.cbReprintJIT.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReprintJIT.ForeColor = System.Drawing.Color.Black;
            this.cbReprintJIT.Location = new System.Drawing.Point(13, 80);
            this.cbReprintJIT.Name = "cbReprintJIT";
            this.cbReprintJIT.Size = new System.Drawing.Size(148, 29);
            this.cbReprintJIT.TabIndex = 20;
            this.cbReprintJIT.Tag = "reprintJIT";
            this.cbReprintJIT.Text = "เมนู Reprint JIT";
            this.cbReprintJIT.UncheckedState.BorderColor = System.Drawing.Color.Green;
            this.cbReprintJIT.UncheckedState.BorderRadius = 6;
            this.cbReprintJIT.UncheckedState.BorderThickness = 1;
            this.cbReprintJIT.UncheckedState.FillColor = System.Drawing.Color.White;
            // 
            // cbHistory
            // 
            this.cbHistory.Animated = true;
            this.cbHistory.AutoSize = true;
            this.cbHistory.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.cbHistory.CheckedState.BorderRadius = 6;
            this.cbHistory.CheckedState.BorderThickness = 1;
            this.cbHistory.CheckedState.FillColor = System.Drawing.Color.Green;
            this.cbHistory.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHistory.ForeColor = System.Drawing.Color.Black;
            this.cbHistory.Location = new System.Drawing.Point(13, 115);
            this.cbHistory.Name = "cbHistory";
            this.cbHistory.Size = new System.Drawing.Size(153, 29);
            this.cbHistory.TabIndex = 21;
            this.cbHistory.Tag = "history";
            this.cbHistory.Text = "เมนู ประวัติการชั่ง";
            this.cbHistory.UncheckedState.BorderColor = System.Drawing.Color.Green;
            this.cbHistory.UncheckedState.BorderRadius = 6;
            this.cbHistory.UncheckedState.BorderThickness = 1;
            this.cbHistory.UncheckedState.FillColor = System.Drawing.Color.White;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(325, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "ลบ";
            // 
            // tgsWghDel
            // 
            this.tgsWghDel.Animation = 5;
            this.tgsWghDel.BackColor = System.Drawing.Color.Transparent;
            this.tgsWghDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tgsWghDel.BackgroundImage")));
            this.tgsWghDel.Checked = false;
            this.tgsWghDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tgsWghDel.InnerCirclePadding = 3;
            this.tgsWghDel.Location = new System.Drawing.Point(364, 46);
            this.tgsWghDel.Margin = new System.Windows.Forms.Padding(21, 73, 21, 73);
            this.tgsWghDel.Name = "tgsWghDel";
            this.tgsWghDel.Size = new System.Drawing.Size(40, 20);
            this.tgsWghDel.TabIndex = 23;
            this.tgsWghDel.ThumbMargin = 3;
            toggleState1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            toggleState1.BackColorInner = System.Drawing.Color.White;
            toggleState1.BorderColor = System.Drawing.Color.Red;
            toggleState1.BorderColorInner = System.Drawing.Color.White;
            toggleState1.BorderRadius = 17;
            toggleState1.BorderRadiusInner = 11;
            toggleState1.BorderThickness = 1;
            toggleState1.BorderThicknessInner = 1;
            this.tgsWghDel.ToggleStateDisabled = toggleState1;
            toggleState2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            toggleState2.BackColorInner = System.Drawing.Color.White;
            toggleState2.BorderColor = System.Drawing.Color.Red;
            toggleState2.BorderColorInner = System.Drawing.Color.White;
            toggleState2.BorderRadius = 17;
            toggleState2.BorderRadiusInner = 11;
            toggleState2.BorderThickness = 1;
            toggleState2.BorderThicknessInner = 1;
            this.tgsWghDel.ToggleStateOff = toggleState2;
            toggleState3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            toggleState3.BackColorInner = System.Drawing.Color.White;
            toggleState3.BorderColor = System.Drawing.Color.Green;
            toggleState3.BorderColorInner = System.Drawing.Color.White;
            toggleState3.BorderRadius = 17;
            toggleState3.BorderRadiusInner = 11;
            toggleState3.BorderThickness = 1;
            toggleState3.BorderThicknessInner = 1;
            this.tgsWghDel.ToggleStateOn = toggleState3;
            this.tgsWghDel.Value = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(310, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "แก้ไข";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.ActiveImage = null;
            this.btnAddAccount.AllowAnimations = true;
            this.btnAddAccount.AllowBuffering = false;
            this.btnAddAccount.AllowToggling = false;
            this.btnAddAccount.AllowZooming = true;
            this.btnAddAccount.AllowZoomingOnFocus = false;
            this.btnAddAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAccount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddAccount.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnAddAccount.ErrorImage")));
            this.btnAddAccount.FadeWhenInactive = false;
            this.btnAddAccount.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnAddAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAccount.Image")));
            this.btnAddAccount.ImageActive = null;
            this.btnAddAccount.ImageLocation = null;
            this.btnAddAccount.ImageMargin = 15;
            this.btnAddAccount.ImageSize = new System.Drawing.Size(31, 29);
            this.btnAddAccount.ImageZoomSize = new System.Drawing.Size(46, 44);
            this.btnAddAccount.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnAddAccount.InitialImage")));
            this.btnAddAccount.Location = new System.Drawing.Point(394, 77);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Rotation = 0;
            this.btnAddAccount.ShowActiveImage = true;
            this.btnAddAccount.ShowCursorChanges = true;
            this.btnAddAccount.ShowImageBorders = true;
            this.btnAddAccount.ShowSizeMarkers = false;
            this.btnAddAccount.Size = new System.Drawing.Size(46, 44);
            this.btnAddAccount.TabIndex = 17;
            this.btnAddAccount.ToolTipText = "";
            this.btnAddAccount.WaitOnLoad = false;
            this.btnAddAccount.Zoom = 15;
            this.btnAddAccount.ZoomSpeed = 10;
            // 
            // frmPrivilage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 329);
            this.Controls.Add(this.guna2GroupBox1);
            this.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmPrivilage";
            this.Text = "frmPrivilage";
            this.Load += new System.EventHandler(this.frmPrivilage_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.pnControl.ResumeLayout(false);
            this.pnControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbEmployList;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuToggleSwitch tgsWghEdit;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel pnControl;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2CheckBox cbSetting;
        private Guna.UI2.WinForms.Guna2CheckBox cbPrivilage;
        private Guna.UI2.WinForms.Guna2CheckBox cbWeight;
        private Guna.UI2.WinForms.Guna2CheckBox cbReprintJIT;
        private Guna.UI2.WinForms.Guna2CheckBox cbHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuToggleSwitch tgsWghDel;
        private Bunifu.UI.WinForms.BunifuImageButton btnAddAccount;
    }
}