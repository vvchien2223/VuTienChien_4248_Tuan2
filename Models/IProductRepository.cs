using System.Collections.Generic;
namespace VuTienChien_4248_Tuan2.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);

    }
}
