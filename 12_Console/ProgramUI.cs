using _12_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Console
{
    public class ProgramUI
    {
        public void Run()
        {
            Person personOne = new Person();
            personOne.Name = "Jeff";
            personOne.Age = 10;
            personOne.IsMarried = true;

            Person personTwo = new Person("Christa", 11, true);
            Console.WriteLine(personTwo.IsMarried);
            

            PersonRepository _repo = new PersonRepository();
            _repo.AddPerson(personOne);
            _repo.AddPerson(personTwo);

             List<Person> localList = _repo.ReturnList();

            int number = localList.Count();
            Console.WriteLine(number);
            Console.ReadKey();








        }
       
    }
}
