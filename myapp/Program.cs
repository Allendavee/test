
using System;
using System.IO;

namespace Program
{
    class Vehicle
    {
        public string type = "Mercedes";

        public virtual void honk()
        {
            Console.WriteLine("Tuk Tuk");
        }
    }

    class Truck : Vehicle
    {
        public string modelName = "Benz";

        public override void honk()
        {
            base.honk();
            Console.WriteLine("Pim Pim");
        }
    }
    class Trucks : Vehicle
    {
        public string modelName = "Mustang";

        public override void honk()
        {
            base.honk();
            Console.WriteLine("Scru Scru");
        }
    }
    public class Car
    {
        public string model;
        public string color;
        public int year;

        public void fullInfo()
        {
            Console.WriteLine("The car is going really fast");
        }

        public Car(string carModel, string carColor, int carYear)
        {
            color = carColor;
            model = carModel;
            year = carYear;
        }
    }

    // Abstract Classes and Methods
    abstract class Animals
    {
        public abstract void animalSound();

        public void animalSleep()
        {
            Console.WriteLine("Zzzz");
        }
    }

    class Pig : Animals
    {
        public override void animalSound()
        {
            Console.WriteLine("Fin fin");
        }
    }
    class Helloworld
    {

        static void AddNum(int x, int y)
        {
            int z = x + y;
            Console.WriteLine(z);
        }
        static void Main(String[] args)
        {
            // string name;
            // Console.WriteLine("Hello World!");
            // Console.WriteLine("Enter your name: ");
            // name = Console.ReadLine();
            // if ( name.Length == 5 )
            // {
            //     Console.WriteLine("The number of Letters in your name is equal to 5");
            //     Console.WriteLine("Welcome: " + name);
            // }
            // else
            // {
            //     Console.WriteLine("Enter a name not longer more than 5 letters ");
            // }

            // AddNum(25, 40);

            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("filename.txt", writeText);

            string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the content

            Car Ford = new Car("Mustang", "Red", 2022);

            Car Toyota = new Car("Toyota", "Camry", 2022);

            Car Tesla = new Car("Tesla", "Model S", 2022);

            Console.WriteLine(Ford.model + " " + " " + Ford.color + " "+ Ford.year);

            Vehicle myObj2 = new Vehicle();
            Vehicle myObj3 = new Trucks();

            Truck myObj = new Truck();

            myObj.honk();
            myObj2.honk();
            myObj3.honk();
            Console.WriteLine(myObj.type + " " + myObj.modelName);

            Pig piglet = new Pig();

            piglet.animalSleep();
            piglet.animalSound();
// Try Catch error handling.....
            try
            {
                int[] number = {1, 2, 3, 4, 5};
                Console.WriteLine(number[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The try catch has completed ");
            }


            


        }
    }
}