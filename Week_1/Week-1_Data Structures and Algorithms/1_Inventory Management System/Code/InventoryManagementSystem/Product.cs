public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return $"ID: {ProductId}, Name: {ProductName}, Qty: {Quantity}, Price: ${Price}";
    }
}
