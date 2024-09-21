namespace car_app.Models
{
    //Об'єкт містить: модель, колір, рік випуску, тип кузова і т.д.
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public string ModelType { get; set; }
        public string Description { get; set; }
    }
}
