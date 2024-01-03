namespace Book_Loan_Management_System
{
    partial class Add_Book
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
            this.addborrower_button = new System.Windows.Forms.Button();
            this.isbnno_textbox = new System.Windows.Forms.TextBox();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.yearofpublication_textbox = new System.Windows.Forms.TextBox();
            this.bookedition_textbox = new System.Windows.Forms.TextBox();
            this.booktitle_textbox = new System.Windows.Forms.TextBox();
            this.bookid_textbox = new System.Windows.Forms.TextBox();
            this.isbnno_label = new System.Windows.Forms.Label();
            this.yearofpublication_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.bookedition_label = new System.Windows.Forms.Label();
            this.booktitle_label = new System.Windows.Forms.Label();
            this.bookid_label = new System.Windows.Forms.Label();
            this.totalpages_textbox = new System.Windows.Forms.TextBox();
            this.totalpages_label = new System.Windows.Forms.Label();
            this.description_textbox = new System.Windows.Forms.TextBox();
            this.description_label = new System.Windows.Forms.Label();
            this.language_textbox = new System.Windows.Forms.TextBox();
            this.genre_textbox = new System.Windows.Forms.TextBox();
            this.language_label = new System.Windows.Forms.Label();
            this.genre_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addborrower_button
            // 
            this.addborrower_button.BackColor = System.Drawing.Color.LightPink;
            this.addborrower_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addborrower_button.Location = new System.Drawing.Point(297, 365);
            this.addborrower_button.Name = "addborrower_button";
            this.addborrower_button.Size = new System.Drawing.Size(172, 47);
            this.addborrower_button.TabIndex = 46;
            this.addborrower_button.Text = "Add Book";
            this.addborrower_button.UseVisualStyleBackColor = false;
            this.addborrower_button.Click += new System.EventHandler(this.addborrower_button_Click);
            // 
            // isbnno_textbox
            // 
            this.isbnno_textbox.Location = new System.Drawing.Point(249, 255);
            this.isbnno_textbox.Name = "isbnno_textbox";
            this.isbnno_textbox.Size = new System.Drawing.Size(100, 20);
            this.isbnno_textbox.TabIndex = 45;
            // 
            // price_textbox
            // 
            this.price_textbox.Location = new System.Drawing.Point(249, 215);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(100, 20);
            this.price_textbox.TabIndex = 44;
            // 
            // yearofpublication_textbox
            // 
            this.yearofpublication_textbox.Location = new System.Drawing.Point(249, 179);
            this.yearofpublication_textbox.Name = "yearofpublication_textbox";
            this.yearofpublication_textbox.Size = new System.Drawing.Size(100, 20);
            this.yearofpublication_textbox.TabIndex = 43;
            // 
            // bookedition_textbox
            // 
            this.bookedition_textbox.Location = new System.Drawing.Point(249, 140);
            this.bookedition_textbox.Name = "bookedition_textbox";
            this.bookedition_textbox.Size = new System.Drawing.Size(100, 20);
            this.bookedition_textbox.TabIndex = 42;
            // 
            // booktitle_textbox
            // 
            this.booktitle_textbox.Location = new System.Drawing.Point(249, 95);
            this.booktitle_textbox.Name = "booktitle_textbox";
            this.booktitle_textbox.Size = new System.Drawing.Size(100, 20);
            this.booktitle_textbox.TabIndex = 41;
            this.booktitle_textbox.TextChanged += new System.EventHandler(this.firstname_textbox_TextChanged);
            // 
            // bookid_textbox
            // 
            this.bookid_textbox.Location = new System.Drawing.Point(249, 54);
            this.bookid_textbox.Name = "bookid_textbox";
            this.bookid_textbox.Size = new System.Drawing.Size(100, 20);
            this.bookid_textbox.TabIndex = 40;
            // 
            // isbnno_label
            // 
            this.isbnno_label.AutoSize = true;
            this.isbnno_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnno_label.Location = new System.Drawing.Point(58, 251);
            this.isbnno_label.Name = "isbnno_label";
            this.isbnno_label.Size = new System.Drawing.Size(74, 20);
            this.isbnno_label.TabIndex = 39;
            this.isbnno_label.Text = "ISBN_no";
            // 
            // yearofpublication_label
            // 
            this.yearofpublication_label.AutoSize = true;
            this.yearofpublication_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearofpublication_label.Location = new System.Drawing.Point(58, 176);
            this.yearofpublication_label.Name = "yearofpublication_label";
            this.yearofpublication_label.Size = new System.Drawing.Size(151, 20);
            this.yearofpublication_label.TabIndex = 38;
            this.yearofpublication_label.Text = "Year_of_publication";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.Location = new System.Drawing.Point(58, 211);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(44, 20);
            this.price_label.TabIndex = 37;
            this.price_label.Text = "Price";
            // 
            // bookedition_label
            // 
            this.bookedition_label.AutoSize = true;
            this.bookedition_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookedition_label.Location = new System.Drawing.Point(58, 134);
            this.bookedition_label.Name = "bookedition_label";
            this.bookedition_label.Size = new System.Drawing.Size(102, 20);
            this.bookedition_label.TabIndex = 36;
            this.bookedition_label.Text = "Book_edition";
            this.bookedition_label.Click += new System.EventHandler(this.lastname_label_Click);
            // 
            // booktitle_label
            // 
            this.booktitle_label.AutoSize = true;
            this.booktitle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booktitle_label.Location = new System.Drawing.Point(58, 91);
            this.booktitle_label.Name = "booktitle_label";
            this.booktitle_label.Size = new System.Drawing.Size(80, 20);
            this.booktitle_label.TabIndex = 35;
            this.booktitle_label.Text = "Book_title";
            // 
            // bookid_label
            // 
            this.bookid_label.AutoSize = true;
            this.bookid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookid_label.Location = new System.Drawing.Point(58, 51);
            this.bookid_label.Name = "bookid_label";
            this.bookid_label.Size = new System.Drawing.Size(67, 20);
            this.bookid_label.TabIndex = 34;
            this.bookid_label.Text = "Book_id";
            // 
            // totalpages_textbox
            // 
            this.totalpages_textbox.Location = new System.Drawing.Point(249, 298);
            this.totalpages_textbox.Name = "totalpages_textbox";
            this.totalpages_textbox.Size = new System.Drawing.Size(100, 20);
            this.totalpages_textbox.TabIndex = 48;
            // 
            // totalpages_label
            // 
            this.totalpages_label.AutoSize = true;
            this.totalpages_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpages_label.Location = new System.Drawing.Point(58, 294);
            this.totalpages_label.Name = "totalpages_label";
            this.totalpages_label.Size = new System.Drawing.Size(97, 20);
            this.totalpages_label.TabIndex = 47;
            this.totalpages_label.Text = "Total_pages";
            // 
            // description_textbox
            // 
            this.description_textbox.Location = new System.Drawing.Point(553, 134);
            this.description_textbox.Multiline = true;
            this.description_textbox.Name = "description_textbox";
            this.description_textbox.Size = new System.Drawing.Size(100, 20);
            this.description_textbox.TabIndex = 54;
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.Location = new System.Drawing.Point(415, 137);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(89, 20);
            this.description_label.TabIndex = 53;
            this.description_label.Text = "Description";
            // 
            // language_textbox
            // 
            this.language_textbox.Location = new System.Drawing.Point(552, 91);
            this.language_textbox.Name = "language_textbox";
            this.language_textbox.Size = new System.Drawing.Size(100, 20);
            this.language_textbox.TabIndex = 52;
            // 
            // genre_textbox
            // 
            this.genre_textbox.Location = new System.Drawing.Point(553, 51);
            this.genre_textbox.Name = "genre_textbox";
            this.genre_textbox.Size = new System.Drawing.Size(100, 20);
            this.genre_textbox.TabIndex = 51;
            // 
            // language_label
            // 
            this.language_label.AutoSize = true;
            this.language_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.language_label.Location = new System.Drawing.Point(415, 94);
            this.language_label.Name = "language_label";
            this.language_label.Size = new System.Drawing.Size(81, 20);
            this.language_label.TabIndex = 50;
            this.language_label.Text = "Language";
            // 
            // genre_label
            // 
            this.genre_label.AutoSize = true;
            this.genre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre_label.Location = new System.Drawing.Point(415, 54);
            this.genre_label.Name = "genre_label";
            this.genre_label.Size = new System.Drawing.Size(54, 20);
            this.genre_label.TabIndex = 49;
            this.genre_label.Text = "Genre";
            // 
            // Add_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.description_textbox);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.language_textbox);
            this.Controls.Add(this.genre_textbox);
            this.Controls.Add(this.language_label);
            this.Controls.Add(this.genre_label);
            this.Controls.Add(this.totalpages_textbox);
            this.Controls.Add(this.totalpages_label);
            this.Controls.Add(this.addborrower_button);
            this.Controls.Add(this.isbnno_textbox);
            this.Controls.Add(this.price_textbox);
            this.Controls.Add(this.yearofpublication_textbox);
            this.Controls.Add(this.bookedition_textbox);
            this.Controls.Add(this.booktitle_textbox);
            this.Controls.Add(this.bookid_textbox);
            this.Controls.Add(this.isbnno_label);
            this.Controls.Add(this.yearofpublication_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.bookedition_label);
            this.Controls.Add(this.booktitle_label);
            this.Controls.Add(this.bookid_label);
            this.Name = "Add_Book";
            this.Text = "Add_Book";
            this.Load += new System.EventHandler(this.Add_Book_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addborrower_button;
        private System.Windows.Forms.TextBox isbnno_textbox;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.TextBox yearofpublication_textbox;
        private System.Windows.Forms.TextBox bookedition_textbox;
        private System.Windows.Forms.TextBox booktitle_textbox;
        private System.Windows.Forms.TextBox bookid_textbox;
        private System.Windows.Forms.Label isbnno_label;
        private System.Windows.Forms.Label yearofpublication_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label bookedition_label;
        private System.Windows.Forms.Label booktitle_label;
        private System.Windows.Forms.Label bookid_label;
        private System.Windows.Forms.TextBox totalpages_textbox;
        private System.Windows.Forms.Label totalpages_label;
        private System.Windows.Forms.TextBox description_textbox;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.TextBox language_textbox;
        private System.Windows.Forms.TextBox genre_textbox;
        private System.Windows.Forms.Label language_label;
        private System.Windows.Forms.Label genre_label;
    }
}