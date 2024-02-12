using System;
using System.Buffers;
using System.Runtime.InteropServices;
using System.Xml.Xsl;
class Program
{
    static void Main(string[] args)
    {   var cars = new List<Car>();


        var car = new Car();
        car.make = "Honda";
        car.model = "Civic";
        car.gallons = 10;
        car.milesPerGallon = 30;
        cars.Add(car);

        var Owner = new Owner();
        Owner.name = "Sus";
        Owner.phone = "322-333";
        car.owner = Owner;

       // var car = new Car("kia", "Soul", 5, 5, owner);
        //cars.Add(car);

        //var car1 = newCar();
        car.make = "Ford";
        car.model = "F-150";
        car.gallons = 30;
        car.milesPerGallon = 5;
        cars.Add(car);

        //var Owner = new Owner();
        Owner.name = "Bob";
        Owner.phone = "333-333";
        car.owner = Owner;

        foreach (var c in cars){
            //System.Console.WriteLine($"{c.make} {c.model}: Range= {c.gallons * c.milesPerGallon}");
            c.Display();
            int range = c.TotalRange();
        }
        
    }
}


public class Car {
    public int milesPerGallon;
    public int gallons;
    public string make;
    public string model;
    public Owner owner;

    public int TotalRange() {
        return gallons * milesPerGallon;
    }

    public void Display(){
        System.Console.WriteLine($"{make} {model} {owner.name}: Range= {TotalRange()}");
    }
}
public class Owner {
    public string name;
    public string phone;
}
