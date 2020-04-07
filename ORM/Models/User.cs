using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ORM.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public decimal Balance { get; set; }

        public List<Incomes> Incomes { get; set; }
        public List<Expense> Expenses { get; set; }
        public List<SavingGoal> SavingGoals { get; set; }
    }
}
