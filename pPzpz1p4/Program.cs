using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pPzpz1p4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string s = "";
            for (int i = 1; i < n; i++)
            {
                s += i;
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
