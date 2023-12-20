using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();

            var myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Corolla";
            myCar.Year = 2003;
            myCar.EngineNoise = "vroom";
            myCar.HonkNoise = "...";
            myCar.IsDriveable = true;
            lot.Cars.Add(myCar);

            var previousCar = new Car()
            {
                Make = "Toyota",
                Model = "Tacoma",
                Year = 2001,
                EngineNoise = "vrrroom",
                HonkNoise = "beep",
                IsDriveable = true
            };
            lot.Cars.Add(previousCar);

            var newCar = new Car(2019, "Chevy", "Silverado", "brummMmmMmm", "HOOONK", true);
            lot.Cars.Add(newCar);

            myCar.MakeEngineNoise();
            myCar.MakeHonkNoise();
            previousCar.MakeEngineNoise();
            previousCar.MakeHonkNoise();
            newCar.MakeEngineNoise();
            newCar.MakeHonkNoise();

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }

            Console.WriteLine($"Number of Cars in Car Lot: {CarLot.numberOfCars}");
        }
    }
}
