using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceVehicle
{
    internal class Car:Vehicle
    {
        public string CarModel;
        public string CarName;
        public int Year;

        public Car(int speed ,string carmodel,string carname,int year):base (speed)
        {
            CarModel = carmodel;
            CarName = carname;
            Year = year;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Car model is {CarModel} \n Car Name is  {CarName} \n  Year is {Year}  \n speed was {Speed} per hour");


        }



    }
}
