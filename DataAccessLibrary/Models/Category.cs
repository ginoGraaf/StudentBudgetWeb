﻿using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLibrary
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public double Bedrag { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
    }
}
