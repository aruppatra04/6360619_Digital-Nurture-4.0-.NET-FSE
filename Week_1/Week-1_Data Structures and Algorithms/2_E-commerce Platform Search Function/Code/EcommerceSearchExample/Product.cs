public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty; 
    public string Category { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"ID: {ProductId}, Name: {ProductName}, Category: {Category}";
    }
}
