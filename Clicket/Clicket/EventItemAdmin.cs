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
    public partial class EventItemAdmin : UserControl
    {
        public EventItemAdmin()
        {
            InitializeComponent();
        }

        private string _eventTitle;
        private string _date;
        private string _location;
        private string _price;
        private Image _poster;

        public string title
        {
            get { return _eventTitle; }
            set { _eventTitle = value; lbTitle.Text = value; }
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
            get { return price; }
            set { _price = value; lbPrice.Text = value; }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Event _event = new Event();
            CreateUpdate createUpdate = new CreateUpdate(_event);
            createUpdate.Show();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
