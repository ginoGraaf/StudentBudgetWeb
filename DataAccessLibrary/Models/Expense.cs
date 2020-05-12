using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public Category Category { get; set; }

        public Expense(int id, string name, int amount, Category category)
        {
            Id = id;
            Name = name;
            Amount = amount;
            Category = category;
        }
    }
}
