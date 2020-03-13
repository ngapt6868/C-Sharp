using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so thu ba: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so thu 4: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so thu 5: ");
            int e = int.Parse(Console.ReadLine());
            int max = a;
            if (max < b) max = b;
            if (max < c) max = c;
            if (max < d) max = d;
            if (max < e) max = e;
            int secondMax = a;
            if (b < max && secondMax < b) secondMax = b;
            if (c < max && secondMax < c) secondMax = c;
            if (d < max && secondMax < d) secondMax = d;
            if (e < max && secondMax < e) secondMax = e;
            Console.WriteLine("SecondMax la: " + secondMax);
            Console.ReadKey();
        }
    }
}
