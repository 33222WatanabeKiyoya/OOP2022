﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;

namespace Exercise1 {
    class Program : TextProcessor{

        static void main(String[] args) {
            TextProcessor.Run<ToHankakuProcessor>("");


        }
    


       
    }
}
