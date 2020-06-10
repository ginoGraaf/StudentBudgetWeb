using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLibrary
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public double Bedrag { get; set; }
        public int UserId { get; set; }

    }
}
