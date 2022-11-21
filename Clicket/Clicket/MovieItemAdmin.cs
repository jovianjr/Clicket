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
        public MovieItemAdmin()
        {
            InitializeComponent();
        }

        private string _movieTitle;
        private string _ageRate;
        private string _duration;
        private string _genre;
        private string _date;
        private string _location;
        private string _price;
        private Image _poster;

        public string title
        {
            get { return _movieTitle; }
            set { _movieTitle = value; lbTitle.Text = value; }
        }

        public string ageRate
        {
            get { return _ageRate; }
            set { _ageRate = value; lbAgeRate.Text = value; }
        }
        public string genre
        {
            get { return _genre; }
            set { _genre = value; lbGenre.Text = value; }
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
        public string duration
        {
            get { return _duration; }
            set { _duration = value; lbDur.Text = /*_durHour + "*/ "h " /* + _durMinute*/ + "m"; }
        }
        public string price
        {
            get { return _price; }
            set { _price = value; lbPrice.Text = value; }   
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Movie _movie = new Movie();
            CreateUpdate createUpdate = new CreateUpdate(_movie);
            createUpdate.Show();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
