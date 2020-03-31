﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace ORM.DataAccess
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions <UserContext> options) : base(options) { }
        public DbSet<Models.User> Users { get; set; }
    }
}
