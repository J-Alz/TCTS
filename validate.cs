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
        string cte = "";
        string cts = "";
        string ctse = "";
        string cs = "";
        string time = "";

        public Validate(string lambda, string miu, 
            string k, string n, string m,
            string cte, string cts, string ctse, string cs, string time)
        {
            this.lambda = lambda;
            this.miu = miu;
            this.k = k;
            this.n = n;
            this.m = m;
            this.cte = cte;
            this.cts = cts;
            this.ctse = ctse;
            this.cs = cs;
            this.time = time;
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
        public double Cte()
        {
            string value;
            value = (cte == "") ? "0" : cte;
            return double.Parse(value);
        }
        public double Cts()
        {
            string value;
            value = (cts == "") ? "0" : cts;
            return double.Parse(value);
        }
        public double Ctse()
        {
            string value;
            value = (ctse == "") ? "0" : ctse;
            return double.Parse(value);
        }
        public double Cs()
        {
            string value;
            value = (cs == "") ? "0" : cs;
            return double.Parse(value);
        }
        public double Time()
        {
            string value;
            value = (time == "")? "0" : time;
            return double.Parse(time);
        }
    }
}
