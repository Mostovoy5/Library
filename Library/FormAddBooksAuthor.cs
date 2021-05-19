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
    public partial class FormAddBooksAuthor : Form
    {
        public FormAddBooksAuthor()
        {
            InitializeComponent();
            LBBooksRefresh();
            LBActhorRefresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BooksAuthor.BooksAuthors.Add(new BooksAuthor() 
            { 
                Author = (Author)clbAuthor.SelectedItem, 
                Book = (Book)lbBook.SelectedItem 
            });
            this.Close();
        }
        private void LBBooksRefresh()
        {
            lbBook.DataSource = null;
            lbBook.DataSource = Book.Books;
        }
        private void LBActhorRefresh()
        {
            clbAuthor.DataSource = null;
            clbAuthor.DataSource = Author.Authors;
        }
    }
}
