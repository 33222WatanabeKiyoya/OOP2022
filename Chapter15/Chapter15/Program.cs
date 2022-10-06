using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15 {
    class Program {

        static void Main(string[] args) {

            var query = Library.Books.Select(b => b.PublishedYear).Distinct().OrderBy(y => y);
                        

            foreach(var n in query) {

                Console.WriteLine(n);
            }
              
        }
    }
}
