﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {

        public static class FeetConverter {

         double FromMeter(double feet)
        {
            return feet * 0.3048;
        }

        // メートルからフィートを求める
         double ToMeter(double meter)
        {
            return meter / 0.3048;
        }

    }
        
    }
