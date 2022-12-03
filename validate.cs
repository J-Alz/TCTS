using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTS
{
    internal class Validate
    {
        string lambda = "";
        string miu = "";
        string k = "";
        string n = "";
        string m = "";
        public Validate(string lambda, string miu, string k, string n, string m)
        {
            this.lambda = lambda;
            this.miu = miu;
            this.k = k;
            this.n = n;
            this.m = m;
        }
        

        public double Lambda(){
            string value;
            value = (lambda == "") ? "0":lambda;
            return double.Parse(value); 
        }
        public double Miu()
        {
            string value;
            value = (miu == "") ? "0" : miu;
            return double.Parse(value);
        }
        public int K()
        {
            string value;
            value = (k == "") ? "0" : k;
            return int.Parse(value);
        }
        public int N()
        {
            string value;
            value = (n == "") ? "0" : n;
            return int.Parse(value);
        }
        public int M()
        {
            string value;
            value = (m == "") ? "0" : m;
            return int.Parse(value);
        } 
    }
}
