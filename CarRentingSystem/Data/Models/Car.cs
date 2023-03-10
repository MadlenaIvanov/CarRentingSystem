using System.ComponentModel.DataAnnotations;
using static CarRentingSystem.Data.DataConstants;

namespace CarRentingSystem.Data.Models
{
    public class Car
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(CarBrandMaxLength)]
        public string Brand { get; set; }

        [Required]
        [MaxLength(CarModelMaxLength)]
        public string Model { get; set; }

        [Required]
        [MaxLength(CarDescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public int Year { get; set; }

        //since we have a list of cars in the category
        public int CategoryId { get; set; }
        public Category Category { get; init; }



    }
}
