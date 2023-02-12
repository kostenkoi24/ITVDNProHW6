using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6_2
{
    public class MiniVan : Car
    {
        public MiniVan() { }

        public MiniVan(string name, short maxSpeed, short currentSpeed)
            : base(name, maxSpeed, currentSpeed)
        {
        }

        public override void Acceleration()
        {
            state = EngineState.EngineDead;
            Console.WriteLine("MINIVAN:  Двигун згорів!");
        }
    }
}
