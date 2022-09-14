using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter.Framework {
    public abstract class ConverterBase {

        public abstract bool IsMyUnit(string name);

        protected abstract double Ratio { get; }

        public abstract string UnitName { get; }


        //メートルから変換
        public double FromMeter(double meter) {
            return meter / Ratio;
        }

        //メートルへ変換
        public double ToMeter(double feet) {
            return feet * Ratio;

        }
    }
}
