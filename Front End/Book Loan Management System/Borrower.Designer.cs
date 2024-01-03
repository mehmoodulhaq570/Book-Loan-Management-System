namespace Book_Loan_Management_System
{
    partial class Borrower
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
            this.borrowergridview = new System.Windows.Forms.DataGridView();
            this.displayauthors_button = new System.Windows.Forms.Button();
            this.deleteborrower_button = new System.Windows.Forms.Button();
            this.addborrower_button = new System.Windows.Forms.Button();
            this.displayfine_button = new System.Windows.Forms.Button();
            this.addfine_button = new System.Windows.Forms.Button();
            this.borrowergridview2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.borrowergridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowergridview2)).BeginInit();
            this.SuspendLayout();
            // 
            // borrowergridview
            // 
            this.borrowergridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowergridview.Location = new System.Drawing.Point(247, 45);
            this.borrowergridview.Name = "borrowergridview";
            this.borrowergridview.Size = new System.Drawing.Size(492, 271);
            this.borrowergridview.TabIndex = 9;
            this.borrowergridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // displayauthors_button
            // 
            this.displayauthors_button.BackColor = System.Drawing.Color.LightPink;
            this.displayauthors_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayauthors_button.Location = new System.Drawing.Point(36, 45);
            this.displayauthors_button.Name = "displayauthors_button";
            this.displayauthors_button.Size = new System.Drawing.Size(172, 54);
            this.displayauthors_button.TabIndex = 7;
            this.displayauthors_button.Text = "Display Borrowers";
            this.displayauthors_button.UseVisualStyleBackColor = false;
            this.displayauthors_button.Click += new System.EventHandler(this.displayauthors_button_Click);
            // 
            // deleteborrower_button
            // 
            this.deleteborrower_button.BackColor = System.Drawing.Color.LightPink;
            this.deleteborrower_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteborrower_button.Location = new System.Drawing.Point(36, 204);
            this.deleteborrower_button.Name = "deleteborrower_button";
            this.deleteborrower_button.Size = new System.Drawing.Size(172, 49);
            this.deleteborrower_button.TabIndex = 6;
            this.deleteborrower_button.Text = "Delete Borrower";
            this.deleteborrower_button.UseVisualStyleBackColor = false;
            this.deleteborrower_button.Click += new System.EventHandler(this.deleteborrower_button_Click);
            // 
            // addborrower_button
            // 
            this.addborrower_button.BackColor = System.Drawing.Color.LightPink;
            this.addborrower_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addborrower_button.Location = new System.Drawing.Point(36, 125);
            this.addborrower_button.Name = "addborrower_button";
            this.addborrower_button.Size = new System.Drawing.Size(172, 53);
            this.addborrower_button.TabIndex = 5;
            this.addborrower_button.Text = "Add Borrower";
            this.addborrower_button.UseVisualStyleBackColor = false;
            this.addborrower_button.Click += new System.EventHandler(this.addborrower_button_Click);
            // 
            // displayfine_button
            // 
            this.displayfine_button.BackColor = System.Drawing.Color.LightPink;
            this.displayfine_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayfine_button.Location = new System.Drawing.Point(36, 349);
            this.displayfine_button.Name = "displayfine_button";
            this.displayfine_button.Size = new System.Drawing.Size(172, 49);
            this.displayfine_button.TabIndex = 10;
            this.displayfine_button.Text = "Display Fine";
            this.displayfine_button.UseVisualStyleBackColor = false;
            this.displayfine_button.Click += new System.EventHandler(this.fine_button_Click);
            // 
            // addfine_button
            // 
            this.addfine_button.BackColor = System.Drawing.Color.LightPink;
            this.addfine_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addfine_button.Location = new System.Drawing.Point(36, 278);
            this.addfine_button.Name = "addfine_button";
            this.addfine_button.Size = new System.Drawing.Size(172, 49);
            this.addfine_button.TabIndex = 11;
            this.addfine_button.Text = "Add Fine";
            this.addfine_button.UseVisualStyleBackColor = false;
            this.addfine_button.Click += new System.EventHandler(this.addfine_button_Click);
            // 
            // borrowergridview2
            // 
            this.borrowergridview2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowergridview2.Location = new System.Drawing.Point(247, 338);
            this.borrowergridview2.Name = "borrowergridview2";
            this.borrowergridview2.Size = new System.Drawing.Size(240, 76);
            this.borrowergridview2.TabIndex = 12;
            // 
            // Borrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.borrowergridview2);
            this.Controls.Add(this.addfine_button);
            this.Controls.Add(this.displayfine_button);
            this.Controls.Add(this.borrowergridview);
            this.Controls.Add(this.displayauthors_button);
            this.Controls.Add(this.deleteborrower_button);
            this.Controls.Add(this.addborrower_button);
            this.Name = "Borrower";
            this.Text = "Borrower";
            this.Load += new System.EventHandler(this.Borrower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.borrowergridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowergridview2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView borrowergridview;
        private System.Windows.Forms.Button displayauthors_button;
        private System.Windows.Forms.Button deleteborrower_button;
        private System.Windows.Forms.Button addborrower_button;
        private System.Windows.Forms.Button displayfine_button;
        private System.Windows.Forms.Button addfine_button;
        private System.Windows.Forms.DataGridView borrowergridview2;
    }
}