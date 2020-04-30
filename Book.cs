using System;
using System.Collections.Generic;

namespace Fisher.Bookstore.Tests
{

        public class Book
        {
        public int Id { get; set; }
        public string Title { get; set; }
        
        public List<BookAuthor> BookAuthor { get; set; }
        public double Price { get; set; }

        internal void ApplyMemberDiscount()
        {
            Price = Price *.90;
        }

    }

    }
