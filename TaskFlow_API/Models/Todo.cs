namespace TaskFlow_API.Models;

public class Todo
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public DateTime? DueDate { get; set; }
}