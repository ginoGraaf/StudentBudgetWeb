using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLibrary
{
    public class SavingGoalsModel
    {
        [Key]
        public int ID { get; set; }

        public int UserID { get; set; }
        public string GoalName { get; set; }
        public int savingAmount { get; set; }
    }
}
