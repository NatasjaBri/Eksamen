using MSF.Models;
using MSF.Services;
using MSF.Repositories;

namespace MSF.UI.ViewModels
{
	public class CreateOrderViewModel
	{
		private IOrderService orderService;
		private IProductRepository productRepository;

		public Order CurrentOrder { get; set; }
		public Product SelectedProduct { get; set; }

		public void CreateOrder()
		{
		}
		public void AddProduct()
		{
		}
		public void RemoveProduct()
		{
		}
		public void SaveOrder()
		{
		}
		public void UpdateOrder()
		{
		}
		public void DeleteOrder()
		{
		}
		public decimal CalculatePrice()
		{
			return 0;
		}
	}
}