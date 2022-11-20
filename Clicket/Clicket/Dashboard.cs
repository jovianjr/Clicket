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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void populateItems()
        {
            MovieItem[] movieItems = new MovieItem[20];

            for (int i = 0; i < movieItems.Length; i++)
            {
                movieItems[i] = new MovieItem();
                movieItems[i].title = "Movie " + i.ToString();
                movieItems[i].ageRate = "-";

                //if (flp_movie.Controls.Count > 0)
                //{
                //    flp_movie.Controls.Clear();
                //}
                //else
                flp_movie.Controls.Add(movieItems[i]);
            }

            EventItem[] eventItems = new EventItem[20];
            for (int i = 0; i < eventItems.Length; i++)
            {
                eventItems[i] = new EventItem();
                eventItems[i].title = "Event " + i.ToString();

                //if (flp_movie.Controls.Count > 0)
                //{
                //    flp_movie.Controls.Clear();
                //}
                //else
                flp_event.Controls.Add(eventItems[i]);
            }

            History[] histories = new History[20];
            for (int i = 0; i < histories.Length; i++)
            {
                histories[i] = new History();
                histories[i].title = i.ToString();
                histories[i].date = i.ToString();
                histories[i].location = i.ToString();
                histories[i].price = i.ToString();
                histories[i].qty = i.ToString();
                histories[i].total = i.ToString();
                histories[i].status = i.ToString();

                flp_history.Controls.Add(histories[i]);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            populateItems();
            flp_event.Visible = false;
            flp_history.Visible = false;
            btn_Movie.BackColor = Color.FromArgb(255, 195, 0);
            iconMovie.BackColor = Color.FromArgb(255, 195, 0);
        }

        private void btn_Movie_Click(object sender, EventArgs e)
        {
            flp_movie.Visible = true;
            flp_event.Visible = false;
            flp_history.Visible = false;

            lbTitle.Text = "#MOVIES";
            lbSubTitle.Text = "NOW SHOWING";

            btn_Movie.BackColor = iconMovie.BackColor = Color.FromArgb(255, 195, 0);

            btn_Event.BackColor = iconEvent.BackColor = Color.White;

            btnHistory.BackColor = iconHistory.BackColor = Color.White;
        }

        private void btn_Event_Click(object sender, EventArgs e)
        {
            flp_movie.Visible = false;
            flp_event.Visible = true;
            flp_history.Visible = false;

            lbTitle.Text = "#EVENTS";
            lbSubTitle.Text = "WILL BE HELD";

            btn_Movie.BackColor = iconMovie.BackColor = Color.White;

            btn_Event.BackColor = iconEvent.BackColor = Color.FromArgb(255, 195, 0);

            btnHistory.BackColor = iconHistory.BackColor = Color.White;
        }
        private void btnHistory_Click(object sender, EventArgs e)
        {
            flp_movie.Visible = false;
            flp_event.Visible = false;
            flp_history.Visible = true;

            lbTitle.Text = "#HISTORY";
            lbSubTitle.Text = "Transaction History List";

            btn_Movie.BackColor = iconMovie.BackColor = Color.White;

            btn_Event.BackColor = iconEvent.BackColor = Color.White;

            btnHistory.BackColor = iconHistory.BackColor = Color.FromArgb(255, 195, 0);
        }

        private void iconEvent_Click(object sender, EventArgs e)
        {
            btn_Event.PerformClick();
        }

        private void iconMovie_Click(object sender, EventArgs e)
        {
            btn_Movie.PerformClick();
        }

        private void iconHistory_Click(object sender, EventArgs e)
        {
            btnHistory.PerformClick();
        }
    }
}
