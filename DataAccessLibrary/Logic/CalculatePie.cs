using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DataAccessLibrary.Logic
{
    public class CalculatePie
    {
        ApplicationContext application;
        public CalculatePie(ApplicationContext application)
        {
            this.application = application;
        }

        //later make this user ID.
        public List<PieModel>GetPieData()
        {
            List<Expense> expenses = new List<Expense>();
            expenses = application.Expenses.ToList();
         
            decimal amount = GetTotalAmount(expenses);

            return CreateData(expenses,amount);
        }

        List<PieModel>CreateData(List<Expense> expenses,decimal amount)
        {
            Random rnd;
            List<PieModel> pieData = new List<PieModel>();
            for (int i = 0; i < expenses.Count; i++)
            {
                double Precentage = 0;
                rnd = new Random(new System.DateTime().Millisecond);
                string colorName = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)).ToString();
                if (expenses[i].Amount > 0.00m)
                {
                    Precentage = ((double)expenses[i].Amount / (double)amount) * 100;
                }
                PieModel pieDataInfo = new PieModel(expenses[i].Category.Title, colorName, (int)Precentage);
                pieData.Add(pieDataInfo);
            }
            return pieData;
        }

        decimal GetTotalAmount(List<Expense> expenses)
        {
            decimal amount = 0;
            for (int i = 0; i < expenses.Count; i++)
            {
                amount += expenses[i].Amount;   
            }
            return amount;
        }
    }
}
