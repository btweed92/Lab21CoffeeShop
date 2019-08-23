using System;
using System.Collections.Generic;

namespace Lab20CoffeeShopPt3.Models
{
    public partial class Items
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
        public string ItemDesc { get; set; }
    }
}
