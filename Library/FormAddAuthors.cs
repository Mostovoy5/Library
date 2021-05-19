using Library.Data;
using System;
using System.Windows.Forms;

namespace Library
{
    public partial class FormAddAuthors : Form
    {
        public FormAddAuthors()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Author.Authors.Add( new Author
            {
                Name = textName.Text,
                Surname = textSurname.Text,
                MiddleName = textMiddleName.Text,
                Pseudonym = textPseudonym.Text
            });
            this.Close();
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
