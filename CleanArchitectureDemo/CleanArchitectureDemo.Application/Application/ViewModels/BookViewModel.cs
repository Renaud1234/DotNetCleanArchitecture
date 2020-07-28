using CleanArchitectureDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureDemo.Application.ViewModels
{
    public class BookViewModel
    {
        public IEnumerable<Book> Books { get; set; }
    }
}
