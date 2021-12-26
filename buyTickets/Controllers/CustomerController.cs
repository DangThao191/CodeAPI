using AutoMapper;
using DomainLayer.Models;
using DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.CustomerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buyTickets.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService customerService;
        private readonly IMapper _mapper;
        public CustomerController(ICustomerService customerService, IMapper mapper)
        {
            this.customerService = customerService;
            _mapper = mapper;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, CustomerDTO>().ReverseMap());
            _mapper = new Mapper(config);
        }
        [HttpGet(nameof(GetCustomer))]
        public IActionResult GetCustomer(int id)
        {
            var result = customerService.GetCustomer(id);
            if(result is not null)
            {
                return Ok(result);
            }
            return BadRequest("not found");
        }
        [HttpGet(nameof(GetAllCustomer))]
        public IActionResult GetAllCustomer()
        {
            var customer = customerService.GetAllCustomer();
            var customerDTO = _mapper.Map<IEnumerable<CustomerDTO>>(customer);
            if (customerDTO is not null)
            {
                return Ok(customerDTO);
            }
            return BadRequest("not found");

        }
        [HttpPost(nameof(InsertCustomer))]
        public IActionResult InsertCustomer(CustomerDTO customerDTO)
        {
            var customer = _mapper.Map<Customer>(customerDTO);
            customerService.InsertCustomer(customer);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateCustomer))]
        public IActionResult UpdateCustomer(CustomerDTO customerDTO)
        {

            var customer =  _mapper.Map<Customer>(customerDTO);
            customerService.UpdateCustomer(customer);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteCustomer))]
        public IActionResult DeleteCustomer(int id)
        {
            customerService.DeleteCustomer(id);
            return Ok("Delete customer");
        }
    }
}
