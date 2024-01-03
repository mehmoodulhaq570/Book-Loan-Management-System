using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Loan_Management_System
{
    public partial class ownerform : Form
    {
        public ownerform()
        {
            InitializeComponent();
        }

        private void ownerform_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Author_Form aform = new Author_Form();
            aform.ShowDialog();
        }

        private void book_button_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            book.ShowDialog();
        }

        private void borrower_button_Click(object sender, EventArgs e)
        {
            Borrower brw = new Borrower();  
            brw.ShowDialog();
        }
    }
}
