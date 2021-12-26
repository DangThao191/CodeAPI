using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.TicketService
{
    public class TicketService : ITicketService
    {
        private IRepository<Ticket> repo;
        public TicketService(IRepository<Ticket> repo)
        {
            this.repo = repo;
        }
        public void DeleteTicket(int id)
        {
            Ticket ticket = GetTicket(id);
            repo.Remove(ticket);
            repo.SaveChanges();
        }

        public IEnumerable<Ticket> GetAllTicket()
        {
            return repo.GetAll();
        }

        public Ticket GetTicket(int id)
        {
            return repo.Get(id);
        }

        public void InsertTicket(Ticket ticket)
        {
            repo.Insert(ticket);
        }

        public void UpdateTicket(Ticket ticket)
        {
            repo.Update(ticket);
        }
    }
}
