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
        public subjects()
        {
            InitializeComponent();
            db = new ProjContext();
        }

        private void subjects_Load(object sender, EventArgs e)
        {
            dgv_sub.DataSource = db.Subjects.Select(s => new { name = s.name, doc_name = s.doc.name }).ToList();
        }
        int id;
        private void button1_Click(object sender, EventArgs e)
        {
            int rowIndex = dgv_sub.SelectedCells[0].RowIndex;
            string Name = dgv_sub.Rows[rowIndex].Cells[0].Value?.ToString();
            var q1 = db.Subjects.Where(s => s.name == Name).FirstOrDefault();
            // int id = q1.id;
            db.Remove(q1);
            db.SaveChanges();
            MessageBox.Show("Done");

            dgv_sub.DataSource = db.Subjects.Select(s => new { name = s.name, doc_name = s.doc.name }).ToList();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            admin admin = new admin();  
            this.Hide();
            admin.ShowDialog();
        }
    }
}
