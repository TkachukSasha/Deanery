﻿using AutoMapper;
using Deanery.Application.Common.Contracts;
using Deanery.Domain.Entities;
using Deanery.Domain.Models.Request;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Deanery.Api.Controllers.V1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SubjectController : Controller
    {
        private readonly IBaseRepository<Subject> _repository;
        private readonly IMapper _mapper;

        public SubjectController(IBaseRepository<Subject> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("subjects")]
        public async Task<ActionResult<IEnumerable<Subject>>> GetAllSubjects()
        {
            var result = await _repository.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Subject>> Get(string id)
        {
            var result = await _repository.Get(id);
            return Ok(result);
        }

        [HttpPost("subject")]
        public ActionResult CreateSubject([FromBody] CreateSubjectRequest request)
        {
            var map = _mapper.Map<Subject>(request);
            var result = _repository.Create(map);

            return Ok(result);
        }

        [HttpPut("subject")]
        public IActionResult Update([FromBody] CreateSubjectRequest request)
        {
            var map = _mapper.Map<Subject>(request);
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
