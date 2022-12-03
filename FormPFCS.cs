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
            this.n = n;
            pfcs = new PFCS(lambda, miu,k,n,m);
        }

        private void FormPFCS_Load(object sender, EventArgs e)
        {
            tbP0.Text = pfcs.P0.ToString("N2");
            tbPe.Text = pfcs.Pe.ToString("N2");

            for (int i = 0; i < n; i++)
            {
                tbPn.Text += "P(" + (i + 1) + ") = " +
                    pfcs.Pn[i].ToString("N2") +
                    string.Format(Environment.NewLine);
                
            }
            
            tbL.Text = pfcs.L.ToString("N2");
            tbLq.Text = pfcs.Lq.ToString("N2");
            tbLn.Text = pfcs.Ln.ToString("N2");

            tbW.Text = pfcs.W.ToString("N2");
            tbWq.Text = pfcs.Wq.ToString("N2");
            tbWn.Text = pfcs.Wn.ToString("N2");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pfcs.Pn.ToString());
        }
    }
}
