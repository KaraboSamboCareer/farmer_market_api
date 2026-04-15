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
    public class ProduceController : ControllerBase
    {
        private List<ProduceListing> ProduceListings =
        [
            new (1, 1, "Tomatoes", "Vegetables", 2.5, 100, true, DateTime.Now.AddDays(-10), DateTime.Now.AddDays(-5), "Freshly harvested tomatoes."),
            new (2, 2, "Apples", "Fruits", 3.0, 50, true, DateTime.Now.AddDays(-15), DateTime.Now.AddDays(-7), "Crisp and sweet apples."),
            new (3, 3, "Carrots", "Vegetables", 1.8, 200, true, DateTime.Now.AddDays(-20), DateTime.Now.AddDays(-10), "Organic carrots from our farm.")
        ];

        [HttpGet]
        public IActionResult GetProduceListings()
        {
            return Ok(ProduceListings);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduceListingById(int id)
        {
            var produce = ProduceListings.FirstOrDefault(p => p.ListingId == id);
            if (produce == null)
            {
                return NotFound();
            } else
            {
                return Ok(produce.GetFormattedSummary());
            }
        }

    }
}