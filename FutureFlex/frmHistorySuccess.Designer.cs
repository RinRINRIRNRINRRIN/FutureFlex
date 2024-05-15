namespace FutureFlex
{
    partial class frmHistorySuccess
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorySuccess));
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.txtJobNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.cl_btnDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cl_wgh_GVNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_po = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_GVID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_county = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_side = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_weightPaper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_weightCore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_boxNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_joint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_numMeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_weightRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_machineOperator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_net = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_tare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_gross = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_statusOdoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_btnDel,
            this.cl_wgh_GVNAME,
            this.cl_wgh_po,
            this.cl_wgh_id,
            this.cl_wgh_dateTime,
            this.cl_wgh_employee,
            this.cl_wgh_GVID,
            this.cl_wgh_county,
            this.cl_wgh_type,
            this.cl_wgh_side,
            this.cl_wgh_weightPaper,
            this.cl_wgh_weightCore,
            this.cl_wgh_boxNum,
            this.cl_wgh_joint,
            this.cl_wgh_numMeter,
            this.cl_wgh_weightRoll,
            this.cl_wgh_machineOperator,
            this.cl_wgh_net,
            this.cl_wgh_tare,
            this.cl_wgh_gross,
            this.cl_wgh_statusOdoo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetail.EnableHeadersVisualStyles = false;
            this.dgvDetail.GridColor = System.Drawing.Color.White;
            this.dgvDetail.Location = new System.Drawing.Point(11, 57);
            this.dgvDetail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(1200, 793);
            this.dgvDetail.TabIndex = 1;
            this.dgvDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellContentClick);
            // 
            // txtJobNo
            // 
            this.txtJobNo.BorderColor = System.Drawing.Color.Navy;
            this.txtJobNo.BorderRadius = 8;
            this.txtJobNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJobNo.DefaultText = "";
            this.txtJobNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJobNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJobNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJobNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJobNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJobNo.Font = new System.Drawing.Font("Athiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobNo.ForeColor = System.Drawing.Color.Black;
            this.txtJobNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJobNo.IconRight = ((System.Drawing.Image)(resources.GetObject("txtJobNo.IconRight")));
            this.txtJobNo.Location = new System.Drawing.Point(11, 12);
            this.txtJobNo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtJobNo.Name = "txtJobNo";
            this.txtJobNo.PasswordChar = '\0';
            this.txtJobNo.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtJobNo.PlaceholderText = "EX. (GV-67-01-0001)";
            this.txtJobNo.SelectedText = "";
            this.txtJobNo.Size = new System.Drawing.Size(232, 35);
            this.txtJobNo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtJobNo.TabIndex = 4;
            // 
            // cl_btnDel
            // 
            this.cl_btnDel.HeaderText = "";
            this.cl_btnDel.Name = "cl_btnDel";
            this.cl_btnDel.ReadOnly = true;
            this.cl_btnDel.Text = "DELETE";
            this.cl_btnDel.UseColumnTextForButtonValue = true;
            this.cl_btnDel.Visible = false;
            // 
            // cl_wgh_GVNAME
            // 
            this.cl_wgh_GVNAME.DataPropertyName = "wgh_GVNAME";
            this.cl_wgh_GVNAME.HeaderText = "เลขที่ GV";
            this.cl_wgh_GVNAME.Name = "cl_wgh_GVNAME";
            this.cl_wgh_GVNAME.ReadOnly = true;
            this.cl_wgh_GVNAME.Width = 150;
            // 
            // cl_wgh_po
            // 
            this.cl_wgh_po.DataPropertyName = "wgh_po";
            this.cl_wgh_po.HeaderText = "เลขที่ PO";
            this.cl_wgh_po.Name = "cl_wgh_po";
            this.cl_wgh_po.ReadOnly = true;
            this.cl_wgh_po.Width = 110;
            // 
            // cl_wgh_id
            // 
            this.cl_wgh_id.DataPropertyName = "wgh_id";
            this.cl_wgh_id.HeaderText = "wgh_id";
            this.cl_wgh_id.Name = "cl_wgh_id";
            this.cl_wgh_id.ReadOnly = true;
            this.cl_wgh_id.Visible = false;
            // 
            // cl_wgh_dateTime
            // 
            this.cl_wgh_dateTime.DataPropertyName = "wgh_dateTime";
            this.cl_wgh_dateTime.HeaderText = "วัน/เวลา";
            this.cl_wgh_dateTime.Name = "cl_wgh_dateTime";
            this.cl_wgh_dateTime.ReadOnly = true;
            this.cl_wgh_dateTime.Width = 170;
            // 
            // cl_wgh_employee
            // 
            this.cl_wgh_employee.DataPropertyName = "wgh_employee";
            this.cl_wgh_employee.HeaderText = "พนักงานชั่ง";
            this.cl_wgh_employee.Name = "cl_wgh_employee";
            this.cl_wgh_employee.ReadOnly = true;
            this.cl_wgh_employee.Width = 130;
            // 
            // cl_wgh_GVID
            // 
            this.cl_wgh_GVID.DataPropertyName = "wgh_GVID";
            this.cl_wgh_GVID.HeaderText = "wgh_GVID";
            this.cl_wgh_GVID.Name = "cl_wgh_GVID";
            this.cl_wgh_GVID.ReadOnly = true;
            this.cl_wgh_GVID.Visible = false;
            // 
            // cl_wgh_county
            // 
            this.cl_wgh_county.DataPropertyName = "wgh_county";
            this.cl_wgh_county.HeaderText = "เลือกประเทศ";
            this.cl_wgh_county.Name = "cl_wgh_county";
            this.cl_wgh_county.ReadOnly = true;
            this.cl_wgh_county.Width = 150;
            // 
            // cl_wgh_type
            // 
            this.cl_wgh_type.DataPropertyName = "wgh_type";
            this.cl_wgh_type.HeaderText = "เลือกประเภท";
            this.cl_wgh_type.Name = "cl_wgh_type";
            this.cl_wgh_type.ReadOnly = true;
            this.cl_wgh_type.Width = 150;
            // 
            // cl_wgh_side
            // 
            this.cl_wgh_side.DataPropertyName = "wgh_side";
            this.cl_wgh_side.HeaderText = "เลือกด้าน";
            this.cl_wgh_side.Name = "cl_wgh_side";
            this.cl_wgh_side.ReadOnly = true;
            this.cl_wgh_side.Width = 150;
            // 
            // cl_wgh_weightPaper
            // 
            this.cl_wgh_weightPaper.DataPropertyName = "wgh_weightPaper";
            this.cl_wgh_weightPaper.HeaderText = "นน.กระดาษ/แกน";
            this.cl_wgh_weightPaper.Name = "cl_wgh_weightPaper";
            this.cl_wgh_weightPaper.ReadOnly = true;
            this.cl_wgh_weightPaper.Width = 180;
            // 
            // cl_wgh_weightCore
            // 
            this.cl_wgh_weightCore.DataPropertyName = "wgh_weightCore";
            this.cl_wgh_weightCore.HeaderText = "นน.แกน";
            this.cl_wgh_weightCore.Name = "cl_wgh_weightCore";
            this.cl_wgh_weightCore.ReadOnly = true;
            this.cl_wgh_weightCore.Width = 120;
            // 
            // cl_wgh_boxNum
            // 
            this.cl_wgh_boxNum.DataPropertyName = "wgh_boxNum";
            this.cl_wgh_boxNum.HeaderText = "จำนวนกล่อง";
            this.cl_wgh_boxNum.Name = "cl_wgh_boxNum";
            this.cl_wgh_boxNum.ReadOnly = true;
            this.cl_wgh_boxNum.Width = 130;
            // 
            // cl_wgh_joint
            // 
            this.cl_wgh_joint.DataPropertyName = "wgh_joint";
            this.cl_wgh_joint.HeaderText = "รอยต่อ";
            this.cl_wgh_joint.Name = "cl_wgh_joint";
            this.cl_wgh_joint.ReadOnly = true;
            this.cl_wgh_joint.Width = 120;
            // 
            // cl_wgh_numMeter
            // 
            this.cl_wgh_numMeter.DataPropertyName = "wgh_numMeter";
            this.cl_wgh_numMeter.HeaderText = "จำนวนเมตร";
            this.cl_wgh_numMeter.Name = "cl_wgh_numMeter";
            this.cl_wgh_numMeter.ReadOnly = true;
            this.cl_wgh_numMeter.Width = 130;
            // 
            // cl_wgh_weightRoll
            // 
            this.cl_wgh_weightRoll.DataPropertyName = "wgh_weightRoll";
            this.cl_wgh_weightRoll.HeaderText = "นน.ม้วน";
            this.cl_wgh_weightRoll.Name = "cl_wgh_weightRoll";
            this.cl_wgh_weightRoll.ReadOnly = true;
            this.cl_wgh_weightRoll.Width = 120;
            // 
            // cl_wgh_machineOperator
            // 
            this.cl_wgh_machineOperator.DataPropertyName = "wgh_machineOperator";
            this.cl_wgh_machineOperator.HeaderText = "ผู้ควบคุมเครื่อง";
            this.cl_wgh_machineOperator.Name = "cl_wgh_machineOperator";
            this.cl_wgh_machineOperator.ReadOnly = true;
            this.cl_wgh_machineOperator.Width = 150;
            // 
            // cl_wgh_net
            // 
            this.cl_wgh_net.DataPropertyName = "wgh_net";
            this.cl_wgh_net.HeaderText = "NET";
            this.cl_wgh_net.Name = "cl_wgh_net";
            this.cl_wgh_net.ReadOnly = true;
            // 
            // cl_wgh_tare
            // 
            this.cl_wgh_tare.DataPropertyName = "wgh_tare";
            this.cl_wgh_tare.HeaderText = "TARE";
            this.cl_wgh_tare.Name = "cl_wgh_tare";
            this.cl_wgh_tare.ReadOnly = true;
            // 
            // cl_wgh_gross
            // 
            this.cl_wgh_gross.DataPropertyName = "wgh_gross";
            this.cl_wgh_gross.HeaderText = "GROSS";
            this.cl_wgh_gross.Name = "cl_wgh_gross";
            this.cl_wgh_gross.ReadOnly = true;
            // 
            // cl_wgh_statusOdoo
            // 
            this.cl_wgh_statusOdoo.DataPropertyName = "wgh_statusOdoo";
            this.cl_wgh_statusOdoo.HeaderText = "wgh_statusOdoo";
            this.cl_wgh_statusOdoo.Name = "cl_wgh_statusOdoo";
            this.cl_wgh_statusOdoo.ReadOnly = true;
            this.cl_wgh_statusOdoo.Visible = false;
            // 
            // frmHistorySuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1224, 865);
            this.Controls.Add(this.txtJobNo);
            this.Controls.Add(this.dgvDetail);
            this.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmHistorySuccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHistorySuccess";
            this.Load += new System.EventHandler(this.frmHistorySuccess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDetail;
        private Guna.UI2.WinForms.Guna2TextBox txtJobNo;
        private System.Windows.Forms.DataGridViewButtonColumn cl_btnDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_GVNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_po;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_dateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_GVID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_county;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_side;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_weightPaper;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_weightCore;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_boxNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_joint;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_numMeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_weightRoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_machineOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_net;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_tare;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_gross;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_statusOdoo;
    }
}