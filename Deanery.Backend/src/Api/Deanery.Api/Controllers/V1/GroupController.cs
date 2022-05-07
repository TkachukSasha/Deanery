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
    public class GroupController : Controller
    {
        private readonly IBaseRepository<Group> _repository;
        private readonly IMapper _mapper;
        private readonly IUriRepository _uriService;

        public GroupController(IBaseRepository<Group> repository, IMapper mapper, IUriRepository uriService)
        {
            _repository = repository;
            _mapper = mapper;
            _uriService = uriService;
        }

        [HttpGet("groups")]
        public async Task<ActionResult<IEnumerable<Group>>> GetAllGroups([FromQuery] PaginationQuery query)
        {
            var pagginationQuery = _mapper.Map<PaginationFilter>(query);
            var result = await _repository.GetAll(pagginationQuery);

            if (pagginationQuery == null || pagginationQuery.PageNumber < 1 || pagginationQuery.PageSize < 1)
            {
                return Ok(new PagedResponse<Group>(result));
            }

            var response = PaginationHelper.CreatePaginatedResponse(_uriService, pagginationQuery, result);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Group>> Get(string id)
        {
            var result = await _repository.Get(id);
            return Ok(result);
        }

        [HttpPost("group")]
        public ActionResult CreateGroup([FromBody] CreateGroupRequest request)
        {
            var map = _mapper.Map<Group>(request);
            var result = _repository.Create(map);

            return Ok(result);
        }

        [HttpPut("group")]
        public IActionResult Update([FromBody] CreateGroupRequest request)
        {
            var map = _mapper.Map<Group>(request);
            var result = _repository.Update(map);
            return Ok(result);
        }

        [HttpDelete("group")]
        public IActionResult Delete(string id)
        {
            var result = _repository.Delete(id);
            return Ok(result);
        }
    }
}
