using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Distance : BaseEntity
    {
     
        public string DistanceName { get; set; }
        public DateTime DepartureDay { get; set; }
        public DateTime DepartureTime { get; set; }
        public string  Leaving { get; set; }
        public string Destination { get; set; }
      
        public virtual List<Ticket> Tickets { get; set; }
    }
}
