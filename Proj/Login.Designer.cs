namespace Proj
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            label1 = new Label();
            label2 = new Label();
            txt_email = new TextBox();
            txt_Password = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ScrollBar;
            label1.Font = new Font("Adobe Fan Heiti Std B", 16F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(58, 87);
            label1.Name = "label1";
            label1.Size = new Size(81, 34);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ScrollBar;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Adobe Fan Heiti Std B", 16F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(58, 215);
            label2.Name = "label2";
            label2.Size = new Size(134, 34);
            label2.TabIndex = 1;
            label2.Text = "password";
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Adobe Fan Heiti Std B", 14F);
            txt_email.Location = new Point(58, 136);
            txt_email.Multiline = true;
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(357, 43);
            txt_email.TabIndex = 2;
            // 
            // txt_Password
            // 
            txt_Password.Font = new Font("Adobe Fan Heiti Std B", 14F);
            txt_Password.Location = new Point(58, 264);
            txt_Password.Margin = new Padding(0);
            txt_Password.Multiline = true;
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(357, 43);
            txt_Password.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Microsoft Sans Serif", 14F);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(58, 364);
            button1.Name = "button1";
            button1.Size = new Size(123, 55);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ScrollBar;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            button2.Location = new Point(499, 12);
            button2.Name = "button2";
            button2.Size = new Size(71, 47);
            button2.TabIndex = 9;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(365, 274);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ScrollBar;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(58, 307);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ScrollBar;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(58, 182);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 12;
            label4.Visible = false;
            label4.Click += label4_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(582, 703);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_Password);
            Controls.Add(txt_email);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_email;
        private TextBox txt_Password;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
    }
}