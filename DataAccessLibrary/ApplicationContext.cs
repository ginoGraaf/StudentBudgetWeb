using System;
using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLibrary
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Category> Categories { get; set; }

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
                totalExpenses += item.Amount;
            }
            return TotalExpenses;
        }
    }
}
