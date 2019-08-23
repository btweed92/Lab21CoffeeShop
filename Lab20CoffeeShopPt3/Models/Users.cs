using System;
using System.Collections.Generic;

namespace Lab20CoffeeShopPt3.Models
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string UserPass { get; set; }
        public string UserFirst { get; set; }
        public string UserLast { get; set; }
        public decimal? UserFunds { get; set; }
    }
}
