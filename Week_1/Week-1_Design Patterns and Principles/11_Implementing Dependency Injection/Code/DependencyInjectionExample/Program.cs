using System;

class Program
{
    static void Main()
    {
        // Inject repository implementation into service
        CustomerRepository repo = new CustomerRepositoryImpl();
        CustomerService service = new CustomerService(repo);

        // Use the service
        service.DisplayCustomer(1);  // Existing customer
        service.DisplayCustomer(4);  // Non-existing customer
    }
}
