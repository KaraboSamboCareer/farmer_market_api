using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Farmers_Market_API.Models;
using Microsoft.AspNetCore.Mvc;
using Farmers_Market_API.Enums;
using Farmers_Market_API.Repositories;

namespace Farmers_Market_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProduceController : ControllerBase
    {
        private ProduceRepository _produceRepository = new ProduceRepository();
        

        [HttpGet]
        public IActionResult GetProduceListings()
        {
            return Ok(_produceRepository.getAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetProduceListingById(int id)
        {
            var produce = _produceRepository.GetById(id);
            if (produce == null)
            {
                return NotFound();
            } else
            {
                return Ok(produce);
            }
        }

        [HttpGet("{id}/summary")]
        public IActionResult GetProduceListingSummary(int id)
        {
            var produce = _produceRepository.GetById(id);
            if(produce == null)
            {
                return NotFound();
            } else
            {
                return Ok(produce.GetFormattedSummary());
            }
        }

        [HttpPost]
        public IActionResult CreateProduceListing([FromBody] ProduceListing newListing)
        {
            _produceRepository.AddProduce(newListing);
            return Created($"localhost:5142/api/Produce/{newListing.ListingId}", newListing);
        }

        [HttpGet("available")]
        public IActionResult GetAvailableProduce(){
            
            return Ok(_produceRepository.GetAvailable());
        }

        [HttpGet("category/{category}")]
        public IActionResult GetProduceByCategory([FromRoute] Category category)
        {
           return Ok(_produceRepository.GetByCategory(category)); 
        }
        


    }
}