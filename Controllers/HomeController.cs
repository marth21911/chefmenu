using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Crudelicious.Models;
using Microsoft.EntityFrameworkCore;

namespace Crudelicious.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyContext _context;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.AllDishes = _context.Dishes.OrderByDescending(d => d.CreatedAt).ToList();
            return View();
        }
        [HttpGet("home")]
        public IActionResult GoHome()
        {
            ViewBag.AllDishes = _context.Dishes.OrderByDescending(d => d.CreatedAt).ToList();
            return View("Index");
        }
        [HttpGet("edit/{DishID}")]
        public IActionResult EditDish(int DishID)
        {
            Dish DishToEdit = _context.Dishes.FirstOrDefault(a =>a.DishID == DishID);
            return View(DishToEdit);
        }
        [HttpGet("oneDish/{DishID}")]
        public IActionResult GetOne(int DishID)
        {
            ViewBag.OneDish = _context.Dishes.FirstOrDefault(d => d.DishID == DishID);
            return View("ViewDish");
        }
        [HttpGet("CreateDish")]
        public IActionResult Create()
        {
            return View("CreateDish");
        }
        [HttpPost("newDish")]
        public IActionResult AddDish (Dish newDish)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else{
                return View("CreateDish");
            }
        }
                [HttpPost("/OneDish/update/{DishID}")]
        public IActionResult UpdateDish (int DishID,Dish updatedDish)
        {
            if(ModelState.IsValid)
            {
                Dish oldDish = _context.Dishes.FirstOrDefault(a =>a.DishID == DishID);
                oldDish.Name = updatedDish.Name;
                oldDish.Chef = updatedDish.Chef;
                oldDish.Tastiness=updatedDish.Tastiness;
                oldDish.Calories=updatedDish.Calories;
                oldDish.Description=updatedDish.Description;
                oldDish.UpdatedAt= DateTime.Now;
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else{
                return View("EditDish", updatedDish);
            }
        }
        [HttpGet("OneDish/remove/{DishID}")]
        public IActionResult RemoveDish(int DishID)
        {
            Dish DishToRemove = _context.Dishes.SingleOrDefault(d => d.DishID == DishID);
            _context.Dishes.Remove(DishToRemove);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
