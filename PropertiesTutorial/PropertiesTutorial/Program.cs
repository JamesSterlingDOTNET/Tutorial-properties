using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Name = "Steve";
            human.Age = 49;
            human.City = "Washington DC";
            human.SSN = 6416461241;
            Console.WriteLine("Name: " + human.Name + ". Age: " + human.Age + ". Lives in: " + human.City + ". SSN: " + human.SSN);

            Animal anim = new Animal(10, "WOOF WOOF", "Dog");
            Console.WriteLine("His age: " + anim.Age + ". Sounds like: " + anim.Sound + ". Is a: " + anim.AnimalType);
            Console.ReadLine();
        }
    }
}
