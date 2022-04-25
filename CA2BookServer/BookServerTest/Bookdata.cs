using CA2BookServer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookServerTest
{
    public interface IBookService
    {
        IEnumerable<Books> GetAll();
        Books Add(Books newBook);
        Books GetById(int id);
        void Remove(int id);
    }
    public class BookService : IBookService
    {

        private readonly List<Books> _books;

        public BookService()
        {
            _books = new List<Books>()
            {
                new Books
                {
                    BookID = 1,
                    BookName = " A Hazard of Hearts",
                    Review = "Exellent",
                    Genre = "Romance   ",
                    price = 15,
                    Read = 1
                },
                new Books
                {
                    BookID = 18,
                    BookName = " Going Home",
                    Review = "Good",
                    Genre = "Fiction   ",
                    price = 10,
                    Read = 0
                },
                new Books
                {
                    BookID = 19,
                    BookName = "Romeo and Juliet",
                    Review = "Exellent",
                    Genre = "Play      ",
                    price = 30,
                    Read = 56
                },
                new Books
                {
                    BookID = 20,
                    BookName = " The Dream Merchants ",
                    Review = "Good",
                    Genre = "Adventure ",
                    price = 17,
                    Read = 136
                }
            };
        }

        public IEnumerable<Books> GetAll()
        {
            return _books;
        }

        public Books Add(Books newBook)
        {
            _books.Add(newBook);
            return newBook;
        }

        public Books GetById(int id) => _books.Where(a => a.BookID == id).FirstOrDefault();

        public void Remove(int id)
        {
            var existing = _books.First(a => a.BookID == id);
            _books.Remove(existing);
        }
    }

}
