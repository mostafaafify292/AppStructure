using System;
using Microsoft.AspNetCore.Mvc;

namespace AppStructure.Controllers
{
    public class MovieController : Controller
    {
        //Action-->public NonStatic Func  =>Movie/GetMovie
        public IActionResult GetMovie(int id)
        {
            //ContentResult result = new ContentResult();
            //result.Content = $"movie id = {id}";
            //result.ContentType = "text/html" ;
            //result.StatusCode = 200 ;
            //return result ;
            return Content($"movie id = {id}");
        }
        [ActionName("zz")]
        //[AcceptVerbs("post","get")]
        //[HttpGet]
        public IActionResult Index()
        {
            //return Redirect("{BaseUrl}/Movie/GetMovie/20");
            //return RedirectToAction("GetMovie",10);
            return RedirectToRoute("defult", new { controller = "Movie", action = "GetMovie" , id = 100 });

        }
    }
}
