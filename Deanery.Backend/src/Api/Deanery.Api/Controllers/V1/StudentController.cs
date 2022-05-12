using AutoMapper;
using Deanery.Application.Common.Contracts;
using Deanery.Application.Common.Pagination.Filters;
using Deanery.Application.Common.Pagination.Helpers;
using Deanery.Application.Common.Pagination.Queries;
using Deanery.Application.Common.Pagination.Response;
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
        private readonly IStudentRepository _repository;
        private readonly IMapper _mapper;
        private readonly IUriRepository _uriService;

        public StudentController(IStudentRepository repository, IMapper mapper, IUriRepository uriRepository)
        {
            _repository = repository;
            _mapper = mapper;
            _uriService = uriRepository;
        }

        [HttpGet("students")]
        public async Task<ActionResult<IEnumerable<Student>>> GetAllStudents([FromQuery] PaginationQuery query)
        {
            var pagginationQuery = _mapper.Map<PaginationFilter>(query);
            var result = await _repository.GetAll(pagginationQuery);

            if (pagginationQuery == null || pagginationQuery.PageNumber < 1 || pagginationQuery.PageSize < 1)
            {
                return Ok(new PagedResponse<Student>(result));
            }

            var response = PaginationHelper.CreatePaginatedResponse(_uriService, pagginationQuery, result);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> Get(string id)
        {
            var result = await _repository.Get(id);
            return Ok(result);
        }

        [HttpPost("student")]
        public ActionResult CreateStudent([FromBody] CreateStudentRequest request)
        {
            var map = _mapper.Map<Student>(request);
            var result = _repository.Create(map);

            return Ok(result);
        }

        [HttpPut("student")]
        public IActionResult Update([FromBody] CreateStudentRequest request)
        {
            var map = _mapper.Map<Student>(request);
            var result = _repository.Update(map);
            return Ok(result);
        }

        [HttpDelete("student")]
        public IActionResult Delete(string id)
        {
            var result = _repository.Delete(id);
            return Ok(result);
        }
    }
}
