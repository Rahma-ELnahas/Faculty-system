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
    public partial class studentProf : Form
    {
        int id;
        ProjContext obj = new ProjContext();
        public studentProf(int id)
        {
            InitializeComponent();
            this.id = id;


        }
        public studentProf()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            student student = new student(id);
            this.Hide();
            student.ShowDialog();
        }

        private void studentProf_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                var s1 = obj.users.Where(s => s.id == id).SingleOrDefault();
                txt_mail.Text = s1.email;
                txt_age.Text = s1.age.ToString();
                textBox4.Text = s1.phone.ToString();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var s1 = obj.users.Where(s => s.id == id).SingleOrDefault();

            s1.email = txt_mail.Text;
            s1.age = int.Parse(txt_age.Text);
            s1.phone = int.Parse(textBox4.Text);

            obj.SaveChanges();
            MessageBox.Show("Done");

            student student = new student(id);
            this.Hide();
            student.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = obj.users.Where(s => s.id == id).SingleOrDefault();
            int oldPassword;
            bool isOldPasswordInt = int.TryParse(texold.Text, out oldPassword);

            if (!isOldPasswordInt)
            {
                MessageBox.Show("Please enter a valid old password.");
                return;
            }
            if (oldPassword != data.password) 
            {
                MessageBox.Show("Please, enter correct old password.");
                return;
            }

            if (txtnew.Text != txtconf.Text)
            {
                MessageBox.Show("Please, enter the same password in both fields.");
                return;
            }
            int newPassword;
            bool isNewPasswordInt = int.TryParse(txtnew.Text, out newPassword);

            if (!isNewPasswordInt)
            {
                MessageBox.Show("Please enter a valid new password.");
                return;
            }

            data.password = newPassword; 
            obj.SaveChanges();
            MessageBox.Show("Password updated successfully.");
            txtnew.Text = txtconf.Text = texold.Text = "";
        }
    }
}
