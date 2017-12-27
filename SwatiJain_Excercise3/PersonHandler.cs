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

        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }
    }
}
