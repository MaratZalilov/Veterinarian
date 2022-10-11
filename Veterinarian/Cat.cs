using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinarian
{
    internal class Cat : Animal
    {
        protected string _food = "meat";
        protected string _location = "USSR";
        public override void Eat()
        {
            
        }

        public override void MakeNoise()
        {
            
        }

        public override void Sleep()
        {
            
        }

        public override void GetInfo()
        {
            Console.WriteLine("Кошка");
            Console.WriteLine($"Кушает - {_food}");
            Console.WriteLine($"Прибыло из - {_location}");
        }
    }
}
