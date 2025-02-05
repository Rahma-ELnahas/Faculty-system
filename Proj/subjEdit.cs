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
    public partial class subjEdit : Form
    {
        ProjContext obj;
        int index;
        int id;
        public subjEdit(int index)
        {
            InitializeComponent();
            obj = new ProjContext();
            this.index = index;

        }

        private void subjEdit_Load(object sender, EventArgs e)
        {
            dgv_editsubj.DataSource = obj.Subjects
         .Where(s => !s.Subs.Any(sub => sub.accId == index)) // التأكد من أن الدورة ليست مسجلة للطالب
         .Include(s => s.doc)
         .Select(s => new
         {
             s.id,
             name = s.name,
             doctor_name = s.doc.name
         })
         .ToList();
            dgv_editsubj.Columns[0].Visible = false;
        }

        private void Done_Click(object sender, EventArgs e)
        {
            sub s = new sub();
            s.accId = index;
            s.courseId = id;
            obj.Subs.Add(s);
            obj.SaveChanges();
            MessageBox.Show("Done");
            dgv_editsubj.DataSource = obj.Subjects
         .Where(s => !s.Subs.Any(sub => sub.accId == index)) // التأكد من أن الدورة ليست مسجلة للطالب
         .Include(s => s.doc)
         .Select(s => new
         {
             s.id,
             name = s.name,
             doctor_name = s.doc.name
         })
         .ToList();
            dgv_editsubj.Columns[0].Visible = false;




        }

        private void dgv_editsubj_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_editsubj.SelectedRows[0].Cells["id"].Value;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            studentSub studentSub = new studentSub(index);   
            this.Hide();
            studentSub.ShowDialog();
        }
    }
}
