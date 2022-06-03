using Microsoft.EntityFrameworkCore;

namespace Shop.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent _content;

        public ShopCart(AppDBContent appDbContent)
        {
            this._content = appDbContent;
        } 
        public string ShopCartId { get; set; }
        public List<ShopCartItem> ShopCartItemsList { get; set; }

        public static ShopCart GetCart(IServiceProvider service) // get current session or create new
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var content = service.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString(); // session id
            session.SetString("CartId", shopCartId); // new session

            return new ShopCart(content) { ShopCartId = shopCartId };
        }

        public void AddToCart(Car car)
        {
            _content.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                car = car, 
                price = car.Price
            });

            _content.SaveChanges();
        }

        public List<ShopCartItem> GetShopItems()
        {
            return _content.ShopCartItem.Where(x => x.ShopCartId == ShopCartId).Include(s => s.car).ToList();
        }
    }
}
