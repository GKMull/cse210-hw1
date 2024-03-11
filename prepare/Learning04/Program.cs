using System;
using System.IO.Pipes;

class Program
{
 
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Student student = new Student("id1", "john", "Comp sci");
        Faculty faculty = new Faculty("id2", "pro mack", "Bio");

        student.Display();
        faculty.Display();

        List<Person> people = new List<Person>();
        people.Add(student);
        people.Add(faculty);

        foreach (Person person in people) 
        {

        }
    
    }
}
class Person{
    public string id;
    public string name;

    public Person(string id, string name) {
        this.id = id;
        this.name = name;
    }
}

class Student: Person {
    public string major;

    public Student(string id, string name, string major) : base(id, name) {

        this.major = major;
    }

    public void Display()
    {
        Console.WriteLine($"Student: {name} (ID: {id}), Major: {major}");
    }
}


class Faculty : Person
{
    public Faculty(string id, string name, string major) : base(id, name)
    {
        // Faculty doesn't have a major, so no need to set it
    }

    public void Display()
    {
        Console.WriteLine($"Faculty: {name} (ID: {id})");
    }

}






class Vehicle{
    private string make;
    private string model;
    private int miles;

    public Vehicle(string make, string model, int miles){
        this.make = make;
        this.model = model;
        this.miles = miles;

    
    }
}
class Car : Vehicle {
    private int towing;

    public Car(string make, string model, int miles) : base(make, model, miles) {

    }
}

class Truck : Vehicle {
    private int towing;

    public Truck(string make, string model, int miles, int towing) : base(make, model, miles) {
        this.towing = towing;
    }
}