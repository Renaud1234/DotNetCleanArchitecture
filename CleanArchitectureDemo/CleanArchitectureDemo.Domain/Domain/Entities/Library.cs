using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureDemo.Domain.Entities
{
    public class Library
    {
        // Init Collections
        public Library()
        {
            Books = new HashSet<Book>();
        }


        // Entity properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }


        // Navigation properties
        public ICollection<Book> Books { get; private set; }
    }
}
