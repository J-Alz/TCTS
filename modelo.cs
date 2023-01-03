using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTS
{
    internal abstract class modelo
    {
        private int lambda;
        private int miu;

        public int Lambda
        {
            get { return lambda; }
            set { lambda = value; }
        }
        public int Miu
        {
            get { return miu; }
            set { miu = value; }
        }

        //TODO:
        //1. Lambda y Miu deben ser enteros por ley
        //  a. Cambiar conversiones (int) en cada modelo de cola.
        //..
        //..

    }
}
