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
        public FormPICS(double lambda, double miu, int k, int n,
             double cte, double cts, double ctse, double cs, double tiempo)
        {
            InitializeComponent();
            this.n = n;
            pics = new PICS(lambda, miu, k, n,cte,cts,ctse,cs,tiempo);
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

            tbW.Text = pics.W.ToString("N3");
            tbWq.Text = pics.Wq.ToString("N3");
            tbWn.Text = pics.Wn.ToString("N3");

            tbCTTE.Text = pics.Ctte.ToString("N2");
            tbCTTS.Text = pics.Ctts.ToString("N2");
            tbCTTSE.Text = pics.Cttse.ToString("N2");
            tbCTS.Text = pics.Cts.ToString("N2");
            tbCT.Text = pics.Ct.ToString("N2");

        }

        private void btCalcularCosto_Click(object sender, EventArgs e)
        {
            //FormCostos ventanaCosto = new FormCostos();
            //ventanaCosto.Show();
        }
    }
}
