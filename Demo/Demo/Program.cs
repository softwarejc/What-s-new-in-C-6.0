using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {

        static void Main(string[] args)
        {
            Person juan = new Person("Juan Carlos", 29);

            Console.WriteLine("Hello \{juan.Name}");
            Console.WriteLine("You born in \{juan.GetYearOfBirth()}");
            Console.ReadLine();
        }


    }
}
