namespace Proj
{
    partial class Semail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Semail));
            dgv_email = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_email).BeginInit();
            SuspendLayout();
            // 
            // dgv_email
            // 
            dgv_email.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_email.Location = new Point(27, 360);
            dgv_email.Name = "dgv_email";
            dgv_email.RowHeadersWidth = 51;
            dgv_email.Size = new Size(523, 300);
            dgv_email.TabIndex = 0;
            dgv_email.RowHeaderMouseDoubleClick += dgv_email_RowHeaderMouseDoubleClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(505, 299);
            button1.Name = "button1";
            button1.Size = new Size(45, 44);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(444, 297);
            button2.Name = "button2";
            button2.Size = new Size(55, 48);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(385, 297);
            button3.Name = "button3";
            button3.Size = new Size(53, 46);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button4.Location = new Point(498, 12);
            button4.Name = "button4";
            button4.Size = new Size(72, 57);
            button4.TabIndex = 4;
            button4.Text = ">";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Semail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(582, 703);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgv_email);
            Name = "Semail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Semail";
            Load += Semail_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_email).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_email;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}