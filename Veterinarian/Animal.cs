using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinarian
{
    abstract class Animal
    {
        protected string _food;
        protected string _location;
        protected string _breed;
        protected string _name;
        protected string _color;

        public abstract void MakeNoise();
        public abstract void Eat();
        public abstract void Sleep();
        public abstract void GetInfo();
    }
}
