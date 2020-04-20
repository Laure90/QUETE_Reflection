using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace QUETE_Reflection
{
    public class ClassInspector
    {
        public static void GetAllProperties(object reflected)
        {
            Type objectType = reflected.GetType();

            PropertyInfo[] properties = objectType.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);

            Console.WriteLine("Propreties : ");
            foreach (var element in properties)
            {
                Console.WriteLine("\t" + element);
            }
        }

        public static void GetAllFields(object reflected)
        {
            Type objectType = reflected.GetType();

            FieldInfo[] fieldInfos = objectType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            Console.WriteLine("Fields : ");
            foreach (var element in fieldInfos)
            {
                Console.WriteLine("\t" + element);
            }
        }

        public static void GetAllMethods(object reflected)
        {
            Type objectType = reflected.GetType();

            MethodInfo[] methods = objectType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            Console.WriteLine("Methods : ");
            foreach (var element in methods)
            {
                Console.WriteLine("\t" + element);
            }
        }
    }
}
