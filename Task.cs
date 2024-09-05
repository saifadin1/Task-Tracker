public class Task
{
    public int id { get; set; }
    public string status { get; set; }
    public string description { get; set; }
    public DateTime createdAt { get; set; } = DateTime.Now;
    public DateTime updatedAt { get; set; } = DateTime.Now;

    public Task(string status, string description)
    {
        this.status = status;
        this.description = description;
    }
}