using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinarian
{
    internal class Veterinarians
    {

        public void TreateAnimal(Animal animal)
        {
            animal.GetInfo();
            Console.WriteLine("Животное принято на приём...");
            Console.WriteLine();
        }
    }
}
