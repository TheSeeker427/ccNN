using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccNN
{
    class nnMath
    {

        public static double sigmoid(double a)
        {
            return (1/(1+Math.Pow(Math.E, -a)));
        }
    }
}
