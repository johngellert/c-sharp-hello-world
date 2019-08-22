using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            byte number = 3;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "John";
            bool isWorking = true;

            var someNumber = 3;
            var someCount = 10;
            var someTotalPrice = 20.95f;
            var someCharacter = 'A';
            var someFirstName = "John";
            var isWorkingWell = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine(someNumber);
            Console.WriteLine(someCount);
            Console.WriteLine(someTotalPrice);
            Console.WriteLine(someCharacter);
            Console.WriteLine(someFirstName);
            Console.WriteLine(isWorkingWell);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); //  string that can be used as
            // a template, this is called a format string, at run time, the place holders will be replaced
            // with the arguments passed in after the format string.

            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            const float Pi = 3.14f;
        }
    }
}