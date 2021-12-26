using DomainLayer.EntityMapper;
using DomainLayer.IdentityAuth;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class BuyTicketDbContext:IdentityDbContext<ApplicationUser>
    {
        public BuyTicketDbContext(DbContextOptions<BuyTicketDbContext> options) : base(options)
        {
             
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new TicketMap());
            modelBuilder.ApplyConfiguration(new DistanceMap());
            modelBuilder.ApplyConfiguration(new VehicleMap());
      
            base.OnModelCreating(modelBuilder);
        }
        
    }
}
