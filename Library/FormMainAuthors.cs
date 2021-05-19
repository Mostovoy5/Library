using Library.Data;
using System;
using System.Windows.Forms;

namespace Library
{
    public partial class FormMainAuthors : Form
    {
        public FormMainAuthors()
        {
            InitializeComponent();
            LBActhorRefresh();
            LBBooksRefresh();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            new FormAddAuthors().ShowDialog();
            LBActhorRefresh();
            LBBooksRefresh();
        }

        private void LBActhorRefresh()
        {
            lbAuthor.DataSource = null;
            lbAuthor.DataSource = Author.Authors;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelAuthor_Click(object sender, EventArgs e)
        {
            Author.Authors.Remove((Author)lbAuthor.SelectedItem);
            LBActhorRefresh();
            LBBooksRefresh();
        }

        private void LBBooksRefresh()
        {
            lbBooks.DataSource = null;
            if(lbAuthor.SelectedItem != null)
                lbBooks.DataSource = ((Author)lbAuthor.SelectedItem).Books;
        }

        private void lbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LBBooksRefresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormAddBooksAuthor().ShowDialog();
            LBBooksRefresh();
            LBActhorRefresh();
        }
    }
}
