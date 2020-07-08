using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes
{
    public enum VehicleType { Car, Truck, Motorcycle, Spaceship, Plane, Boat, Submarine }
    public class Vehicle
    {
        // Properties : 
        // [Access Modifer] [Type the Property can hold] [Property Name] { [Getters; & Setters;] }
        // prop <tab> <tab>
        public int MyProperty { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        public string Color { get; set; }

        public VehicleType TypeOfVehicle { get; set; }

        // Empty Constructor.  Had to be created so we can create an empty Vehicle object in ClassTests
        public Vehicle() { }

        // Overloaded Constructor. When we create a Vehicle object, we can pass in all the parameters.
        public Vehicle(string make, string model, int year, double mileage, string color, VehicleType tOV)
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
            Color = color;
            TypeOfVehicle = tOV;
        }
    }

    public class Person
    {
        // Property
        public string FirstName { get; set; }
        // propfull <tab> <tab>
        private string _lastName;

        // Property
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        // Property which can't be set (only a getter) - composed from settable properties
        public string FullName
        { get { return $"{FirstName} {LastName}"; } }

        // Property
        public DateTime DateOfBirth { get; set; }

        // Property which can't be set (only a getter) - composed from settable properties
        public int AgeInYears
        {
            get
            {

                if (DateOfBirth == new DateTime())
                {
                    return 9001;
                }
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                return Convert.ToInt32(Math.Floor(totalAgeInYears));
            }
        }

        // Property - use Vehicle as an object and use it as the transport property of a Person
        public Vehicle Transport { get; set; }

        // Constructor
        public Person(string firstName, string lastName, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = birthday;
        }
    }
}
