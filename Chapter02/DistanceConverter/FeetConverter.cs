using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {

    public static class FeetConverter {
        private const double ratio = 0.305; //定数retioを定義
        //外部からもアクセスさせたい場合 public static readonly double ratio = 0.3048; 

        //フィートからメートルを求める(静的メソッド)
        public static double FromMeter(double feet)
        {
            return feet * ratio;
        }

        // メートルからフィートを求める(静的メソッド)
        public static double ToMeter(double meter)
        {
            return meter / ratio;
        }

    }

}
