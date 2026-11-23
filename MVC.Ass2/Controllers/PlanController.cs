using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Ass2.Context;
namespace MVC.Ass2.Controllers
{
    public class PlanControllern : Controller
    {
        //// BaseUrl/Plans/Test
        //public IActionResult Test()
        //{
        //    return View(); // Razor Page Test
        //}


        // List All Plans

        // /plans/Index
        public async Task<IActionResult> Index()
        {
            using GymDbContext context = new GymDbContext();

            var plans = await context.Plans.ToListAsync();

            return View(plans); // Passing Plans To The Index View
        }
    }
}
