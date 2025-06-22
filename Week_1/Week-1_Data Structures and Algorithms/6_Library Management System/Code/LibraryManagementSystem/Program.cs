using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Book[] books = new Book[]
        {
            new Book { BookId = 1, Title = "C# in Depth", Author = "Jon Skeet" },
            new Book { BookId = 2, Title = "Clean Code", Author = "Robert C. Martin" },
            new Book { BookId = 3, Title = "The Pragmatic Programmer", Author = "Andy Hunt" },
            new Book { BookId = 4, Title = "Introduction to Algorithms", Author = "Cormen" },
            new Book { BookId = 5, Title = "Design Patterns", Author = "Erich Gamma" }
        };

        Console.WriteLine("Linear Search for 'Clean Code':");
        var result1 = BookSearch.LinearSearch(books, "Clean Code");
        Console.WriteLine(result1 != null ? result1.ToString() : "Book not found");

        Console.WriteLine();

        Console.WriteLine("Binary Search for 'Clean Code' (sorted list):");
        var sortedBooks = books.OrderBy(b => b.Title).ToArray();
        var result2 = BookSearch.BinarySearch(sortedBooks, "Clean Code");
        Console.WriteLine(result2 != null ? result2.ToString() : "Book not found");
    }
}
