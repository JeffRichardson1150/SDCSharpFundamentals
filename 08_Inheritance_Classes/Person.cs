using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes
{
    // Parent class - all things in common with customer and employee
    public class Person
    {
        // Name as a whole
        // public string Name { get; set; }

        // change the property Name to separate First vs Last
        // _firstName and _lastName are private "backing fields". Since they are private, they're only available within this Class (not outside)
        private string _firstName;
        private string _lastName;
        public string Name
        {
            get
            {
                string fullName = $"{_firstName} {_lastName}";
                return (!string.IsNullOrEmpty(fullName)) ? fullName : "Unnamed";
            }
        }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        // class methods
        // the property of Name gets set by the 2 private strings in the get of Name
        // these methods set the "backing fields" (_firstName & _lastName) for Name 
        public void SetFirstName(string name)
        {
            _firstName = name;
        }
        public void SetLastName(string name)
        {
            _lastName = name;
        }
    }
}
