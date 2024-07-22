namespace FutureFlex
{
    partial class frmPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrint));
            this.guna2NotificationPaint1 = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.gbMain = new Guna.UI2.WinForms.Guna2GroupBox();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbSend = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbNotSend = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtPO = new Guna.UI2.WinForms.Guna2TextBox();
            this.sb = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.gbMain.SuspendLayout();
            this.bunifuGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2NotificationPaint1
            // 
            this.guna2NotificationPaint1.Alignment = Guna.UI2.WinForms.Enums.CustomContentAlignment.TopRight;
            this.guna2NotificationPaint1.FillColor = System.Drawing.Color.Red;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "เลือก PO ที่ต้องการพิมพ์";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Navy;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1333, 5);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 12;
            // 
            // gbMain
            // 
            this.gbMain.BorderColor = System.Drawing.Color.Navy;
            this.gbMain.BorderRadius = 6;
            this.gbMain.Controls.Add(this.bunifuGroupBox1);
            this.gbMain.Controls.Add(this.reportViewer1);
            this.gbMain.Controls.Add(this.txtPO);
            this.gbMain.Controls.Add(this.label1);
            this.gbMain.Controls.Add(this.guna2ControlBox1);
            this.gbMain.CustomBorderColor = System.Drawing.Color.Navy;
            this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMain.Font = new System.Drawing.Font("Athiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMain.ForeColor = System.Drawing.Color.White;
            this.gbMain.Location = new System.Drawing.Point(0, 0);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(1388, 755);
            this.gbMain.TabIndex = 2;
            this.gbMain.Text = "พิมพ์ข้อมูล";
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.Navy;
            this.bunifuGroupBox1.BorderRadius = 6;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.label3);
            this.bunifuGroupBox1.Controls.Add(this.rdbSend);
            this.bunifuGroupBox1.Controls.Add(this.label2);
            this.bunifuGroupBox1.Controls.Add(this.rdbNotSend);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(350, 64);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(308, 50);
            this.bunifuGroupBox1.TabIndex = 17;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Text = "ค้นหา";
            this.bunifuGroupBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "รายการที่ส่งแล้ว";
            // 
            // rdbSend
            // 
            this.rdbSend.AllowBindingControlLocation = false;
            this.rdbSend.BackColor = System.Drawing.Color.Transparent;
            this.rdbSend.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.rdbSend.BorderThickness = 1;
            this.rdbSend.Checked = false;
            this.rdbSend.Location = new System.Drawing.Point(162, 22);
            this.rdbSend.Name = "rdbSend";
            this.rdbSend.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.rdbSend.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rdbSend.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.rdbSend.RadioColor = System.Drawing.Color.DodgerBlue;
            this.rdbSend.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rdbSend.Size = new System.Drawing.Size(20, 20);
            this.rdbSend.TabIndex = 2;
            this.rdbSend.Tag = "SEND";
            this.rdbSend.Text = null;
            this.rdbSend.CheckedChanged2 += new System.EventHandler<Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs>(this.RAIDO_BUTTON_CHECK);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "รายการที่ยังค้างส่ง";
            // 
            // rdbNotSend
            // 
            this.rdbNotSend.AllowBindingControlLocation = false;
            this.rdbNotSend.BackColor = System.Drawing.Color.Transparent;
            this.rdbNotSend.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.rdbNotSend.BorderThickness = 1;
            this.rdbNotSend.Checked = true;
            this.rdbNotSend.Location = new System.Drawing.Point(8, 22);
            this.rdbNotSend.Name = "rdbNotSend";
            this.rdbNotSend.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.rdbNotSend.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rdbNotSend.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.rdbNotSend.RadioColor = System.Drawing.Color.DodgerBlue;
            this.rdbNotSend.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rdbNotSend.Size = new System.Drawing.Size(20, 20);
            this.rdbNotSend.TabIndex = 0;
            this.rdbNotSend.Tag = "NOTSEND";
            this.rdbNotSend.Text = null;
            this.rdbNotSend.CheckedChanged2 += new System.EventHandler<Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs>(this.RAIDO_BUTTON_CHECK);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FutureFlex.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 123);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1364, 620);
            this.reportViewer1.TabIndex = 16;
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
            this.txtPO.Location = new System.Drawing.Point(12, 78);
            this.txtPO.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPO.Name = "txtPO";
            this.txtPO.PasswordChar = '\0';
            this.txtPO.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPO.PlaceholderText = "PO";
            this.txtPO.SelectedText = "";
            this.txtPO.Size = new System.Drawing.Size(331, 36);
            this.txtPO.TabIndex = 15;
            this.txtPO.TextChanged += new System.EventHandler(this.txtPO_TextChanged);
            this.txtPO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guna2TextBox1_KeyDown);
            // 
            // sb
            // 
            this.sb.AllowDragging = false;
            this.sb.AllowMultipleViews = true;
            this.sb.ClickToClose = true;
            this.sb.DoubleClickToClose = true;
            this.sb.DurationAfterIdle = 3000;
            this.sb.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sb.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sb.ErrorOptions.ActionBorderRadius = 1;
            this.sb.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.sb.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.sb.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.sb.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.sb.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.sb.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.sb.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.sb.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.sb.ErrorOptions.IconLeftMargin = 12;
            this.sb.FadeCloseIcon = false;
            this.sb.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.sb.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sb.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sb.InformationOptions.ActionBorderRadius = 1;
            this.sb.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.sb.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.sb.InformationOptions.BackColor = System.Drawing.Color.White;
            this.sb.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.sb.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.sb.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.sb.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.sb.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.sb.InformationOptions.IconLeftMargin = 12;
            this.sb.Margin = 10;
            this.sb.MaximumSize = new System.Drawing.Size(0, 0);
            this.sb.MaximumViews = 7;
            this.sb.MessageRightMargin = 15;
            this.sb.MinimumSize = new System.Drawing.Size(0, 0);
            this.sb.ShowBorders = false;
            this.sb.ShowCloseIcon = false;
            this.sb.ShowIcon = true;
            this.sb.ShowShadows = true;
            this.sb.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sb.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sb.SuccessOptions.ActionBorderRadius = 1;
            this.sb.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.sb.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.sb.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.sb.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.sb.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.sb.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.sb.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.sb.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.sb.SuccessOptions.IconLeftMargin = 12;
            this.sb.ViewsMargin = 7;
            this.sb.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sb.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sb.WarningOptions.ActionBorderRadius = 1;
            this.sb.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.sb.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.sb.WarningOptions.BackColor = System.Drawing.Color.White;
            this.sb.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.sb.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.sb.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.sb.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.sb.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.sb.WarningOptions.IconLeftMargin = 12;
            this.sb.ZoomCloseIcon = true;
            // 
            // frmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1388, 755);
            this.Controls.Add(this.gbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrint_Load);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.bunifuGroupBox1.ResumeLayout(false);
            this.bunifuGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2NotificationPaint guna2NotificationPaint1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2GroupBox gbMain;
        private Guna.UI2.WinForms.Guna2TextBox txtPO;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuRadioButton rdbSend;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuRadioButton rdbNotSend;
        private Bunifu.UI.WinForms.BunifuSnackbar sb;
    }
}