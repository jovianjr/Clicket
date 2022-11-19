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
    public partial class MovieItem : UserControl
    {
        public static MovieItem instance;

        public MovieItem()
        {
            InitializeComponent();
            instance = this;
        }

        private string _movieTitle;
        private string _ageRate;
        private string _duration;
        private string _genre;
        private string _date;
        private string _location;
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

        private void btn_Details_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail();
            Detail.instance.lb_Title.Text = "Movie Details";
            detail.Show();
        }
    }
}
