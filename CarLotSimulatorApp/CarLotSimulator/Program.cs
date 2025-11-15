using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Car lot object that will hold the list of cars
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
            
            // Add this car to the parking lot.
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

            // add second car to the parking lot
            carLotA.ParkingLot.Add(mySecondCar);

            // instantiate third car with custom constructor
            Car myThirdCar = new Car(2025, "Toyota", "Corolla", true);
            myThirdCar.MakeEngineNoise("Varoom");
            myThirdCar.MakeHonkNoise("Beep beep");

            // add the third car to the parking lot
            carLotA.ParkingLot.Add(myThirdCar);

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instantiate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            
            // iterate through the list of cars in the parking lot and print all the fields for each car
            Console.WriteLine($"Number of Cars in Parking Lot A = {CarLot.numOfCars}");
            foreach (var car in carLotA.ParkingLot)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");  
                Console.WriteLine($"\t Engine noise = {car.EngineNoise}, Car Honk Noise = {car.HonkNoise}, Is Drivable = {car.IsDrivable}");
            }
            
        }
        
    }
}