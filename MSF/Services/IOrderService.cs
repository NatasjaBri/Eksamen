using System;
using System.Collections.Generic;
using System.Text;
using MSF.Models;

namespace MSF.Services
{
	public interface IOrderService
	{
		void SaveOrder(Order order);

		void UpdateOrder(Order order);

		void DeleteOrder(int orderId);

		Order GetOrderById(int orderId);

		decimal CalculateTotalPrice(Order order);

		int GenerateOrderId();
	}
}