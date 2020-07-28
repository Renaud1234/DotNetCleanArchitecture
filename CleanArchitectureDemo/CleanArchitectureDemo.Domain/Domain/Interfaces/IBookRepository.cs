using CleanArchitectureDemo.Domain.Entities;
using System.Collections.Generic;

namespace CleanArchitectureDemo.Domain.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
    }
}
