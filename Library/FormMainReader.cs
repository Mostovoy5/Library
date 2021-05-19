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
    public partial class FormMainReader : Form
    {
        public FormMainReader()
        {
            InitializeComponent();
            LBReaderRefresh();

        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            new FormReader().ShowDialog();
            LBReaderRefresh();
            LBBooksRefresh();


        }
        private void LBReaderRefresh()
        {
            lbReader.DataSource = null;
            lbReader.DataSource = Reader.Readers;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelReader_Click(object sender, EventArgs e)
        {
            Reader.Readers.Remove((Reader)lbReader.SelectedItem);
            LBReaderRefresh();
            LBBooksRefresh();

        }

        private void lbReader_SelectedIndexChanged(object sender, EventArgs e)
        {
            LBReaderRefresh();
            LBBooksRefresh();
        }

        private void LBBooksRefresh()
        {
       
        }
    }
}
