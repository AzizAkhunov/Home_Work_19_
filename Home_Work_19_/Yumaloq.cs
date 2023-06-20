using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_16_
{
    internal class Yumaloq<T> : Shape
    {
        private T R;

        public Yumaloq(T r) => R = r;

        public override void Yuzani_topish()
        {
            double w = Convert.ToDouble(R);
            double S = Math.PI * w * w / w;
            Console.WriteLine($"Yumaloq yuzasi : {S}");
        }
    }
}