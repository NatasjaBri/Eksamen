using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.Models
{
	public class Product
	{
		public int ProductId { get; set; }
		public string Name { get; set; }
		public List<string> ProductVariant { get; set; }
		public decimal Price { get; set; }
	}
}