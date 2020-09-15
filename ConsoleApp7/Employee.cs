using System;

namespace ConsoleApp7
{
    public class Employee
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int HourlySalary { get; set; }

        public string StreetAddress { get; private set; }
        public int PostalCode { get; private set; }
        public string City { get; private set; }

        public Employee(DateTime birthDate, int hourlySalary)
        {
            BirthDate = birthDate;
            HourlySalary = hourlySalary;
        }

        public void ChangeAddress(string streetAddress, int postalCode, string city)
        {
            StreetAddress = streetAddress;
            PostalCode = postalCode;
            City = city;
            //SendMail
        }

        public decimal CalculateSalary(int hours)
        {
            if (BirthDate.Year < 1973)
                hours = hours + 10;
            return hours * HourlySalary;
        }
    }
}