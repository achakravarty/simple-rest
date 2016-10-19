using RestEasy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestEasy
{
    public class MockData
    {
        public IEnumerable<User> Users { get; } = new List<User>
            {
                new User
                {
                    Id = 1,
                    FirstName = "Tony",
                    LastName = "Stark"
                },
                new User
                {
                    Id = 2,
                    FirstName = "Bruce",
                    LastName = "Banner"
                },
                new User
                {
                    Id = 3,
                    FirstName = "Peter",
                    LastName = "Parker"
                }
            };

        public IEnumerable<Voucher> Vouchers { get; } = new List<Voucher>
        {
            new Voucher
            {
                UserId = 1,
                Number = "XXXX-XXXX-XXXX-1234",
                Value = "$10:00"
            },
            new Voucher
            {
                UserId = 2,
                Number = "XXXX-XXXX-XXXX-2345",
                Value = "$20:00"
            },
            new Voucher
            {
                UserId = 3,
                Number = "XXXX-XXXX-XXXX-3456",
                Value = "$30:00"
            },
            new Voucher
            {
                UserId = 1,
                Number = "XXXX-XXXX-XXXX-4567",
                Value = "$40:00"
            },
            new Voucher
            {
                UserId = 3,
                Number = "XXXX-XXXX-XXXX-5678",
                Value = "$50:00"
            }
        };
    }
}