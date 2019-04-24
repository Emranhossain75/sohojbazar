using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SOHOJBAZAR.Models;

namespace SOHOJBAZAR.Models
{
    public class AuthenticationContext :IdentityDbContext
    {
        public AuthenticationContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
        public DbSet<SOHOJBAZAR.Models.Customer> Customer { get; set; }
        public DbSet<SOHOJBAZAR.Models.Item> Item { get; set; }
        public DbSet<SOHOJBAZAR.Models.Order> Order { get; set; }
        public DbSet<SOHOJBAZAR.Models.PaymentDetail> PaymentDetail { get; set; }
    }
}
