using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHi();
            SayHiUser("Justin");
            SayHiAge("Justin", 10); 
            Console.ReadLine(); 
        }

        static void SayHi()
        {
            Console.WriteLine("hi "); 
        }

        static void SayHiUser(string name)
        {
            Console.WriteLine("hi "+name);

        }

        static void SayHiAge(string name, int age)
        {
            Console.WriteLine("hi " + name+ " you are "+ age);
        }
    }
}
