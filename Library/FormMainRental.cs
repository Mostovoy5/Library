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
    public partial class FormMainRental : Form
    {
        public FormMainRental()
        {
            InitializeComponent();
            LBBookRentalRefresh();
        }

        private void btnAddRental_Click(object sender, EventArgs e)
        {
            new FormAddRental().ShowDialog();
            LBBookRentalRefresh();
        }

        private void LBBookRentalRefresh()
        {
            lbRental.DataSource = null;
            lbRental.DataSource = BookRental.Rentals;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void btnDelRental_Click(object sender, EventArgs e)
        {
            BookRental.Rentals.Remove((BookRental)lbRental.SelectedItem);
            LBBookRentalRefresh();
        }
    }
}
