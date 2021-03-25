using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public bool IsColdBlooded { get; set; }
        public bool HasLegs { get; set; }
        public bool HasScales { get; set; }
        public string Environment { get; set; }
    }
}
