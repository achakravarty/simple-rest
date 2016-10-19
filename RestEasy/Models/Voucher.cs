using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestEasy.Models
{
    public class Voucher
    {
        public long UserId { get; set; }

        public string Number { get; set; }

        public string Value { get; set; }
    }
}