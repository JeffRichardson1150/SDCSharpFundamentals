using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Classes
{
    public class PersonRepository
    {
        // A new instance - the list is empty. The list may only hold items of type Person
        // '_' signifies this is a "field" - it will be used throughout the program. It doesn't affect it's function.  Like div / section / etc in HTML
        // Declare the list at the top of the repository; we'll use the list in all our methods in the PersonRepository class. (it's "global")
        List<Person> _listOfPeople = new List<Person>();

        public void AddPerson(Person x)
        {
            _listOfPeople.Add(x);
        }

        public void RemovePerson(Person y)
        {
            _listOfPeople.Remove(y);
        }

        public List<Person> ReturnList()
        {
            return _listOfPeople; 
        }
    }
}
