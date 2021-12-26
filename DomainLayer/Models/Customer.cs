using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Customer:BaseEntity
    {
       
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Order { get; set; }
    
        public virtual List<Ticket> Tickets { get; set; }
     
    }
}
