using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Loan_Management_System
{
    public partial class Book_Loan : Form
    {
        public Book_Loan()
        {
            InitializeComponent();
        }

        private void issuebook_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection connection = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Book Loan System;Integrated Security=True");
                connection.Open();

                command.Connection = connection;
                command.CommandText = "INSERT INTO Book_Loan (copy_id, borrower_id, loan_date, loan_days, return_date) VALUES('" + copyid_textbox.Text + "','" + borrowerid_textbox.Text + "','" + loandate_textbox.Text + "','" + loandays_textbox.Text + "','" + returndate_textbox.Text + "')";
                command.ExecuteNonQuery();

                connection.Close();

                // Assuming Author_Form is the form where you want to display authors, you can refresh the data
                Author_Form aform = new Author_Form();
                aform.displayauthors_button_Click(sender, e);
                MessageBox.Show("Book is issued successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle the exception (you might want to log it or display an error message)
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
