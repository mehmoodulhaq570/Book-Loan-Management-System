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
    public partial class Add_Authos : Form
    {
        public Add_Authos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateofbirth_label_Click(object sender, EventArgs e)
        {

        }

        public void addauthor_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection connection = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Book Loan System;Integrated Security=True");
                connection.Open();

                command.Connection = connection;
                command.CommandText = "INSERT INTO Author (author_id, first_name, last_name, email_id, contact_no, address, date_of_birth, nationality) VALUES('" + authorid_textbox.Text + "','" + firstname_textbox.Text +"','" + lastname_textbox.Text+ "','" + emailid_textbox.Text + "','" + contactno_textbox.Text + "','" + address_textbox.Text + "','" + dateofbirth_textbox.Text + "','" + nationality_textbox.Text + "')";
                command.ExecuteNonQuery();

                connection.Close();

                // Assuming Author_Form is the form where you want to display authors, you can refresh the data
                Author_Form aform = new Author_Form();
                aform.displayauthors_button_Click(sender, e);
                MessageBox.Show("Author added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle the exception (you might want to log it or display an error message)
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void Add_Authos_Load(object sender, EventArgs e)


        {

        }
    }
}
