using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btap2
{
    class Program
    {
        static void NhapA(out Double A)
        {
            Console.Write("Nhap so thuc A bat ky: ");
            A = Double.Parse(Console.ReadLine());
        }
        static void Nhapx(out Double x)
        {
            do
            {
                Console.Write("Nhap so thuc x : ");
                x = Double.Parse(Console.ReadLine());
                if (x <= 0)
                    Console.WriteLine("X khong thoa man ");
            }
            while (x <= 0);
        }
        static void Nhapn(out int n)
        {
            do
            {
                Console.Write("Nhap so nguyen duong n : ");
                n = int.Parse(Console.ReadLine());
                if (n < 5 || n > 20)
                    Console.WriteLine("n khong thoa man ");
            }
            while (n < 5 || n > 20);
        }
        static Double S(Double A, Double x, int n)
        {
            Double S = A;
            int k = 1;
            int T = n;
            for(int i=0;i<n;i++)
            {
                S += (Math.Pow(-1, k++) * Math.Sqrt(Math.Pow(x, i))) / T;
                T--;
            }
            return S;
        }
        static void Main(string[] args)
        {
            Double A, x;
            int n;
            NhapA(out A);
            Nhapx(out x);
            Nhapn(out n);
            Console.WriteLine("gia tri cua S la : " + S(A, x, n));
            Console.ReadKey();
        }
    }
}
