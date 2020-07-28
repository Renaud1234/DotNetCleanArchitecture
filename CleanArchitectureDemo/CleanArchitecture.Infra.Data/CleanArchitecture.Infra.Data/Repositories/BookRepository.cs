using CleanArchitectureDemo.Domain.Entities;
using CleanArchitectureDemo.Domain.Interfaces;
using CleanArchitectureDemo.Infra.Data.Persistence;
using System;
using System.Collections.Generic;

namespace CleanArchitectureDemo.Infra.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        public LibraryDbContext _context;
        public BookRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _context.Books;
        }
    }
}
