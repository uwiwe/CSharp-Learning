﻿using System;

namespace HelloWorld
{
    /*class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Type your username and press enter
            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display
            Console.WriteLine("Username is: " + userName);

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);

            for (int d = 0; d < 5; d++)
            { 
                Console.WriteLine("Yes"); 
            }

        }
    }*/

    class Car
    {
        string model;
        string color;
        int year;

        static void CreateCarsAndPrintModels(string[] args)
        {
            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
        }
    }
}