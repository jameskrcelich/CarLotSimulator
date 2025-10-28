using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        public class Car
        {
            public Car() // Default Constructor
            {
            }
            
            // Custom Constructor
            public Car(int year, string make, string model, bool isDrivable)
            {
                Year = year;
                Make = make;
                Model = model;
                IsDrivable = isDrivable;
            }

            public int Year; // Property		
            public string Make { get; set; } // Property
            public string Model { get; set; } // Property
            public string EngineNoise { get; set; } // Property
            public string HonkNoise { get; set; } // Property
            public bool IsDrivable;

            public void MakeEngineNoise(string engineNoise)
            {
                EngineNoise = engineNoise;
            }

            public void MakeHonkNoise(string honkNoise)
            {
                HonkNoise = honkNoise;
            }
        }

        public class CarLot
        {
            public List<Car> ParkingLot { get; set; } = new List<Car>();

            public void PrintCars()
            {
                foreach (var car in ParkingLot)
                {
                    Console.WriteLine($"{car.Year} {car.Make} {car.Model}");   
                }
            }
        }

        static void Main(string[] args)
        {
            //TODO
            CarLot carLotA = new CarLot();

            //Create a separate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            //Now that the Car class is created we can instantiate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car myFirstCar = new Car();

            myFirstCar.Year = 1969;
            myFirstCar.Make = "Chevrolet";
            myFirstCar.Model = "Camaro";
            myFirstCar.MakeEngineNoise("Varoom");
            myFirstCar.MakeHonkNoise("Beep beep");
            myFirstCar.IsDrivable = false;
            
            carLotA.ParkingLot.Add(myFirstCar);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            Car mySecondCar = new Car()
            {
                Year = 1989,
                Make = "Pontiac",
                Model = "Grand Prix",
                IsDrivable = true
            };
            mySecondCar.MakeEngineNoise("Varoom");
            mySecondCar.MakeHonkNoise("Beep beep");

            carLotA.ParkingLot.Add(mySecondCar);

            Car myThirdCar = new Car(2025, "Toyota", "Corolla", true);
            myThirdCar.MakeEngineNoise("Varoom");
            myThirdCar.MakeHonkNoise("Beep beep");

            Console.Write($"First car  = {myFirstCar.Year} {myFirstCar.Make} {myFirstCar.Model}");
            Console.WriteLine($" {myFirstCar.EngineNoise} {myFirstCar.HonkNoise} {myFirstCar.IsDrivable}");
            Console.Write($"Second car = {mySecondCar.Year} {mySecondCar.Make} {mySecondCar.Model}");
            Console.WriteLine($" {mySecondCar.EngineNoise} {mySecondCar.HonkNoise} {mySecondCar.IsDrivable}");
            Console.Write($"Third car  = {myThirdCar.Year} {myThirdCar.Make} {myThirdCar.Model}");
            Console.WriteLine($" {myThirdCar.EngineNoise} {myThirdCar.HonkNoise} {myThirdCar.IsDrivable}");

            carLotA.ParkingLot.Add(myThirdCar);

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            carLotA.PrintCars();
        }
        
    }
}