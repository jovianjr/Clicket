using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicket
{
    public partial class SubmitPayment : Form
    {
        public SubmitPayment(string totalPrice)
        {
            InitializeComponent();
            lbTotal.Text = totalPrice;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            ofdPayment.ShowDialog();
            this.lbFileName.Text = ofdPayment.FileName;
            if (lbFileName.Text == "openFileDialog1" || lbFileName.Text == " ")
            {
                lbFileName.Visible = false;
                btnSubmit.Visible = false;
            }
            else
            {
                lbFileName.Visible = true;
                btnSubmit.Visible = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            pnThanks.Visible = true;
            pnSubmitSlip.Visible = false;
        }

        private void SubmitPayment_Load(object sender, EventArgs e)
        {
            pnSubmitSlip.Visible = true;
            pnThanks.Visible = false;
            btnSubmit.Visible = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
