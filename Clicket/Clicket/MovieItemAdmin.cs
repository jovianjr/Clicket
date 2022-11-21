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
    public partial class MovieItemAdmin : UserControl
    {
        private Movie _currMovie;

        public MovieItemAdmin(Movie currMovie)
        {
            InitializeComponent();
            _currMovie = currMovie;

            lbTitle.Text = currMovie.Title;
            lbAgeRate.Text = currMovie.ageRate;
            lbGenre.Text = currMovie.Title;
            lbDate.Text = currMovie.Date.ToString("ddd, dd MMM yyyy");
            lbLocation.Text = currMovie.Location;
            lbDur.Text = currMovie.DurationHour + "h " + currMovie.DurationMin + "m";
            lbPrice.Text = "Rp. " + currMovie.Price.ToString();
            pb_poster.ImageLocation = currMovie.ImgURL;
        }

        public Movie CurrMovie
        {
            get { return _currMovie; }
            set { _currMovie = value; }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            CreateUpdate createUpdate = new CreateUpdate(_currMovie);
            createUpdate.Show();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
