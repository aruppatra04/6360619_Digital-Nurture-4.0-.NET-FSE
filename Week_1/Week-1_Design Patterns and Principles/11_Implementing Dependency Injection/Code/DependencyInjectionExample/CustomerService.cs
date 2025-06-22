using System;

public class CustomerService
{
    private readonly CustomerRepository _repository;

    // Constructor Injection
    public CustomerService(CustomerRepository repository)
    {
        _repository = repository;
    }

    public void DisplayCustomer(int id)
    {
        string customer = _repository.FindCustomerById(id);
        Console.WriteLine($"Customer with ID {id}: {customer}");
    }
}
