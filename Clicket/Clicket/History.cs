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
    public partial class History : UserControl
    {
        public History()
        {
            InitializeComponent();
        }

        private string _title;
        private string _date;
        private string _location;
        private string _price;
        private string _qty;
        private string _total;
        private string _status;

        public string title
        {
            get { return _title; }
            set { _title = value; lbTitle.Text = value; }
        }
        public string date
        {
            get { return _date; }
            set { _date = value; lbDate.Text = value; }
        }
        public string location
        {
            get { return _location; }
            set { _location = value; lbLocation.Text = value; }
        }
        public string price
        {
            get { return _price; }
            set { _price = value; lbPrice.Text = value; }
        }
        public string qty
        {
            get { return _qty; }
            set { _qty = value; lbQty.Text = value; }
        }
        public string total
        {
            get { return _total; }
            set { _total = value; lbTotal.Text = value; }
        }
        public string status
        {
            get { return _status; }
            set { _status = value; lbStatus.Text = value; }
        }
    }
}
