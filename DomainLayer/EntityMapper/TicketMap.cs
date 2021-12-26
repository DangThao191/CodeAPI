using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.EntityMapper
{
    public class TicketMap : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_ticketId");
            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("Id").HasColumnType("INT");

            builder.HasOne(x => x.Customer)
           .WithMany(x => x.Tickets)
           .HasForeignKey(x => x.CustomerId);

            builder.HasOne(x => x.Vehicle)
           .WithMany(x => x.Tickets)
            .HasForeignKey(x => x.VehicleId);

            builder.HasOne(x => x.Distance)
            .WithMany(x => x.Tickets)
            .HasForeignKey(x => x.DistanceId);

        }

    }
}
