// TODO: referrence Models namespace
using COMP003B.Assignment3.Models;
using Microsoft.AspNetCore.Mvc;


namespace COMP003B.Assignment3.Controllers
{
    public class StudentsController : Controller
    {
        private static List<Student> _students = new List<Student>();
        // GET: Students
        public IActionResult Index()
        {
            return View(_students);
        }
    }
}
