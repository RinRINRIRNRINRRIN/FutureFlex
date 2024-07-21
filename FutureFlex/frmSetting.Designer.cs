
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
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.gbWGH.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
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
            this.guna2GroupBox3.Controls.Add(this.guna2ControlBox1);
            this.guna2GroupBox3.Controls.Add(this.btnHistory);
            this.guna2GroupBox3.Controls.Add(this.gbWGH);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.Navy;
            this.guna2GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox3.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(266, 246);
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
            this.btnHistory.Size = new System.Drawing.Size(242, 39);
            this.btnHistory.TabIndex = 22;
            this.btnHistory.Tag = "history";
            this.btnHistory.Text = "บันทึกรายการ";
            this.btnHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Navy;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Navy;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(217, 5);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 23;
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(266, 246);
            this.Controls.Add(this.guna2GroupBox3);
            this.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSetting";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.gbWGH.ResumeLayout(false);
            this.gbWGH.PerformLayout();
            this.guna2GroupBox3.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2Button btnHistory;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}