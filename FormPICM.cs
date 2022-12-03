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
        public FormPICM(double lambda, double miu, int k, int n)
        {
            InitializeComponent();
            this.n = n;
            picm = new PICM(lambda, miu, k, n);
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

            tbW.Text = picm.W.ToString("N2");
            tbWq.Text = picm.Wq.ToString("N2");
            tbWn.Text = picm.Wn.ToString("N2");

        }
    }
}
