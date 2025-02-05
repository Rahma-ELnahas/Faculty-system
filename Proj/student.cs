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
    public partial class student : Form
    {
        int id;
        ProjContext obj;
        public student(int id)
        {
            InitializeComponent();
            this.id = id;
            obj = new ProjContext();

        }
        public student()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            login l = new login();
            this.Hide();
            l.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //login l = new login();
            //this.Hide();
            //l.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void student_Load(object sender, EventArgs e)
        {
            var s1 = obj.users.Where(s => s.id == id).SingleOrDefault();
            lbl_student.Text = s1.name;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            login l = new login();
            this.Hide();
            l.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            studentProf studentProf = new studentProf(id);
            this.Hide();
            studentProf.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            studentProf studentProf = new studentProf(id);
            this.Hide();
            studentProf.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            studentSub studentSub = new studentSub(id);
            this.Hide();
            studentSub.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            studentSub studentSub = new studentSub(id);
            this.Hide();
            studentSub.ShowDialog();

        }
    }
}
