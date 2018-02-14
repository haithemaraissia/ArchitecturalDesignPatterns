using System.Collections.Generic;
using System.Linq;
using DesignPattern.Repo.Model;
using xUnit.Repo.Context;
using xUnit.Repo.Interface;

namespace xUnit.Repo.Concrete
{
    public class InMemoryRepository : IBookRepository
    {
        private readonly List<Book> _bookRepo;

        public InMemoryRepository()
        {
            _bookRepo = new InMemoryContext().GetBooks();
        }

        public Book GetById(int id)
        {
            return _bookRepo.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Book> GetAll()
        {
            return _bookRepo.ToList();
        }

        public void Add(Book book)
        {
            _bookRepo.Add(book);
        }

        public void Update(Book book)
        {
            var oldbook = GetById(book.Id);
            _bookRepo.Remove(oldbook);
            _bookRepo.Add(book);
        }

        public void Delete(int id)
        {
            _bookRepo.Remove(_bookRepo.FirstOrDefault(x => x.Id == id));
        }
    }
}
