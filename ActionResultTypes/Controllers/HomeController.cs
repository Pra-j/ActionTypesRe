using ActionResultTypes.Models;
using ActionResultTypes.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ActionResultTypes.Controllers
{
    public class HomeController : Controller
    {
        private static List<Product> products = new List<Product>();

        public IActionResult Index()
        {
            ViewBag.Message = "This is Batmans message";

            ViewData["Message"] = "I am batman";

            TempData["Message"] = "This is TempData message";

            return View();
        }

        public IActionResult Privacy()
        {
            string message = TempData["Message"] as string;
            ViewBag.TempMessage = message;

            return View();
        }

        // Display the Create Page
        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new ProductViewModel();
            return View(viewModel);
        }

        // Handle Form Submission
        [HttpPost]
        public IActionResult Create(ProductViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                viewModel.Product.Id = products.Count + 1; // Generate a fake ID
                products.Add(viewModel.Product);

                return RedirectToAction("Success");
            }

            viewModel.Categories = new List<string> { "Electronics", "Books", "Clothing", "Home Appliances" };
            return View(viewModel);
        }

        // Display Success Page
        public IActionResult Success()
        {
            return View(products);
        }
    }
}
//9866416485
//9866182568