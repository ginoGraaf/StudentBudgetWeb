using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public async Task<IEnumerable<PieModel>>GetPieData( int userID)
        {
            List<Category> category = new List<Category>();
            category = await application.Categories.Where(c => c.User.Id == userID).ToListAsync();
            List<PieModel> pieData = new List<PieModel>();
            pieData =CreateData(category, GetTotalAmount(category));
            return pieData;
        }

        List<PieModel>CreateData(List<Category> category, double amount)
        {
            Random rnd;
            List<PieModel> pieData = new List<PieModel>();
            for (int i = 0; i < category.Count; i++)
            {
                double Precentage = 0;
                rnd = new Random(new System.DateTime().Millisecond);
                string colorName = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)).ToString();

                if (Convert.ToDecimal(category[i].Bedrag) > 0.00m)
                {
                    Precentage = category[i].Bedrag / amount * 100;
                }
                PieModel pieDataInfo = new PieModel(category[i].Title, colorName, (int)Precentage);
                pieData.Add(pieDataInfo);
            }
            return pieData;
        }

        double GetTotalAmount(List<Category> category)
        {
            double amount = 0;
            for (int i = 0; i < category.Count; i++)
            {
                amount += category[i].Bedrag;   
            }
            return amount;
        }
    }
}
