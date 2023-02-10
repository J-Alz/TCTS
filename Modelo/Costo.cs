using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTS.Modelo
{
    internal class Costo
    {
        private float tiempo;
        private float cte;
        private float cts;
        private float ctse;
        private float cs;

        public float Tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }
        }
        public float Cte
        {
            get { return cte; }
            set { cte = value; }
        }
        public float Cts
        {
            get { return cts; }
            set { cts = value; }
        }
        public float Ctse
        {
            get { return ctse; }
            set { ctse = value; }
        }
        public float Cs
        {
            get { return cs; }
            set { cs = value; }
        }
        /*
        public double calcularCTTE(double value)
        {
            return lambda * tiempo * wq * value;
        }
        public double calcularCTTS(double value)
        {
            return lambda * tiempo * w * value;
        }
        public double calcularCTTSE(double value)
        {
            return lambda * tiempo * (1 / miu) * value;
        }
        public double calcularCTS(double value)
        {
            return k * value;
        }
        public double calcularCT()
        {
            return ctte + ctts + cttse + cts;
        }
        */
    }
}
