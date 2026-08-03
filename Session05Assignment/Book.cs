using System;
using System.Collections.Generic;
using System.Text;

namespace Session05Assignment
{
    public class Book
    {
        
        private string password = "secret";

        internal int copiesInStock = 5;
       
        public string Title;
        public Genre BookGenre { get; set; }
        
    }
}
