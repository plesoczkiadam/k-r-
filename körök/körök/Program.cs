using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace körök
{
    class Kor
    {
        public double Sugar { get; set; }
        public double kerulet()
        {
            double krubi = 2 * Sugar * Math.PI;
            return krubi;

        }
        public double terulet()
        {
            double banán = Sugar * Sugar * Math.PI;
            return banán;

        }
        public Kor(double _Sugar)
        {
            Sugar = _Sugar;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var kor1 = new Kor(5);
            Console.WriteLine($"a kör kerülete {kor1.kerulet():.##}, területe{kor1.terulet():.##}");
            Console.ReadLine();
        }
    }
}
