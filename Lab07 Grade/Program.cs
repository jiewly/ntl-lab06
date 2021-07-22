using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Grade
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("input score=");
            var input = Double.Parse(Console.ReadLine());

            var grd = new Grade(input);

            var result = grd.grade();

            Console.WriteLine("  " + result);

            Console.ReadLine();
        }
    }
}
