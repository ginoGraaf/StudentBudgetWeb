using System;
using DataAccessLibrary;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLibrary
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Expense> Expenses { get; set; }
      
        public DbSet<SavingGoalsModel> SavingGoals { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
