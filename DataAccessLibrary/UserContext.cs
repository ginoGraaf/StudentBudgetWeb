using System;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLibrary
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        DbSet<User> users { get; set; }
    }
}
