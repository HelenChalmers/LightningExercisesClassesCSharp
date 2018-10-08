using System;
using System.Collections.Generic;

// Create a few (4 or so) instances of books and use the method on your Library class to add them to the list of books in an instance of Library


namespace LighteningExercisesClassesCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Book StarGirl = new Book() {
                Title = "StarGirl",
                Author = "Jerry Spinelli",
                ISBN = "ABC123"
            };

            Book HarryPotter = new Book()
            {
                Title = "Harry Potter",
                Author = "J.K. Rowling",
                ISBN = "DEF456"
            };
            Book tomSawyer = new Book()
            {
                Title = "The Adventures of Tom Sawyer",
                Author = "Mark Twain",
                ISBN = "GHI789"
            };

            Book book1 = new Book()
            {
                Title = "Book1",
                Author = "Author1",
                ISBN = "1A"

            };
            Book book2 = new Book()
            {
                Title = "Book2",
                Author = "Author2",
                ISBN = "2B",
                IsAvailable = false

            };

            Console.WriteLine($"book2 isavailable = {book2.IsAvailable}");


            List<Book> books = new List<Book>(){
                book1, book2
            };

            Library HomeLibrary = new Library(books, "Downtown Library", "Downtown");
            // {
            //     LibraryName = "Downtown Library", 
            //     Address = "Downtown"
            // };
            HomeLibrary.AddToInventory(StarGirl);
            HomeLibrary.AddToInventory(HarryPotter);
            HomeLibrary.AddToInventory(tomSawyer);

            if (HomeLibrary.IsAvailable("2B"))
            {
                Console.WriteLine("2B is available");
            }
        }
    }
}
