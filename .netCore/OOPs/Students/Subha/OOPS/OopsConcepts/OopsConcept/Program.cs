using OopsConcept;
using System;
namespace OOPsConcept
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Dog d=new Dog();
            Pug p=new Pug();
            Cat c = new Cat();
            d.breed = "Pomeranian";
            d.name = "Dog";
            p.color = "White";
            c.name = "Persian Cat";
            string messageParent = "Parent class method";
            string messageChild = "Child class method";
            
            d.displayAnimal(messageParent);

            d.displayAnimal(messageParent);

            d.displayDog(messageChild);
            p.displayPug(messageChild);
            c.displayCat(messageChild);

                
        }
    }
}