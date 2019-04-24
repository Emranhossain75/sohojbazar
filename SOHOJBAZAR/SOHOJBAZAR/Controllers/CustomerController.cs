using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SOHOJBAZAR.Models;

namespace SOHOJBAZAR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly AuthenticationContext _context;

        public CustomerController(AuthenticationContext context)
        {
            _context = context;
        }

        // GET: api/Customer
        [HttpGet]
        public IEnumerable<Customer> GetCustomer()
        {
            return _context.Customer;
        }

      
    }
}