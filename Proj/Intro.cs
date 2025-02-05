namespace Proj
{

    public partial class intro : Form
    {
        public intro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            login f = new login();
            this.Hide();
            f.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            guest guest = new guest();
            this.Hide();
            guest.ShowDialog();
        }
    }
}
