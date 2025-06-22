using System;

class Program
{
    static void Main()
    {
        Student student = new Student
        {
            Name = "Alice Johnson",
            Id = "S1001",
            Grade = "A"
        };

        StudentView view = new StudentView();

        StudentController controller = new StudentController(student, view);

        controller.UpdateView();

        controller.SetStudentName("Alice Smith");
        controller.SetStudentGrade("A+");

        controller.UpdateView();
    }
}
