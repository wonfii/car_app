using car_app.Helpers;
using car_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace car_app.Controllers
{
    public class CarsController : Controller
    {
        List<Car> cars;
        public CarsController()
        {
            cars = new List<Car>(SeedCars.GetSeedCars());
        }

        
        public IActionResult Index()
        {
            return View(cars);
        }

        public IActionResult Details(int id)//7
        {
            if (id < 0) { return BadRequest(); }//error 400

            var car = cars.Find(c => c.Id == id);

            if (car == null) { return NotFound(); }//error 404
            return View(car);
        }

        public IActionResult Delete(int id)//7
        {
            if (id < 0) { return BadRequest(); }//error 400

            cars = new List<Car>(SeedCars.DeleteCar(id));

            return RedirectToAction("Index");
        }
    }
}
