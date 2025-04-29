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
            this.label10 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.gbOdoo = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbProduction = new System.Windows.Forms.RadioButton();
            this.pnPro = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.rbUAT = new System.Windows.Forms.RadioButton();
            this.pnUat = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbase = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gbSerer.SuspendLayout();
            this.gbOdoo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnPro.SuspendLayout();
            this.pnUat.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(781, 28);
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
            // gbOdoo
            // 
            this.gbOdoo.Controls.Add(this.panel2);
            this.gbOdoo.Location = new System.Drawing.Point(320, 67);
            this.gbOdoo.Name = "gbOdoo";
            this.gbOdoo.Size = new System.Drawing.Size(614, 313);
            this.gbOdoo.TabIndex = 10;
            this.gbOdoo.TabStop = false;
            this.gbOdoo.Text = "Odoo settings";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.rbProduction);
            this.panel2.Controls.Add(this.pnPro);
            this.panel2.Controls.Add(this.rbUAT);
            this.panel2.Controls.Add(this.pnUat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 281);
            this.panel2.TabIndex = 13;
            // 
            // rbProduction
            // 
            this.rbProduction.AutoSize = true;
            this.rbProduction.Location = new System.Drawing.Point(308, 10);
            this.rbProduction.Name = "rbProduction";
            this.rbProduction.Size = new System.Drawing.Size(140, 29);
            this.rbProduction.TabIndex = 15;
            this.rbProduction.TabStop = true;
            this.rbProduction.Tag = "PRODUCTION";
            this.rbProduction.Text = "Odoo Production";
            this.rbProduction.UseVisualStyleBackColor = true;
            this.rbProduction.CheckedChanged += new System.EventHandler(this.rbUAT_CheckedChanged);
            // 
            // pnPro
            // 
            this.pnPro.Controls.Add(this.label1);
            this.pnPro.Controls.Add(this.label6);
            this.pnPro.Controls.Add(this.textBox1);
            this.pnPro.Controls.Add(this.textBox2);
            this.pnPro.Controls.Add(this.label11);
            this.pnPro.Controls.Add(this.textBox3);
            this.pnPro.Enabled = false;
            this.pnPro.Location = new System.Drawing.Point(305, 47);
            this.pnPro.Name = "pnPro";
            this.pnPro.Size = new System.Drawing.Size(294, 215);
            this.pnPro.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Database";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "URL";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 33);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(283, 33);
            this.textBox2.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "Key";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(10, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(282, 33);
            this.textBox3.TabIndex = 4;
            // 
            // rbUAT
            // 
            this.rbUAT.AutoSize = true;
            this.rbUAT.Location = new System.Drawing.Point(6, 10);
            this.rbUAT.Name = "rbUAT";
            this.rbUAT.Size = new System.Drawing.Size(96, 29);
            this.rbUAT.TabIndex = 13;
            this.rbUAT.TabStop = true;
            this.rbUAT.Tag = "UAT";
            this.rbUAT.Text = "Odoo UAT";
            this.rbUAT.UseVisualStyleBackColor = true;
            this.rbUAT.CheckedChanged += new System.EventHandler(this.rbUAT_CheckedChanged);
            // 
            // pnUat
            // 
            this.pnUat.Controls.Add(this.label7);
            this.pnUat.Controls.Add(this.label9);
            this.pnUat.Controls.Add(this.txtbase);
            this.pnUat.Controls.Add(this.txtURL);
            this.pnUat.Controls.Add(this.label8);
            this.pnUat.Controls.Add(this.txtKey);
            this.pnUat.Enabled = false;
            this.pnUat.Location = new System.Drawing.Point(3, 47);
            this.pnUat.Name = "pnUat";
            this.pnUat.Size = new System.Drawing.Size(294, 215);
            this.pnUat.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Database";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "URL";
            // 
            // txtbase
            // 
            this.txtbase.Location = new System.Drawing.Point(10, 165);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(282, 33);
            this.txtbase.TabIndex = 6;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(9, 37);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(283, 33);
            this.txtURL.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Key";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(10, 101);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(282, 33);
            this.txtKey.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(6, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(928, 33);
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
            this.groupBox1.Size = new System.Drawing.Size(940, 426);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ตั้งค่าระบบ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(124, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 25);
            this.label12.TabIndex = 12;
            this.label12.Text = "Port";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(465, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 25);
            this.label13.TabIndex = 12;
            this.label13.Text = "Port";
            this.label13.Visible = false;
            // 
            // frmConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(957, 442);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnPro.ResumeLayout(false);
            this.pnPro.PerformLayout();
            this.pnUat.ResumeLayout(false);
            this.pnUat.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbProduction;
        private System.Windows.Forms.Panel pnPro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton rbUAT;
        private System.Windows.Forms.Panel pnUat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}