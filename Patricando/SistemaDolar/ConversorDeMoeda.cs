using System;
using System.Globalization;


namespace SistemaDolar
{
	class ConversorDeMoeda
	{
        public static double IOF = 0.06;
		public double r;

		public static double converter(double d, double c){
            double p1 = (d * c);
            double r = p1 + (p1 * IOF);

			return r;
        }
	}
}
