using FutureFlex.command;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FutureFlex
{
    public partial class frmWeightDetail : Form
    {

        tbForSendSQL tbForSendSQL = new tbForSendSQL();


        public frmWeightDetail()
        {
            InitializeComponent();
        }

        private void frmWeightDetail_Load(object sender, EventArgs e)

        {
            dgvDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Athiti", 12, FontStyle.Regular);
            dgvDetail.DefaultCellStyle.Font = new Font("Athiti", 12, FontStyle.Regular);
            dgvDetail.DefaultCellStyle.ForeColor = Color.Black;


        }
    }
}
