using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement2
{
    internal class User
    {
        public bool HaveLibarayCard=false;
        public void BorrowBook(Library library,string BookName)
        {
            if (!HaveLibarayCard)
            {
                Console.WriteLine("This User does't have a Libaray Card to borrow books.");
                return;
            }
            
            string book=library.books.FirstOrDefault(b=>b.Key==BookName).Key;
            if(book is null)
            {
                Console.WriteLine($"This is not available.");
                return;
            }
            if (library.books[BookName] > 0)
            {
                library.books[BookName]--;
                Console.WriteLine($"{BookName} was Borrowed.");
            }
            else
            {
                Console.WriteLine("This book is not available right now ,you can come later.");
            }
        }

    }
}
