using System.ComponentModel.DataAnnotations;

namespace CarRentingSystem.Data.Models
{
    public class Category
    {
        public int Id { get; init; }

        [Required]
        public string Name { get; set; }

        public IEnumerable<Car> Cars { get; init; } = new List<Car>();
    }
}
