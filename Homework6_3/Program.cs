using System;
using System.Reflection;
using System.Text;
using Homework6_2;

namespace Homework6_3
{

    class CarTemperature : Car
    {
        public override void Acceleration()
        {

        }

    }



    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;
            Console.SetWindowSize(80, 45);

            CarTemperature instance = new CarTemperature();
           //instance.TemperatureConvertation

            Type type = instance.GetType();

            

            double Celsius = 20;


            MethodInfo TemperatureConvertation = type.GetMethod("TemperatureConvertation", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            double Fahrenheit = (double)TemperatureConvertation.Invoke(instance, new object[] { Celsius });

            Console.WriteLine($"Celsius {Celsius} = Fahrenheit {Fahrenheit}");

            
            Console.ReadKey();


        }

      


    }
}
