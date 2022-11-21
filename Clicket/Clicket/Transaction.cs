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
    public partial class Transaction : UserControl
    {
        public Transaction(int id, string tipe, string title, string date, string location, string price, string qty, string total, string status)
        {
            InitializeComponent();
            _id = id;
            lblTipe.Text = _tipe = tipe;
            lbTitle.Text = _title = title;
            lbDate.Text = _date = date;
            lbLocation.Text = _location = location;
            lbPrice.Text = _price = price;
            lbQty.Text = _qty = qty;
            lbTotal.Text = _total = total;
            lblStatus.Text = _status = status;
        }
        private int _id;
        private string _tipe;
        private string _title;
        private string _date;
        private string _location;
        private string _price;
        private string _qty;
        private string _total;
        private string _status;

        public string Title{ get => _title; }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin?", "Confirm Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Action action = new Action();

                if(_tipe == "movie") { 
                    action.confirmOrderMovie(_id);
                } else if (_tipe == "event")
                {
                    action.confirmOrderEvent(_id);
                }
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin?", "Reject Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Action action = new Action();

                if (_tipe == "movie")
                {
                    action.rejectOrderMovie(_id);
                }
                else if (_tipe == "event")
                {
                    action.rejectOrderEvent(_id);
                }
            }
        }
    }
}
