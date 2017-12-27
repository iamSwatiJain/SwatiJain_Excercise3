using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwatiJain_Excercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            PersonHandler ph = new PersonHandler();
            var newPerson = ph.CreatePerson(12, "Swati", "Jain", 5.3, 45.1);
            Console.WriteLine($"{newPerson.FName} {newPerson.LName} is {newPerson.Age} years old and has height {newPerson.Height} and weight {newPerson.Weight}.");
            ph.SetAge(p, 45);
            Console.WriteLine("The new age is "+p.Age);
            Console.WriteLine("The new name: "+p.FName);

            Animal a = new Dog("Dog",6,40.5,4);
            Animal b = new Flamingo("Flamingo",2,5,10,true);
            Animal s = new Swan("Swan",3,4,15,true);
            List<Animal> Animals= new List<Animal>();
            Animals.Add(a);
            Animals.Add(b);
            Animals.Add(s);
            foreach (Animal animal in Animals)
            {
                Console.WriteLine(animal.Stats());
            }
            // Only the unique attributes called from derived/inherited class and the rest are invoked from the base classes.

            Dog d = new Dog();
            // Dog d = new Bird(); 
            //Q: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
            //A: Cannot implicitly converet Bird to Dog
            //Q: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
            //A: Animal



        }
    }
}
