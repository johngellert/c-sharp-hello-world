﻿using System;

namespace HelloWorld
{
    public class Person
    {
        public Person()
        {

        }

        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + firstName + " " + lastName);
        }
    }
}
