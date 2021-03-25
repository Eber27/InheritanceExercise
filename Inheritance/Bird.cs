using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public bool FlyorNot { get; set; }
        public string Type { get; set; }
        public bool HasFeathers { get; set; }
        public int Wings { get; set; }

    }
}
