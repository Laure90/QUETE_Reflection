using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace QUETE_Reflection
{
    public class ClassInspector
    {
        public static void GetAllMethods(object reflected)
        {
            Type objectType = reflected.GetType();
            Console.WriteLine("***** Methods *****");
            MethodInfo[] privateMethodInfo = objectType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            MemberInfo[] publicMehtodInfo = objectType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            Console.WriteLine("Private methods :");
            foreach (MethodInfo method in privateMethodInfo)
            {
                Console.WriteLine("->{0}", method.Name);
            }
            Console.WriteLine("Public methods :");
            foreach (MethodInfo m in publicMehtodInfo)
            {
                Console.WriteLine("->{0}", m.Name);
            }
            Console.WriteLine("");
        }

        public static void GetAllFields(object reflected)
        {
            Type objectType = reflected.GetType();
            Console.WriteLine("***** Fields *****");
            FieldInfo[] PrivateFieldInfo = objectType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo[] PublicFieldInfo = objectType.GetFields(BindingFlags.Instance | BindingFlags.Public);
            Console.WriteLine("Private fields :");
            foreach (FieldInfo field in PrivateFieldInfo)
            {
                Console.WriteLine("->{0}", field.Name);
            }
            Console.WriteLine("Public fields :");
            foreach (FieldInfo field in PublicFieldInfo)
            {
                Console.WriteLine("->{0}", field.Name);
            }
            Console.WriteLine("");
        }

        public static void GetAllProperties(object reflected)
        {
            Type objectType = reflected.GetType();
            Console.WriteLine("***** Properties *****");
            PropertyInfo[] privatePropertyInfo = objectType.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);
            PropertyInfo[] publicPropertyInfo = objectType.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            Console.WriteLine("Private properties :");
            foreach (PropertyInfo property in privatePropertyInfo)
            {
                Console.WriteLine("->{0}", property.Name);
            }
            Console.WriteLine("Public properties :");
            foreach (PropertyInfo property in publicPropertyInfo)
            {
                Console.WriteLine("->{0}", property.Name);
            }
            Console.WriteLine("");
        }
    }
}
