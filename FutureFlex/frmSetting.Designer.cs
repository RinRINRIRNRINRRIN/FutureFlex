
namespace FutureFlex
{
    partial class frmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.gbWGH = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbbWGHBAUTRATE = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbbWGHCOM = new System.Windows.Forms.ComboBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnHistory = new Guna.UI2.WinForms.Guna2Button();
            this.gbSCN = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbSCNBUADRATE = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbSCNCOM = new System.Windows.Forms.ComboBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.gbWGH.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            this.gbSCN.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbWGH
            // 
            this.gbWGH.BorderColor = System.Drawing.Color.Navy;
            this.gbWGH.BorderRadius = 6;
            this.gbWGH.Controls.Add(this.label14);
            this.gbWGH.Controls.Add(this.cbbWGHBAUTRATE);
            this.gbWGH.Controls.Add(this.label15);
            this.gbWGH.Controls.Add(this.cbbWGHCOM);
            this.gbWGH.CustomBorderColor = System.Drawing.Color.Navy;
            this.gbWGH.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWGH.ForeColor = System.Drawing.Color.White;
            this.gbWGH.Location = new System.Drawing.Point(12, 53);
            this.gbWGH.Name = "gbWGH";
            this.gbWGH.Size = new System.Drawing.Size(242, 130);
            this.gbWGH.TabIndex = 12;
            this.gbWGH.Text = "SETTING WEIGHT PORT";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(11, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 25);
            this.label14.TabIndex = 15;
            this.label14.Text = "BAUTRATE : ";
            // 
            // cbbWGHBAUTRATE
            // 
            this.cbbWGHBAUTRATE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWGHBAUTRATE.ForeColor = System.Drawing.Color.Black;
            this.cbbWGHBAUTRATE.FormattingEnabled = true;
            this.cbbWGHBAUTRATE.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cbbWGHBAUTRATE.Location = new System.Drawing.Point(112, 86);
            this.cbbWGHBAUTRATE.Name = "cbbWGHBAUTRATE";
            this.cbbWGHBAUTRATE.Size = new System.Drawing.Size(121, 33);
            this.cbbWGHBAUTRATE.TabIndex = 13;
            this.cbbWGHBAUTRATE.Tag = "BUADRATE";
            this.cbbWGHBAUTRATE.DropDown += new System.EventHandler(this.GET_BUADRATE);
            this.cbbWGHBAUTRATE.DropDownClosed += new System.EventHandler(this.CLEAR_COMBOBOX);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(52, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 25);
            this.label15.TabIndex = 12;
            this.label15.Text = "COM : ";
            // 
            // cbbWGHCOM
            // 
            this.cbbWGHCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWGHCOM.ForeColor = System.Drawing.Color.Black;
            this.cbbWGHCOM.FormattingEnabled = true;
            this.cbbWGHCOM.Location = new System.Drawing.Point(112, 47);
            this.cbbWGHCOM.Name = "cbbWGHCOM";
            this.cbbWGHCOM.Size = new System.Drawing.Size(121, 33);
            this.cbbWGHCOM.TabIndex = 11;
            this.cbbWGHCOM.Tag = "COM";
            this.cbbWGHCOM.DropDown += new System.EventHandler(this.GET_SERIALPORT);
            this.cbbWGHCOM.DropDownClosed += new System.EventHandler(this.CLEAR_COMBOBOX);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2GroupBox3;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.Navy;
            this.guna2GroupBox3.BorderRadius = 6;
            this.guna2GroupBox3.Controls.Add(this.btnHistory);
            this.guna2GroupBox3.Controls.Add(this.gbSCN);
            this.guna2GroupBox3.Controls.Add(this.gbWGH);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.Navy;
            this.guna2GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox3.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(516, 246);
            this.guna2GroupBox3.TabIndex = 22;
            this.guna2GroupBox3.Text = "SETTING PORT";
            // 
            // btnHistory
            // 
            this.btnHistory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHistory.BorderRadius = 6;
            this.btnHistory.BorderThickness = 1;
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHistory.FillColor = System.Drawing.Color.GhostWhite;
            this.btnHistory.Font = new System.Drawing.Font("Athiti", 12F);
            this.btnHistory.ForeColor = System.Drawing.Color.Navy;
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHistory.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHistory.Location = new System.Drawing.Point(12, 200);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(490, 39);
            this.btnHistory.TabIndex = 22;
            this.btnHistory.Tag = "history";
            this.btnHistory.Text = "บันทึกรายการ";
            this.btnHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // gbSCN
            // 
            this.gbSCN.BorderColor = System.Drawing.Color.Navy;
            this.gbSCN.BorderRadius = 6;
            this.gbSCN.Controls.Add(this.label4);
            this.gbSCN.Controls.Add(this.cbbSCNBUADRATE);
            this.gbSCN.Controls.Add(this.label5);
            this.gbSCN.Controls.Add(this.cbbSCNCOM);
            this.gbSCN.CustomBorderColor = System.Drawing.Color.Navy;
            this.gbSCN.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSCN.ForeColor = System.Drawing.Color.White;
            this.gbSCN.Location = new System.Drawing.Point(260, 53);
            this.gbSCN.Name = "gbSCN";
            this.gbSCN.Size = new System.Drawing.Size(242, 130);
            this.gbSCN.TabIndex = 22;
            this.gbSCN.Text = "SETTING SCANNER PORT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "BAUTRATE : ";
            // 
            // cbbSCNBUADRATE
            // 
            this.cbbSCNBUADRATE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSCNBUADRATE.ForeColor = System.Drawing.Color.Black;
            this.cbbSCNBUADRATE.FormattingEnabled = true;
            this.cbbSCNBUADRATE.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cbbSCNBUADRATE.Location = new System.Drawing.Point(112, 86);
            this.cbbSCNBUADRATE.Name = "cbbSCNBUADRATE";
            this.cbbSCNBUADRATE.Size = new System.Drawing.Size(121, 33);
            this.cbbSCNBUADRATE.TabIndex = 13;
            this.cbbSCNBUADRATE.Tag = "BUADRATE";
            this.cbbSCNBUADRATE.DropDown += new System.EventHandler(this.GET_BUADRATE);
            this.cbbSCNBUADRATE.DropDownClosed += new System.EventHandler(this.CLEAR_COMBOBOX);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(52, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "COM : ";
            // 
            // cbbSCNCOM
            // 
            this.cbbSCNCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSCNCOM.ForeColor = System.Drawing.Color.Black;
            this.cbbSCNCOM.FormattingEnabled = true;
            this.cbbSCNCOM.Location = new System.Drawing.Point(112, 47);
            this.cbbSCNCOM.Name = "cbbSCNCOM";
            this.cbbSCNCOM.Size = new System.Drawing.Size(121, 33);
            this.cbbSCNCOM.TabIndex = 11;
            this.cbbSCNCOM.Tag = "COM";
            this.cbbSCNCOM.DropDown += new System.EventHandler(this.GET_SERIALPORT);
            this.cbbSCNCOM.DropDownClosed += new System.EventHandler(this.CLEAR_COMBOBOX);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(516, 246);
            this.Controls.Add(this.guna2GroupBox3);
            this.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmSetting";
            this.Text = "frmSetting";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.gbWGH.ResumeLayout(false);
            this.gbWGH.PerformLayout();
            this.guna2GroupBox3.ResumeLayout(false);
            this.gbSCN.ResumeLayout(false);
            this.gbSCN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox gbWGH;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbbWGHBAUTRATE;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbbWGHCOM;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2GroupBox gbSCN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbSCNBUADRATE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbSCNCOM;
        private Guna.UI2.WinForms.Guna2Button btnHistory;
    }
}