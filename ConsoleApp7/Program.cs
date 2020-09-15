using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee(new DateTime(1972,8,3),123  );
            employee.Name = "Stefan Holmberg";
            decimal d = employee.CalculateSalary(20);


            Employee employee2 = new Employee(new DateTime(2002, 3, 30),500);
            employee2.Name = "Josefine Holmberg";
            d = employee2.CalculateSalary(20);

            Console.WriteLine("Hello World!");


            //Input
            var newStreet = "Hoppgatan 12";
            var newCity = "Nystad";
            int newPostal = 1234;
            employee2.ChangeAddress(newStreet, newPostal,newCity);
            Console.WriteLine(employee2.StreetAddress);

        }
    }
}
