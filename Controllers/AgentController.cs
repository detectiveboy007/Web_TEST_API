using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_TEST_API.Models.Dtos;
using Web_TEST_API.Repository.IRepository;

namespace Web_TEST_API.Controllers
{
    [Route("api/v{version:apiVersion}/TESTAgent")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class AgentController : ControllerBase
    {
        private readonly ITESTAgentRepository _npRepo;
        private readonly IMapper _mapper;
        public AgentController(ITESTAgentRepository npRepo, IMapper mapper)
        {
            _npRepo = npRepo;
            _mapper = mapper;
        }

        [HttpGet("{TESTAgentId}", Name = "GetTESTAgent")]
        [ProducesResponseType(200, Type = typeof(TESTAgentDto))]
        [ProducesResponseType(404)]
        //[Authorize(Roles = "testap")]
        [Authorize]
        [ProducesDefaultResponseType]
        public IActionResult GetTESTAgent(string TESTAgentId)
        {
            var obj = _npRepo.GetTESTAgent(TESTAgentId);
            if (obj == null)
            {
                return NotFound();
            }
            var objDto = _mapper.Map<TESTAgentDto>(obj);

            return Ok(objDto);
        }
    }
}
