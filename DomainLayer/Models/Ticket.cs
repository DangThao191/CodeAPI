using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Ticket : BaseEntity
    {
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }
        public int DistanceId { get; set; }
        public string Price { get; set; }
        public string Seat { get; set; }   
        public virtual Customer Customer { get; set; }
     
        public virtual Vehicle Vehicle { get; set; }
        public virtual Distance Distance { get; set; }

    }
}
