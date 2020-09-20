using System;
using System.Collections.Generic;
using System.Text;

namespace Dz_013
{
    public class Customers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<bool> IsDebtor { get; set; }
        public virtual ICollection<BooksInLibrary> BooksInLibrary { get; set; }
    }
}
