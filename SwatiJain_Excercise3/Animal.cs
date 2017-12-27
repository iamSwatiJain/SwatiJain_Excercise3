using System;

namespace SwatiJain_Excercise3
{
    public class Animal
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public double Weight;

        internal Animal() {}

        internal Animal(String name,int age,double weight) {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public virtual String Stats() => Name + " is " + Age + " years old and has weight " + Weight+" kg";

    }

    public class Dog : Animal
    {
        public int NoOfLimbs { get; set; }

        internal Dog() { }
        
        internal Dog(String name, int age, double weight, int noOfLimbs)
        {
            Name = name;
            Age = age;
            Weight = weight;
            NoOfLimbs = noOfLimbs;
        }

        public override String Stats()
        {
            return base.Stats() + " and has " + NoOfLimbs +" limbs.";
        }

        public string GetString() => "valfri sträng"; 
    }

    public class Bird : Animal
    {
        public double WingSpan { get; set; }

        internal Bird() {}

        internal Bird(String name, int age, double weight, double wingSpan)
        {
            Name = name;
            Age = age;
            Weight = weight;
            WingSpan = wingSpan;
        }

        public override String Stats()
        {
            return base.Stats() + " and has a wing span of " + WingSpan+" cm";
        }
    }

    public class Pelican : Bird
    {
        public bool HasThroatPouch { get; set; }

        internal Pelican() { }

        internal Pelican(String name, int age, double weight, double wingspan, bool hasThroatPouch)
        {
            Name = name;
            Age = age;
            Weight = weight;
            WingSpan = wingspan;
            HasThroatPouch = hasThroatPouch;
        }

        public override String Stats()
        {
            return base.Stats()+". Has Throat Pouch : " + HasThroatPouch;
        }
    }

    public class Flamingo : Bird
    {
        public bool IsPink { get; set; }

        internal Flamingo() { }

        internal Flamingo(String name, int age, double weight, double wingspan, bool isPink)
        {
            Name = name;
            Age = age;
            Weight = weight;
            WingSpan = wingspan;
            IsPink = isPink;
        }
        
        public override String Stats()
        {
            return base.Stats()+". Is Pink: "+ IsPink;
        }
    }

    public class Swan : Bird
    {
       public bool IsHerbivorous { get; set; }

        internal Swan() { }

        internal Swan(String name, int age, double weight, double wingspan, bool isHerbivorous)
        {
            Name = name;
            Age = age;
            Weight = weight;
            WingSpan = wingspan;
            IsHerbivorous = isHerbivorous;
        }

        public override String Stats()
        {
            return base.Stats() +". Is Herbivorous: "+ IsHerbivorous;
        }
    }
    //Q: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
    //A: class Bird
    //Q: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
    //A: class Animal
}
