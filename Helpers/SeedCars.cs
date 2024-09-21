using car_app.Models;

namespace car_app.Helpers
{
    public class SeedCars
    {
        private static List<Car> cars = new List<Car>
        {
            new Car
                {
                    Id = 1,
                    Model = "Tesla Model S",
                    Color = "Black",
                    Year = 2023,
                    ModelType = "Electric",
                    Description = "The Tesla Model S is a luxury all-electric sedan with advanced features like Autopilot and a high range on a single charge."
                },
                new Car
                {
                    Id = 2,
                    Model = "BMW M3",
                    Color = "Blue",
                    Year = 2021,
                    ModelType = "Sedan",
                    Description = "The BMW M3 is a high-performance version of the 3 Series, offering dynamic handling and an aggressive design."
                },
                new Car
                {
                    Id = 3,
                    Model = "Toyota Camry",
                    Color = "White",
                    Year = 2020,
                    ModelType = "Sedan",
                    Description = "The Toyota Camry is a reliable mid-size sedan, known for its fuel efficiency and comfortable ride."
                },
                new Car
                {
                    Id = 4,
                    Model = "Ford Mustang",
                    Color = "Red",
                    Year = 2019,
                    ModelType = "Coupe",
                    Description = "The Ford Mustang is an iconic American muscle car, offering powerful performance and a bold design."
                },
                new Car
                {
                    Id = 5,
                    Model = "Audi Q7",
                    Color = "Silver",
                    Year = 2022,
                    ModelType = "SUV",
                    Description = "The Audi Q7 is a luxury SUV with spacious seating, advanced technology, and excellent all-wheel drive performance."
                },
                new Car
                {
                    Id = 6,
                    Model = "Porsche 911",
                    Color = "Yellow",
                    Year = 2023,
                    ModelType = "Sports",
                    Description = "The Porsche 911 is a world-class sports car, known for its iconic design, superb handling, and high-speed capabilities."
                }
        };
        public static IEnumerable<Car> GetSeedCars()
        {
            return cars;
        }

        public static List<Car> DeleteCar(int id)
        {
            var car = cars.FirstOrDefault(c => c.Id == id);
            if (car != null)
            {
                cars.Remove(car);
                return cars; 
            }
            return cars; 
        }
    }
}
