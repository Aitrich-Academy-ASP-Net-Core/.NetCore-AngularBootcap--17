using InheritanceAnimal;

internal class Program
{
    private static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.MakeSound(); 
       Dog dog = new Dog();
        dog.MakeSound();
    }
}