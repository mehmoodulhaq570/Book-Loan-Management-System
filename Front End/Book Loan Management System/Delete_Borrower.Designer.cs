namespace Book_Loan_Management_System
{
    partial class Delete_Borrower
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
            this.deleteborrower_button = new System.Windows.Forms.Button();
            this.borrowerid_textbox = new System.Windows.Forms.TextBox();
            this.borrowerid_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteborrower_button
            // 
            this.deleteborrower_button.BackColor = System.Drawing.Color.LightPink;
            this.deleteborrower_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteborrower_button.Location = new System.Drawing.Point(210, 168);
            this.deleteborrower_button.Name = "deleteborrower_button";
            this.deleteborrower_button.Size = new System.Drawing.Size(172, 49);
            this.deleteborrower_button.TabIndex = 28;
            this.deleteborrower_button.Text = "Delete Borrower";
            this.deleteborrower_button.UseVisualStyleBackColor = false;
            this.deleteborrower_button.Click += new System.EventHandler(this.deleteborrower_button_Click);
            // 
            // borrowerid_textbox
            // 
            this.borrowerid_textbox.Location = new System.Drawing.Point(361, 106);
            this.borrowerid_textbox.Name = "borrowerid_textbox";
            this.borrowerid_textbox.Size = new System.Drawing.Size(100, 20);
            this.borrowerid_textbox.TabIndex = 30;
            // 
            // borrowerid_label
            // 
            this.borrowerid_label.AutoSize = true;
            this.borrowerid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerid_label.Location = new System.Drawing.Point(155, 107);
            this.borrowerid_label.Name = "borrowerid_label";
            this.borrowerid_label.Size = new System.Drawing.Size(94, 20);
            this.borrowerid_label.TabIndex = 29;
            this.borrowerid_label.Text = "Borrower_id";
            // 
            // Delete_Borrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(687, 404);
            this.Controls.Add(this.borrowerid_textbox);
            this.Controls.Add(this.borrowerid_label);
            this.Controls.Add(this.deleteborrower_button);
            this.Name = "Delete_Borrower";
            this.Text = "Delete_Borrower";
            this.Load += new System.EventHandler(this.Delete_Borrower_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deleteborrower_button;
        private System.Windows.Forms.TextBox borrowerid_textbox;
        private System.Windows.Forms.Label borrowerid_label;
    }
}