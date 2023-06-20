using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_16_
{
    internal class Kvadrat<T> : Shape
    {
        private T width;

        public Kvadrat(T n)
        {
            width = n;
        }

        public override void Yuzani_topish()
        {
            double w = Convert.ToDouble(width);
            var S = w * w;
            Console.WriteLine($"Kvadratni yuzasi : {S}");
        }
    }
}
