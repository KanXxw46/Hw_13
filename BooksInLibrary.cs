﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dz_013
{
    public class BooksInLibrary
    {
        public int Id { get; set; }
        public Nullable<int> Id_book { get; set; }
        public Nullable<int> Id_author { get; set; }
        public Nullable<int> Id_customer { get; set; }

        public virtual Authors Authors { get; set; }
        public virtual Books Books { get; set; }
        public virtual Customers Customers { get; set; }
    }
}
