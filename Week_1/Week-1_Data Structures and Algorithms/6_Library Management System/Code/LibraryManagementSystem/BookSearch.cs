using System;

public static class BookSearch
{
    // Linear search by title
    public static Book? LinearSearch(Book[] books, string title)
    {
        foreach (var book in books)
        {
            if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                return book;
        }
        return null;
    }

    // Binary search by title 
    public static Book? BinarySearch(Book[] books, string title)
    {
        int left = 0;
        int right = books.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            int comparison = string.Compare(books[mid].Title, title, StringComparison.OrdinalIgnoreCase);

            if (comparison == 0)
                return books[mid];
            else if (comparison < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }
}
