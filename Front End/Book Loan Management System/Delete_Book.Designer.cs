namespace Book_Loan_Management_System
{
    partial class Delete_Book
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
            this.deletebook_button = new System.Windows.Forms.Button();
            this.bookid_textbox = new System.Windows.Forms.TextBox();
            this.authorid_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deletebook_button
            // 
            this.deletebook_button.BackColor = System.Drawing.Color.LightPink;
            this.deletebook_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebook_button.Location = new System.Drawing.Point(282, 216);
            this.deletebook_button.Name = "deletebook_button";
            this.deletebook_button.Size = new System.Drawing.Size(150, 43);
            this.deletebook_button.TabIndex = 28;
            this.deletebook_button.Text = "Delete Book";
            this.deletebook_button.UseVisualStyleBackColor = false;
            this.deletebook_button.Click += new System.EventHandler(this.deletebook_button_Click);
            // 
            // bookid_textbox
            // 
            this.bookid_textbox.Location = new System.Drawing.Point(411, 132);
            this.bookid_textbox.Name = "bookid_textbox";
            this.bookid_textbox.Size = new System.Drawing.Size(109, 20);
            this.bookid_textbox.TabIndex = 27;
            // 
            // authorid_label
            // 
            this.authorid_label.AutoSize = true;
            this.authorid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorid_label.Location = new System.Drawing.Point(233, 132);
            this.authorid_label.Name = "authorid_label";
            this.authorid_label.Size = new System.Drawing.Size(67, 20);
            this.authorid_label.TabIndex = 26;
            this.authorid_label.Text = "Book_id";
            // 
            // Delete_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.deletebook_button);
            this.Controls.Add(this.bookid_textbox);
            this.Controls.Add(this.authorid_label);
            this.Name = "Delete_Book";
            this.Text = "Delete_Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deletebook_button;
        private System.Windows.Forms.TextBox bookid_textbox;
        private System.Windows.Forms.Label authorid_label;
    }
}