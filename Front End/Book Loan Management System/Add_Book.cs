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
    public partial class Add_Book : Form
    {
        public Add_Book()
        {
            InitializeComponent();
        }

        private void lastname_label_Click(object sender, EventArgs e)
        {

        }

        private void firstname_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Book_Load(object sender, EventArgs e)
        {

        }

        private void addborrower_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection connection = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Book Loan System;Integrated Security=True");
                connection.Open();

                command.Connection = connection;
                command.CommandText = "INSERT INTO Book (book_id, book_title, book_edition, year_of_publication, price, ISBN_no, total_pages, genre, language, description) VALUES ('" + bookid_textbox.Text + "','" + booktitle_textbox.Text + "','" + bookedition_textbox.Text + "','" + yearofpublication_textbox.Text + "','" + price_textbox.Text + "','" + isbnno_textbox.Text + "','" + totalpages_textbox.Text + "','" + genre_textbox.Text + "','" + language_textbox.Text + "','" + description_textbox.Text + "')";
                command.ExecuteNonQuery();

                connection.Close();

                // Assuming Author_Form is the form where you want to display authors, you can refresh the data
                Author_Form aform = new Author_Form();
                aform.displayauthors_button_Click(sender, e);
                MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle the exception (you might want to log it or display an error message)
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
