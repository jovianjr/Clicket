namespace Clicket
{
    public partial class Detail : Form
    {
        public static Detail instance;
        public Label lb_Title;

        private int _quantity;

        public Detail()
        {
            InitializeComponent();
            instance = this;
            lb_Title = lb_title;
            //b_cinema_chosen.Text = cb_cinema.SelectedItem.ToString() ;
            //lb_time_chosen.Text = cb_time.SelectedItem.ToString();
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            pb_poster.Visible = false;
            pn_Details.Visible = false;
            pn_payment.Visible = true;
            lbTitle.Text = "Payment";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Detail_Load(object sender, EventArgs e)
        {
            pn_payment.Visible = false;

            cb_cinema.Text = "---";
            cb_time.Text = "---" ;
            tb_qty.Text = "x" + _quantity.ToString();
            lb_qty_chosen.Text = tb_qty.Text;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (pn_payment.Visible == true)
            {
                pn_payment.Visible = false;
                pn_Details.Visible = true;
                pb_poster.Visible = true;
            }
            else
                this.Close();
        }

        private void btn_addQty_Click(object sender, EventArgs e)
        {
            _quantity += 1;
            tb_qty.Text = _quantity.ToString();
            lb_qty_chosen.Text = "x" + tb_qty.Text;
        }
    }
}