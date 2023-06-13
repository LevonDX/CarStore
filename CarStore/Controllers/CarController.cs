using CarStore.Data;
using CarStore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarStore.Controllers
{
    [Authorize]
    public class CarController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Index()
        {
            var Cars = _context.Cars
                .Include(c => c.Model)
                .ThenInclude(m => m.Make);

            List<CarViewModel> cars = new List<CarViewModel>();
            foreach (var car in Cars)
            {
                cars.Add(new CarViewModel
                {
                    Id = car.Id,
                    Color = car.Color,
                    Year = car.Year,
                    Price = car.Price,
                    Make = car.Model.Make.Name,
                    Model = car.Model.Name
                });
            }

            return View(cars);
        }
    }
}
