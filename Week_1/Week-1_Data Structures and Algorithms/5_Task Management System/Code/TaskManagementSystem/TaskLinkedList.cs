public class TaskNode
{
    public Task Data { get; set; }
    public TaskNode? Next { get; set; }

    public TaskNode(Task data)
    {
        Data = data;
        Next = null;
    }
}

public class TaskLinkedList
{
    private TaskNode? head;

    public void AddTask(Task task)
    {
        TaskNode newNode = new TaskNode(task);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            TaskNode current = head;
            while (current.Next != null)
                current = current.Next;

            current.Next = newNode;
        }
    }

    public Task? SearchTask(int taskId)
    {
        TaskNode? current = head;
        while (current != null)
        {
            if (current.Data.TaskId == taskId)
                return current.Data;
            current = current.Next;
        }
        return null;
    }

    public void TraverseTasks()
    {
        TaskNode? current = head;
        if (current == null)
        {
            Console.WriteLine("No tasks in the list.");
            return;
        }

        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
    }

    public void DeleteTask(int taskId)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        if (head.Data.TaskId == taskId)
        {
            head = head.Next;
            Console.WriteLine($"Task {taskId} deleted.");
            return;
        }

        TaskNode? current = head;
        while (current.Next != null && current.Next.Data.TaskId != taskId)
        {
            current = current.Next;
        }

        if (current.Next == null)
        {
            Console.WriteLine("Task not found.");
        }
        else
        {
            current.Next = current.Next.Next;
            Console.WriteLine($"Task {taskId} deleted.");
        }
    }
}
