using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btap1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = NhapsoN();
            int[] a = new int[n];
            Console.WriteLine("Nhap mang: ");
            NhapMang(a, n);
            Console.WriteLine("Vi tri cac so nguyen to trong mang la:");
            XuatMang(a);
            Console.ReadKey();
        }
        static int NhapsoN()
        {
            int n;
            do
            {
                Console.Write("Nhap so nguyen duong n: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0) Console.WriteLine("Yeu cau ban nhap lai n ");
            } while (n <= 0);
            return n;
        }
        static void NhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static bool Songuyento(int n)
        {
            if (n < 2) return false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                        return false;
                }
            }
            return true;
        }
        static void XuatMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (Songuyento(a[i]))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
