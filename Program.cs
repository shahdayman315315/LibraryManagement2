namespace LibraryManagement2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Librarian librarian=new Librarian(library);
            librarian.AddBook("first book", 1);
            librarian.AddBook("second book", 2);
            librarian.RemoveBook("second book");
            librarian.DisplayLibraryBooks();
            User user = new User();
            user.HaveLibarayCard=true;
            user.BorrowBook(library,"first book");
            user.BorrowBook(library, "second book");
            user.BorrowBook(library, "first book");


        }
    }
}




