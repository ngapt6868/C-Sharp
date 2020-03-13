using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen n : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                while (n>1 && n % i == 0)
                {
                    Console.Write( i );
                    Console.Write("x");
                    n /= i;
                }
            }
            Console.ReadKey();
        }
    }
}
