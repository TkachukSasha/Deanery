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
    public class StudentController : Controller
    {
        private readonly IBaseRepository<Student> _repository;
        private readonly IMapper _mapper;

        public StudentController(IBaseRepository<Student> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("subjects")]
        public async Task<ActionResult<IEnumerable<Student>>> GetAllSubjects()
        {
            var result = await _repository.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> Get(string id)
        {
            var result = await _repository.Get(id);
            return Ok(result);
        }

        [HttpPost("subject")]
        public ActionResult CreateSubject([FromBody] CreateStudentRequest request)
        {
            var map = _mapper.Map<Student>(request);
            var result = _repository.Create(map);

            return Ok(result);
        }

        [HttpPut("subject")]
        public IActionResult Update([FromBody] CreateStudentRequest request)
        {
            var map = _mapper.Map<Student>(request);
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
