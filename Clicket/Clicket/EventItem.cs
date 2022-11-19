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
    public partial class EventItem : UserControl
    {
        public static EventItem instance;

        public EventItem()
        {
            InitializeComponent();
            instance = this;
        }

        private string _eventTitle;
        private string _genre;
        private string _date;
        private string _location;
        private string _price;
        private string _poster;

        [Category("CustomProps")]
        public string title
        {
            get { return _eventTitle; }
            set { _eventTitle = value; lbTitle.Text = value; }
        }
        public string date
        {
            get { return _date; }
            set { _date = value; lblDate.Text = value; }
        }
        public string location
        {
            get { return _location; }
            set { _location = value; lblLocation.Text = value; }
        }
        public string price
        {
            get { return _price; }
            set { _price = value; lblPrice.Text = value; }
        }
        public string poster
        {
            get { return _poster.ToString(); }
            set { _poster = value; pb_poster.ImageLocation = value; pb_poster.BackgroundImageLayout = ImageLayout.Stretch; }
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail();
            Detail.instance.lb_Title.Text = "Event Details";
            detail.Show();
        }
    }
}
