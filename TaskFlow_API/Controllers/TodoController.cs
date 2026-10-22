using Microsoft.AspNetCore.Mvc;
using TaskFlow_API.Models;
using TaskFlow_API.Services;

namespace TaskFlow_API.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoController : ControllerBase
{
    public TodoController()
    {
        
    }

    [HttpGet]
    public ActionResult<List<Todo>> GetAllTasks() => TodoService.GetAllTasks();

    [HttpGet("{id}")]
    public ActionResult<Todo> GetTaskById(int id)
    {
        var todo = TodoService.GetTaskById(id);
        if (todo == null)
            return NotFound();

        return todo;
    }

    [HttpPost]
    public IActionResult CreateTask(Todo todo)
    {
        TodoService.Add(todo);
        return CreatedAtAction(nameof(GetAllTasks), new { id = todo.Id }, todo);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateTask(int id, Todo todo)
    {
        if (id != todo.Id)
            return BadRequest();

        var existingTask = TodoService.GetTaskById(id);
        if (existingTask is null)
            return NotFound();
        
        TodoService.Update(todo);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteTask(int id)
    {
        var todo = TodoService.GetTaskById(id);

        if (todo is null)
            return NotFound();
        
        TodoService.Delete(id);

        return NoContent();
    }
}