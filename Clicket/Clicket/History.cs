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
        public History(string title, string date, string location, string price, string qty, string total, string status)
        {
            InitializeComponent();
            lbTitle.Text = _title = title;
            lbDate.Text = _date = date;
            lbLocation.Text = _location = location;
            lbPrice.Text = _price = price;
            lbQty.Text = _qty = qty;
            lbTotal.Text = _total = total;
            lbStatus.Text = _status = status;
        }

        private string _title;
        private string _date;
        private string _location;
        private string _price;
        private string _qty;
        private string _total;
        private string _status;
    }
}
