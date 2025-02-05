using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj
{
    public partial class guest : Form
    {
        public guest()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            intro IN = new intro();
            this.Hide();
            IN.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guest2 gg = new guest2();
            this.Hide();
            gg.ShowDialog();
        }
    }
}
