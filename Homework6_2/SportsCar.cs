using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6_2
{
    public class SportsCar : Car
    {
        public SportsCar() { }

        public SportsCar(string name, short maxSpeed, short currentSpeed)
            : base(name, maxSpeed, currentSpeed)
        {
        }

        public override void Acceleration()
        {
            Console.WriteLine("SPORTCAR:  Прискорюється!");
        }
    }

    internal class SecretCar : Car
    {
        public override void Acceleration()
        {
            throw new NotImplementedException();
        }
    }
}
