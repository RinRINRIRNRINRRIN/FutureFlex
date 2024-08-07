namespace FutureFlex
{
    partial class frmConnect
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
            this.txtHost = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSerer = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.gbOdoo = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbase = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbSerer.SuspendLayout();
            this.gbOdoo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(11, 57);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(173, 33);
            this.txtHost.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(478, 30);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(153, 33);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "ปิด";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Host/server";
            // 
            // gbSerer
            // 
            this.gbSerer.Controls.Add(this.label10);
            this.gbSerer.Controls.Add(this.txtDatabase);
            this.gbSerer.Controls.Add(this.label5);
            this.gbSerer.Controls.Add(this.txtPort);
            this.gbSerer.Controls.Add(this.label4);
            this.gbSerer.Controls.Add(this.txtPassword);
            this.gbSerer.Controls.Add(this.label3);
            this.gbSerer.Controls.Add(this.txtUser);
            this.gbSerer.Controls.Add(this.label2);
            this.gbSerer.Controls.Add(this.txtHost);
            this.gbSerer.Location = new System.Drawing.Point(6, 67);
            this.gbSerer.Name = "gbSerer";
            this.gbSerer.Size = new System.Drawing.Size(308, 313);
            this.gbSerer.TabIndex = 4;
            this.gbSerer.TabStop = false;
            this.gbSerer.Text = "Server settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "User";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(12, 121);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(282, 33);
            this.txtUser.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 185);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(282, 33);
            this.txtPassword.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(190, 57);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(104, 33);
            this.txtPort.TabIndex = 8;
            // 
            // gbOdoo
            // 
            this.gbOdoo.Controls.Add(this.label7);
            this.gbOdoo.Controls.Add(this.txtbase);
            this.gbOdoo.Controls.Add(this.label8);
            this.gbOdoo.Controls.Add(this.txtKey);
            this.gbOdoo.Controls.Add(this.label9);
            this.gbOdoo.Controls.Add(this.txtURL);
            this.gbOdoo.Location = new System.Drawing.Point(320, 67);
            this.gbOdoo.Name = "gbOdoo";
            this.gbOdoo.Size = new System.Drawing.Size(308, 313);
            this.gbOdoo.TabIndex = 10;
            this.gbOdoo.TabStop = false;
            this.gbOdoo.Text = "Odoo settings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Database";
            // 
            // txtbase
            // 
            this.txtbase.Location = new System.Drawing.Point(12, 185);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(282, 33);
            this.txtbase.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Key";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(12, 121);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(282, 33);
            this.txtKey.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "URL";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(11, 57);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(283, 33);
            this.txtURL.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Database";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(12, 249);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(282, 33);
            this.txtDatabase.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(75, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(472, 33);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "บันทึกข้อมูล";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.gbSerer);
            this.groupBox1.Controls.Add(this.gbOdoo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 426);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ตั้งค่าระบบ";
            // 
            // frmConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 442);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConnect";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConnect_FormClosing);
            this.Load += new System.EventHandler(this.frmConnect_Load);
            this.gbSerer.ResumeLayout(false);
            this.gbSerer.PerformLayout();
            this.gbOdoo.ResumeLayout(false);
            this.gbOdoo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbSerer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.GroupBox gbOdoo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbase;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}