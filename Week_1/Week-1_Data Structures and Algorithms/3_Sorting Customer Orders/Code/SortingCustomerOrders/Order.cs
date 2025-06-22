public class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public double TotalPrice { get; set; }

    public override string ToString()
    {
        return $"OrderID: {OrderId}, Customer: {CustomerName}, Total: ${TotalPrice}";
    }
}
