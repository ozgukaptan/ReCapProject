using Bussines.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpPost("isrentable")]
        public IActionResult GetIsRentable(Rental rental)
        {
            var result = _rentalService.CheckCarRentable(rental);
            if (result.Success)
            {
                return Ok(result);
            }

            return Ok(result);
        }
    }
}
