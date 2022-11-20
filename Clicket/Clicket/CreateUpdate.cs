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
        public CreateUpdate()
        {
            InitializeComponent();
        }

        //Movie
        public CreateUpdate(Movie _movie)
        {
            InitializeComponent();
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
            //pb_poster = _movie.ImgURL; 
            dtpEndDate.Visible = false;
        }

        //Event
        public CreateUpdate(Event _event)
        {
            InitializeComponent();
            tbTitle.Text = _event.Title;
            dtpDate.Value = _event.StartDate;
            dtpEndDate.Value = _event.EndDate;
            tbLocation.Text = _event.Location;
            tbDescription.Text = _event.Description;
            tbPrice.Text = _event.Price.ToString();
            tbQuota.Text = _event.Quota.ToString();
            tbDurHour.Visible = false;
            tbDurMin.Visible = false;
            cbGenre.Visible = false;
            cbAgeRate.Visible = false;
            //pb_poster = _movie.ImgURL;
        }

        private void SaveData()
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SaveData();
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ofdPoster.ShowDialog();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
