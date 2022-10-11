using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinarian
{
    internal class Horse : Animal
    {
        protected string _food = "Apple";
        protected string _location = "Barn";
        public override void Eat()
        {
            
        }

        public override void GetInfo()
        {
            Console.WriteLine("Лошадь");
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
