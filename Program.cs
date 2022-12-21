using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("project of prime number");

            for (int i =4;i<=18;++i)
            {
                if (i % 2 != 0 & i % 3 !=0) 
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
