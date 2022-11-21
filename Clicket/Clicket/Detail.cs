namespace Clicket
{
    public partial class Detail : Form
    {
        public static Detail instance;
        public Label lb_Title;
        private Movie _movie;
        private Event _event;

        private int _quantity;

        public Detail(Movie currMovie)
        {
            InitializeComponent();
            instance = this;
            _movie = currMovie;

            lb_Title = lb_title;
            lb_Title.Text = "Movie Details";
            lbTitle.Text = currMovie.Title;
            lbTitleInPay.Text = currMovie.Title;
            tbDescription.Text = currMovie.Description;
            lbLocation.Text = currMovie.Location;
            lbDate.Text = currMovie.Date.ToString("ddd, dd MMM yyyy");
            lbDur.Text = currMovie.DurationHour + "h " + currMovie.DurationMin + "m";
            lblPrice.Text = "Rp. " + currMovie.Price.ToString();
            lbQuota.Text = currMovie.Quota.ToString() + " seats available";
            pb_poster.ImageLocation = currMovie.ImgURL;
            lbGenre.Text = string.Join(", ", currMovie.Genre);

            lbDateInPay.Text = currMovie.Date.ToString("ddd, dd MMM yyyy");
            lbLocationInPay.Text = currMovie.Location;
            lbPriceInPay.Text = "Rp. " + currMovie.Price.ToString();

            this.WindowState = FormWindowState.Maximized;
        }

        public Detail(Event currEvent)
        {
            InitializeComponent();
            instance = this;
            _event = currEvent;

            lb_Title = lb_title;
            lb_Title.Text = "Event Details";
            lbTitle.Text = currEvent.Title;
            lbTitleInPay.Text = currEvent.Title;
            tbDescription.Text = currEvent.Description;
            lbLocation.Text = currEvent.Location;
            lbDate.Text = currEvent.StartDate.ToString("dd MMM yyyy") + " - " + currEvent.EndDate.ToString("dd MMM yyyy");
            lblPrice.Text = "Rp. " + currEvent.Price.ToString();
            lbQuota.Text = currEvent.Quota.ToString() + " seats available";
            pb_poster.ImageLocation = currEvent.ImgURL;

            lbDateInPay.Text = currEvent.StartDate.ToString("dd MMM yyyy") + " - " + currEvent.EndDate.ToString("dd MMM yyyy");
            lbLocationInPay.Text = currEvent.Location;
            lbPriceInPay.Text = "Rp. " + currEvent.Price.ToString();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            pn_Details.Visible = false;
            pn_payment.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Detail_Load(object sender, EventArgs e)
        {
            pn_payment.Visible = false;

            tb_qty.Text = _quantity.ToString();
            lb_qty_chosen.Text = tb_qty.Text;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (pn_payment.Visible == true)
            {
                pn_payment.Visible = false;
                pn_Details.Visible = true;
            }
            else
                this.Close();
        }
        private string HitungTotal()
        {
            int totalPrice = int.Parse(lbPriceInPay.Text.Replace("Rp", "").Replace(".", ""))
                * int.Parse(lb_qty_chosen.Text.Replace("x", ""));
            return "Rp " + totalPrice;

        }
        private void btn_addQty_Click(object sender, EventArgs e)
        {
            _quantity += 1;
            tb_qty.Text = _quantity.ToString();
            lb_qty_chosen.Text = "x" + tb_qty.Text;

            lbTotal.Text = HitungTotal();
        }

        private void btn_minQty_Click(object sender, EventArgs e)
        {
            _quantity -= 1;
            tb_qty.Text = _quantity.ToString();
            lb_qty_chosen.Text = "x" + tb_qty.Text;
            lbTotal.Text = HitungTotal();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            SubmitPayment submitPayment = new SubmitPayment(lbTotal.Text, _quantity, _movie, _event);
            submitPayment.Show();

        }
    }
}