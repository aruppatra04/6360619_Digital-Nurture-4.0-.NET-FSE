using System;

public class EmployeeManager
{
    private Employee[] employees;
    private int count;

    public EmployeeManager(int size)
    {
        employees = new Employee[size];
        count = 0;
    }

    // Add
    public void AddEmployee(Employee employee)
    {
        if (count < employees.Length)
        {
            employees[count++] = employee;
            Console.WriteLine("Employee added.");
        }
        else
        {
            Console.WriteLine("Employee list is full.");
        }
    }

    // Search by ID
    public Employee? SearchEmployee(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (employees[i].EmployeeId == id)
                return employees[i];
        }
        return null;
    }

    // Traverse
    public void ListEmployees()
    {
        if (count == 0)
        {
            Console.WriteLine("No employees found.");
            return;
        }

        Console.WriteLine("All Employees:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(employees[i]);
        }
    }

    // Delete by ID
    public void DeleteEmployee(int id)
    {
        int index = -1;
        for (int i = 0; i < count; i++)
        {
            if (employees[i].EmployeeId == id)
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            Console.WriteLine("Employee not found.");
            return;
        }

        for (int i = index; i < count - 1; i++)
        {
            employees[i] = employees[i + 1];
        }

        employees[--count] = null!;
        Console.WriteLine("Employee deleted.");
    }
}
