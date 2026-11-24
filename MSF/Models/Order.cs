using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
