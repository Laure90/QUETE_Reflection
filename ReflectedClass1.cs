using System;
using System.Collections.Generic;
using System.Text;

namespace QUETE_Reflection
{
    public class ReflectedClass1
    {
        private int _id;
        private string _name { get; set; }

        public void MakeId()
        {
            for(int i = 0; i < 5; i++)
            {
                _id = i;
                _name = "John";
                Console.WriteLine(_id + _name);
            }
        }
    }
}
