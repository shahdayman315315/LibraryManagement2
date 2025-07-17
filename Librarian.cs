using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement2
{
    internal class Librarian
    {
        Library library;
        public Librarian(Library libary) 
        { 
        this.library = libary;
        }
        public void AddBook(string BookName,int amount)
        {
            string book=library.books.FirstOrDefault(b=>b.Key==BookName).Key;
            if(book is not null)
            {
                library.books[BookName] += amount;
                return;
            }

            library.books.Add(BookName, amount);

            Console.WriteLine($"New Book was Added: {BookName}");
        }
        public void RemoveBook(string BookName)
        {
            string book = library.books.FirstOrDefault(b => b.Key == BookName).Key;
            if(book is null)
            {
                Console.WriteLine($"{BookName} is not Exist in The Library.");
                return;
            }
            library.books.Remove(book);
            Console.WriteLine($"{BookName} was Removed from The Library.");
        }
        public void DisplayLibraryBooks()
        {
            library.DisplayBooks();
        }
    }
}
