using AutoMapper;
using DomainLayer.Models;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.VehicleService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buyTickets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService vehicleService;
        private readonly IMapper _mapper;
        public VehicleController(IVehicleService vehicleService, IMapper mapper)
        {
            this.vehicleService = vehicleService;
            _mapper = mapper;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, CustomerDTO>().ReverseMap());
            _mapper = new Mapper(config);
        }
        [HttpGet(nameof(GetVehicle))]
        public IActionResult GetVehicle(int id)
        {
            var result = vehicleService.GetVehicle(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("not found");
        }
        [HttpGet(nameof(GetAllVehicle))]
        public IActionResult GetAllVehicle()
        {
            var vehicle = vehicleService.GetAllVehicle();
            var vehicleDTO = _mapper.Map<IEnumerable<VehicleDTO>>(vehicle);
            if (vehicleDTO is not null)
            {
                return Ok(vehicleDTO);
            }
            return BadRequest("not found");

        }
        [HttpPost(nameof(InsertVehicle))]
        public IActionResult InsertVehicle(VehicleDTO vehicleDTO)
        {
            var vehicle = _mapper.Map<Vehicle>(vehicleDTO);
            vehicleService.InsertVehicle(vehicle);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateCustomer))]
        public IActionResult UpdateCustomer(VehicleDTO vehicleDTO)
        {

            var vehicle = _mapper.Map<Vehicle>(vehicleDTO);
            vehicleService.UpdateVehicle(vehicle);
            return Ok("Insert success");
        }
        [HttpDelete(nameof(DeleteVehicle))]
        public IActionResult DeleteVehicle(int id)
        {
            vehicleService.DeleteVehicle(id);
            return Ok("Delete customer");
        }
    }
}
