namespace Book_Loan_Management_System
{
    partial class Author_Form
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
            this.addauthor_button = new System.Windows.Forms.Button();
            this.deleteauthor_button = new System.Windows.Forms.Button();
            this.displayauthors_button = new System.Windows.Forms.Button();
            this.authorgridview = new System.Windows.Forms.DataGridView();
            this.authorgridview2 = new System.Windows.Forms.DataGridView();
            this.authorslist_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.authorgridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorgridview2)).BeginInit();
            this.SuspendLayout();
            // 
            // addauthor_button
            // 
            this.addauthor_button.BackColor = System.Drawing.Color.LightPink;
            this.addauthor_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addauthor_button.Location = new System.Drawing.Point(35, 211);
            this.addauthor_button.Name = "addauthor_button";
            this.addauthor_button.Size = new System.Drawing.Size(150, 43);
            this.addauthor_button.TabIndex = 0;
            this.addauthor_button.Text = "Add Author";
            this.addauthor_button.UseVisualStyleBackColor = false;
            this.addauthor_button.Click += new System.EventHandler(this.addauthor_button_Click);
            // 
            // deleteauthor_button
            // 
            this.deleteauthor_button.BackColor = System.Drawing.Color.LightPink;
            this.deleteauthor_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteauthor_button.Location = new System.Drawing.Point(35, 292);
            this.deleteauthor_button.Name = "deleteauthor_button";
            this.deleteauthor_button.Size = new System.Drawing.Size(150, 43);
            this.deleteauthor_button.TabIndex = 1;
            this.deleteauthor_button.Text = "Delete Author";
            this.deleteauthor_button.UseVisualStyleBackColor = false;
            this.deleteauthor_button.Click += new System.EventHandler(this.deleteauthor_button_Click);
            // 
            // displayauthors_button
            // 
            this.displayauthors_button.BackColor = System.Drawing.Color.LightPink;
            this.displayauthors_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayauthors_button.Location = new System.Drawing.Point(35, 55);
            this.displayauthors_button.Name = "displayauthors_button";
            this.displayauthors_button.Size = new System.Drawing.Size(150, 41);
            this.displayauthors_button.TabIndex = 2;
            this.displayauthors_button.Text = "Display Autors";
            this.displayauthors_button.UseVisualStyleBackColor = false;
            this.displayauthors_button.Click += new System.EventHandler(this.displayauthors_button_Click);
            // 
            // authorgridview
            // 
            this.authorgridview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.authorgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorgridview.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.authorgridview.Location = new System.Drawing.Point(206, 55);
            this.authorgridview.Name = "authorgridview";
            this.authorgridview.Size = new System.Drawing.Size(492, 271);
            this.authorgridview.TabIndex = 4;
            this.authorgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // authorgridview2
            // 
            this.authorgridview2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorgridview2.Location = new System.Drawing.Point(206, 348);
            this.authorgridview2.Name = "authorgridview2";
            this.authorgridview2.Size = new System.Drawing.Size(492, 80);
            this.authorgridview2.TabIndex = 5;
            // 
            // authorslist_button
            // 
            this.authorslist_button.BackColor = System.Drawing.Color.LightPink;
            this.authorslist_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorslist_button.Location = new System.Drawing.Point(35, 129);
            this.authorslist_button.Name = "authorslist_button";
            this.authorslist_button.Size = new System.Drawing.Size(150, 41);
            this.authorslist_button.TabIndex = 6;
            this.authorslist_button.Text = "Autors List";
            this.authorslist_button.UseVisualStyleBackColor = false;
            this.authorslist_button.Click += new System.EventHandler(this.authorslist_button_Click_1);
            // 
            // Author_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(723, 454);
            this.Controls.Add(this.authorslist_button);
            this.Controls.Add(this.authorgridview2);
            this.Controls.Add(this.authorgridview);
            this.Controls.Add(this.displayauthors_button);
            this.Controls.Add(this.deleteauthor_button);
            this.Controls.Add(this.addauthor_button);
            this.Name = "Author_Form";
            this.Text = "Author_Form";
            this.Load += new System.EventHandler(this.Author_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authorgridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorgridview2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addauthor_button;
        private System.Windows.Forms.Button deleteauthor_button;
        private System.Windows.Forms.Button displayauthors_button;
        private System.Windows.Forms.DataGridView authorgridview;
        private System.Windows.Forms.DataGridView authorgridview2;
        private System.Windows.Forms.Button authorslist_button;
    }
}