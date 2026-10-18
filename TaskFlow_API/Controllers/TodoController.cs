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
}