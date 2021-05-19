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
    public partial class FormAddBooks : Form
    {
        public FormAddBooks()
        {
            InitializeComponent();
        }



        private void btmAddBooks_Click(object sender, EventArgs e)
        {
            Book.Books.Add(new Book
            {
                Name = textName.Text,
                PageNumber = (int)numBookPages.Value,
                YearOfPublication = dtpBook.Value
            });
            this.Close();
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddAuthorsBooks_Click(object sender, EventArgs e)
        {

        }

        private void numBookPages_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpBook_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numBookPages_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void FormBooksAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
