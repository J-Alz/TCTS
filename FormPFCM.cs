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
        public FormPFCM(double lambda, double miu, int k, int n, int m)
        {
            InitializeComponent();
            pfcm = new PFCM(lambda, miu, k, n, m);
        }

        private void FormPFCM_Load(object sender, EventArgs e)
        {
            tbP0.Text = pfcm.P0.ToString();
            tbPe.Text = pfcm.Pe.ToString();
            tbPNe.Text = pfcm.PNe.ToString();
            for (int i = 0; i < n; i++)
            {
                tbPn.Text = "P(" + (i + 1) + ") = " +
                    pfcm.Pn[i].ToString() +
                    string.Format(Environment.NewLine);
            }

            tbL.Text = pfcm.L.ToString();
            tbLq.Text = pfcm.Lq.ToString();
            tbLn.Text = pfcm.Ln.ToString();

            tbW.Text = pfcm.W.ToString();
            tbWq.Text = pfcm.Wq.ToString();
            tbWn.Text = pfcm.Wn.ToString();
        }
    }
}
