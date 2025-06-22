using System.Collections.Generic;

public class CustomerRepositoryImpl : CustomerRepository
{
    private Dictionary<int, string> _customers = new()
    {
        { 1, "Alice Johnson" },
        { 2, "Bob Smith" },
        { 3, "Charlie Davis" }
    };

    public string FindCustomerById(int id)
    {
        return _customers.TryGetValue(id, out string name) ? name : "Customer not found.";
    }
}
