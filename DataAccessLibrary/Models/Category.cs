﻿using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace DataAccessLibrary
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public double Bedrag { get; set; }
        public User User { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
    }
}
