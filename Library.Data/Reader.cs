using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data
{
    public class Reader : Base
    {
        static public List<Reader> Readers = new List<Reader>();
        private Guid _readerId;

        public Book Books
        {
            get { return Book.Books.Where(b => b.Id == _readerId).SingleOrDefault(); }
            set { _readerId = value.Id; }
        }

        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public int HallNumber { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname + " " + MiddleName + " " + HallNumber;
        }
    }
}
