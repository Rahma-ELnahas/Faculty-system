namespace Proj
{
    partial class edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_name = new TextBox();
            txt_phone = new TextBox();
            txt_age = new TextBox();
            txt_pass = new TextBox();
            txt_mail = new TextBox();
            Done = new Button();
            label6 = new Label();
            button1 = new Button();
            txt_role = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 14F);
            label1.Location = new Point(64, 82);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 14F);
            label2.Location = new Point(64, 134);
            label2.Name = "label2";
            label2.Size = new Size(71, 32);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 14F);
            label3.Location = new Point(64, 186);
            label3.Name = "label3";
            label3.Size = new Size(112, 32);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft New Tai Lue", 14F);
            label4.Location = new Point(64, 238);
            label4.Name = "label4";
            label4.Size = new Size(56, 32);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft New Tai Lue", 14F);
            label5.Location = new Point(64, 290);
            label5.Name = "label5";
            label5.Size = new Size(82, 32);
            label5.TabIndex = 4;
            label5.Text = "Phone";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(171, 82);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(272, 30);
            txt_name.TabIndex = 5;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(171, 290);
            txt_phone.Multiline = true;
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(272, 30);
            txt_phone.TabIndex = 7;
            // 
            // txt_age
            // 
            txt_age.Location = new Point(171, 238);
            txt_age.Multiline = true;
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(272, 30);
            txt_age.TabIndex = 8;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(203, 186);
            txt_pass.Multiline = true;
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(240, 30);
            txt_pass.TabIndex = 9;
            // 
            // txt_mail
            // 
            txt_mail.Location = new Point(171, 134);
            txt_mail.Multiline = true;
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(272, 30);
            txt_mail.TabIndex = 10;
            // 
            // Done
            // 
            Done.BackColor = SystemColors.ActiveBorder;
            Done.Cursor = Cursors.Hand;
            Done.Font = new Font("Microsoft New Tai Lue", 14F);
            Done.Location = new Point(64, 412);
            Done.Name = "Done";
            Done.Size = new Size(117, 47);
            Done.TabIndex = 11;
            Done.Text = "Done";
            Done.UseVisualStyleBackColor = false;
            Done.Click += Done_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft New Tai Lue", 14F);
            label6.Location = new Point(64, 342);
            label6.Name = "label6";
            label6.Size = new Size(61, 32);
            label6.TabIndex = 12;
            label6.Text = "Role";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            button1.Location = new Point(502, 12);
            button1.Name = "button1";
            button1.Size = new Size(68, 52);
            button1.TabIndex = 14;
            button1.Text = ">";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txt_role
            // 
            txt_role.Location = new Point(171, 342);
            txt_role.Multiline = true;
            txt_role.Name = "txt_role";
            txt_role.Size = new Size(272, 30);
            txt_role.TabIndex = 15;
            // 
            // edit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(582, 703);
            Controls.Add(txt_role);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(Done);
            Controls.Add(txt_mail);
            Controls.Add(txt_pass);
            Controls.Add(txt_age);
            Controls.Add(txt_phone);
            Controls.Add(txt_name);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "edit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "edit";
            Load += edit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_name;
        private TextBox txt_phone;
        private TextBox txt_age;
        private TextBox txt_pass;
        private TextBox txt_mail;
        private Button Done;
        private Label label6;
        private Button button1;
        private TextBox txt_role;
    }
}