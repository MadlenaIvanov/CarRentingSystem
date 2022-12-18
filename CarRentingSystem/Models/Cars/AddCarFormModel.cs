using System.ComponentModel.DataAnnotations;
using static CarRentingSystem.Data.DataConstants;

namespace CarRentingSystem.Models.Cars
{
    public class AddCarFormModel
    {
        [Required]
        [MinLength(CarBrandMinLength)]
        [MaxLength(CarBrandMaxLength)]
        public string Brand { get; init; }

        [Required]
        [MinLength(CarModelMinLength)]
        [MaxLength(CarModelMaxLength)]
        public string Model { get; init; }

        [Required]
        [MinLength(CarDescriptionMinLength)]
        [MaxLength(CarDescriptionMaxLength)]
        public string Description { get; init; }

        [Required]
        [Display(Name = "Image")]
        [Url]
        public string ImageUrl { get; init; }

        [Range(CarYearMinValue, CarYearMaxValue)]
        public int Year { get; init; }

        [Display(Name = "Pick a category")]
        public int CategoryId { get; init; }

        public IEnumerable<CarCategoryViewModel> Categories { get; set; }
    }
}
