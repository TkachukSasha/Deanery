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
    public class TeacherController : Controller
    {
        private readonly IBaseRepository<Teacher> _repository;
        private readonly IMapper _mapper;
        private readonly IUriRepository _uriService;

        public TeacherController(IBaseRepository<Teacher> repository, IMapper mapper, IUriRepository uriRepository)
        {
            _repository = repository;
            _mapper = mapper;
            _uriService = uriRepository;
        }

        [HttpGet("teachers")]
        public async Task<ActionResult<IEnumerable<Teacher>>> GetAllTeachers([FromQuery] PaginationQuery query)
        {
            var pagginationQuery = _mapper.Map<PaginationFilter>(query);
            var result = await _repository.GetAll(pagginationQuery);

            if (pagginationQuery == null || pagginationQuery.PageNumber < 1 || pagginationQuery.PageSize < 1)
            {
                return Ok(new PagedResponse<Teacher>(result));
            }

            var response = PaginationHelper.CreatePaginatedResponse(_uriService, pagginationQuery, result);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Teacher>> Get(string id)
        {
            var result = await _repository.Get(id);
            return Ok(result);
        }

        [HttpPost("teacher")]
        public ActionResult CreateTeacher([FromBody] CreateTeacherRequest request)
        {
            var map = _mapper.Map<Teacher>(request);
            var result = _repository.Create(map);

            return Ok(result);
        }

        [HttpPut("teacher")]
        public IActionResult Update([FromBody] CreateTeacherRequest request)
        {
            var map = _mapper.Map<Teacher>(request);
            var result = _repository.Update(map);
            return Ok(result);
        }

        [HttpDelete("teacher")]
        public IActionResult Delete(string id)
        {
            var result = _repository.Delete(id);
            return Ok(result);
        }
    }
}
