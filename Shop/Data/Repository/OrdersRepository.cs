using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent _content;
        private readonly ShopCart _shopCart;
        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart)
        {
            this._content = appDBContent;
            this._shopCart = shopCart;
        }
        public void CreateOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            _content.Order.Add(order);

            var items = _shopCart.ShopCartItemsList;

            foreach (var item in items)
            {
                var orderDetail = new OrderDetail()
                {
                    carId = item.car.Id,
                    orderId = order.id,
                    price = item.car.Price
                };
                _content.OrderDetail.Add(orderDetail);
            }
            _content.SaveChanges();
        }
    }
}
