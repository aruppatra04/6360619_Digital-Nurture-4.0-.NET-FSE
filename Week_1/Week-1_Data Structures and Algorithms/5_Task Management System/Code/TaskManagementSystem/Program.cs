using System;

class Program
{
    static void Main()
    {
        TaskLinkedList taskList = new TaskLinkedList();

        taskList.AddTask(new Task { TaskId = 1, TaskName = "Design UI", Status = "Pending" });
        taskList.AddTask(new Task { TaskId = 2, TaskName = "Develop API", Status = "In Progress" });
        taskList.AddTask(new Task { TaskId = 3, TaskName = "Write Tests", Status = "Pending" });

        Console.WriteLine("All Tasks:");
        taskList.TraverseTasks();

        Console.WriteLine("\nSearching for Task ID 2:");
        var task = taskList.SearchTask(2);
        Console.WriteLine(task != null ? task.ToString() : "Task not found");

        Console.WriteLine("\nDeleting Task ID 2:");
        taskList.DeleteTask(2);

        Console.WriteLine("\nFinal Task List:");
        taskList.TraverseTasks();
    }
}
