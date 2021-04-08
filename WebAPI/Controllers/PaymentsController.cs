using Bussines.Abstract;
using Entities.Concrete;
using Entities.Dtos;
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
    public class PaymentsController : ControllerBase
    {
        IPaymentService _paymentService;
        ICreditCardService _creditCardService;
        public PaymentsController(IPaymentService paymentService,ICreditCardService creditCardService)
        {
            _creditCardService = creditCardService;
            _paymentService = paymentService;
        }
        [HttpPost("pay")]
        public IActionResult Pay(RentalPaymentDto rentalPaymentDto)
        {
            var result = _paymentService.ReceivePayment(rentalPaymentDto.Payment, rentalPaymentDto.Rental);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getcreditcardbyuserıd")]
        public IActionResult getCreditCardByUserId(int userId)
        {
            var result = _creditCardService.GetByUserId(userId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

    }
}
