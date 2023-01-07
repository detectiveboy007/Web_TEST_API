using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_TEST_API.Models;

namespace Web_TEST_API.Repository.IRepository
{
    public interface ITESTAgentRepository
    {
        ICollection<TESTAgent> GetTESTAgent();
        TESTAgent GetTESTAgent(string TESTAgentId);
      
    }
}
