using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Classes
{
    [TestClass]
    public class ClassTests
    {
        [TestMethod]
        public void VehiclePropertyTests()
        {
            Vehicle firstVehicle = new Vehicle();
            firstVehicle.Color = "Blue";
            Console.WriteLine(firstVehicle.Color);
            firstVehicle.Make = "Cadillac";
            firstVehicle.Model = "DTS";
            firstVehicle.Mileage = 7;
            firstVehicle.Year = 2018;
            firstVehicle.TypeOfVehicle = VehicleType.Car;

            string carDetails = $"{firstVehicle.Make} {firstVehicle.Color}";

            Console.WriteLine(carDetails);

            Vehicle myVehicle = new Vehicle();
            myVehicle.Year = 2025;

            Vehicle rocket = new Vehicle("SpaceX", "Falcon Heavy", 2015, 90000, "Space Gray", VehicleType.Spaceship);
        }

        // testm <tab> <tab> - create a new TestMethod
        [TestMethod]
        public void PersonTests()
        {
            Person personTwo = new Person("Appa", "YipYp", new DateTime(1805,06,11));
            Console.WriteLine(personTwo.AgeInYears); ;
            Console.WriteLine(personTwo.FullName);

            Person newPerson = new Person("Zuko", "FireLord", DateTime(1990, 06, 22));
            newPerson.Transport = new Vehicle("Pontiac", "Firebird", 1989, 100123, "Red & Gold", VehicleType.Car);
            Console.WriteLine(newPerson.Transport.Model);

            // The point of Unit Test Assemblies is to test the code you've written. A big part is the Assert.  Rather than - Run a test, Open Output, ... , with the Assert, we can run it and the green check will tell X amount of tests passed (in the Test Explorer)
            // Here, we're confirming the FullName has been created properly from the data I provided.
            Assert.AreEqual("Zuko FireLord", newPerson.FullName);
        }
    }
}
