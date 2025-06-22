using System;

class Program
{
    static void Main()
    {
        EmployeeManager manager = new EmployeeManager(5); // array of 5 employees

        manager.AddEmployee(new Employee { EmployeeId = 101, Name = "Alice", Position = "Manager", Salary = 75000 });
        manager.AddEmployee(new Employee { EmployeeId = 102, Name = "Bob", Position = "Engineer", Salary = 60000 });
        manager.AddEmployee(new Employee { EmployeeId = 103, Name = "Charlie", Position = "Designer", Salary = 55000 });

        manager.ListEmployees();

        Console.WriteLine("\nSearching for Employee ID 102...");
        var emp = manager.SearchEmployee(102);
        Console.WriteLine(emp != null ? emp.ToString() : "Employee not found");

        Console.WriteLine("\nDeleting Employee ID 102...");
        manager.DeleteEmployee(102);

        Console.WriteLine("\nFinal List:");
        manager.ListEmployees();
    }
}
