using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Vehicle:BaseEntity
    {
        public string VehicleNumber { get; set; }
        public string VehicleType { get; set; }
        public virtual List<Ticket> Tickets { get; set; }
     
    }
}
