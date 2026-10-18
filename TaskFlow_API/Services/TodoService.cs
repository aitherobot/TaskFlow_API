using TaskFlow_API.Models;

namespace TaskFlow_API.Services;

public static class TodoService
{
    private static List<Todo> Todos { get; }
    private static int nextId = 0;

    static TodoService()
    {
        Todos = new List<Todo>()
        {
            new Todo { Id = 1, Name = "Camera refactor", Description = "Work on better camera movement" }
        };
    }
    
    public static List<Todo> GetAllTasks() => Todos;
}