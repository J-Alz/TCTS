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
    public partial class FormPFCM : Form
    {
        PFCM pfcm;
        int n;
        public FormPFCM(double lambda, double miu, int k, int n, int m,
            double cte, double cts, double ctse, double cs, double tiempo)
        {
            InitializeComponent();
            this.n = n;
            pfcm = new PFCM(lambda, miu, k, n, m,cte,cts,ctse,cs, tiempo);
        }
        private void FormPFCM_Load(object sender, EventArgs e)
        {
            tbP0.Text = pfcm.P0.ToString("N2");
            tbPe.Text = pfcm.Pe.ToString("N2");
            tbPNe.Text = pfcm.PNe.ToString("N2");
            for (int i = 0; i < n; i++)
            {
                tbPn.Text += "P(" + (i + 1) + ") = " +
                    pfcm.Pn[i].ToString("N2") +
                    string.Format(Environment.NewLine);
            }

            tbL.Text = pfcm.L.ToString("N2");
            tbLq.Text = pfcm.Lq.ToString("N2");
            tbLn.Text = pfcm.Ln.ToString("N2");

            tbW.Text = pfcm.W.ToString("N3");
            tbWq.Text = pfcm.Wq.ToString("N3");
            tbWn.Text = pfcm.Wn.ToString("N3");

            tbCTTE.Text = pfcm.Ctte.ToString("N2");
            tbCTTS.Text = pfcm.Ctts.ToString("N2");
            tbCTTSE.Text = pfcm.Cttse.ToString("N2");
            tbCTS.Text = pfcm.Cts.ToString("N2");
            tbCT.Text = pfcm.Ct.ToString("N2");
        }
    }
}
