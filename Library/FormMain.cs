using Library.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Library
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
           var b1 = new Book
            {
                Name = "Book Water",
                PageNumber = 863,
                YearOfPublication = new DateTime(2015, 7, 20)
            };
            Book.Books.Add(b1);

            var b2 = new Book
            {
                Name = "Good Me",
                PageNumber = 356,
                YearOfPublication = new DateTime(2014, 5, 13)
            };
            Book.Books.Add(b2);

            var b3 = new Book
            {
                Name = "Fire",
                PageNumber = 356,
                YearOfPublication = new DateTime(2014, 5, 13)
            };
            Book.Books.Add(b3);

            var b4 = new Book
            {
                Name = "Understand me",
                PageNumber = 356,
                YearOfPublication = new DateTime(2014, 5, 13)
            };
            Book.Books.Add(b4);

            var b5 = new Book
            {
                Name = "GO Go go",
                PageNumber = 356,
                YearOfPublication = new DateTime(2014, 5, 13)
            };
            Book.Books.Add(b5);



            var a1 = new Author
            {
                Name = "Sergey",
                Surname = "Hort",
                MiddleName = "Olegovich",
                Pseudonym = "Rock"
            };
            Author.Authors.Add(a1);

            var a2 = new Author
            {
                Name = "Andrey",
                Surname = "Miron",
                MiddleName = "Batkovich",
                Pseudonym = "Mirando"
            };
            Author.Authors.Add(a2);

            var a3 = new Author
            {
                Name = "Ilay",
                Surname = "Tent",
                MiddleName = "Georgov",
                Pseudonym = "Luke"
            };
            Author.Authors.Add(a3);


            var r1 = new Reader
            {
                Name = "Ivan",
                MiddleName = "Bombino",
                HallNumber = 2,
                Surname = "Ivanov",
                Books = b1 
            };
            Reader.Readers.Add(r1);

            var r2 = new Reader
            {
                Name = "Bombom",
                MiddleName = "Olegovich",
                HallNumber = 2,
                Surname = "Tarasuk",
                Books = b2
            }; 
            Reader.Readers.Add(r2);

            var r3 = new Reader
            {
                Name = "Valentin",
                MiddleName = "Novichkovich",
                HallNumber = 2,
                Surname = "Baiden",
                Books = b3
            };
            Reader.Readers.Add(r3);



            BooksAuthor.BooksAuthors.Add(new BooksAuthor() { Author = a1, Book = b1 });
            BooksAuthor.BooksAuthors.Add(new BooksAuthor() { Author = a1, Book = b2 });
            BooksAuthor.BooksAuthors.Add(new BooksAuthor() { Author = a2, Book = b2 });
            BooksAuthor.BooksAuthors.Add(new BooksAuthor() { Author = a3, Book = b2 });
            BooksAuthor.BooksAuthors.Add(new BooksAuthor() { Author = a1, Book = b3 });
            BooksAuthor.BooksAuthors.Add(new BooksAuthor() { Author = a3, Book = b4 });
            BooksAuthor.BooksAuthors.Add(new BooksAuthor() { Author = a2, Book = b5 });


            LBBooksRefresh();
            LBActhorRefresh();
            LBReaderRefresh();
            LBBookRentalRefresh();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void LBBooksRefresh()
        {
            lbBooks.DataSource = null;
            lbBooks.DataSource = Book.Books;
        }
        private void LBActhorRefresh()
        {
            lbAuthors.DataSource = null;
            lbAuthors.DataSource = Author.Authors;
        }
        private void LBReaderRefresh()
        {
            lbReaders.DataSource = null;
            lbReaders.DataSource = Reader.Readers;
        }
        private void LBBookRentalRefresh()
        {
            lbRental.DataSource = null;
            lbRental.DataSource = BookRental.Rentals;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new FormAbout().ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbBooks_SelectedIndexChanged(object sender, EventArgs e) // lbBooks
        {

        }

        private void lbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbReaders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbRental_SelectedIndexChanged(object sender, EventArgs e)
        {

        } 
        
        private void button1_Click(object sender, EventArgs e) // btnBooks
        {
            new FormMainBooks().ShowDialog();
            LBBooksRefresh();
            LBActhorRefresh();
            LBReaderRefresh();
            LBBookRentalRefresh();
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            new FormMainAuthors().ShowDialog();
            LBBooksRefresh();
            LBActhorRefresh();
            LBReaderRefresh();
            LBBookRentalRefresh();
        }

        private void btnReaders_Click(object sender, EventArgs e)
        {
            new FormMainReader().ShowDialog();
            LBBooksRefresh();
            LBActhorRefresh();
            LBReaderRefresh();
            LBBookRentalRefresh();
        }
        
        private void button1_Click_1(object sender, EventArgs e) //btnRental
        {
            new FormMainRental().ShowDialog();
            LBBooksRefresh();
            LBActhorRefresh();
            LBReaderRefresh();
            LBBookRentalRefresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
