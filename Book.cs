using System;

namespace LighteningExercisesClassesCSharp
{
    public class Book 
    
    {

    public Book()
    {
        IsAvailable = true;
    }
//         Make a Book class that has
// - Title property
// - Author property
// - ISBN (this will be a string) property
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    public bool IsAvailable { get; set; }

    }
   } 