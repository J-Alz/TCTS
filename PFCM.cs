﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTS
{
    internal class PFCM:modeloColas
    {
        int m;
        int n;
        double psubE;
        double psubNE;
        tools t = new tools();
        public int M
        {
            get { return m; }
            set { m = value; }
        }
        public int N
        {
            get { return n; }
            set { n = value; }
        }
        public double PsubE
        {
            get { return psubE; }
            set { psubE = value; }
        }
        public double PsubNE
        {
            get { return psubNE; }
            set { psubNE = value; }
        }
        public void calcPsubZero()
        {
            double sumatoria1 = 0;
            double sumatoria2 = 0;
            for(int n = 0; n < K - 1; n++)
            {
                sumatoria1 += (t.fact(M)/(t.fact(M - n) * t.fact(n)))*Math.Pow(Lambda/Miu,2);
            }
            for(int n = 0; n < K - 1; n++)
            {
                sumatoria2 += (t.fact(M) / (t.fact(M - n) * t.fact(K) * Math.Pow(K, n - K))) *
                    Math.Pow(Lambda/Miu,n);
            }
            PsubZero = 1 / (sumatoria1 + sumatoria2);
        }
        public void calcPsubN()
        {
            if(n >= 0 && n <= K)
            {
                PsubN = PsubZero * 
                    (t.fact(M)/(t.fact(M - N)*t.fact(N)))*
                    Math.Pow(Lambda/Miu,N);
            }
            else
            {
                PsubN = PsubZero *
                    (t.fact(M) / (t.fact(M - N) * t.fact(K)*Math.Pow(K,N - K))) *
                    Math.Pow(Lambda / Miu, N);
            }
        }
        public void calcPsubE()
        {
            double sumatoria = 0;
            for(int i = 0; i < K-1; i++)
            {
                sumatoria += PsubN;//Not
            }
            PsubE = 1 - sumatoria;
        }
        public void calcPsubNE()
        {
            PsubNE = 1 - PsubE;
        }
        public void calcL()
        {
            double sumatoria1 = 0,
                sumatoria2 = 0,
                sumatoria3 = 0;

            for(int i = 0; i < K-1; i++)
            {
                sumatoria1 += N * PsubN;//Not
            }
            for(int i = 0; i < M; i++)
            {
                sumatoria2 += (N - K) * PsubN;
            }
            sumatoria3 = sumatoria1 / N;
            L = sumatoria1 + sumatoria2 + K * (1 - sumatoria3);
        }
        public void calcLsubQ()
        {
            double sumatoria = 0;
            for (int i = 0; i < M; i++)
            {
                sumatoria += (N - K) * PsubN;
            }
            LsubQ = sumatoria;
        }
        public void calcLsubN()
        {
            LsubN = LsubQ / PsubE;
        }
        public void calcWsubQ()
        {
            WsubQ = LsubQ / Math.Pow(M - L,Lambda);
        }
        public void calcW()
        {
            W = WsubQ + (1 / Miu);
        }
        public void calcWsubN()
        {
            WsubN = WsubQ / PsubE;
        }
    }
}
