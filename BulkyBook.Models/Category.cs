using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BulkyBook.Models
{
    public class Category
    {
        [Key] //as property is Id itself,by default it will be primary key
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(0, 100, ErrorMessage = "The field Display Order must be between 0 -- 100")]
        public int DisplayOrder { get; set; }
    }
}
