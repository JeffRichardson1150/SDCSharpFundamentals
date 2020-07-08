using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes.Animals
{
    public enum DietType {  Herbivore=1, Omnivore, Carnivore, Insectivore}
    public class Animal
    // If we declare Animal class as abstract, can't "new it up" in AnimalTest
    //public abstract class Animal
    {
        public int NumberOfLegs { get; set; }
        public bool IsMammal { get; set; }
        public bool HasFur { get; set; }
        public bool IsEndangered { get; set; }
        public DietType TypeOfDiet { get; set; }
        // virtual - can be redefined
        public virtual void Move()
        {
            Console.WriteLine($"This {GetType().Name} moves.");
        }
    }
}
