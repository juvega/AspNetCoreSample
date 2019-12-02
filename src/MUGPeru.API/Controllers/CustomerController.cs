using Microsoft.AspNetCore.Mvc;
using MUGPeru.API.Data;
using MUGPeru.API.Filters;
using System.Collections.Generic;
using System.Linq;

namespace MUGPeru.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly NorthwindLiteContext _context;
        public CustomerController(NorthwindLiteContext context)
        {
            _context = context;
        }

        [MapperFilterResult(typeof(IList<Models.DTOs.Customer>), typeof(IList<Models.Customer>))]
        public IActionResult GetCustomerList()
        {
            return Ok(_context.Customer.ToList());
        }
    }
}
