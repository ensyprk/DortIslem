using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
     class DortIslem
    {
        public float toplama(float a,float b)
        {
            return (a + b);
        }

        public float cıkarma(float a, float b)
        {
            return a - b;
        }
        public double carpma(double a, double b)
        {
            return a * b;
        }
        public double bolme(double a, double b)
        {
            if ( b == 0) {  return 000000000; }
            else
            return a / b;
        }
    }
}
