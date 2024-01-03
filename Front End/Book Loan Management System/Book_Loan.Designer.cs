namespace Book_Loan_Management_System
{
    partial class Book_Loan
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
            this.returndate_textbox = new System.Windows.Forms.TextBox();
            this.loandays_textbox = new System.Windows.Forms.TextBox();
            this.loandate_textbox = new System.Windows.Forms.TextBox();
            this.borrowerid_textbox = new System.Windows.Forms.TextBox();
            this.copyid_textbox = new System.Windows.Forms.TextBox();
            this.loandays_label = new System.Windows.Forms.Label();
            this.returndate_label = new System.Windows.Forms.Label();
            this.loandate_label = new System.Windows.Forms.Label();
            this.borrowerid_label = new System.Windows.Forms.Label();
            this.copyid_label = new System.Windows.Forms.Label();
            this.issuebook_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // returndate_textbox
            // 
            this.returndate_textbox.Location = new System.Drawing.Point(400, 232);
            this.returndate_textbox.Name = "returndate_textbox";
            this.returndate_textbox.Size = new System.Drawing.Size(100, 20);
            this.returndate_textbox.TabIndex = 54;
            // 
            // loandays_textbox
            // 
            this.loandays_textbox.Location = new System.Drawing.Point(400, 196);
            this.loandays_textbox.Name = "loandays_textbox";
            this.loandays_textbox.Size = new System.Drawing.Size(100, 20);
            this.loandays_textbox.TabIndex = 53;
            // 
            // loandate_textbox
            // 
            this.loandate_textbox.Location = new System.Drawing.Point(400, 157);
            this.loandate_textbox.Name = "loandate_textbox";
            this.loandate_textbox.Size = new System.Drawing.Size(100, 20);
            this.loandate_textbox.TabIndex = 52;
            // 
            // borrowerid_textbox
            // 
            this.borrowerid_textbox.Location = new System.Drawing.Point(400, 112);
            this.borrowerid_textbox.Name = "borrowerid_textbox";
            this.borrowerid_textbox.Size = new System.Drawing.Size(100, 20);
            this.borrowerid_textbox.TabIndex = 51;
            // 
            // copyid_textbox
            // 
            this.copyid_textbox.Location = new System.Drawing.Point(400, 71);
            this.copyid_textbox.Name = "copyid_textbox";
            this.copyid_textbox.Size = new System.Drawing.Size(100, 20);
            this.copyid_textbox.TabIndex = 50;
            // 
            // loandays_label
            // 
            this.loandays_label.AutoSize = true;
            this.loandays_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loandays_label.Location = new System.Drawing.Point(209, 193);
            this.loandays_label.Name = "loandays_label";
            this.loandays_label.Size = new System.Drawing.Size(87, 20);
            this.loandays_label.TabIndex = 49;
            this.loandays_label.Text = "Loan_days";
            // 
            // returndate_label
            // 
            this.returndate_label.AutoSize = true;
            this.returndate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returndate_label.Location = new System.Drawing.Point(209, 228);
            this.returndate_label.Name = "returndate_label";
            this.returndate_label.Size = new System.Drawing.Size(99, 20);
            this.returndate_label.TabIndex = 48;
            this.returndate_label.Text = "Return_date";
            // 
            // loandate_label
            // 
            this.loandate_label.AutoSize = true;
            this.loandate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loandate_label.Location = new System.Drawing.Point(209, 151);
            this.loandate_label.Name = "loandate_label";
            this.loandate_label.Size = new System.Drawing.Size(86, 20);
            this.loandate_label.TabIndex = 47;
            this.loandate_label.Text = "Loan_date";
            // 
            // borrowerid_label
            // 
            this.borrowerid_label.AutoSize = true;
            this.borrowerid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerid_label.Location = new System.Drawing.Point(209, 108);
            this.borrowerid_label.Name = "borrowerid_label";
            this.borrowerid_label.Size = new System.Drawing.Size(80, 20);
            this.borrowerid_label.TabIndex = 46;
            this.borrowerid_label.Text = "Borrow_id";
            // 
            // copyid_label
            // 
            this.copyid_label.AutoSize = true;
            this.copyid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyid_label.Location = new System.Drawing.Point(209, 68);
            this.copyid_label.Name = "copyid_label";
            this.copyid_label.Size = new System.Drawing.Size(66, 20);
            this.copyid_label.TabIndex = 45;
            this.copyid_label.Text = "Copy_id";
            // 
            // issuebook_button
            // 
            this.issuebook_button.BackColor = System.Drawing.Color.Pink;
            this.issuebook_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuebook_button.Location = new System.Drawing.Point(284, 308);
            this.issuebook_button.Name = "issuebook_button";
            this.issuebook_button.Size = new System.Drawing.Size(142, 42);
            this.issuebook_button.TabIndex = 55;
            this.issuebook_button.Text = "Issue Book";
            this.issuebook_button.UseVisualStyleBackColor = false;
            this.issuebook_button.Click += new System.EventHandler(this.issuebook_button_Click);
            // 
            // Book_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.issuebook_button);
            this.Controls.Add(this.returndate_textbox);
            this.Controls.Add(this.loandays_textbox);
            this.Controls.Add(this.loandate_textbox);
            this.Controls.Add(this.borrowerid_textbox);
            this.Controls.Add(this.copyid_textbox);
            this.Controls.Add(this.loandays_label);
            this.Controls.Add(this.returndate_label);
            this.Controls.Add(this.loandate_label);
            this.Controls.Add(this.borrowerid_label);
            this.Controls.Add(this.copyid_label);
            this.Name = "Book_Loan";
            this.Text = "Book_Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox returndate_textbox;
        private System.Windows.Forms.TextBox loandays_textbox;
        private System.Windows.Forms.TextBox loandate_textbox;
        private System.Windows.Forms.TextBox borrowerid_textbox;
        private System.Windows.Forms.TextBox copyid_textbox;
        private System.Windows.Forms.Label loandays_label;
        private System.Windows.Forms.Label returndate_label;
        private System.Windows.Forms.Label loandate_label;
        private System.Windows.Forms.Label borrowerid_label;
        private System.Windows.Forms.Label copyid_label;
        private System.Windows.Forms.Button issuebook_button;
    }
}