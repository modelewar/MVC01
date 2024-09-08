using Microsoft.AspNetCore.Mvc;

namespace MVC01.Controllers
{
    public class MoviesController:Controller
    {

        //https://localhost:44363/Movies/GeMovies?id=10
        public IActionResult GetMovies( int id , string name , Employee emploe ) 
        {
            return Content($"Movie With Id = {id} , Name = {name}");
        }

        //Action Parameter Binding
        //1.Form [html Form ]
        //2.Segment
        //3.Query String
        //4.File

        public IActionResult index() 
        {
            //ContentResult result = new ContentResult();
            // result.Content = "Hello From Index";
            // result.ContentType = "text/html"; //Default
            // //result.ContentType = "object/pdf";
            // return result;

            return Content("Hello From Index", "text/html");
        }

        public IActionResult Test()
        {
            //RedirectResult result = new RedirectResult("https://localhost:44363/Movies/Index");
            //return result;
            //return Redirect("https://localhost:44363/Movies/Index");

            //return RedirectToAction(nameof(Index));
            return RedirectToRoute(new { Controller = "Movies" , action = "Index" });


        }

    }
}
