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
            tbPsubZero.Text = pfcm.PsubZero.ToString();
            tbPsubE.Text = pfcm.PsubE.ToString();
            tbPsubNE.Text = pfcm.PsubNE.ToString();
            for(int i = 0; i < n; i++)
            {
                tbPsubN.Text += "P(" + (i + 1) + ") --> " +
                    pfcm.PsubN[i].ToString("N3") + string.Format(Environment.NewLine);
            }

            tbL.Text = pfcm.L.ToString();
            tbLsubQ.Text = pfcm.LsubQ.ToString();
            tbLsubN.Text = pfcm.LsubN.ToString();

            tbW.Text = pfcm.W.ToString();
            tbWsubQ.Text = pfcm.WsubQ.ToString();
            tbWsubN.Text = pfcm.WsubN.ToString();
            /*
            */
        }
    }
}
