namespace BharghavasPieShop.Models
{
    public class CategoryRepository:ICategoryRepository
    {
        private readonly BharghavasPieShopDbContext _bharghavasPieShopDbContext;

        public CategoryRepository(BharghavasPieShopDbContext bharghavasPieShopDbContext)
        {
            _bharghavasPieShopDbContext = bharghavasPieShopDbContext;
        }

        public IEnumerable<Category> AllCategories =>
            _bharghavasPieShopDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
