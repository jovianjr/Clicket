﻿using System;
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
    public partial class DashboardAdmin : Form
    {
        private bool btn_Movie_State;
        private bool btn_Event_State;

        public DashboardAdmin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void populateItems(List<Movie> listMovie, List<Event> listEvent, List<Transaction> listHistory)
        {
            MovieItemAdmin[] movieItems = new MovieItemAdmin[listMovie.Count];


            for (int i = 0; i < movieItems.Length; i++)
            {
                movieItems[i] = new MovieItemAdmin(listMovie[i]);
                flp_movie.Controls.Add(movieItems[i]);
            }

            EventItemAdmin[] eventItems = new EventItemAdmin[listEvent.Count];
            for (int i = 0; i < eventItems.Length; i++)
            {
                eventItems[i] = new EventItemAdmin(listEvent[i]);
                flp_event.Controls.Add(eventItems[i]);
            }

            Transaction[] transaction = new Transaction[listHistory.Count];
            for (int i = 0; i < transaction.Length; i++)
            {
                flp_history.Controls.Add(listHistory[i]);
            }
        }

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {
            flp_event.Visible = false;
            flp_history.Visible = false;
            btn_Movie.BackColor = Color.FromArgb(255, 195, 0);
            iconMovie.BackColor = Color.FromArgb(255, 195, 0);

            Action action = new Action();
            List<Movie> movies = action.getMovieList();
            List<Event> events = action.getEventList();
            List<Transaction> histories = action.getHistoryListAdmin();
            populateItems(movies, events, histories);

        }
        private void btn_Movie_Click(object sender, EventArgs e)
        {
            btn_Movie_State = true;
            btn_Event_State = false;

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
            btn_Movie_State = false;
            btn_Event_State = true;

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
            btn_Movie_State = false;
            btn_Event_State = false;

            flp_movie.Visible = false;
            flp_event.Visible = false;
            flp_history.Visible = true;

            lbTitle.Text = "#HISTORY";
            lbSubTitle.Text = "TRANSACTION LIST";

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (btn_Movie_State)
            {
                CreateUpdate createUpdate = new CreateUpdate("movie");
                createUpdate.Show();
            }
            else if (btn_Event_State)
            {
                CreateUpdate createUpdate = new CreateUpdate("event");
                createUpdate.Show();
            }
        }

    }
}
