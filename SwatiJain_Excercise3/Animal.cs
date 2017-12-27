using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwatiJain_Excercise3
{
    class Animal
    {
        public String name;
        public int age;
        public double weight;

        internal Animal() {}

        internal Animal(String name,int age,double weight) {
            this.name = name;
            this.age = age;
            this.weight = weight;
        }

        public virtual String Stats() => name + " is " + age + " years old and has weight " + weight+" kg";

    }

    class Dog : Animal
    {
        int noOfLimbs;

        internal Dog() { }
        
        internal Dog(String name, int age, double weight, int noOfLimbs)
        {
            base.name = name;
            base.age = age;
            base.weight = weight;
            this.noOfLimbs = noOfLimbs;
        }

        public override String Stats()
        {
            return base.Stats() + " and has " + noOfLimbs +" limbs.";
        }
    }

    class Bird : Animal
    {
        public double wingSpan;

        internal Bird() {}

        internal Bird(String name, int age, double weight, double wingSpan)
        {
            base.name = name;
            base.age = age;
            base.weight = weight;
            this.wingSpan = wingSpan;
        }

        public override String Stats()
        {
            return base.Stats() + " and has a wing span of " + wingSpan+" cm";
        }
    }

    class Pelican : Bird
    {
        bool hasThroatPouch;

        internal Pelican() { }

        internal Pelican(String name, int age, double weight, double wingspan, bool hasThroatPouch)
        {
            base.name = name;
            base.age = age;
            base.weight = weight;
            base.wingSpan = wingspan;
            this.hasThroatPouch = hasThroatPouch;
        }

        public override String Stats()
        {
            return base.Stats()+". Has Throat Pouch : " + hasThroatPouch;
        }
    }

    class Flamingo : Bird
    {
        bool isPink;

        internal Flamingo() { }

        internal Flamingo(String name, int age, double weight, double wingspan, bool isPink)
        {
            base.name = name;
            base.age = age;
            base.weight = weight;
            base.wingSpan = wingspan;
            this.isPink = isPink;
        }
        
        public override String Stats()
        {
            return base.Stats()+". Is Pink: "+ isPink;
        }
    }

    class Swan : Bird
    {
       bool isHerbivorous;

        internal Swan() { }

        internal Swan(String name, int age, double weight, double wingspan, bool isHerbivorous)
        {
            base.name = name;
            base.age = age;
            base.weight = weight;
            base.wingSpan = wingspan;
            this.isHerbivorous = isHerbivorous;
        }

        public override String Stats()
        {
            return base.Stats() +". Is Herbivorous: "+ isHerbivorous;
        }
    }
    //Q: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
    //A: class Bird
    //Q: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
    //A: class Animal
}
