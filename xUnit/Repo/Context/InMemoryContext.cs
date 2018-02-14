using System.Collections.Generic;
using DesignPattern.Repo.Model;

namespace xUnit.Repo.Context
{
    public class InMemoryContext
    {
        private readonly List<Book> _myBooks;

        public InMemoryContext()
        {
            _myBooks = new List<Book>();
        }

        public List<Book>GetBooks()
        {

            _myBooks.AddRange(new[] {
                new Book
                {
                    Id = 1,
                    Name = "Book1",
                    Price = 28.50
                },
                new Book
                {
                    Id = 2,
                    Name = "Book2",
                    Price = 15
                },
                new Book
                {
                    Id = 3,
                    Name = "Book3",
                    Price = 20
                },
                new Book
                {
                    Id = 4,
                    Name = "Book4",
                    Price = 75
                },
                new Book
                {
                    Id = 5,
                    Name = "Book5",
                    Price = 29.20
                },
                new Book
                {
                    Id = 6,
                    Name = "Book6",
                    Price = 19.99
                },
                new Book
                {
                    Id = 7,
                    Name = "Book7",
                    Price = 29.99
                }
                
            });
            return _myBooks;
        }
    }
}
