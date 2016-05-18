using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesTutorial
{
    public class Animal
    {
        public int Age { get; set; }
        public string Sound { get; set; }
        public string AnimalType { get; set; }

        public Animal(int age, string sound, string animalType)
        {
            this.Age = age;
            this.Sound = sound;
            this.AnimalType = animalType;
        }
    }
}
