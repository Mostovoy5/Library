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
    public partial class FormAddRental : Form
    {
        public FormAddRental()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnReader_Click(object sender, EventArgs e)
        {
            BookRental.Rentals.Add(new BookRental
            {
                Name = textName.Text,
                DateOfCapture = dtpDateOfCapture.Value,
                DateReturn = dtpDateReturn.Value,
                RentalPrice = (int)nudRentalPrice.Value
            });
            this.Close();
        }
    }
}
