using System;
using System.Collections.Generic;
using _08_Inheritance_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Inheritance_Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void SetName_ShouldSetCorrectly()
        {
            Person martha = new Person();
            martha.PhoneNumber = "8675309";

            Person stanley = new Person
            {
                PhoneNumber = "8675309",
                Email = "stanley@gmail.com",
            };

            Customer bob = new Customer();
            bob.PhoneNumber = "800-555-1234";

            Employee ted = new SalaryEmployee
            {
                PhoneNumber = "fakeNumber",
                Salary = 120000,
                HireDate = new DateTime(1304, 01, 01),
        };
            Console.WriteLine(ted.YearsWithCompany);
        }

        [TestMethod]
        public void CustomerIsPremium_ShouldGetCorrectBool()
        {
            Customer firstCustomer = new Customer();
            firstCustomer.IsPremium = true;
            Person newPerson = new Person();

            Console.WriteLine(newPerson.GetType());
            Console.WriteLine(firstCustomer.GetType());
            Assert.IsTrue(firstCustomer.IsPremium);
        }

        [TestMethod]
        public void EmployeeTests()
        {
            Employee jarvis = new Employee();
            HourlyEmployee tony = new HourlyEmployee();
            SalaryEmployee pepper = new SalaryEmployee();

            tony.HoursWorked = 55;
            tony.HourlyWage = 9003;
            pepper.Salary = 2000000;

            // Since all above types inherit from type Employee, they can be treated as Employee and added to the List of Employees.  However, we can only access 
            List<Employee> allEmployees = new List<Employee>();
            allEmployees.Add(jarvis);
            allEmployees.Add(tony);
            allEmployees.Add(pepper);
            // because of the set methods, I can't assign a string directly to Name
            //tony.Name = "Tony Stark";
            tony.SetFirstName("Tony");
            tony.SetLastName("Stark");

            foreach(Employee worker in allEmployees)
            {
                if(worker.GetType() == typeof(SalaryEmployee))
                {
                    // cast the employees in the Employee List as SalaryEmployee
                    SalaryEmployee sEmployee = (SalaryEmployee)worker;
                    // this won't work because Employee List is only Employee (no Salary exists)
                    // Console.WriteLine($"This is a salary employee that makes {worker.Salary}");
                    Console.WriteLine($"This is a salary employee that makes {sEmployee.Salary}");
                }
                // Pattern Matching
                // turn worker into Hourly worker and create a new variable in the if statement.
                // hourlyWorker is HourlyEmployee type
                else if (worker is HourlyEmployee hourlyWorker) // pattern matching
                {
                    // HourlyEmployee hEmployee = (HourlyEmployee)hourlyWorker;
                    // Console.WriteLine($"{worker.Name} has worked {hEmployee.HoursWorked} hours!");

                    Console.WriteLine($"{worker.Name} has worked {hourlyWorker.HoursWorked} hours!");
                }
            }

        }
    }
}
