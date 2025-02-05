using Proj.Models;
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
    public partial class admin : Form
    {
        int id;
        ProjContext obj;
        public admin(int id)
        {
            InitializeComponent();
            this.id = id;
            obj = new ProjContext();

        }
        public admin()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Semail semail = new Semail();
            this.Hide();
            semail.ShowDialog();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            var s1 = obj.users.Where(s => s.id == id).SingleOrDefault();
            lbl_id.Text = s1.name;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            login login = new login();
            this.Hide();
            login.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            login login = new login();
            this.Hide();
            login.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Semail semail = new Semail();
            this.Hide();
            semail.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            subjects sub = new subjects();
            this.Hide();
            sub.ShowDialog();
        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }
    }
}
