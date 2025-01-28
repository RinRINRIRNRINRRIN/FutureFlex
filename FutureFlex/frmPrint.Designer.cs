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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sb = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2NotificationPaint1
            // 
            this.guna2NotificationPaint1.Alignment = Guna.UI2.WinForms.Enums.CustomContentAlignment.TopRight;
            this.guna2NotificationPaint1.FillColor = System.Drawing.Color.Red;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Navy;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1340, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 12;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FutureFlex.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 72);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1364, 693);
            this.reportViewer1.TabIndex = 16;
            this.reportViewer1.Print += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.reportViewer1_Print);
            this.reportViewer1.PrintingBegin += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.reportViewer1_PrintingBegin);
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
            this.label9.Location = new System.Drawing.Point(7, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 25);
            this.label9.TabIndex = 59;
            this.label9.Text = "ปริ้นรายการ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Athiti Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(1, -3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 51);
            this.label10.TabIndex = 58;
            this.label10.Text = "Print";
            // 
            // frmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1387, 779);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrint_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2NotificationPaint guna2NotificationPaint1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Bunifu.UI.WinForms.BunifuSnackbar sb;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}