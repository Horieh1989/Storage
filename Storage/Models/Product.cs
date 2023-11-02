using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First Name should be minimum 3 characters and a maximum of 50 characters")]
        [DataType(DataType.Text)]
        public string? Name { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Price must be a positive number")]
        public int Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public string? Catagory {  get; set; }
        public string? Shelf {  get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Count must be a positive number")]
        public int Count {  get; set; }
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Description should be minimum 10 characters and a maximum of 500 characters")]
        [DataType(DataType.MultilineText)]
        public string? Description {  get; set; }

    }
}
