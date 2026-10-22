using TaskFlow_API.Models;

namespace TaskFlow_API.Services;

public static class TodoService
{
    private static List<Todo> Todos { get; }
    private static int nextId = 3;

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

    public static void Add(Todo todo)
    {
        todo.Id = nextId++;
        Todos.Add(todo);
    }
    
    public static void Update(Todo todo)
    {
        var index = Todos.FindIndex(t => t.Id == todo.Id);

        if (index == -1)
            return;

        Todos[index] = todo;
    }

    public static void Delete(int id)
    {
        var todo = GetTaskById(id);
        
        if (todo is null)
            return;
        
        Todos.Remove(todo);
    }
}