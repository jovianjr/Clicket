using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Clicket
{
    public partial class CreateUpdate : Form
    {
        private Boolean _isNewMovie;
        private Boolean _isNewEvent;
        private Event currEvent;
        private Movie currMovie;

        public CreateUpdate()
        {
            InitializeComponent();
        }

        public CreateUpdate(string type)
        {
            InitializeComponent();

            if (type == "movie")
            {
                dtpEndDate.Visible = false;
                _isNewMovie = true;
            }

            if (type == "event")
            {
                tbDurHour.Visible = false;
                tbDurMin.Visible = false;
                cbGenre.Visible = false;
                cbAgeRate.Visible = false;
                _isNewEvent = true;
            }
        }

        //Movie
        public CreateUpdate(Movie _movie)
        {
            InitializeComponent();
            currMovie = _movie;
            tbTitle.Text = _movie.Title;
            dtpDate.Value = _movie.Date;
            tbLocation.Text = _movie.Location;
            tbDescription.Text = _movie.Description;
            tbPrice.Text = _movie.Price.ToString();
            tbDurHour.Text = _movie.DurationHour.ToString();
            tbDurMin.Text = _movie.DurationMin.ToString();
            tbQuota.Text = _movie.Quota.ToString();
            cbGenre.SelectedItem = _movie.Genre;
            cbAgeRate.SelectedItem = _movie.ageRate;
            pb_poster.ImageLocation = _movie.ImgURL;
            dtpEndDate.Visible = false;
            _isNewMovie = false;
            _isNewEvent = false;
        }

        //Event
        public CreateUpdate(Event _event)
        {
            InitializeComponent();
            currEvent = _event;
            tbTitle.Text = _event.Title;
            dtpDate.Value = _event.StartDate;
            dtpEndDate.Value = _event.EndDate;
            tbLocation.Text = _event.Location;
            tbDescription.Text = _event.Description;
            tbPrice.Text = _event.Price.ToString();
            tbQuota.Text = _event.Quota.ToString();
            pb_poster.ImageLocation = _event.ImgURL;
            tbDurHour.Visible = false;
            tbDurMin.Visible = false;
            cbGenre.Visible = false;
            cbAgeRate.Visible = false;
            _isNewMovie = false;
            _isNewEvent = false;
        }

        private void SaveData()
        {
            Action action = new Action();
            if (_isNewMovie)
            {
                Movie newMovie = new Movie();
                newMovie.Title = tbTitle.Text;
                newMovie.Description = tbDescription.Text;
                newMovie.Location = tbLocation.Text;
                newMovie.Date = dtpDate.Value.Date;
                newMovie.DurationHour = Int32.Parse(tbDurHour.Text);
                newMovie.DurationMin = Int32.Parse(tbDurMin.Text);
                newMovie.Price = Int32.Parse(tbPrice.Text);
                newMovie.Quota = Int32.Parse(tbQuota.Text);
                newMovie.ageRate = "PG";
                newMovie.Genre = new string[]{"action"};
                newMovie.ImgURL = pb_poster.ImageLocation;
                action.add(newMovie);
            } else if (_isNewEvent)
            {
                Event newEvent = new Event();
                newEvent.Title = tbTitle.Text;
                newEvent.Description = tbDescription.Text;
                newEvent.Location = tbLocation.Text;
                newEvent.StartDate = dtpDate.Value.Date;
                newEvent.EndDate = dtpEndDate.Value.Date;
                newEvent.Price = Int32.Parse(tbPrice.Text);
                newEvent.Quota = Int32.Parse(tbQuota.Text);
                newEvent.ImgURL = pb_poster.ImageLocation;
                action.add(newEvent);
            }
            else if (currMovie != null)
            {
                Movie newMovie = new Movie();
                newMovie.MovieID = currMovie.MovieID;
                newMovie.Title = tbTitle.Text;
                newMovie.Description = tbDescription.Text;
                newMovie.Location = tbLocation.Text;
                newMovie.Date = dtpDate.Value.Date;
                newMovie.DurationHour = Int32.Parse(tbDurHour.Text);
                newMovie.DurationMin = Int32.Parse(tbDurMin.Text);
                newMovie.Price = Int32.Parse(tbPrice.Text);
                newMovie.Quota = Int32.Parse(tbQuota.Text);
                newMovie.ageRate = cbAgeRate.SelectedItem.ToString();
                newMovie.Genre = currMovie.Genre;
                newMovie.ImgURL = pb_poster.ImageLocation;
                action.update(newMovie);
            } else if(currEvent != null)
            {
                Event newEvent = new Event();
                newEvent.EventID = currEvent.EventID;
                newEvent.Title = tbTitle.Text;
                newEvent.Description = tbDescription.Text;
                newEvent.Location = tbLocation.Text;
                newEvent.StartDate = dtpDate.Value.Date;
                newEvent.EndDate = dtpEndDate.Value.Date;
                newEvent.Price = Int32.Parse(tbPrice.Text);
                newEvent.Quota = Int32.Parse(tbQuota.Text);
                newEvent.ImgURL = pb_poster.ImageLocation;
                action.update(newEvent);
            }
        }
         
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SaveData();
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ofdPoster.ShowDialog();
            pb_poster.ImageLocation = ofdPoster.FileName;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
