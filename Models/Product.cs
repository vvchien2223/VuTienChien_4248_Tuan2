using System.ComponentModel.DataAnnotations;

namespace VuTienChien_4248_Tuan2.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required, StringLength(100)] public string Name { get; set; }
        [Range(0.01, 10000.00)] public decimal Price { get; set; }
        public string Description { get; set; }
        public int CategoryID {  get; set; }  
    }
}
