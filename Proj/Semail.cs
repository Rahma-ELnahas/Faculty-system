using Proj.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj
{
    public partial class Semail : Form
    {
        ProjContext db;
        int index;
        public Semail()
        {
            InitializeComponent();
            db = new ProjContext();
        }
        public Semail(int id)
        {
            InitializeComponent();
            db = new ProjContext();
            this.index = id;
        }

        private void Semail_Load(object sender, EventArgs e)
        {
            dgv_email.DataSource = db.users.ToList();
        }
        int id;
        private void dgv_email_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_email.SelectedRows[0].Cells[0].Value;
            user d = db.users.Where(n => n.id == id).SingleOrDefault();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            user d = db.users.Where(n => n.id == id).SingleOrDefault();
            db.users.Remove(d);
            db.SaveChanges();
            dgv_email.DataSource = db.users.ToList();
            MessageBox.Show("Done");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            edit ed = new edit(index,0);
            this.Hide();
            ed.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edit ed = new edit(id,index);
            this.Hide();
            ed.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            admin l = new admin(index);
            this.Hide();
            l.ShowDialog();
        }
    }
}
