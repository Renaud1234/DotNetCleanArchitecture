using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureDemo.Domain.Entities
{
    public class Book
    {
        // Entity properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }
        public string AuthorName { get; set; }


        // Navigation properties
        public int LibraryId { get; set; }
    }
}
