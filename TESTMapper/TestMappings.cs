using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_TEST_API.Models;
using Web_TEST_API.Models.Dtos;

namespace Web_TEST_API.TESTMapper
{
    public class TestMappings : Profile
    {
        public TestMappings()
        {
            CreateMap<TESTAgent, TESTAgentDto>().ReverseMap();
        }
    }
}
