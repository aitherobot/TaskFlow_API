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
            new Todo { Id = 1, Name = "Camera refactor", Description = "Work on better camera movement" },
            new Todo { Id = 2, Name = "Tower Defense Prototype", Description = "Create a tower defense prototype for the game jam" }
        };
    }
    
    public static List<Todo> GetAllTasks() => Todos;
    
    public static Todo? GetTaskById(int id) => Todos.FirstOrDefault(t => t.Id == id);
}