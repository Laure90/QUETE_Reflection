using System;
using System.Reflection;

namespace QUETE_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informations of the ReflectedClass1 :");
            var reflected = new ReflectedClass1();
            ClassInspector.GetAllProperties(reflected);
            ClassInspector.GetAllFields(reflected);
            ClassInspector.GetAllMethods(reflected);

            Console.WriteLine("\nInformations of the ReflectedClass2 :");
            var reflected2 = new ReflectedClass2();
            ClassInspector.GetAllProperties(reflected2);
            ClassInspector.GetAllFields(reflected2);
            ClassInspector.GetAllMethods(reflected2);
        }
    }
}
