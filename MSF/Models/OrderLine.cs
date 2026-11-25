using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.Models
{
	public class OrderLine
	{
		public int Quantity { get; set; }

		public decimal LinePrice { get; set; }
	}
}