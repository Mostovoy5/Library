using Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data
{
    public class BooksAuthor
    {
        static public List<BooksAuthor> BooksAuthors = new List<BooksAuthor>();
        private Guid _bookId;

        public Author Author
        {
            get { return Author.Authors.Where(a => a.Id == _authorId).SingleOrDefault(); }
            set { _authorId = value.Id; }
        }

        private Guid _authorId;

        public Book Book
        {
            get { return Book.Books.Where(b => b.Id == _bookId).SingleOrDefault(); }
            set { _bookId = value.Id; }
        }

    }
}
