using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTS.Modelo
{
    internal class Cola
    {
        private float lambda;
        private float miu;
        private int k;
        private int m;

        public float Lambda
        {
            get { return lambda; }
            set { lambda = value; }
        }
        public float Miu
        {
            get { return miu; }
            set { miu = value; }
        }
        public int K
        {
            get { return k; }
            set { k = value; }
        }
        public int M
        {
            get { return m; }
            set { m = value; }
        }
        public static int factorial(int n)
        {
            if (value == 0)
                return 1;

            int result = 1;
            for (int i = 1; i <= value; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
