using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement2
{
    internal class Library
    {
        public Dictionary<string,int> books=new Dictionary<string,int>();

        public void DisplayBooks()
        {
            Console.WriteLine("Available Books");
            foreach(var book in books)
            {
                Console.WriteLine(book.Key);
            }
        }
    }
}
