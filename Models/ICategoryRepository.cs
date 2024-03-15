namespace VuTienChien_4248_Tuan2.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}
