using System.ComponentModel.DataAnnotations;

namespace Supplier.App.Models
{
    public class productVM
    {
        
        public int ProductID { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        [MinLength(2, ErrorMessage = "Product Name must have at least 2 characters")]
        public string? Name { get; set; }
        //[Required]
        [MinLength(2, ErrorMessage = "Description must have at least 2 characters")]
        public string? Description { get; set; }
        public int? Qty { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Unit must have at least 2 characters")]
        public string? Unit { get; set; }
        public DateTime? DateAdded { get; set; } = DateTime.Now;
        public DateTime? DateModified { get; set; } = DateTime.Now;
    }
}
