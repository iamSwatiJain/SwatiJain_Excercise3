using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwatiJain_Excercise3
{
    class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person p = new Person
            {
                Age = age,
                FName = fname,
                LName = lname,
                Height = height,
                Weight = weight
            };
            return p;
        }
    }
}
