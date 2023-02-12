using System;
using System.Reflection;

namespace Homework6_5
{
    class Program
    {
        static string Text;
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            string path = @"D:\ITVDN\C sharp Professional\Homeworks\Homework6\Homework6_2\bin\Debug\netcoreapp3.1\Homework6_2.dll";
            
            Assembly assembly = null;

            assembly = Assembly.LoadFile(path);

            Type[] types = assembly.GetTypes();

            

            foreach (Type type in types)
            {
                Text += "Тип:  " + type + Environment.NewLine;
                Console.WriteLine(Text);
                var methods = type.GetMethods();
                if (methods != null)
                {
                    foreach (var method in methods)
                    {
                        string methStr = "Метод:" + method.Name + "\n";
                        var methodBody = method.GetMethodBody();
                        
                        Text += methStr + Environment.NewLine;
                        Console.WriteLine(Text);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
