using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proj.Models;
using System.Text.RegularExpressions;


namespace Proj
{
    public partial class login : Form
    {
        SqlConnection con;

        public login()
        {
            InitializeComponent();

            con = new SqlConnection("Server=.;Database=Project;Trusted_Connection=True; TrustServerCertificate=True");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label3.Text = label4.Text = "";
            string email = txt_email.Text;
            string pass = txt_Password.Text;

            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]{5,}\.com$";
            bool isValidEmail = Regex.IsMatch(email, emailPattern);
            if (!isValidEmail)
            {
                label4.Visible=true;
                label4.Text = "❌ Invalid email format";
                return;
            }
            if (string.IsNullOrWhiteSpace(pass))
            {
                label3.Visible = true;
                label3.Text = "❌ Please enter a password";
                return;
            }

                try
            {
                string q1 = "SELECT * FROM users WHERE users.email=@email and users.password=@pass";
                var user = con.Query<Models.user>(q1, new { email, pass }).FirstOrDefault();

                if (user != null)
                {
                    if (user.role == "student")
                    {
                        student studentForm = new student(user.id);
                        this.Hide();
                        studentForm.ShowDialog();
                    }
                    else if (user.role == "admin")
                    {
                        admin ad = new admin(user.id);
                        this.Hide();
                        ad.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Email Or password are incorrect");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            intro intro = new intro();
            this.Hide();
            intro.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txt_Password.PasswordChar == '*')
            {
                txt_Password.PasswordChar = '\0';
            }
            else
            {
                txt_Password.PasswordChar = '*';
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
