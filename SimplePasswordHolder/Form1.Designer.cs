namespace SimplePasswordHolder
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WebsiteNameEntry = new System.Windows.Forms.TextBox();
            this.UsernameEntry = new System.Windows.Forms.TextBox();
            this.PasswordEntry = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 54);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(300, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the Website Name, your Username, and your Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 84);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2);
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Website Name: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 113);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2);
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 139);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(2);
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // WebsiteNameEntry
            // 
            this.WebsiteNameEntry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WebsiteNameEntry.Location = new System.Drawing.Point(231, 84);
            this.WebsiteNameEntry.Name = "WebsiteNameEntry";
            this.WebsiteNameEntry.Size = new System.Drawing.Size(292, 20);
            this.WebsiteNameEntry.TabIndex = 5;
            this.WebsiteNameEntry.TextChanged += new System.EventHandler(this.WebsiteNameEntry_TextChanged);
            // 
            // UsernameEntry
            // 
            this.UsernameEntry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UsernameEntry.Location = new System.Drawing.Point(231, 111);
            this.UsernameEntry.Name = "UsernameEntry";
            this.UsernameEntry.Size = new System.Drawing.Size(292, 20);
            this.UsernameEntry.TabIndex = 6;
            this.UsernameEntry.TextChanged += new System.EventHandler(this.UsernameEntry_TextChanged);
            // 
            // PasswordEntry
            // 
            this.PasswordEntry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordEntry.Location = new System.Drawing.Point(231, 138);
            this.PasswordEntry.Name = "PasswordEntry";
            this.PasswordEntry.Size = new System.Drawing.Size(292, 20);
            this.PasswordEntry.TabIndex = 7;
            this.PasswordEntry.TextChanged += new System.EventHandler(this.PasswordEntry_TextChanged);
            // 
            // Submit
            // 
            this.Submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Submit.Location = new System.Drawing.Point(325, 180);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(84, 34);
            this.Submit.TabIndex = 8;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(733, 439);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.PasswordEntry);
            this.Controls.Add(this.UsernameEntry);
            this.Controls.Add(this.WebsiteNameEntry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form1";
            this.Text = "Simple Password Holder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WebsiteNameEntry;
        private System.Windows.Forms.TextBox UsernameEntry;
        private System.Windows.Forms.TextBox PasswordEntry;
        private System.Windows.Forms.Button Submit;
    }
}

