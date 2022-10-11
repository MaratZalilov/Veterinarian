using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinarian
{
    internal class Dog : Animal
    {
        protected string _food = "Chappi";
        protected string _location = "USA";
        public override void Eat()
        {
            
        }

        public override void GetInfo()
        {
            Console.WriteLine("Собака");
            Console.WriteLine($"Кушает - {_food}");
            Console.WriteLine($"Прибыло из - {_location}");
        }

        public override void MakeNoise()
        {
            
        }

        public override void Sleep()
        {
            
        }
    }
}
