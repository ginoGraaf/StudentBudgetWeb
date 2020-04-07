﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ORM.Models;


namespace ORM.DataAccess
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions <UserContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
   
    }
}


