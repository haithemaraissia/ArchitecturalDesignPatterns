using System.Collections.Generic;
using DesignPattern.Repo.Model;

namespace xUnit.Repo.Interface
{
    public interface IBookRepository
    {
        //CRUD
        Book GetById(int id);

        IEnumerable<Book> GetAll();

        void Add(Book book);

        void Update(Book book);

        void Delete(int id);


    }
}
