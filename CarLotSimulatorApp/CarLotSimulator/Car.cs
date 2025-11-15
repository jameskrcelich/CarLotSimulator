namespace CarLotSimulator;

public class Car
{
    public Car()  // Default Constructor
    {
        CarLot.numOfCars++;
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