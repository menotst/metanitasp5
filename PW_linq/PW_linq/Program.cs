using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PW_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Nissan", "Aston Martin", "Chevrolet", "Alfa Romeo", "Chrysler", "Dodge", "BMW",
                              "Ferrari", "Audi", "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};

            string auto = cars.Where(p=>p.StartsWith("S")).First();
            Console.WriteLine(auto);
            Console.ReadKey();
        }
    }
}