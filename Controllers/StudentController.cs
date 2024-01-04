using Microsoft.AspNetCore.Mvc;
using sms.Data;
using sms.Models;

namespace sms.Controllers;

public class StudentController : Controller
{
    private readonly ApplicationDbContext _db;

    public StudentController(ApplicationDbContext db)
    {
        _db = db;
    }
    public IActionResult Index()
    {
        List<Student> students = _db.Students.ToList();
       
        return View(students);
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Student student)
    {
        _db.Students.Add(student);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete()
    {
        return View();
    }
}