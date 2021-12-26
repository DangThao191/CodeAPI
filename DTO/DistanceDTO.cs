using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DistanceDTO
    {
        public int Id { get; set; }
        public string DistanceName { get; set; }
        public DateTime DepartureDay { get; set; }
        public DateTime DepartureTime { get; set; }
        public string Leaving { get; set; }
        public string Destination { get; set; }
    }
}
