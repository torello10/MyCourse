using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class CoursesController:Controller
    {
       public IActionResult index()
       {
           return Content("Io sono index");
       } 

       public IActionResult detail(string id) 
       {
           return Content($"io sono il dettaglio di id {id}");
       } 
    }
}