using System;
using System.Collections.Generic;
using System.Text;

namespace Dz_013
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<BooksInLibrary> BooksInLibrary { get; set; }
    }
}
