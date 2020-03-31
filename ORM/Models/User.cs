﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ORM.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public decimal Balance { get; private set; }

        public List<Incomes> Incomes = new List<Incomes>();
        public List<Expense> Expenses = new List<Expense>();
        public List<SavingGoal> SavingGoals = new List<SavingGoal>();
    }
}
