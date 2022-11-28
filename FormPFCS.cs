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
    public partial class FormPFCS : Form
    {
        PFCS pfcs;
        int n;
        public FormPFCS(double lambda, double miu, int k, int n, int m)
        {
            InitializeComponent();
            pfcs = new PFCS(lambda, miu,k,n,m);
        }

        private void FormPFCS_Load(object sender, EventArgs e)
        {
            tbPsubZero.Text = pfcs.PsubZero.ToString();
            tbPsubE.Text = pfcs.PsubE.ToString();
            for(int i = 0; i < n; i++)
            {
                tbPsubN.Text += "P(" + (i + 1) + ") --> " +
                    pfcs.PsubN[i].ToString("N3") + string.Format(Environment.NewLine);
            }
            tbL.Text = pfcs.L.ToString();
            tbLsubQ.Text = pfcs.LsubQ.ToString();
            tbLsubN.Text = pfcs.LsubN.ToString();

            tbW.Text = pfcs.W.ToString();
            tbWsubQ.Text = pfcs.WsubQ.ToString();
            tbWsubN.Text = pfcs.WsubN.ToString();
            
        }
    }
}
