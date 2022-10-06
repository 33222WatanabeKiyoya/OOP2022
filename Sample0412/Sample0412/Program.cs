using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample0412
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数：");
            int money = int.Parse(Console.ReadLine());

            Console.WriteLine("10000円札: {0}",money/10000);
            Console.WriteLine("5000円札: {0}", money % 10000 / 5000);
            Console.WriteLine("1000円札:{0}",  money % 5000 / 1000);
            Console.WriteLine("500円玉:{0}",   money % 1000 / 500);
            Console.WriteLine("100円玉:{0}",   money % 500 / 100);
            Console.WriteLine("50円玉:{0}",    money % 100/ 50);
            Console.WriteLine("10円玉:{0}",    money % 50 / 10);
            Console.WriteLine("5円玉:{0}",     money % 10 / 5);
            Console.WriteLine("1円玉:{0}",     money % 5);

        }
    }
}
