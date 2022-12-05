using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTS
{
    internal class PICS: modeloColas
    {
        
        private double ro;
        public PICS(double lambda, double miu, int k, int n, 
            double cte, double cts, double ctse, double cs, double tiempo)
        {
            Lambda = lambda;    //a
            Miu = miu;          //b
            K = k;              //c
            Tiempo = tiempo;
            Ro = calcularRo();  //1
            P0 = calcularP0();  //2
            Pn = calcularPn(n); //3 *
            L = calcularL();    //4
            Lq = calcularLq();  //5
            Ln = calcularLn();  //6
            W = calcularW();    //7
            Wq = calcularWq();  //8
            Wn = calcularWn();  //9
            Ctte = calcularCTTE(cte);
            Ctts = calcularCTTS(cts);
            Cttse = calcularCTTSE(ctse);
            Cts = calcularCTS(cs);
            Ct = calcularCT();
        }

        #region get/Set Ro
        public double Ro
        {
            get { return ro; }
            set { ro = value; }
        }
        #endregion

        private double calcularRo()
        {
            return Lambda / Miu;
        }
        private double calcularP0()
        {
            return 1 - Ro;
        }
        private List<double> calcularPn(int n)
        {
            List<double> lista = new List<double>();
            for(int i = 1; i <= n; i++)
            {
                lista.Add(P0 * Math.Pow(Ro, i));
            }
            return lista;
        }
        private double calcularL()
        {
            return  Lambda / (Miu - Lambda);
        }
        private double calcularLq()
        {
            return Math.Pow(Lambda, 2) / (Miu * (Miu - Lambda));
        }
        private double calcularLn()
        {
            return Lambda / (Miu - Lambda);
        }
        private double calcularW()
        {
            return 1 / (Miu - Lambda);
        }
        private double calcularWq()
        {
            return Lambda / (Miu * (Miu - Lambda));
        }
        private double calcularWn()
        {
            return 1 / (Miu - Lambda);
        }
    }
}
