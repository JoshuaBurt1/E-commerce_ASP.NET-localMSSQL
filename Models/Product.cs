using System.ComponentModel.DataAnnotations;

namespace QuartzCreations.Models
{
    public enum JewelleryMeasureUnit //predefined values for size
    {
        Karat,
        PartsGold,
        Hallmark,
        Purity
    }
    public class Product
    {
        public int Id { get; set; } //primary key

        [Required()]
        [Display(Name = "Category")]
        public int CategoryId { get; set; } //foreign key

        [Required()]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Display(Name = "Product Description")]
        public string? Description { get; set; } //? allows fields to be null

        public string? Material { get; set; }

        [Required()]
        public decimal Price { get; set; }

        [Required()]
        public decimal Measure { get; set; } //measure unit value

        [Required()]
        public JewelleryMeasureUnit MeasureUnit { get; set; }
        public string? Photo { get; set; }

        //Parent reference (primary key)
        public Category? Category { get; set; } 
    }
}


