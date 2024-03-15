
namespace VuTienChien_4248_Tuan2.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        private readonly List<Category> _categoryList;
        public MockCategoryRepository()
        {
            _categoryList = new List<Category>
            {
            new Category { Id = 1,Name ="LapTop"},
            new Category { Id = 2,Name ="Desktop"},
            };
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryList;
        }
    }
}
