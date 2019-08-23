using System;
namespace HelloWorld.Vehicles
{
    public class Car
    {
        public Car()
        {
        }

        public string year;
        public string make;
        public string model;

        public void Description ()
        {
            Console.WriteLine("My car is a " + year + " " + make + " " + model);
        }
        
    }
}
