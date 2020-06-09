using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Rest.Models;

namespace Rest.Controllers
{
    public class HomeController : Controller
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Category> Categories { get; set; }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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
        public double CalculateAverage(DbSet<Expense> expenses)
        {
            double amount = expenses.Count();
            double average;

            average = TotalExpenses(expenses) / amount;
            return average;
        }

        private double TotalExpenses(DbSet<Expense> expenses)
        {
            double TotalExpenses = 0;
            foreach (var item in expenses)
            {
               TotalExpenses += (double)item.Amount;
            }
            return TotalExpenses;
        }
    }
}
