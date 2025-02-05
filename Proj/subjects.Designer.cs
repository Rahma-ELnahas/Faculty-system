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
            ((System.ComponentModel.ISupportInitialize)dgv_sub).BeginInit();
            SuspendLayout();
            // 
            // dgv_sub
            // 
            dgv_sub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sub.Location = new Point(45, 367);
            dgv_sub.Name = "dgv_sub";
            dgv_sub.RowHeadersWidth = 51;
            dgv_sub.Size = new Size(302, 271);
            dgv_sub.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ScrollBar;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(157, 316);
            button3.Name = "button3";
            button3.Size = new Size(53, 46);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(45, 317);
            button1.Name = "button1";
            button1.Size = new Size(45, 44);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
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
            button2.Location = new Point(96, 315);
            button2.Name = "button2";
            button2.Size = new Size(55, 48);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = false;
            // 
            // subjects
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(570, 703);
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
        }

        #endregion

        private DataGridView dgv_sub;
        private Button button3;
        private Button button1;
        private Button button4;
        private Button button2;
    }
}