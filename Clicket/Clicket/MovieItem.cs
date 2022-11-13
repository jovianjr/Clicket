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
        private Image _poster;

        [Category("CustomProps")]
        public string title
        {
            get { return _movieTitle; }
            set { _movieTitle = value; lbTitle.Text = value; }
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
            Detail.instance.lb_Title.Text = "Movie Details";
            detail.Show();

        }
    }
}
