using CarRentingSystem.Data;
using CarRentingSystem.Models.Cars;
using Microsoft.AspNetCore.Mvc;

namespace CarRentingSystem.Controllers
{
    public class CarsController : Controller
    {
        private readonly CarRentingDbContext data;

        public CarsController(CarRentingDbContext data)
        {
            this.data = data;
        }

        public IActionResult Add() => View(new AddCarFormModel
        {
            Categories = this.GetCarCategories()
        });
           

        [HttpPost]
        public IActionResult Add(AddCarFormModel car)
        {
            if (!ModelState.IsValid)
            {
                car.Categories = this.GetCarCategories();

                return View(car);
            }

            return RedirectToAction("Index", "Home");
        }

        private IEnumerable<CarCategoryViewModel> GetCarCategories()
            => this.data
                .Categories
                .Select(c => new CarCategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToList();
    }
}
