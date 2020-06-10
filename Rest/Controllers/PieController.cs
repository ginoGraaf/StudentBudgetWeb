using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccessLibrary;
using DataAccessLibrary.Models;
using DataAccessLibrary.Logic;

namespace Rest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PieController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public PieController(ApplicationContext context)
        {
            this._context = context;
        }
        // GET: api/Pie
        [HttpGet]
        public List<PieModel> GetPieData()
        {
            List<PieModel> pieModels = new List<PieModel>();
            CalculatePie calculatePie = new CalculatePie(this._context);
            pieModels = calculatePie.GetPieData();

            return pieModels;
        }

        // GET: api/Pie/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }


    }
}
