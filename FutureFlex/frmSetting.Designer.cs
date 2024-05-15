
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
            this.gbDate = new Guna.UI2.WinForms.Guna2GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbSTOPBITS = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbDATABITS = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbbParity = new System.Windows.Forms.ComboBox();
            this.cbbBAUTRATE = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbbCOMPORT = new System.Windows.Forms.ComboBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gbPassword = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.gbDate.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            this.gbPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDate
            // 
            this.gbDate.BorderColor = System.Drawing.Color.Navy;
            this.gbDate.BorderRadius = 6;
            this.gbDate.Controls.Add(this.button4);
            this.gbDate.Controls.Add(this.label11);
            this.gbDate.Controls.Add(this.cbbSTOPBITS);
            this.gbDate.Controls.Add(this.label12);
            this.gbDate.Controls.Add(this.cbbDATABITS);
            this.gbDate.Controls.Add(this.label13);
            this.gbDate.Controls.Add(this.label14);
            this.gbDate.Controls.Add(this.cbbParity);
            this.gbDate.Controls.Add(this.cbbBAUTRATE);
            this.gbDate.Controls.Add(this.label15);
            this.gbDate.Controls.Add(this.cbbCOMPORT);
            this.gbDate.CustomBorderColor = System.Drawing.Color.Navy;
            this.gbDate.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDate.ForeColor = System.Drawing.Color.White;
            this.gbDate.Location = new System.Drawing.Point(23, 71);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(242, 292);
            this.gbDate.TabIndex = 12;
            this.gbDate.Text = "SETTING WEIGHT PORT";
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(9, 252);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 34);
            this.button4.TabIndex = 21;
            this.button4.Text = "บันทึก";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(12, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "STOP BITS : ";
            // 
            // cbbSTOPBITS
            // 
            this.cbbSTOPBITS.ForeColor = System.Drawing.Color.Black;
            this.cbbSTOPBITS.FormattingEnabled = true;
            this.cbbSTOPBITS.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbbSTOPBITS.Location = new System.Drawing.Point(112, 203);
            this.cbbSTOPBITS.Name = "cbbSTOPBITS";
            this.cbbSTOPBITS.Size = new System.Drawing.Size(121, 33);
            this.cbbSTOPBITS.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(8, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 25);
            this.label12.TabIndex = 18;
            this.label12.Text = "DATA BITS  : ";
            // 
            // cbbDATABITS
            // 
            this.cbbDATABITS.ForeColor = System.Drawing.Color.Black;
            this.cbbDATABITS.FormattingEnabled = true;
            this.cbbDATABITS.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cbbDATABITS.Location = new System.Drawing.Point(112, 164);
            this.cbbDATABITS.Name = "cbbDATABITS";
            this.cbbDATABITS.Size = new System.Drawing.Size(121, 33);
            this.cbbDATABITS.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(33, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 25);
            this.label13.TabIndex = 16;
            this.label13.Text = "PARITY : ";
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
            // cbbParity
            // 
            this.cbbParity.ForeColor = System.Drawing.Color.Black;
            this.cbbParity.FormattingEnabled = true;
            this.cbbParity.Items.AddRange(new object[] {
            "Even",
            "Odd",
            "None",
            "Mark",
            "Space"});
            this.cbbParity.Location = new System.Drawing.Point(112, 125);
            this.cbbParity.Name = "cbbParity";
            this.cbbParity.Size = new System.Drawing.Size(121, 33);
            this.cbbParity.TabIndex = 14;
            // 
            // cbbBAUTRATE
            // 
            this.cbbBAUTRATE.ForeColor = System.Drawing.Color.Black;
            this.cbbBAUTRATE.FormattingEnabled = true;
            this.cbbBAUTRATE.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cbbBAUTRATE.Location = new System.Drawing.Point(112, 86);
            this.cbbBAUTRATE.Name = "cbbBAUTRATE";
            this.cbbBAUTRATE.Size = new System.Drawing.Size(121, 33);
            this.cbbBAUTRATE.TabIndex = 13;
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
            // cbbCOMPORT
            // 
            this.cbbCOMPORT.ForeColor = System.Drawing.Color.Black;
            this.cbbCOMPORT.FormattingEnabled = true;
            this.cbbCOMPORT.Location = new System.Drawing.Point(112, 47);
            this.cbbCOMPORT.Name = "cbbCOMPORT";
            this.cbbCOMPORT.Size = new System.Drawing.Size(121, 33);
            this.cbbCOMPORT.TabIndex = 11;
            this.cbbCOMPORT.DropDown += new System.EventHandler(this.cbbCOMPORT_DropDown);
            this.cbbCOMPORT.SelectedIndexChanged += new System.EventHandler(this.cbbCOMPORT_SelectedIndexChanged);
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
            this.guna2GroupBox3.Controls.Add(this.gbPassword);
            this.guna2GroupBox3.Controls.Add(this.gbDate);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.Navy;
            this.guna2GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox3.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(283, 393);
            this.guna2GroupBox3.TabIndex = 22;
            this.guna2GroupBox3.Text = "SETTING PORT";
            // 
            // gbPassword
            // 
            this.gbPassword.BorderColor = System.Drawing.Color.Navy;
            this.gbPassword.BorderRadius = 8;
            this.gbPassword.Controls.Add(this.txtPassword);
            this.gbPassword.CustomBorderColor = System.Drawing.Color.Navy;
            this.gbPassword.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPassword.ForeColor = System.Drawing.Color.White;
            this.gbPassword.Location = new System.Drawing.Point(12, 139);
            this.gbPassword.Name = "gbPassword";
            this.gbPassword.Size = new System.Drawing.Size(259, 91);
            this.gbPassword.TabIndex = 23;
            this.gbPassword.Text = "ความปลอดภัย";
            this.gbPassword.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.Navy;
            this.txtPassword.BorderRadius = 8;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Athiti", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(7, 47);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPassword.PlaceholderText = "รหัสผ่าน";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(241, 33);
            this.txtPassword.TabIndex = 19;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
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
            this.ClientSize = new System.Drawing.Size(283, 393);
            this.Controls.Add(this.guna2GroupBox3);
            this.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmSetting";
            this.Text = "frmSetting";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.gbDate.ResumeLayout(false);
            this.gbDate.PerformLayout();
            this.guna2GroupBox3.ResumeLayout(false);
            this.gbPassword.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox gbDate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbSTOPBITS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbDATABITS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbbParity;
        private System.Windows.Forms.ComboBox cbbBAUTRATE;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbbCOMPORT;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2GroupBox gbPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}