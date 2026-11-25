using System;
using System.Collections.Generic;
using System.Text;
using MSF.Models;

namespace MSF.Services
{
	public class OrderService
	{
		public void SaveOrder(Order order) { }

		public void UpdateOrder(Order order) { }

		public void DeleteOrder(int orderId) { }

		public Order GetOrderById(int orderId) { }

		public decimal CalculateTotalPrice(Order order) { }

		public int GenerateOrderId() { }
	}
}