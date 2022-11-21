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
        private Event _currEvent;

        public EventItem(Event currEvent)
        {
            InitializeComponent();
            instance = this;
            _currEvent = currEvent;

            lbTitle.Text = currEvent.Title;
            lblDate.Text = currEvent.StartDate.ToString("dd MMM yyyy") + " - " + currEvent.EndDate.ToString("dd MMM yyyy");
            lblLocation.Text = currEvent.Location;
            lblPrice.Text = "Rp. " + currEvent.Price.ToString();
            pb_poster.ImageLocation = currEvent.ImgURL;
        }

        public Event CurrEvent
        {
            get { return _currEvent; }
            set { _currEvent = value;}
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail(_currEvent);
            detail.Show();
        }
    }
}
