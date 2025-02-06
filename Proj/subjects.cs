using Microsoft.EntityFrameworkCore;
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
    public partial class subjects : Form
    {
        ProjContext db;
        int index;
        string name;
        public subjects()
        {
            InitializeComponent();
            db = new ProjContext();
        }
        public subjects(int id)
        {
            InitializeComponent();
            db = new ProjContext();
            this.index = id;
        }

        private void subjects_Load(object sender, EventArgs e)
        {
            dgv_sub.DataSource = db.Subjects.Select(s => new { name = s.name, doc_name = s.doc.name }).ToList();
            var q2 = db.users.Where(s => s.role == "doctor").ToList();
            cb_doctor.DataSource = q2;
            cb_doctor.ValueMember = "id";
            cb_doctor.DisplayMember = "name";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var q1 = db.Subjects.Where(s => s.name == name).FirstOrDefault();
            db.Subjects.Remove(q1);
            db.SaveChanges();
            MessageBox.Show("Done");
            txt_phone.Text = "";
            dgv_sub.DataSource = db.Subjects.Select(s => new { name = s.name, doc_name = s.doc.name }).ToList();
            button2.Visible = false;
            button1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            admin admin = new admin(index);
            this.Hide();
            admin.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int rowIndex = dgv_sub.SelectedCells[0].RowIndex;
            //string Name = dgv_sub.Rows[rowIndex].Cells[0].Value?.ToString();
            var q1 = db.Subjects.Where(s => s.name == Name).FirstOrDefault();
            //if (q1 != null)
            //{
            //    MessageBox.Show("This subject already exists");
            //    return;
            //}

            subject s = new subject();
            s.name = txt_phone.Text;
            s.docId = (int)cb_doctor.SelectedValue;
            db.Subjects.Add(s);
            db.SaveChanges();
            dgv_sub.DataSource = db.Subjects.Select(s => new { name = s.name, doc_name = s.doc.name }).ToList();
            txt_phone.Text = "";
            MessageBox.Show("Done");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var q1 = db.Subjects.Where(s => s.name == name).FirstOrDefault();
            q1.name = txt_phone.Text;
            q1.docId = (int)cb_doctor.SelectedValue;
            db.SaveChanges();
            dgv_sub.DataSource = db.Subjects.Select(s => new { name = s.name, doc_name = s.doc.name }).ToList();
            txt_phone.Text = "";
            button2.Visible = false;
            button1.Visible = false;
            MessageBox.Show("Done");

        }

        private void dgv_sub_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            name = dgv_sub.SelectedRows[0].Cells[0].Value.ToString();
            var r = db.Subjects.Where(s => s.name.Equals(name)).Include(s => s.doc).FirstOrDefault();
            txt_phone.Text = r.name;
            cb_doctor.SelectedValue = r.docId;
            button2.Visible = true;
            button1.Visible = true;
        }
    }
}
