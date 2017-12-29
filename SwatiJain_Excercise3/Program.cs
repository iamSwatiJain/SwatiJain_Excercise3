using System;
using System.Collections.Generic;

namespace SwatiJain_Excercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            var ph = new PersonHandler();
            var p = ph.CreatePerson(age: 29, fname: "Swati", lname: "Jain", height: 5.3, weight: 45.1);
            Console.WriteLine($"{p.FName} {p.LName} is {p.Age} years old and has height {p.Height} ft and weight {p.Weight} kg.");
            //ph.SetAge(p, 45);
            //Console.WriteLine("The new age is " + p.Age);
            //Console.WriteLine("The new name: " + p.FName);

            Console.WriteLine();

            //var a = new Dog("Tommy", 6, 40.5, 4);
            //var b = new Flamingo("Flamingo", 2, 5, 10, true);
            //var s = new Swan("Swan", 3, 4, 15, true);

            //var Animals = new List<Animal>();
            //Animals.Add(a);
            //Animals.Add(b);
            //Animals.Add(s);

            var Animals = new List<Animal>
            {
                new Dog("Tommy", 6, 40.5, 4),
                new Flamingo("Flamingo", 2, 5, 10, true),
                new Swan("Swan", 3, 4, 15, true)
            };

            foreach (var animal in Animals)
            {
                Console.WriteLine(animal.Stats());

                if (animal is Dog) // animal is Dog means animal is instance of Dog.
                {
                    Console.WriteLine((animal as Dog).GetString()); // animal as Dog means typecast animal as type Dog. Then method GetString is invoked on instance of Dog.
                }
            }
            // Only the unique attributes are called from derived/inherited class and the rest are invoked from the base classes.

            var d = new Dog();
            // Dog d = new Bird(); 
            //Q: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
            //A: Cannot implicitly converet Bird to Dog
            //Q: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
            //A: Animal
            //Q: Kommer du åt den metoden från Animals listan? Varför inte?
            //A: Because the GetString method belongs to dog only and not to Animal class so can't invoke it on all Animal objects.

            Console.WriteLine();

            var errors = new List<UserError>
            {
                new NumericInputError(),
                new TextInputError(),
                new NegativeInputError(),
                new DateInputError(),
                new TimeInputError()
            };

            foreach (var error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }

            // Q: Varför är polymorfism viktigt att behärska?
            // A: It reduces rework and makes re-use of code possible.
            // Q: Hur kan polymorfism förändra och förbättra kod via en bra struktur?
            // A: Easy to understand the relations between objects and helps to maintain a common structure between objects. Inherited objects can be treated as parent object.
            // Q: Vad är det för en skillnad på en Abstrakt klass och ett Interface?
            // A: A class can inherit only 1 abstract class but multiple interfaces.

            Console.ReadKey();
        }
    }
}
