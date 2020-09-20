using System;

namespace Dz_013
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                ShowDebtors();
                ShowAuthors();
            }

            static void ShowDebtors()
            {
                using (BestLibraryEntities db = new BestLibraryEntities())
                {
                    Console.WriteLine("--------------- Debtors ---------------");
                    var debtors = db.Customers.Where(c => c.IsDebtor == true);
                    foreach (var item in debtors)
                        Console.WriteLine($"{item.FirstName} {item.LastName}");
                }
            }

            static void ShowAuthors()
            {
                using (BestLibraryEntities db = new BestLibraryEntities())
                {
                    Console.WriteLine("--------------- Authors ---------------");
                    var authors = from a in db.BooksInLibrary
                                  join b in db.Authors on
                                  a.Id_author equals b.Id

                                  where a.Id_book == 3
                                  select new { FN = b.FirstName, LN = b.LastName };

                    foreach (var item in authors)
                    {
                        Console.WriteLine($"{item.FN} {item.LN}");
                    }
                }
            }
        }
    }
}
