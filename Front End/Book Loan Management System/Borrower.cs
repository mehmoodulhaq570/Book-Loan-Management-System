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
    public partial class Borrower : Form
    {
        public Borrower()
        {
            InitializeComponent();
        }

        private void Borrower_Load(object sender, EventArgs e)
        {

        }

        private void addborrower_button_Click(object sender, EventArgs e)
        {
            Add_Borrower add_Borrower = new Add_Borrower();
            add_Borrower.Show();
        }

        private void deleteborrower_button_Click(object sender, EventArgs e)
        {
            Delete_Borrower delborrower = new Delete_Borrower();
            delborrower.Show();
        }

        private void displayauthors_button_Click(object sender, EventArgs e)
        {
            string currentTable = "Borrower";


            borrowergridview.DataSource = null;
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
                borrowergridview2.Text = "Retrieving Records..."; command.Connection = conn;
                command.CommandText = "select * from " + currentTable;
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable(); da.Fill(dt);

                borrowergridview.DataSource = dt;
                borrowergridview2.Text = "Retrieval Successful!"; conn.Close();
            }
            catch (Exception ex)
            {
                borrowergridview2.Text = "Error, " + ex;
            }
        }

        private void fine_button_Click(object sender, EventArgs e)
        {
            
        }

        private void addfine_button_Click(object sender, EventArgs e)
        {
            Fine_Borrower fineborrower = new Fine_Borrower();
            fineborrower.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
