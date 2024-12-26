using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace ActionResultTypes.Controllers
{
    public class DemoController : Controller
    {
        [HttpGet]
        
        public IActionResult Index()
        {
            return View();
        }
            
        public IActionResult GetJson()
        {
            var data = new { Name = "Prajwal Khatri", Age = 30 };
            return Json(data);

        }

        //3. ContentResult: REturns plain text or custom content
        public IActionResult GetContent()
        {
            return Content("This is plain text content", "text/plain");
        }

        //4. FileResult: REturns a file to the client
        public IActionResult GetFile()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
            var fileType = "application/pdf";
            var fileName = "Sample.txt";

            return PhysicalFile(filePath, fileType, fileName); //Serves a file for download.

        }

        //5. RedirectResult: Redirects to another action or URL.
        public IActionResult RedirectToGoogle()
        {
            return Redirect("https://www.google.com"); //Redirects to Google.

        }

        //6. EmptyResult: Returns no content
        public IActionResult GetEmpty()
        {
            return new EmptyResult(); //No response body or status code.
        }
    }
}
