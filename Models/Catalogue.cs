using System.ComponentModel.DataAnnotations;

namespace QuartzCreations.Models
{
    public class Catalogue
    {
        public int Id { get; set; } //primary key

        [Required(AllowEmptyStrings = false, ErrorMessage = "You must provide a category name."), MaxLength(200)]
        [Display(Name = "Category Name")]
        public string Name { get; set; }

        [Display(Name = "Category Description")]
        public string? Description { get; set; } //? allows fields to be null

        public string? Icon { get; set; }

        //needed to set foreign key/navigation property
        //child reference -> One Category : Many Game
        public List<Product>? Products { get; set; }
    }
}
