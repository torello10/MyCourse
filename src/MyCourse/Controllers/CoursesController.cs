using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class CoursesController:Controller
    {
       public IActionResult Index()
       {
           return View();
       } 

       public IActionResult detail(string id) 
       {
           return Content($"io sono il dettaglio di id {id}");
       } 

       public IActionResult search(string title)
       {
           return Content($"il titolo da cercare {title}");
       }
    }
}