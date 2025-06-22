public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"ID: {BookId}, Title: {Title}, Author: {Author}";
    }
}
