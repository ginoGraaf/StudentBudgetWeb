using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccessLibrary
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("UserID")]
        public int UserID { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public Category Category { get; set; }
        public string Regulation { get; set; }
    }
}
