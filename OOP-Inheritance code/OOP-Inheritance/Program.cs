using Inheritance_Encapsulation.data;
using Inheritance_Encapsulation.Models;
using System;
using System.Reflection;

namespace Inheritance_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.name = "Orxan";

            // set and get with reflection for private fields

            //typeof(Person).GetField("surname", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(person, "Akbarov");
            //var personSurname = typeof(Person).GetField("surname", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(person);

            //Car car = new Car();
            //car.HorsePower = 120;
            //Console.WriteLine(car.HorsePower);

            //Animal animal = new Animal();

            //Context context = new Context();

            
        }
    }
    class Person
    {
        public string name;
        private string _surname;
        protected int _age;
        public string Address { get; set; }

    }

    class Student
    {
        
    }

    class Teacher:Person
    {
        public decimal salary;
        public Teacher(int number)
        {
            
        }
    }

    class Car
    {
        public string brand;
        private int _horsepower;

        public readonly int speed;

        //public string color { get; private set; }
        public Car()
        {
            speed = 500;
        }

        public int HorsePower 
        {
            get
            {
                if (_horsepower < 150)
                {
                    Console.WriteLine("can't drive");
                    return -1;
                }
                return _horsepower;
            }
            set
            {
                if (value < 100)
                {
                    Console.WriteLine("Please set correct power");
                    return;
                }
                _horsepower = value;
            }
        }
    }
}
namespace Inheritance_Encapsulation.Models
{

    class Animal
    {
        public string Name { get; set; }

        public string Color { get; set; }
    }
}
namespace Inheritance_Encapsulation.data
{
    class Context
    {
        public int Id { get; set; }
    }
}


    
