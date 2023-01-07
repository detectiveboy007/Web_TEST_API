using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_TEST_API.Models;

namespace Web_TEST_API.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        User Authenticate(string username, string password);
        User Register(string username, string password);
    }
}
