using DataAccessLibrary;
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
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Amount { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public string Regulation { get; set; }
    }
}
