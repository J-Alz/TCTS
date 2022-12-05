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
    public partial class FormPICM : Form
    {
        PICM picm;
        int n;
        public FormPICM(double lambda, double miu, int k, int n,
            double cte, double cts, double ctse, double cs, double tiempo)
        {
            InitializeComponent();
            this.n = n;
            picm = new PICM(lambda, miu, k, n,cte,cts,ctse,cs,tiempo);
        }

        private void FormPICM_Load(object sender, EventArgs e)
        {
            tbP0.Text = picm.P0.ToString("N2");
            tbPk.Text = picm.Pk.ToString("N2");
            tbPNe.Text = picm.PNe.ToString("N2");
            for (int i = 0; i < n; i++)
            {
                tbPn.Text += "P(" + (i + 1) + ") = " +
                    picm.Pn[i].ToString("N2") +
                    string.Format(Environment.NewLine);
            }

            tbL.Text = picm.L.ToString("N2");
            tbLq.Text = picm.Lq.ToString("N2");
            tbLn.Text = picm.Ln.ToString("N2");

            tbW.Text = picm.W.ToString("N3");
            tbWq.Text = picm.Wq.ToString("N3");
            tbWn.Text = picm.Wn.ToString("N3");

            tbCTTE.Text = picm.Ctte.ToString("N2");
            tbCTTS.Text = picm.Ctts.ToString("N2");
            tbCTTSE.Text = picm.Cttse.ToString("N2");
            tbCTS.Text = picm.Cts.ToString("N2");
            tbCT.Text = picm.Ct.ToString("N2");

        }
    }
}
