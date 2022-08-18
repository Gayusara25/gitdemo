using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a number:");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entered :{0}", number);
            Console.ReadLine();
        }
    }
}
