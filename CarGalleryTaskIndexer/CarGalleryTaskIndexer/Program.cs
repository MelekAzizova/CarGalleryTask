using CarGalleryTaskIndexer.Models;

namespace CarGalleryTaskIndexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gallery gallery1 = new Gallery();
            gallery1.Name="BMW"; 
            
            Car car1 = new Car();
            car1.Name = "Bmw";

            Car car2 = new Car();
            car2.Name = "Lexus";


            gallery1.AddCar(car1);
            gallery1.AddCar(car2);
            Console.WriteLine(gallery1["Merc"]);
            foreach (Car car in gallery1.cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}