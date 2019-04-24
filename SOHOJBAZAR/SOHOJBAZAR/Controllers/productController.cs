using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SOHOJBAZAR.Models;

namespace SOHOJBAZAR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productController : ControllerBase
    {
        private UserManager<product> _userManager;

        public productController(UserManager<product> userManager)
        {
            _userManager = userManager;

        }
    }
}