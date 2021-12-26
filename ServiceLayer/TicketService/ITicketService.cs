using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.TicketService
{
    public interface ITicketService
    {
        IEnumerable<Ticket> GetAllTicket();
        Ticket GetTicket(int id);
        void InsertTicket(Ticket ticket);
        void UpdateTicket(Ticket ticket);
        void DeleteTicket(int id);
    }
}
