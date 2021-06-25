using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            Car car1 = new Car(2012, "Jeep", "Liberty", "Vroom", "Beep", true);

            Car car2 = new Car()
            {
                Year = 2007,
                Make = "Mercury",
                Model = "Montego",
                EngineNoise = "groan",
                HonkNoise = "boop",
                IsDrivable = false
            };

            Car car3 = new Car();
            car3.Year = 2009;
            car3.Make = "Nissan";
            car3.Model = "Altima";
            car3.EngineNoise = "click click click";
            car3.HonkNoise = "BEEEEEEP";
            car3.IsDrivable = true;


            CarLot carLot = new CarLot();
            carLot.ParkingLot.Add(car1);
            carLot.ParkingLot.Add(car2);
            carLot.ParkingLot.Add(car3);


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var car in carLot.ParkingLot)
            {
                Console.WriteLine(car.Year);
                Console.WriteLine(car.Make);
                Console.WriteLine(car.Model);
                Console.WriteLine(car.EngineNoise);
                Console.WriteLine(car.HonkNoise);
                Console.WriteLine(car.IsDrivable);
            }
        }
    }
}
