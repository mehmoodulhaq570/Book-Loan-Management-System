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
    public partial class Delete_Authors : Form
    {
        public Delete_Authors()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteauthor_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection connection = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Book Loan System;Integrated Security=True");
                connection.Open();

                command.Connection = connection;
                command.CommandText = "delete from Author where author_id = '" + authorid_textbox.Text + "'";
                command.ExecuteNonQuery();

                connection.Close();

                // Assuming Author_Form is the form where you want to display authors, you can refresh the data
                Author_Form aform = new Author_Form();
                aform.displayauthors_button_Click(sender, e);
                MessageBox.Show("Author delete successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle the exception (you might want to log it or display an error message)
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
