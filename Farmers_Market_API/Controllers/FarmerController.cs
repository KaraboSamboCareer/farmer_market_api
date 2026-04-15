using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Farmers_Market_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Farmers_Market_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FarmerController : ControllerBase
    {
        private readonly List<Farmer> farmers = new List<Farmer> { 
            new (1,"Kobus", "kobus@example.com", "123-456-7890", "Location A", "Province A", 4.5, true), 
            new (2,"Tyrique", "tyrique@example.com", "098-765-4321", "Location B", "Province B", 4.0, true), 
            new (3,"Zandre", "zandre@example.com", "555-555-5555", "Location C", "Province C", 4.8, true) 
            };

        [HttpGet]
        public List<Farmer> GetListOfFarmers()
        {
            return farmers;
        }

        [HttpPost]
        public List<Farmer> CreateFarmer([FromBody] Farmer farmer)
        {
            farmers.Add(farmer);
            return farmers;
        }

        [HttpDelete]
        public List<Farmer> Delete([FromQuery] int farmerId)
        {
            var farmer = farmers.FirstOrDefault(f => f.GetFarmerId() == farmerId);
            if (farmer != null)
            {
                farmers.Remove(farmer);
                return farmers;
            }
            else
            {
                return farmers;
            }
        }

        [HttpPut]
        public Farmer UpdateFarmers([FromBody] Farmer updatedFarmer)
        {
           var farmer = farmers.FirstOrDefault(f => f.GetFarmerId() == updatedFarmer.GetFarmerId());
            if (farmer != null)
            {
                farmer = updatedFarmer;
                return farmer;
            }
            else
            {
                return null;
            }
        }
     }
}