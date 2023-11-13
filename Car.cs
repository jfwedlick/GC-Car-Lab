using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_and_Used_Cars
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
            Make = "0";
            Model = "0";
            Year = 0; 
            Price = 0;
        }

        public Car(string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        public static List<Car> carInventory = new List<Car>();

        public override string ToString()
        {
            string carDetails = $"{Make,-20}{Model,-20}{Year,4}{" ",-21}${Price,-20}{"N/A",-20}\n";
            return carDetails;
        }

        public static void ListCars()
        {
            WriteHeader();
            int idx = 1;

            foreach (Car car in Car.carInventory)
            {
                string cardetails = car.ToString();
                Console.WriteLine($"{idx}. {cardetails}");
                idx++;
            }
        }

        public static string Remove(int carChoice)
        {
            string chosenCar = carInventory.ElementAt(carChoice - 1).ToString();
            carInventory.RemoveAt(carChoice - 1);
            return chosenCar;
        }

        public static void WriteHeader()
        {
            var header = String.Format("{0,-23}{1,-20}{2,-25}{3,-20}{4,-20}\n",
            "Make", "Model", "Year", "Price", "Miles");

            Console.WriteLine(header);
            Console.WriteLine(new string('=', 100));
        }
    }

}
