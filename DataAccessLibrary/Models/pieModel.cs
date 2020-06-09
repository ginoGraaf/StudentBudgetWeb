using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class PieModel
    {
        public string PieName { get; set; }
        public string Color { get; set; }
        public int Precentage { get; set; }

        public PieModel(string pieName,string color, int precentage)
        {
            PieName = pieName;
            Color = color;
            Precentage = precentage;
        }
    }
}
