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
    public partial class FormPICS : Form
    {
        PICS pics;
        int n;
        public FormPICS(double lambda, double miu, int k, int n)
        {
            InitializeComponent();
            this.n = n;
            pics = new PICS(lambda, miu, k, n);
        }
        private void FormPICS_Load(object sender, EventArgs e)
        {
            
            tbRo.Text = pics.Ro.ToString("N2");
            tbP0.Text = pics.P0.ToString("N2");
            for(int i = 0; i < n; i++)
            {
                tbPn.Text += "P("+(i+1)+") = " +
                    pics.Pn[i].ToString("N2") + 
                    string.Format(Environment.NewLine);
            }

            tbL.Text = pics.L.ToString("N2");
            tbLq.Text = pics.Lq.ToString("N2");
            tbLn.Text = pics.Ln.ToString("N2");

            tbW.Text = pics.W.ToString("N2");
            tbWq.Text = pics.Wq.ToString("N2");
            tbWn.Text = pics.Wn.ToString("N2");
        }

        private void btCalcularCosto_Click(object sender, EventArgs e)
        {

        }
    }
}
