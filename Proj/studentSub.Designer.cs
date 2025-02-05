namespace Proj
{
    partial class studentSub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentSub));
            dgv_studentSub = new DataGridView();
            button3 = new Button();
            button1 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_studentSub).BeginInit();
            SuspendLayout();
            // 
            // dgv_studentSub
            // 
            dgv_studentSub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_studentSub.Location = new Point(31, 387);
            dgv_studentSub.Name = "dgv_studentSub";
            dgv_studentSub.RowHeadersWidth = 51;
            dgv_studentSub.Size = new Size(305, 167);
            dgv_studentSub.TabIndex = 0;
            dgv_studentSub.RowHeaderMouseDoubleClick += dgv_studentSub_RowHeaderMouseDoubleClick;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ScrollBar;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(82, 320);
            button3.Name = "button3";
            button3.Size = new Size(53, 46);
            button3.TabIndex = 9;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(31, 320);
            button1.Name = "button1";
            button1.Size = new Size(45, 44);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            button1.Click += delete_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(63, 46);
            button4.TabIndex = 10;
            button4.Text = "<";
            button4.UseVisualStyleBackColor = true;
            button4.Click += back_Click;
            // 
            // studentSub
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(582, 703);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dgv_studentSub);
            Name = "studentSub";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "studentSub";
            Load += studentSub_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_studentSub).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_studentSub;
        private Button button3;
        private Button button1;
        private Button button4;
    }
}