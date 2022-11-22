using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTS
{
    internal class tools
    {
        double resultado = 1;
        public double fact(double value)
        {
            resultado = resultado * value;
            if (value == 0)
                return 1;
            if (value > 1)
            {
                value--;
                fact(value);
            }
            return resultado;
        }
       
    }
}
