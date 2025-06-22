public class Task
{
    public int TaskId { get; set; }
    public string TaskName { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"Task ID: {TaskId}, Name: {TaskName}, Status: {Status}";
    }
}
