using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTS
{
    internal abstract class modelo
    {
        private double lambda;


        public double Lambda
        {
            get { return lambda; }
            set { lambda = value; }
        }
        //TODO:
        //1. Lambda y Miu deben ser enteros por ley
        //  a. Cambiar conversiones (int) en cada modelo de cola.
        //..
        //..

    }
}
