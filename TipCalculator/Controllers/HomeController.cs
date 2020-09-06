using Microsoft.AspNetCore.Mvc;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    public class HomeController : Controller
    {
        //COMPLETE INSTRUCTIONS IN Models FIRST then return here!!!

        [HttpGet]
        public IActionResult Index()
        {
            //STEP 3:
            /*
            Using the IActionResult Index() method in the HomeController of the Future Value program
            as an example, add three objects to the ViewBag:
            Fifteen, Twenty, and TwentyFive, and set all to 0
            */
            ViewBag.Fifteen = 0;
            ViewBag.Twenty = 0;
            ViewBag.TwentyFive = 0;

            return View();
        }

        [HttpPost]
        public IActionResult Index(Calculator calc)
        {
            //STEP 4:
            /*
            Using the IActionResult Index() overloaded method in the HomeController of the Future Value program
            as an example, 
            1. Add an if/else statement testing the ModelState's IsValid property
            2. If valid, set each of the above ViewBag properties to a call of the calc.CalculateTip method that you added in the model TipCalculator.cs.
            Remember that you need to pass in a percentage in the form of a value 0 <= percentage <= 1.  Thus, 0.15 for Fifteen, etc.
            3. For not valid, set each of the ViewBag properties to 0
            */
            if (ModelState.IsValid)
            {
                ViewBag.Fifteen = calc.CalculateTip(0.15);
                ViewBag.Twenty = calc.CalculateTip(0.20);
                ViewBag.TwentyFive = calc.CalculateTip(0.25);
            }
            else
            {
                ViewBag.Fifteen = 0;
                ViewBag.Twenty = 0;
                ViewBag.TwentyFive = 0;
            }
            return View(calc);
        }

        //PROCEED TO Index.cshtml NEXT...
    }
}