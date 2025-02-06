namespace Proj
{
    partial class studentProf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentProf));
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_mail = new TextBox();
            txt_age = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            button1 = new Button();
            txtconf = new TextBox();
            texold = new TextBox();
            txtnew = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("Microsoft New Tai Lue", 14F, FontStyle.Bold);
            label3.Location = new Point(31, 388);
            label3.Name = "label3";
            label3.Size = new Size(86, 31);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gainsboro;
            label4.Font = new Font("Microsoft New Tai Lue", 14F, FontStyle.Bold);
            label4.Location = new Point(31, 339);
            label4.Name = "label4";
            label4.Size = new Size(59, 31);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gainsboro;
            label5.Font = new Font("Microsoft New Tai Lue", 14F, FontStyle.Bold);
            label5.Location = new Point(31, 289);
            label5.Name = "label5";
            label5.Size = new Size(76, 31);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // txt_mail
            // 
            txt_mail.Location = new Point(135, 289);
            txt_mail.Multiline = true;
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(215, 30);
            txt_mail.TabIndex = 6;
            // 
            // txt_age
            // 
            txt_age.Location = new Point(135, 339);
            txt_age.Multiline = true;
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(215, 30);
            txt_age.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(135, 388);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(215, 30);
            textBox4.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Bold | FontStyle.Underline);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(31, 439);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 9;
            label1.Text = "change password";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuBar;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtconf);
            panel1.Controls.Add(texold);
            panel1.Controls.Add(txtnew);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(185, 439);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 165);
            panel1.TabIndex = 10;
            panel1.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.WindowFrame;
            label8.Location = new Point(222, 115);
            label8.Name = "label8";
            label8.Size = new Size(63, 27);
            label8.TabIndex = 17;
            label8.Text = "Show";
            label8.Click += label8_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Font = new Font("Adobe Fan Heiti Std B", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(97, 115);
            button1.Name = "button1";
            button1.Size = new Size(84, 43);
            button1.TabIndex = 11;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtconf
            // 
            txtconf.Location = new Point(134, 78);
            txtconf.Name = "txtconf";
            txtconf.PasswordChar = '*';
            txtconf.Size = new Size(145, 27);
            txtconf.TabIndex = 16;
            txtconf.TextChanged += textBox1_TextChanged;
            // 
            // texold
            // 
            texold.Location = new Point(134, 12);
            texold.Name = "texold";
            texold.PasswordChar = '*';
            texold.Size = new Size(145, 27);
            texold.TabIndex = 14;
            texold.TextChanged += textBox6_TextChanged;
            // 
            // txtnew
            // 
            txtnew.Location = new Point(134, 45);
            txtnew.Name = "txtnew";
            txtnew.PasswordChar = '*';
            txtnew.Size = new Size(145, 27);
            txtnew.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            label7.Location = new Point(11, 80);
            label7.Name = "label7";
            label7.Size = new Size(99, 27);
            label7.TabIndex = 11;
            label7.Text = "Confirm :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            label6.Location = new Point(11, 45);
            label6.Name = "label6";
            label6.Size = new Size(66, 27);
            label6.TabIndex = 12;
            label6.Text = "New :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            label2.Location = new Point(11, 12);
            label2.Name = "label2";
            label2.Size = new Size(56, 27);
            label2.TabIndex = 13;
            label2.Text = "Old :";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(511, 12);
            button2.Name = "button2";
            button2.Size = new Size(59, 52);
            button2.TabIndex = 11;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDarkDark;
            button3.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(31, 492);
            button3.Name = "button3";
            button3.Size = new Size(110, 52);
            button3.TabIndex = 17;
            button3.Text = "Done";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // studentProf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(582, 703);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(txt_age);
            Controls.Add(txt_mail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "studentProf";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "studentProf";
            Load += studentProf_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_mail;
        private TextBox txt_age;
        private TextBox textBox4;
        private Label label1;
        private Panel panel1;
        private TextBox txtconf;
        private TextBox texold;
        private TextBox txtnew;
        private Label label7;
        private Label label6;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label8;
    }
}