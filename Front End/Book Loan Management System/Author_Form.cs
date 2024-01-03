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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Book_Loan_Management_System
{
    public partial class Author_Form : Form
    {

        public Author_Form()
        {
            InitializeComponent();
        }

        private void Author_Form_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Author_Form_Load() called...");
            authorgridview2.Text = "Startup...";
            try
            {
                System.Diagnostics.Debug.WriteLine("within the try");
                SqlConnection connection = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Book Loan System;Integrated Security=True");
                connection.Open();
                authorgridview2.Text = "Connected Successful";
                connection.Close();
            }
            catch (Exception ex)
            {
                authorgridview2.Text = "Error, " + ex;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addauthor_button_Click(object sender, EventArgs e)
        {
            Add_Authos adauthors = new Add_Authos();
            adauthors.Show();
        }

        private void deleteauthor_button_Click(object sender, EventArgs e)
        {
            Delete_Authors dauthors = new Delete_Authors();
            dauthors.Show();
        }

        public void displayauthors_button_Click(object sender, EventArgs e)
        {
            string currentTable = "Author";


            authorgridview.DataSource = null;
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection connection = new SqlConnection(@"Data Source = (local)\SQLEXPRESS; Initial Catalog = Book Loan System; Integrated Security = True");
                var datasource = @"(local)\SQLEXPRESS";
                var database = "Book Loan System";
                var thisUsername = Login_Form.username;
                var thisPassword = Login_Form.password;
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + "; Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword;
                SqlConnection conn = new SqlConnection(connString); conn.Open();
                authorgridview2.Text = "Retrieving Records..."; command.Connection = conn;
                command.CommandText = "select * from " + currentTable;
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable(); da.Fill(dt);

                authorgridview.DataSource = dt;
                authorgridview2.Text = "Retrieval Successful!"; conn.Close();
            }
            catch (Exception ex)
            {
                authorgridview2.Text = "Error, " + ex;
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void authorslist_button_Click(object sender, EventArgs e)
        {

        }

        private void countrecords_Click(object sender, EventArgs e)
        {


        }

        private void authorslist_button_Click_1(object sender, EventArgs e)
        {
            string currentTable = "Author_list";


            authorgridview.DataSource = null;
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection connection = new SqlConnection(@"Data Source = (local)\SQLEXPRESS; Initial Catalog = Book Loan System; Integrated Security = True");
                var datasource = @"(local)\SQLEXPRESS";
                var database = "Book Loan System";
                var thisUsername = Login_Form.username;
                var thisPassword = Login_Form.password;
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + "; Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword;
                SqlConnection conn = new SqlConnection(connString); conn.Open();
                authorgridview2.Text = "Retrieving Records..."; command.Connection = conn;
                command.CommandText = "select * from " + currentTable;
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable(); da.Fill(dt);

                authorgridview.DataSource = dt;
                authorgridview2.Text = "Retrieval Successful!"; conn.Close();
            }
            catch (Exception ex)
            {
                authorgridview2.Text = "Error, " + ex;
            }

        }
    }
}
