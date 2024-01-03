namespace Book_Loan_Management_System
{
    partial class Fine_Borrower
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
            this.borrowerid_textbox = new System.Windows.Forms.TextBox();
            this.borrowerid_label = new System.Windows.Forms.Label();
            this.fineamount_textbox = new System.Windows.Forms.TextBox();
            this.fine_amount = new System.Windows.Forms.Label();
            this.finedate_textbox = new System.Windows.Forms.TextBox();
            this.finedate_label = new System.Windows.Forms.Label();
            this.fineborrower_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // borrowerid_textbox
            // 
            this.borrowerid_textbox.Location = new System.Drawing.Point(388, 74);
            this.borrowerid_textbox.Name = "borrowerid_textbox";
            this.borrowerid_textbox.Size = new System.Drawing.Size(100, 20);
            this.borrowerid_textbox.TabIndex = 32;
            // 
            // borrowerid_label
            // 
            this.borrowerid_label.AutoSize = true;
            this.borrowerid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerid_label.Location = new System.Drawing.Point(182, 75);
            this.borrowerid_label.Name = "borrowerid_label";
            this.borrowerid_label.Size = new System.Drawing.Size(94, 20);
            this.borrowerid_label.TabIndex = 31;
            this.borrowerid_label.Text = "Borrower_id";
            // 
            // fineamount_textbox
            // 
            this.fineamount_textbox.Location = new System.Drawing.Point(388, 139);
            this.fineamount_textbox.Name = "fineamount_textbox";
            this.fineamount_textbox.Size = new System.Drawing.Size(100, 20);
            this.fineamount_textbox.TabIndex = 34;
            // 
            // fine_amount
            // 
            this.fine_amount.AutoSize = true;
            this.fine_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fine_amount.Location = new System.Drawing.Point(182, 140);
            this.fine_amount.Name = "fine_amount";
            this.fine_amount.Size = new System.Drawing.Size(100, 20);
            this.fine_amount.TabIndex = 33;
            this.fine_amount.Text = "Fine Amount";
            // 
            // finedate_textbox
            // 
            this.finedate_textbox.Location = new System.Drawing.Point(388, 210);
            this.finedate_textbox.Name = "finedate_textbox";
            this.finedate_textbox.Size = new System.Drawing.Size(100, 20);
            this.finedate_textbox.TabIndex = 36;
            // 
            // finedate_label
            // 
            this.finedate_label.AutoSize = true;
            this.finedate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finedate_label.Location = new System.Drawing.Point(182, 210);
            this.finedate_label.Name = "finedate_label";
            this.finedate_label.Size = new System.Drawing.Size(84, 20);
            this.finedate_label.TabIndex = 35;
            this.finedate_label.Text = "Fine_Date";
            // 
            // fineborrower_button
            // 
            this.fineborrower_button.BackColor = System.Drawing.Color.LightPink;
            this.fineborrower_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fineborrower_button.Location = new System.Drawing.Point(251, 272);
            this.fineborrower_button.Name = "fineborrower_button";
            this.fineborrower_button.Size = new System.Drawing.Size(172, 49);
            this.fineborrower_button.TabIndex = 37;
            this.fineborrower_button.Text = "Fine Borrower";
            this.fineborrower_button.UseVisualStyleBackColor = false;
            this.fineborrower_button.Click += new System.EventHandler(this.fineborrower_button_Click);
            // 
            // Fine_Borrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.fineborrower_button);
            this.Controls.Add(this.finedate_textbox);
            this.Controls.Add(this.finedate_label);
            this.Controls.Add(this.fineamount_textbox);
            this.Controls.Add(this.fine_amount);
            this.Controls.Add(this.borrowerid_textbox);
            this.Controls.Add(this.borrowerid_label);
            this.Name = "Fine_Borrower";
            this.Text = "Fine_Borrower";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox borrowerid_textbox;
        private System.Windows.Forms.Label borrowerid_label;
        private System.Windows.Forms.TextBox fineamount_textbox;
        private System.Windows.Forms.Label fine_amount;
        private System.Windows.Forms.TextBox finedate_textbox;
        private System.Windows.Forms.Label finedate_label;
        private System.Windows.Forms.Button fineborrower_button;
    }
}