using System;
using System.Collections.Generic;
using System.Text;

namespace ORM.Models
{
    public class SavingGoal
    {
        public string Title { get; set; }
        public decimal MontlySavingAmount { get; set; }
        public decimal MaxAmount { get; set; }
    }
}
