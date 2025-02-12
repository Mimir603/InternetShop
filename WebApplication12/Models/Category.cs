using System.ComponentModel.DataAnnotations;

namespace WebApplication12.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name="Название категории")]
        public string Name { get; set; } = null!;
        [Display(Name = "Порядок отображения")]
        public int OrderDisplay { get; set; }
    }
}
