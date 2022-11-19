using System;
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
    public partial class MovieItem : UserControl
    {
        public static MovieItem instance;
        private Movie _currMovie;

        public MovieItem(Movie currMovie)
        {
            InitializeComponent();
            instance = this;
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
            set { _currMovie = value;}
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail(_currMovie);
            detail.Show();
        }
    }
}
