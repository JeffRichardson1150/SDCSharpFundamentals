using System;
using System.Collections.Generic;
using _12_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _12_TestPerson
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1_AddPerson()
        {
            //AAA

            //Arrange
            PersonRepository _repo = new PersonRepository();
            Person person1 = new Person();

            //Act
            _repo.AddPerson(person1);
            List<Person> localList =_repo.ReturnList();


            //Assert
            int expected = 1;
            int actual = localList.Count;

            Assert.AreEqual(expected, actual);



        }
    }
}
