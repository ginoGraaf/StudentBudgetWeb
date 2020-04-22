using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataAccessLibrary.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Bedrag { get; set; }

    }
}
