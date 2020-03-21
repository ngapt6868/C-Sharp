using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btap3
{
    class Program
    {
        static void Nhapchuoi(String s)
        {
            a = s.Split(' ');
            Console.Write("arr[]={'");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "','");
            }
            Console.WriteLine("'}");
        }
        static void Hienthi()
        {
            Console.WriteLine("Ho: " + a[0]);
            Console.WriteLine("Ten Dem: " + a[1]);
            Console.WriteLine("Ten: " + a[2]);
            Console.WriteLine("Nam Sinh: " + a[3]);
        }
        static String[] a;
        static int tuoi()
        {
            DateTime dateTime = DateTime.Now;
            int tuoi = dateTime.Year;
            return (dateTime.Year - int.Parse(a[a.Length - 1]));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ho , Ten Dem , Ten , Nam sinh : ");
            string s = Console.ReadLine();
            Nhapchuoi(s);
            Hienthi();
            Console.WriteLine("Nam nay: " + tuoi() + " Tuoi");
            Console.ReadKey();
        }
    }
}
