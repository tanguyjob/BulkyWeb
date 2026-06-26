using BulkyBookWeb.Data;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{

    public class Category
    {
 


        // [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public String Name { get; set; } = string.Empty;

        [Range(0,100, ErrorMessage ="Range must between 0 and 100!!!")]
       public int? DisplayOrder { get; set; }

    }
}
