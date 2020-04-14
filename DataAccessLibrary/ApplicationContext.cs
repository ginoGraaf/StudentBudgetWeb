using System;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLibrary
{
    public class ApplicationContext : DbContext
    {
       public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        
        DbSet<User> users { get; set; }
        DbSet<Expense> expenses { get; set; }
    }
}
