
namespace FutureFlex
{
    partial class frmEditUser
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
            this.gbMain = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtOldPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbOpenPass = new System.Windows.Forms.CheckBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.BorderColor = System.Drawing.Color.Navy;
            this.gbMain.BorderRadius = 8;
            this.gbMain.Controls.Add(this.btnSave);
            this.gbMain.Controls.Add(this.cbOpenPass);
            this.gbMain.Controls.Add(this.txtConPass);
            this.gbMain.Controls.Add(this.txtNewPass);
            this.gbMain.Controls.Add(this.txtOldPass);
            this.gbMain.CustomBorderColor = System.Drawing.Color.Navy;
            this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMain.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMain.ForeColor = System.Drawing.Color.White;
            this.gbMain.Location = new System.Drawing.Point(0, 0);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(298, 262);
            this.gbMain.TabIndex = 1;
            this.gbMain.Text = "จัดการบัญชีผู้ใช้งาน";
            // 
            // txtOldPass
            // 
            this.txtOldPass.BorderColor = System.Drawing.Color.Navy;
            this.txtOldPass.BorderRadius = 8;
            this.txtOldPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldPass.DefaultText = "";
            this.txtOldPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOldPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOldPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldPass.Enabled = false;
            this.txtOldPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOldPass.Font = new System.Drawing.Font("Athiti", 12F);
            this.txtOldPass.ForeColor = System.Drawing.Color.Black;
            this.txtOldPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOldPass.Location = new System.Drawing.Point(12, 50);
            this.txtOldPass.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '\0';
            this.txtOldPass.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtOldPass.PlaceholderText = "รหัสผ่านเก่า";
            this.txtOldPass.ReadOnly = true;
            this.txtOldPass.SelectedText = "";
            this.txtOldPass.Size = new System.Drawing.Size(271, 33);
            this.txtOldPass.TabIndex = 7;
            // 
            // txtNewPass
            // 
            this.txtNewPass.BorderColor = System.Drawing.Color.Navy;
            this.txtNewPass.BorderRadius = 8;
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPass.DefaultText = "";
            this.txtNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.Enabled = false;
            this.txtNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPass.Font = new System.Drawing.Font("Athiti", 12F);
            this.txtNewPass.ForeColor = System.Drawing.Color.Black;
            this.txtNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPass.Location = new System.Drawing.Point(12, 93);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '\0';
            this.txtNewPass.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNewPass.PlaceholderText = "รหัสผ่านใหม่";
            this.txtNewPass.ReadOnly = true;
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.Size = new System.Drawing.Size(271, 33);
            this.txtNewPass.TabIndex = 8;
            // 
            // txtConPass
            // 
            this.txtConPass.BorderColor = System.Drawing.Color.Navy;
            this.txtConPass.BorderRadius = 8;
            this.txtConPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConPass.DefaultText = "";
            this.txtConPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConPass.Enabled = false;
            this.txtConPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConPass.Font = new System.Drawing.Font("Athiti", 12F);
            this.txtConPass.ForeColor = System.Drawing.Color.Black;
            this.txtConPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConPass.Location = new System.Drawing.Point(12, 136);
            this.txtConPass.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtConPass.Name = "txtConPass";
            this.txtConPass.PasswordChar = '\0';
            this.txtConPass.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtConPass.PlaceholderText = "ยืนยันรหัสผ่านใหม่";
            this.txtConPass.ReadOnly = true;
            this.txtConPass.SelectedText = "";
            this.txtConPass.Size = new System.Drawing.Size(271, 33);
            this.txtConPass.TabIndex = 9;
            // 
            // cbOpenPass
            // 
            this.cbOpenPass.AutoSize = true;
            this.cbOpenPass.BackColor = System.Drawing.Color.White;
            this.cbOpenPass.ForeColor = System.Drawing.Color.Black;
            this.cbOpenPass.Location = new System.Drawing.Point(12, 172);
            this.cbOpenPass.Name = "cbOpenPass";
            this.cbOpenPass.Size = new System.Drawing.Size(104, 29);
            this.cbOpenPass.TabIndex = 10;
            this.cbOpenPass.Text = "เปิดรหัสผ่าน";
            this.cbOpenPass.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 8;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Athiti Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(12, 207);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(271, 45);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "ยืนยัน";
            // 
            // frmEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 262);
            this.Controls.Add(this.gbMain);
            this.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmEditUser";
            this.Text = "frmEditUser";
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbMain;
        private System.Windows.Forms.CheckBox cbOpenPass;
        private Guna.UI2.WinForms.Guna2TextBox txtConPass;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPass;
        private Guna.UI2.WinForms.Guna2TextBox txtOldPass;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}