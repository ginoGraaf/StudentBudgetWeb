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
        public decimal CalculateAverage(DbSet<Expense> expenses)
        {
            decimal amount = expenses.Count();
            decimal average;

            average = TotalExpenses(expenses) / amount;
            return average;
        }

        private decimal TotalExpenses(DbSet<Expense> expenses)
        {
            decimal TotalExpenses = 0;
            foreach (var item in expenses)
            {
               TotalExpenses += Convert.ToDecimal(item.Amount);
            }
            return TotalExpenses;
        }
    }
}
