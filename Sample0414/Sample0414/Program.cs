using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample0414 {
    class Program {
         static void Main(string[] args)
        {
            //配列の宣言
            int[] count = new int[10];
            int num;

            for (int i = 0; i < 20; i++)
            {
                Console.Write((i + 1) + ":");
                num = int.Parse(Console.ReadLine());
                count[num]++;
            }

            for (int i = 0; i < count.Length; i++)
            {
                Console.Write(i + "の個数:");
                outStar(count[i]);
                Console.WriteLine();

            }

        }
        //「*」を出力するメソッド
        public static void outStar(int num){

            for (int j = 0; j<num; j++)
            {
                Console.Write("*");
            }

        }
    }
}
