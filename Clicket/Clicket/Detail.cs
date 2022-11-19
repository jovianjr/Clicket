namespace Clicket
{
    public partial class Detail : Form
    {
        public static Detail instance;
        public Label lb_Title;

        private string _title;
        private string _ageRate;
        private string _duration;
        private string _genre;
        private string _date;
        private string _location;
        private string _description;
        private string _quota;
        private Image _poster;
        private int _quantity;
        public string title
        {
            get { return _title; }
            set { _title = value; lbTitle.Text = lbTitleInPay.Text = value; }
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
            set { _date = value; lbDate.Text = lbDateInPay.Text = value; }
        }
        public string location
        {
            get { return _location; }
            set { _location = value; lbLocation.Text = lbLocationInPay.Text = value; }
        }
        public string duration
        {
            get { return _duration; }
            set { _duration = value; lbDur.Text = value; }
        }
        public string description
        {
            get { return _description; }
            set { _description = value; tbDescription.Text = value; }
        }
        public string quota
        {
            get { return _quota; }
            set { _quota = value; lbQuota.Text = value + " tickets available"; }
        }

        public Detail()
        {
            InitializeComponent();
            instance = this;
            lb_Title = lb_title;
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
        }
    }
}