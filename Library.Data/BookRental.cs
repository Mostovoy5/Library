using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data
{
    public class BookRental : Base
    {
        static public List<BookRental> Rentals = new List<BookRental>();

        public DateTime DateOfCapture { get; set; }
        public DateTime DateReturn { get; set; }
        public int RentalPrice { get; set; }

        public override string ToString()
        {
            return Name + " " + DateOfCapture + " " + DateReturn + " " + RentalPrice;
        }
    }
}
