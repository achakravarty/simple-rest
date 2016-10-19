using RestEasy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestEasy.Controllers
{
    public class VouchersController : ApiController
    {
        private readonly IEnumerable<Voucher> _vouchers;

        public VouchersController()
        {
            var mock = new MockData();
            _vouchers = mock.Vouchers;
        }

        public IEnumerable<Voucher> GetVouchersForUser(long id)
        {
            return _vouchers.Where(v => v.UserId == id);
        }
    }
}
