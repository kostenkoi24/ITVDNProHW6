using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6_2
{
    public abstract class Car
    {
        protected string name;
        protected short currentSpeed;
        protected short maxSpeed;
        protected EngineState state;

        protected Car()
        {
            state = EngineState.EngineAlive;
        }

        protected Car(string name, short maxSpeed, short currentSpeed)
            : this()
        {
            this.name = name;
            this.maxSpeed = maxSpeed;
            this.currentSpeed = currentSpeed;
        }


        public abstract void Acceleration();

        public void Driver(string name, int age)
        {
            Console.WriteLine("Ім'я водія: {0}. Вік: {1}", name, age);
        }


        #region Властивості

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public short CurrentSpeed
        {
            get { return currentSpeed; }
            set { currentSpeed = value; }
        }

        public short MaxSpeed
        {
            get { return maxSpeed; }
        }

        public EngineState EngineState
        {
            get { return state; }
        }

        #endregion
    }
}
