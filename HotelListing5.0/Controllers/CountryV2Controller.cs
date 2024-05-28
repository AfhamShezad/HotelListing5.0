using HotelListing5._0.Data;
using HotelListing5._0.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace HotelListing5._0.Controllers
{
    [ApiVersion("2.0", Deprecated = true)]
    [Route("api/country")]
    [ApiController]
    public class CountryV2Controller : ControllerBase
    {
        private DatabaseContext _context;

        public CountryV2Controller(DatabaseContext context) { 
        
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCountries()
        {
                return Ok(_context.Countries);

        }
    }
}
