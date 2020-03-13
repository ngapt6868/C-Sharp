using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap7
{
    class Program
    {
        static void Main(string[] args)
        {
            int ts = 1, ms = 1, gt=1, t=1;
            float ps=1;
            Console.WriteLine("Nhap so nguyen x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thuc c: ");
            float c = float.Parse(Console.ReadLine());
            while (( Math.Abs((float)ts / ms)) >=0)
            {
                    ps += ts/ms;
                    gt *= t;
                    ms = gt;
                    t++;
                    ts *= x;
            }
            Console.WriteLine("e^x= ", + ps);
            Console.ReadKey();
        }
    }
}
