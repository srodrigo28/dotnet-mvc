namespace twtodos.Models;

public class Todo
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateOnly Deadline { get; set; }
    public DateOnly? FinishedAt { get; set; }

}