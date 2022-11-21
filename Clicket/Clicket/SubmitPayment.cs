using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicket
{
    public partial class SubmitPayment : Form
    {
        private int qty;
        private Movie movieItem;
        private Event eventItem;
        public SubmitPayment(string totalPrice, int _qty, Movie _movie, Event _event)
        {
            InitializeComponent();
            qty = _qty;
            movieItem = _movie;
            eventItem = _event;
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
            Boolean response = false;
            Action act = new Action();
            
            if (movieItem != null)
            {
                response = act.orderMovie(movieItem.MovieID, User.UserID, qty, movieItem.Price, lbFileName.Text);
            } else if(eventItem != null)
            {
                response = act.orderEvent(eventItem.EventID, User.UserID, qty, eventItem.Price, lbFileName.Text);
            }
            
            if (response == true)
            {
                pnThanks.Visible = true;
                pnSubmitSlip.Visible = false;
            } else
            {
                MessageBox.Show("terjadi kesalahan", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
