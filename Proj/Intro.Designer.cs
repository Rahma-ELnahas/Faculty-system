namespace Proj
{
    partial class intro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(intro));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 40F, FontStyle.Bold);
            label1.Location = new Point(134, 231);
            label1.Name = "label1";
            label1.Size = new Size(303, 83);
            label1.TabIndex = 0;
            label1.Text = "Welcome !";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Adobe Fan Heiti Std B", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(91, 335);
            label2.Name = "label2";
            label2.Size = new Size(389, 100);
            label2.TabIndex = 1;
            label2.Text = "You are now on the app of\n the Faculty  If you are a student, log in, \nand if you want to get to know the college\n click on a guest.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(432, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDarkDark;
            button3.Font = new Font("Adobe Fan Heiti Std B", 14F);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(215, 462);
            button3.Name = "button3";
            button3.Size = new Size(141, 51);
            button3.TabIndex = 5;
            button3.Text = "Login";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Adobe Fan Heiti Std B", 14F);
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(200, 528);
            button1.Name = "button1";
            button1.Size = new Size(171, 51);
            button1.TabIndex = 6;
            button1.Text = "I`m a Gust";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // intro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(582, 703);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "intro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button3;
    }
}
