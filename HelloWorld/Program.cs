using System;
using HelloWorld.Vehicles;

namespace HelloWorld
{
    //// defineing a class
    //public class Person
    //{
    //    public string firstName;
    //    public string lastName;

    //    public void Introduce()
    //    {
    //        Console.WriteLine("My name is " + firstName + " " + lastName);
    //    }

    //}

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


            // looking at type conversion

            // this is implicit type conversion
            // because a byte is smaller than an int, ther would be no data loss
            // by converting the types so this can be implicitly converted
            byte b = 1; //                            00000001 one byte or 8 bits
            int i = b;  // 00000000 00000000 00000000 00000001 4 bytes or 32 bits

            Console.WriteLine(i);

            // here we get an error at complie time because there is a chance of data loss.
            // cannot implicitly convert int to byte
            // in this case there would not be data loss, but the compiler will not do this
            // without being told. Must use explicit type conversion or casting
            //int integer = 1;  // 00000000 00000000 00000000 00000001 4 bytes or 32 bits
            //byte by = integer;//                            00000001 one byte or 8 bits

            // not data loss but cast required
            int x = 2;  // 00000000 00000000 00000001 00000010 4 bytes or 32 bits
            byte y = (byte) x;//                      00000010 one byte or 8 bits

            Console.WriteLine(y);

            // data loss with cast brcause 300 takes more than 1 byte or 8 bits
            // some of the bits are lost so s does not output 300 it outputs 44
            int r = 300; // 00000000 00000000 00000001 00101100 4 bytes or 32 bits
            byte s = (byte) r;

            Console.WriteLine(s);

            // non-compatible types
            // error, cannot implicitly convert type string to int
            string numberOne = "6";
            //int v = numberOne;
            //int q = (int) numberOne; // cannot explicitly convert either

            // need to use Convert class.
            int v = Convert.ToInt32(numberOne); // convert will list the .NET equivilant to the C# type
            // here C# int type is mapped to .NET Int32 type. 

            Console.WriteLine(v);



            Console.WriteLine("operators");

            int a = 10;
            int c = 3;
            Console.WriteLine(a / c); // will output 3 becuase a and be are integers

            // if I need a floating piont number, I need to cast a and c to a floating point number
            // before the operation
            Console.WriteLine((double)a / (double)c);

            Person john = new Person();

            john.firstName = "John"; // assinging value to objects firstName field
            john.lastName = "Smith"; // assigning value to objects lastName field
            john.Introduce(); // calling the introduce method


            Car johnsCar = new Car();
            johnsCar.year = "1997";
            johnsCar.make = "Chevy";
            johnsCar.model = "K1500";

            johnsCar.Description(); 

        }
    }
}