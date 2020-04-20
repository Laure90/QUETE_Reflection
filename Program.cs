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
            DisplayAllAttribut(reflected);

            Console.WriteLine("\nInformations of the ReflectedClass2 :");
            var reflected2 = new ReflectedClass2();
            DisplayAllAttribut(reflected2);
        }

        private static void DisplayAllAttribut(object reflected)
        {
            Type objectType = reflected.GetType();

            PropertyInfo[] properties = objectType.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);
            MethodInfo[] methods = objectType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo[] fieldInfos = objectType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            Console.WriteLine("Propreties : ");
            foreach(var element in properties)
            {
                Console.WriteLine("\t" + element);
            }

            Console.WriteLine("Methods : ");
            foreach (var element in methods)
            {
                Console.WriteLine("\t" + element);
            }

            Console.WriteLine("Fields : ");
            foreach (var element in fieldInfos)
            {
                Console.WriteLine("\t" + element);
            }
        }
    }
}
