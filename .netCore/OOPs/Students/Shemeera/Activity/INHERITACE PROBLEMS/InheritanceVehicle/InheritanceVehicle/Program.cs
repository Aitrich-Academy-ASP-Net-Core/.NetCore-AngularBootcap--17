using InheritanceVehicle;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car(60,"bmw","aaa",1970);
        car.DisplayDetails();
    }
}