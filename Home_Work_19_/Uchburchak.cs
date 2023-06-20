using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_16_
{
    internal class Uchburchak<T> : Shape
    {
        private T width;
        private T balandlik;

        public Uchburchak(T n, T m)
        {
            width = n;
            balandlik = m;
        }

        public override void Yuzani_topish()
        {
            double w = Convert.ToDouble(width);
            double b = Convert.ToDouble(balandlik);
            var S = w * b / 2;
            Console.WriteLine($"Kvadratni yuzasi : {S}");
        }
    }
}
