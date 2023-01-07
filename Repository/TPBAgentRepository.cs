using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_TEST_API.Data;
using Web_TEST_API.Models;
using Web_TEST_API.Repository.IRepository;

namespace Web_TEST_API.Repository
{
    public class TESTAgentRepository : ITESTAgentRepository
    {
        private readonly ApplicationDbContext _db;
        public TESTAgentRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public ICollection<TESTAgent> GetTESTAgent()
        {
            return _db.TESTAgent.OrderBy(a => a.Auto_Id).ToList();
        }

        public TESTAgent GetTESTAgent(string TESTAgentId)
        {
            return _db.TESTAgent.FirstOrDefault(a => a.ID_NBR == TESTAgentId);
        }

     
    }
}
