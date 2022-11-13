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
        private string _ageRate;
        private Image _poster;

        [Category("CustomProps")]
        public string title
        {
            get { return _eventTitle; }
            set { _eventTitle = value; lbTitle.Text = value; }
        }


        [Category("CustomProps")]
        public string ageRate
        {
            get { return _ageRate; }
            set { _ageRate = value; lbAgeRate.Text = value; }
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail();
            Detail.instance.lb_Title.Text = "Event Details";
            detail.Show();

        }
    }
}
