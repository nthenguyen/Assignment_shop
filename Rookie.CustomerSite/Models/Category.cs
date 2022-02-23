using System.ComponentModel.DataAnnotations;

namespace Rookie.CustomerSite.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int OrderDetail { get; set; }    
        public DateTime CreatedDate { get; set; }
    }
}
