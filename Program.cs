namespace Cars_and_Used_Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to Honest Frank's Shitbox Emporium!");
            Console.WriteLine("Here's our inventory of \"quality\" vehicles:");
            Console.WriteLine();
            try
            {
                GetInventory();
                Car.ListCars();
                SelectCar();
            }
            finally
            {
                Console.WriteLine("Enjoy your new/used shitbox!");
                Console.WriteLine("We'll see you again soon!");
            }




        }

        static void GetInventory()
        {
            Car carOne = new Car("Ford", "F150", 2023, 80_000);
            Car carTwo = new Car("Dodge", "Ram", 2023, 100_000);
            Car carThree = new Car("Maserati", "Gran Turismo", 2023, 300_000);

            UsedCar usedCarOne = new UsedCar("Kia", "Sorento", 2013, 40_000, 150_000);
            UsedCar usedCarTwo = new UsedCar("Chrysler", "Town & Country", 2020, 80_000, 20_000);
            UsedCar usedCarThree = new UsedCar("Nissan", "Altima", 2021, 60_000, 10_000);

            Car.carInventory.Add(carOne);
            Car.carInventory.Add(carTwo);
            Car.carInventory.Add(carThree);
            Car.carInventory.Add(usedCarOne);
            Car.carInventory.Add(usedCarTwo);
            Car.carInventory.Add(usedCarThree);
        }

        static void SelectCar()
        {
            while (true)
            {
                Console.Write("Select one of the mechanically-sound automobiles from the list above (1-6): ");
                var userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int carChoice) && carChoice <=6 && carChoice >0)
                {
                    Console.Clear();
                    Console.WriteLine("Excellent choice! Here's the \"reliable\" vehicle you selected: ");
                    Console.WriteLine();
                    Car.WriteHeader();
                    Console.Write($"{carChoice}. ");
                    Console.WriteLine(Car.Remove(carChoice));
                    Console.WriteLine();
                    Console.WriteLine("And here's a new list of the remaining \"functional\" machines you did not choose:");
                    Console.WriteLine();
                    Car.ListCars();
                    break;
                }
                Console.WriteLine("You're a bit stupid, huh?");
                Console.WriteLine("It's okay. Let's try it again.");
                Console.WriteLine();
            }
        }
    }
}

