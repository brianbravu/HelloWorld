using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Person
    {
        public string Name = "Emmanuel";

        public void ReadName()
        {
            Console.WriteLine("Your name is ");
            Name = Console.ReadLine();
        }

        public void SayHello()
        {
            Console.WriteLine("Hello, my name is " + Name);
        }
    }
}
