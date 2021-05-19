using Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data
{
    public class Book : Base
    {
        static public List<Book> Books = new List<Book>();
        public Reader Reader { get; set; }
        public List<Guid> AuthorsBookID = new List<Guid>();

        public DateTime YearOfPublication { get; set; }
        public int PageNumber { get; set; }
        public Guid ReaderId { get; set; }

        public override string ToString()
        {
            return Name + " " + YearOfPublication + " " + PageNumber;
        }

        public List<Reader> Readers
        {
            get { return Reader.Readers.Where(r => r.Books == this).ToList(); }
        }

        public List<Author> Authors
        {
            get { return BooksAuthor.BooksAuthors.Where(ba => ba.Book == this).Select(ba => ba.Author).ToList(); }

        }
    }
}
