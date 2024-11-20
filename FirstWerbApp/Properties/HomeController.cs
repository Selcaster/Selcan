using FirstWerbApp;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class TodoController : Controller
{
    private readonly TodoContext _context;

    public TodoController(TodoContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var todos = _context.Todos.ToList();
        return View(todos);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Todo todo)
    {
        if (ModelState.IsValid)
        {
            _context.Todos.Add(todo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(todo);
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        var todo = _context.Todos.Find(id);
        if (todo == null) return NotFound();
        return View(todo);
    }

    [HttpPost]
    public IActionResult Update(Todo todo)
    {
        if (ModelState.IsValid)
        {
            _context.Todos.Update(todo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(todo);
    }

    public IActionResult Complete(int id)
    {
        var todo = _context.Todos.Find(id);
        if (todo == null) return NotFound();
        todo.IsDone = true;
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        var todo = _context.Todos.Find(id);
        if (todo == null) return NotFound();
        _context.Todos.Remove(todo);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}
