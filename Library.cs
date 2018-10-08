using System;
using System.Collections.Generic;

namespace LighteningExercisesClassesCSharp
{
    public class Library 
    
    {
            //
        public Library(List<Book> initialInventory, string name, string address)
        //has to be the same name as the class
        {
          _bookList = initialInventory;
          LibraryName = name;
            Address = address;
        }

        
// Make a Library class that has:
// - Private List of Books (remember casing and naming convention here)
// - Public Method to add a Book to the List of Books
// - Public Address property
// - Public Name property

private List<Book> _bookList = new List<Book>();
//using new List<Book>();  - you are creating a new object.

public void AddToInventory(Book NewBook) 
{
    _bookList.Add(NewBook);
}
//void - we are not returning anything.  
public string LibraryName { get; set; }
//if it's readonly - only put get ....but if not, can add set.
public string Address { get; set;}


public void Checkout(string isbn, CardHolder cardHolder)
    {
        // Book foundBook = new Book();
        // bool didFindBook = false;
        foreach(Book book in _bookList)
        {
            if(book.ISBN == isbn && book.IsAvailable)
            {
                // foundBook = book;
                // didFindBook = true;
                cardHolder.CheckoutBook(book);
                book.IsAvailable = false;
            }
        }
            // if(didFindBook)
            // {
                // _bookList.Remove(foundBook);
            // }
    }

    //"A", "B", "C"
    //isbn = "B";
    //isbn = "D"; => would return False
    public bool IsAvailable(string isbn)
    {
        foreach(Book book in _bookList)
        {
            if(book.ISBN == isbn)
            {
                return book.IsAvailable;
            } 
        }
             return false;
    }
    }

}