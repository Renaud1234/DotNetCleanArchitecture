using CleanArchitectureDemo.Application.ViewModels;

namespace CleanArchitectureDemo.Application.Interfaces
{
    public interface IBookService
    {
        BookViewModel GetBooks();
    }
}
