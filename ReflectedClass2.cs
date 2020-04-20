using System;
using System.Collections.Generic;
using System.Text;

namespace QUETE_Reflection
{
    public class ReflectedClass2
    {
        public int id { get; set; }
        public string Job { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }

        public ReflectedClass2()
        {
            id = 0;
            Job = "Developer C#";
            City = "Laxou";
            ZipCode = 54520;
        }

        public void MyJobIs()
        {
            Console.WriteLine("Hello, I'm a " + Job + " in formation, I will work in " + City + " " + ZipCode + " but I don't know when I will start !");
        }
    }
}
