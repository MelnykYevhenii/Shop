using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContent _content;

        public CategoryRepository(AppDBContent appDbContent)
        {
            this._content = appDbContent;
        }
        public IEnumerable<Category> AllCategories => _content.Category;
    }
}
