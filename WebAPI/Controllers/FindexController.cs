using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bussines.Abstract;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FindexController : ControllerBase
    {
        IFindeksService _findeksService; 
        public FindexController(IFindeksService findeksService)
        {
            _findeksService = findeksService;
        }

        [HttpGet("getfindexpoint")]
        public IActionResult getFinkes(int userId)
        {
            var result = _findeksService.GetFindekPointByUserId(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
