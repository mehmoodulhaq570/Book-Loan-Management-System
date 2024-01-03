namespace Book_Loan_Management_System
{
    partial class Delete_Authors
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
            this.authorid_textbox = new System.Windows.Forms.TextBox();
            this.authorid_label = new System.Windows.Forms.Label();
            this.deleteauthor_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorid_textbox
            // 
            this.authorid_textbox.Location = new System.Drawing.Point(343, 109);
            this.authorid_textbox.Name = "authorid_textbox";
            this.authorid_textbox.Size = new System.Drawing.Size(109, 20);
            this.authorid_textbox.TabIndex = 24;
            // 
            // authorid_label
            // 
            this.authorid_label.AutoSize = true;
            this.authorid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorid_label.Location = new System.Drawing.Point(165, 109);
            this.authorid_label.Name = "authorid_label";
            this.authorid_label.Size = new System.Drawing.Size(78, 20);
            this.authorid_label.TabIndex = 16;
            this.authorid_label.Text = "Author_id";
            // 
            // deleteauthor_button
            // 
            this.deleteauthor_button.BackColor = System.Drawing.Color.LightPink;
            this.deleteauthor_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteauthor_button.Location = new System.Drawing.Point(214, 193);
            this.deleteauthor_button.Name = "deleteauthor_button";
            this.deleteauthor_button.Size = new System.Drawing.Size(150, 43);
            this.deleteauthor_button.TabIndex = 25;
            this.deleteauthor_button.Text = "Delete Author";
            this.deleteauthor_button.UseVisualStyleBackColor = false;
            this.deleteauthor_button.Click += new System.EventHandler(this.deleteauthor_button_Click);
            // 
            // Delete_Authors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(655, 397);
            this.Controls.Add(this.deleteauthor_button);
            this.Controls.Add(this.authorid_textbox);
            this.Controls.Add(this.authorid_label);
            this.Name = "Delete_Authors";
            this.Text = "Delete_Authors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox authorid_textbox;
        private System.Windows.Forms.Label authorid_label;
        private System.Windows.Forms.Button deleteauthor_button;
    }
}