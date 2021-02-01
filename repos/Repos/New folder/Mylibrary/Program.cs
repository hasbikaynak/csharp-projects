using System;
using System.Reflection;

namespace Mylibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly Lib = Assembly.LoadFile(@"C:\Users\CEM\source\repos\UdemyLib\UdemyLib\bin\Debug\netstandard2.0\UdemyLib.dll");
            Type[] TP = Lib.GetTypes();
            foreach (Type  item in TP)
	{
                ConstructorInfo[] CTORS = item.GetConstructors();
                for (int i = 0; i <CTORS.Length; i++)
			{
                    Console.WriteLine(CTORS[i].ToString());
			}
                Console.ReadLine();
	}
        }
    }
}
