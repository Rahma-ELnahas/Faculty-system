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
    public partial class studentSub : Form
    {
        ProjContext db;
        int id;
        int index;
        public studentSub(int id)
        {
            InitializeComponent();
            db = new ProjContext();
            this.id = id;
        }
        public studentSub()
        {
            InitializeComponent();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            student student = new student(id);
            this.Hide();
            student.ShowDialog();

        }

        private void studentSub_Load(object sender, EventArgs e)
        {
            dgv_studentSub.DataSource = db.Subs.Where(s => s.accId == id).Include(s => s.course)
                .ThenInclude(s => s.doc)
        .Select(s => new { s.courseId, name = s.course.name, doctor_name = s.course.doc.name }).ToList();
            dgv_studentSub.Columns[0].Visible = false;
        }
       
        private void dgv_studentSub_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = (int)dgv_studentSub.SelectedRows[0].Cells["courseId"].Value;
            var d = db.Subs.Where(s => s.courseId == index).FirstOrDefault();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            var d = db.Subs.Where(s => s.courseId == index).FirstOrDefault();
           
            db.Subs.Remove(d);
            db.SaveChanges();
            dgv_studentSub.DataSource = db.Subs.Where(s => s.accId == id).Include(s => s.course).ThenInclude(s => s.doc)
          .Select(s => new { s.courseId, name = s.course.name, doctor_name = s.course.doc.name }).ToList();
            MessageBox.Show("Done");

        }

        private void back_Click(object sender, EventArgs e)
        {
            student student = new student(id);
            this.Hide();
            student.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            subjEdit subjEdit = new subjEdit(id); 
            this.Hide();
            subjEdit.ShowDialog();
        }
    }
}
