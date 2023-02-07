namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            var tires = new List<List<Tire>>();
            var engines = new List<Engine>();
            var cars = new List<Car>();

            string input = Console.ReadLine();
            while (input != "No more tires")
            {
                string[] cmdArgs = input.Split(" ");
                tires.Add(new List<Tire>());
                for (int i = 0; i < cmdArgs.Length; i+=2)
                {
                    int year = int.Parse(cmdArgs[0 + i]);
                    double pressure = double.Parse(cmdArgs[1 + i]);

                    tires[tires.Count - 1].Add(new Tire(year, pressure));
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "Engines done")
            {
                string[] cmdArgs = input.Split(" ");
                int horsePower = int.Parse(cmdArgs[0]);
                double cubicCapacity = double.Parse(cmdArgs[1]);
                engines.Add(new Engine(horsePower, cubicCapacity));
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "Show special")
            {
                string[] cmdArgs = input.Split(" ");
                string make = cmdArgs[0];
                string model = cmdArgs[1];
                int year = int.Parse(cmdArgs[2]);
                double fuelQuantity = double.Parse(cmdArgs[3]);
                double fuelConsumption = double.Parse(cmdArgs[4]);
                int engineIndex = int.Parse(cmdArgs[5]);
                int tiresIndex = int.Parse(cmdArgs[6]);

                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex].ToArray()));

                input = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                if(car.Year >= 2017 && car.Engine.HorsePower > 330 && car.Tires.Sum(x => x.Pressure) > 9 && car.Tires.Sum(x => x.Pressure) < 10)
                {
                    car.Drive(20);
                    Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}\nHorsePowers: {car.Engine.HorsePower}\nFuelQuantity: {car.FuelQuantity}");
                }
            }
        }
    }
}