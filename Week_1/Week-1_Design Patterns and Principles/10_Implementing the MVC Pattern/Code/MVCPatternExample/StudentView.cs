using System;

public class StudentView
{
    public void DisplayStudentDetails(string studentName, string studentId, string studentGrade)
    {
        Console.WriteLine("----- Student Details -----");
        Console.WriteLine($"Name  : {studentName}");
        Console.WriteLine($"ID    : {studentId}");
        Console.WriteLine($"Grade : {studentGrade}");
        Console.WriteLine("---------------------------\n");
    }
}
