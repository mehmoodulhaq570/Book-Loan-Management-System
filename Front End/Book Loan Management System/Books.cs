using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Book_Loan_Management_System
{
    public partial class Books : Form
    {
        private string connectionString;

        public Books()
        {
            InitializeComponent();
            InitializeConnectionString();
        }

        private void InitializeConnectionString()
        {
            var datasource = @"(local)\SQLEXPRESS";
            var database = "Book Loan System";
            var thisUsername = Login_Form.username;
            var thisPassword = Login_Form.password;

            connectionString = $"Data Source={datasource};Initial Catalog={database};Persist Security Info=True;User ID={thisUsername};Password={thisPassword}";
        }

        private SqlConnection CreateConnection()
        {
            return new SqlConnection(connectionString);
        }

        private void ExecuteQuery(string currentTable, string errorMessage)
        {
            bookgridview.DataSource = null;

            try
            {
                using (SqlConnection conn = CreateConnection())
                {
                    conn.Open();
                    bookgridview2.Text = "Retrieving Records...";
                    SqlCommand command = new SqlCommand($"select * from {currentTable}", conn);
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    bookgridview.DataSource = dt;
                    bookgridview2.Text = "Retrieval Successful!";
                }
            }
            catch (Exception ex)
            {
                bookgridview2.Text = $"Error, {errorMessage}: {ex.Message}";
            }
        }

        private void addbook_button_Click(object sender, EventArgs e)
        {
            Add_Book add_Book = new Add_Book();
            add_Book.Show();
        }

        private void deletebook_button_Click(object sender, EventArgs e)
        {
            Delete_Book delete_Book = new Delete_Book();
            delete_Book.Show();
        }

        private void displaybooks_button_Click(object sender, EventArgs e)
        {
            ExecuteQuery("Book", "retrieving books");
        }

        private void bookloan_button_Click(object sender, EventArgs e)
        {
            Book_Loan bookloan = new Book_Loan();
            bookloan.Show();
        }

        private void displaycategory_button_Click(object sender, EventArgs e)
        {
            ExecuteQuery("Category", "retrieving categories");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExecuteQuery("Book_Loan", "retrieving book loans");
        }
    }
}
