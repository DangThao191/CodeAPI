using AutoMapper;
using DomainLayer.Models;
using DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.RouteService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buyTickets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistanceController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IDistanceService distanceService;
        public DistanceController(IDistanceService distanceService, IMapper mapper)
        {
            this.distanceService = distanceService;
            _mapper = mapper;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Distance, DistanceDTO>().ReverseMap());
            _mapper = new Mapper(config);
        }
        [HttpGet(nameof(GetDistance))]
        public IActionResult GetDistance(int id)
        {
            var result = distanceService.GetDistance(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("not found");
        }
        [HttpGet(nameof(GetAllDistance))]
        public IActionResult GetAllDistance()
        {
            var distance = distanceService.GetAllDistance();
            var distanceDTO = _mapper.Map<IEnumerable<DistanceDTO>>(distance);
            if (distanceDTO is not null)
            {
                return Ok(distanceDTO);
            }
            return BadRequest("not found");
        }
        [HttpPost(nameof(InsertDistance))]
        public IActionResult InsertDistance(DistanceDTO distanceDTO)
        {
            var distance = _mapper.Map<Distance>(distanceDTO);
            distanceService.InsertDistance(distance);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateDistance))]
        public IActionResult UpdateDistance(DistanceDTO distanceDTO)
        {
            var distance = _mapper.Map<Distance>(distanceDTO);
            distanceService.UpdateDistance(distance);
            return Ok("Insert success");
        }
        [HttpDelete(nameof(DeleteDistance))]
        public IActionResult DeleteDistance(int id)
        {
            distanceService.DeleteDistance(id);
            return Ok("Delete success");
        }
    }
}
