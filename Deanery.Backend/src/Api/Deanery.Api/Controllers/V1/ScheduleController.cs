using AutoMapper;
using Deanery.Application.Common.Contracts;
using Deanery.Domain.Entities;
using Deanery.Domain.Models.Request;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Deanery.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ScheduleController : Controller
    {
        private readonly IBaseRepository<Schedule> _repository;
        private readonly IMapper _mapper;

        public ScheduleController(IBaseRepository<Schedule> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("subjects")]
        public async Task<ActionResult<IEnumerable<Schedule>>> GetAllSubjects()
        {
            var result = await _repository.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Schedule>> Get(string id)
        {
            var result = await _repository.Get(id);
            return Ok(result);
        }

        [HttpPost("subject")]
        public ActionResult CreateSubject([FromBody] CreateScheduleRequest request)
        {
            var map = _mapper.Map<Schedule>(request);
            var result = _repository.Create(map);

            return Ok(result);
        }

        [HttpPut("subject")]
        public IActionResult Update([FromBody] CreateScheduleRequest request)
        {
            var map = _mapper.Map<Schedule>(request);
            var result = _repository.Update(map);
            return Ok(result);
        }

        [HttpDelete("subject")]
        public IActionResult Delete(string id)
        {
            var result = _repository.Delete(id);
            return Ok(result);
        }
    }
}
