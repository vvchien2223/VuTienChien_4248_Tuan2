using System.ComponentModel.DataAnnotations;

namespace VuTienChien_4248_Tuan2.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, StringLength(50)] 
        public string Name { get; set; }
    }
}
