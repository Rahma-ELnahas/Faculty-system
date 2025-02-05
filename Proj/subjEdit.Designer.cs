namespace Proj
{
    partial class subjEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subjEdit));
            dgv_editsubj = new DataGridView();
            Done = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_editsubj).BeginInit();
            SuspendLayout();
            // 
            // dgv_editsubj
            // 
            dgv_editsubj.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_editsubj.Location = new Point(64, 322);
            dgv_editsubj.Name = "dgv_editsubj";
            dgv_editsubj.RowHeadersWidth = 51;
            dgv_editsubj.Size = new Size(300, 228);
            dgv_editsubj.TabIndex = 0;
            dgv_editsubj.RowHeaderMouseDoubleClick += dgv_editsubj_RowHeaderMouseDoubleClick;
            // 
            // Done
            // 
            Done.BackColor = SystemColors.ActiveBorder;
            Done.Cursor = Cursors.Hand;
            Done.Font = new Font("Microsoft New Tai Lue", 14F);
            Done.Location = new Point(155, 573);
            Done.Name = "Done";
            Done.Size = new Size(117, 47);
            Done.TabIndex = 12;
            Done.Text = "Add";
            Done.UseVisualStyleBackColor = false;
            Done.Click += Done_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button4.Location = new Point(498, 12);
            button4.Name = "button4";
            button4.Size = new Size(72, 57);
            button4.TabIndex = 13;
            button4.Text = ">";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // subjEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(582, 703);
            Controls.Add(button4);
            Controls.Add(Done);
            Controls.Add(dgv_editsubj);
            Name = "subjEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "subjEdit";
            Load += subjEdit_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_editsubj).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_editsubj;
        private Button Done;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button button4;
    }
}