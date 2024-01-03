namespace Book_Loan_Management_System
{
    partial class ownerform
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
            this.author_button = new System.Windows.Forms.Button();
            this.book_button = new System.Windows.Forms.Button();
            this.borrower_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Loan Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // author_button
            // 
            this.author_button.BackColor = System.Drawing.Color.Pink;
            this.author_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_button.ForeColor = System.Drawing.Color.Black;
            this.author_button.Location = new System.Drawing.Point(265, 136);
            this.author_button.Name = "author_button";
            this.author_button.Size = new System.Drawing.Size(142, 41);
            this.author_button.TabIndex = 1;
            this.author_button.Text = "Author";
            this.author_button.UseVisualStyleBackColor = false;
            this.author_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // book_button
            // 
            this.book_button.BackColor = System.Drawing.Color.Pink;
            this.book_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_button.Location = new System.Drawing.Point(265, 209);
            this.book_button.Name = "book_button";
            this.book_button.Size = new System.Drawing.Size(142, 42);
            this.book_button.TabIndex = 2;
            this.book_button.Text = "Book";
            this.book_button.UseVisualStyleBackColor = false;
            this.book_button.Click += new System.EventHandler(this.book_button_Click);
            // 
            // borrower_button
            // 
            this.borrower_button.BackColor = System.Drawing.Color.Pink;
            this.borrower_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrower_button.Location = new System.Drawing.Point(265, 280);
            this.borrower_button.Name = "borrower_button";
            this.borrower_button.Size = new System.Drawing.Size(142, 42);
            this.borrower_button.TabIndex = 3;
            this.borrower_button.Text = "Borrower";
            this.borrower_button.UseVisualStyleBackColor = false;
            this.borrower_button.Click += new System.EventHandler(this.borrower_button_Click);
            // 
            // ownerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(742, 413);
            this.Controls.Add(this.borrower_button);
            this.Controls.Add(this.book_button);
            this.Controls.Add(this.author_button);
            this.Controls.Add(this.label1);
            this.Name = "ownerform";
            this.Text = "Book Loan Management System";
            this.Load += new System.EventHandler(this.ownerform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button author_button;
        private System.Windows.Forms.Button book_button;
        private System.Windows.Forms.Button borrower_button;
    }
}