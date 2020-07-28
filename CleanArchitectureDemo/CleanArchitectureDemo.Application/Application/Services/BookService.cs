using CleanArchitectureDemo.Application.Interfaces;
using CleanArchitectureDemo.Application.ViewModels;
using CleanArchitectureDemo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureDemo.Application.Services
{
    public class BookService : IBookService
    {
        public IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public BookViewModel GetBooks()
        {
            return new BookViewModel()
            {
                Books = _bookRepository.GetBooks()
            };
        }
    }
}
