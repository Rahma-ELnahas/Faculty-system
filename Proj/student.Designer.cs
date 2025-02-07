namespace Proj
{
    partial class student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            lbl_student = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(131, 418);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 75);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Bold);
            label1.Location = new Point(138, 19);
            label1.Name = "label1";
            label1.Size = new Size(135, 40);
            label1.TabIndex = 2;
            label1.Text = "Subjects";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(15, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 83);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(131, 324);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 75);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Bold);
            label2.Location = new Point(117, 18);
            label2.Margin = new Padding(5, 3, 5, 3);
            label2.Name = "label2";
            label2.Size = new Size(196, 40);
            label2.TabIndex = 2;
            label2.Text = "Show Profile";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(22, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 70);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox3);
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(131, 512);
            panel3.Name = "panel3";
            panel3.Size = new Size(330, 75);
            panel3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Bold);
            label3.Location = new Point(164, 18);
            label3.Name = "label3";
            label3.Size = new Size(71, 40);
            label3.TabIndex = 2;
            label3.Text = "Exit";
            label3.Click += label3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(22, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(78, 61);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft New Tai Lue", 30F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(131, 150);
            label4.Name = "label4";
            label4.Size = new Size(110, 66);
            label4.TabIndex = 5;
            label4.Text = "Hi !";
            // 
            // lbl_student
            // 
            lbl_student.AutoSize = true;
            lbl_student.Font = new Font("Microsoft New Tai Lue", 30F, FontStyle.Bold | FontStyle.Italic);
            lbl_student.Location = new Point(118, 241);
            lbl_student.Name = "lbl_student";
            lbl_student.Size = new Size(80, 66);
            lbl_student.TabIndex = 6;
            lbl_student.Text = "Hi";
            // 
            // student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(582, 703);
            Controls.Add(lbl_student);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "student";
            Load += student_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label4;
        private Label lbl_student;
    }
}