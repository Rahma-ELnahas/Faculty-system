namespace Proj
{
    partial class subjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subjects));
            dgv_sub = new DataGridView();
            button3 = new Button();
            button1 = new Button();
            button4 = new Button();
            button2 = new Button();
            cb_doctor = new ComboBox();
            label6 = new Label();
            txt_phone = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_sub).BeginInit();
            SuspendLayout();
            // 
            // dgv_sub
            // 
            dgv_sub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sub.Location = new Point(42, 246);
            dgv_sub.Name = "dgv_sub";
            dgv_sub.RowHeadersWidth = 51;
            dgv_sub.Size = new Size(302, 249);
            dgv_sub.TabIndex = 0;
            dgv_sub.RowHeaderMouseDoubleClick += dgv_sub_RowHeaderMouseDoubleClick;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ScrollBar;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(42, 194);
            button3.Name = "button3";
            button3.Size = new Size(53, 46);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(162, 195);
            button1.Name = "button1";
            button1.Size = new Size(45, 44);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(63, 46);
            button4.TabIndex = 7;
            button4.Text = "<";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ScrollBar;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(101, 192);
            button2.Name = "button2";
            button2.Size = new Size(55, 48);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // cb_doctor
            // 
            cb_doctor.FormattingEnabled = true;
            cb_doctor.Location = new Point(139, 598);
            cb_doctor.Name = "cb_doctor";
            cb_doctor.Size = new Size(205, 28);
            cb_doctor.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft New Tai Lue", 14F);
            label6.Location = new Point(33, 598);
            label6.Name = "label6";
            label6.Size = new Size(93, 32);
            label6.TabIndex = 24;
            label6.Text = "Doctor ";
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(139, 544);
            txt_phone.Multiline = true;
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(205, 30);
            txt_phone.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft New Tai Lue", 14F);
            label5.Location = new Point(33, 544);
            label5.Name = "label5";
            label5.Size = new Size(100, 32);
            label5.TabIndex = 21;
            label5.Text = "Subject ";
            // 
            // subjects
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(570, 703);
            Controls.Add(cb_doctor);
            Controls.Add(label6);
            Controls.Add(txt_phone);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgv_sub);
            Name = "subjects";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "subjects";
            Load += subjects_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_sub).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_sub;
        private Button button3;
        private Button button1;
        private Button button4;
        private Button button2;
        private ComboBox cb_doctor;
        private Label label6;
        private TextBox txt_phone;
        private Label label5;
    }
}