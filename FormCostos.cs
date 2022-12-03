using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCTS
{
    public partial class FormCostos : Form
    {
        double cte;
        double cts;
        double ctse;
        double cs;
        double lambda;
        double miu;
        double wq;
        double w;
        double t;
        double k;
        public FormCostos(double cte, double cts, double ctse, double cs,
            double lambda, double miu, double wq, double w,double k, double t)
        {
            InitializeComponent();
            this.cte = cte;
            this.cts = cts;
            this.ctse = ctse;
            this.cs = cs;
            this.lambda = lambda;
            this.miu = miu;
            this.wq = wq;
            this.w = w;
            this.t = t;
            this.k = k;
        }
        //TODO colocar gets para facilitar las cosas, por el calculo del 0
        //TODO convertir strings en constructor??
        private void FormCostos_Load(object sender, EventArgs e)
        {
            tbCTTE.Text = (lambda * t * wq * cte).ToString();
            tbCTTS.Text = (lambda * t * w * cts).ToString();
            tbCTTSE.Text = (lambda * t * (1/miu) * ctse).ToString();
            tbCTS.Text = (k * cs).ToString();

            tbCT.Text = (double.Parse(tbCTTE.Text) +
                double.Parse(tbCTTS.Text) +
                double.Parse(tbCTTSE.Text) +
                double.Parse(tbCTS.Text)).ToString();
        }
    }
}
