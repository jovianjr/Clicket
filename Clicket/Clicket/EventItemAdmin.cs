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
        private Event _currEvent;
        public EventItemAdmin(Event currEvent)
        {
            InitializeComponent();
            _currEvent = currEvent;

            lbTitle.Text = currEvent.Title;
            lbDate.Text = currEvent.StartDate.ToString("dd MMM yyyy") + " - " + currEvent.EndDate.ToString("dd MMM yyyy");
            lbLocation.Text = currEvent.Location;
            lbPrice.Text = "Rp. " + currEvent.Price.ToString();
            pb_poster.ImageLocation = currEvent.ImgURL;
        }

        public Event CurrEvent
        {
            get { return _currEvent; }
            set { _currEvent = value; }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            CreateUpdate createUpdate = new CreateUpdate(_currEvent);
            createUpdate.Show();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin?", "Delete Event", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Action action = new Action();
                action.delete(_currEvent);
            }
        }
    }
}
