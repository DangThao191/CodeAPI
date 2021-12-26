using AutoMapper;
using DomainLayer.Models;
using DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.TicketService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buyTickets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService ticketService;
      
        public TicketController(ITicketService ticketService)
        {
            this.ticketService = ticketService;
           
        }
        [HttpGet(nameof(GetTicket))]
        public IActionResult GetTicket(int id)
        {
            var result = ticketService.GetTicket(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("not found");
        }
        [HttpGet(nameof(GetAllTicket))]
        public IActionResult GetAllTicket()
        {
            var tickets = ticketService.GetAllTicket();    
            if (tickets is not null)
            {
                return Ok(tickets);
            }
            return BadRequest("not found");
        }
        [HttpPost(nameof(InsertTicket))]
        public IActionResult InsertTicket(Ticket ticket)
        {
          
            ticketService.InsertTicket(ticket);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateTicket))]
        public IActionResult UpdateTicket(Ticket ticket)
        {
          
            ticketService.UpdateTicket(ticket);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteTicket))]
        public IActionResult DeleteTicket(int id)
        {
            ticketService.DeleteTicket(id);
            return Ok("Delete success");
        }
    }
}
