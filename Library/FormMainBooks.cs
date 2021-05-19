using Library.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class FormMainBooks : Form
    {
        public FormMainBooks()
        {
            InitializeComponent();
            LBBooksRefresh();
            LBAuthorsRefresh();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            LBAuthorsRefresh();

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            new FormAddBooks().ShowDialog();
            LBBooksRefresh();
            LBAuthorsRefresh();
        }

        private void btnDelBook_Click(object sender, EventArgs e)
        {
            Book.Books.Remove((Book)lbBooks.SelectedItem);
            LBBooksRefresh();
            LBAuthorsRefresh();
        }
        private void LBBooksRefresh()
        {
            lbBooks.DataSource = null;
            lbBooks.DataSource = Book.Books;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangeBook_Click(object sender, EventArgs e)
        {

        }

        private void FormMainBooks_Load(object sender, EventArgs e)
        {

        }

        private void btnAddReader_Click_1(object sender, EventArgs e)
        {

        }

        private void lbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void LBAuthorsRefresh()
        {
            lbAuthors.DataSource = null;
            if(lbBooks.SelectedItem != null)
                lbAuthors.DataSource = ((Book)lbBooks.SelectedItem).Authors;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormAddBooksAuthor().ShowDialog();
            LBBooksRefresh();
            LBAuthorsRefresh();
        }
    }
}
