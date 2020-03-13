using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao canh thu nhat: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao canh thu hai: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao canh thu ba: ");
            float c = float.Parse(Console.ReadLine());
            if ((a + b) < c || (b + c) < a || (c + a) < b)
            {
                Console.Write("\tkhong phai tam giac");
            }
            else
            {

                if (a == b && b == c && c == a)
                {
                    Console.WriteLine("tam giac deu");
                }
                else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                {
                    if (a == b || b == c || a == c)
                    {
                        Console.WriteLine("Tam giac vuong can");
                    }
                    else
                    {
                        Console.WriteLine("Tam giac vuong");
                    }
                }
                else if(a==b || b==c || a == c)
                {
                    Console.WriteLine("Tam giac can");
                }
                else Console.WriteLine("Tam giac thuong");
            }
                Console.ReadKey();
        }
    }
}
