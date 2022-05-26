using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("文字列１を入力");
            string input1 = Console.ReadLine();

            Console.WriteLine("文字列２を入力");
            string input2 = Console.ReadLine();

            if (input1 == input2) {
                Console.WriteLine("等しいです。");
            }
            else {
                Console.WriteLine("等しくないです。");


            }
        }
    }
}