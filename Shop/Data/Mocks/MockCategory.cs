using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Електромобілі", Description = "Сучасний вид транспорту" },
                    new Category { CategoryName = "Класничні авто", Description = "Застарілий вид транспорту" }
                };
            }
        }
    }
}
