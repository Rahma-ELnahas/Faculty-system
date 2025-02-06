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
    public partial class edit : Form
    {
        int id;
        int index;
        ProjContext obj = new ProjContext();
        public edit(int id, int index)
        {
            InitializeComponent();
            this.id = id;
            this.index = index;

        }
        public edit()
        {
            InitializeComponent();
        }

        private void edit_Load(object sender, EventArgs e)
        {
            if (index > 0)
            {
                var s1 = obj.users.Where(s => s.id == id).SingleOrDefault();
                txt_name.Text = s1.name;
                txt_mail.Text = s1.email;
                txt_pass.Text=s1.password.ToString();
                txt_age.Text = s1.age.ToString();
                txt_phone.Text = s1.phone.ToString();
                txt_role.Text = s1.role;
                
            }
        }
        private void Done_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                var s1 = obj.users.Where(s => s.id == id).SingleOrDefault();
                s1.name = txt_name.Text;
                s1.email = txt_mail.Text;
                s1.password = int.Parse(txt_pass.Text);
                s1.age = int.Parse(txt_age.Text);
                s1.phone = int.Parse(txt_phone.Text);
                s1.role = txt_role.Text;
                obj.SaveChanges();
                MessageBox.Show("Done");
            }
            else
            {
                user u = new user();
                u.name = txt_name.Text;
                u.email = txt_mail.Text;
                u.password = int.Parse(txt_pass.Text);
                u.age = int.Parse(txt_age.Text);
                u.phone = int.Parse(txt_phone.Text);
                u.role = txt_role.Text;

                obj.users.Add(u);
                obj.SaveChanges();
                MessageBox.Show("Done");
                Semail semail = new Semail(id);
                this.Hide();
                semail.Show();
            }
           

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Semail semail = new Semail(index);
            this.Hide();
            semail.Show();
        }
    }
}
