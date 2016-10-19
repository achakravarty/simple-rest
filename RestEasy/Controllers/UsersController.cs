using RestEasy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestEasy.Controllers
{
    public class UsersController : ApiController
    {
        private readonly IEnumerable<User> _users;

        public UsersController()
        {
            var mock = new MockData();
            _users = mock.Users;
        }

        public User Get(long id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public IEnumerable<User> GetUsers()
        {
            return _users;
        }
    }
}
