using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {

            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);

        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                                .Select(x => new {
                                    Name = (string)x.Element("name").Value,
                                    teammembers = (string)x.Element("teammembers").Value

                                });

            foreach (var sport in sports) {
                Console.WriteLine("{0}{1}",sport.Name,sport.teammembers);

            }
        }
    
        private static void Exercise1_2(string file) {
            
        }

        private static void Exercise1_3(string file) {
            
        }

        private static void Exercise1_4(string file, string newfile) {
            

        }
    }
}
