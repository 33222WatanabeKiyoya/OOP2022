using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            if (args.Length >= 1 && args[0] == "-tom")


                PrintMeterToInchList(1, 10);

            else

                PrintInchToMeterList(1, 10);
           
            
        }

        private static void PrintInchToMeterList(int start,int stop) {
            for(int inch = start; inch <= stop; inch++) {
                double meter = InchConverter.ToMeter(inch);
                Console.WriteLine("{0} inch = {1:0.0000} m", inch, meter);
            }
        }

        private static void PrintMeterToInchList(int start, int stop) {
            for (int meter = start; meter <= stop; meter++) {
                double inch = InchConverter.FromMeter(meter);
                Console.WriteLine("{0} meter = {1:0.0000} m", meter, inch);
            }
        }

    }
}

  

            




