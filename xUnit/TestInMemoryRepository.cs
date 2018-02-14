using System.Linq;
using DesignPattern.Repo.Model;
using xUnit.Repo.Concrete;
using Xunit;

namespace DesignPattern.xUnit
{

    public class TestInMemoryRepository
    {

        private InMemoryRepository _Repo;

        public TestInMemoryRepository()
        {
            //Arrange
            _Repo = new InMemoryRepository();
        }

        [Fact]
        public void GetBookById_Should_ReturnNull_When_IdDoestNotExist()
        {
            //Act
            var book = _Repo.GetById(55);

            //Assert
            Assert.Null(book);
        }

        [Fact]
        public void GetBookById_Should_Book_When_IdExist()
        {
            //Act
            var book = _Repo.GetById(2);

            //Assert
            Assert.NotNull(book);
        }

        [Fact]
        public void GetAll_Should_Be_Greater_than_Zero()
        {
            //Act
            var books = _Repo.GetAll();

            //Assert
            Assert.True(books.Any());
        }


        [Fact]
        public void AddBook_Should_AddOneBook_ToListofBooks()
        {
            //Act
            var bookCount = _Repo.GetAll().Count();
            _Repo.Add(
                new Book
                {
                    Id = 12, Name = "Book12", Price = 55.50
                });

            //Assert
            Assert.Equal(bookCount + 1 , _Repo.GetAll().Count());

        }


        [Fact]
        public void UpdateBook_Should_UpdateOnlyCurrentBook()
        {
            //Act
            var book = _Repo.GetById(3);
            book.Name = "Updated Book";
            _Repo.Update(book);

            //Assert
            Assert.Equal(_Repo.GetById(3).Name, "Updated Book");

        }

        [Fact]
        public void DeleteBook_Should_RemoveOneBook_FromListofBooks()
        {
            //Act
            var bookCount = _Repo.GetAll().Count();
            _Repo.Delete(2);

            //Assert
            Assert.Equal(bookCount - 1, _Repo.GetAll().Count());

        }

        public void Dispose()
        {
            _Repo = null;
        }
    }
}