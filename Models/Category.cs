using System.ComponentModel.DataAnnotations;

namespace BlogShare.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The category name is required to fill.")]
        [MaxLength(50, ErrorMessage = "Category name cannot exceed 50 characters.")]
        public string CategoryName { get; set; }
        public string? Description { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
