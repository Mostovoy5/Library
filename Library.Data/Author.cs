using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data
{
    public class Author: Base
    {
        static public List<Author> Authors = new List<Author>();

        public ICollection<Book> BooksWritten { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string Pseudonym { get; set; }

        public Author()
        {
            BooksWritten = new List<Book>();
        }

        public override string ToString()
        {
            return Name + " " + Surname + " " + MiddleName + " " + Pseudonym;
        }

        public List<Book> Books
        {
            get { return BooksAuthor.BooksAuthors.Where(ba => ba.Author == this).Select(ba => ba.Book).ToList(); }

        }
    }
}
