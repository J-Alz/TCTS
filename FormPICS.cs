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
        public FormPICS(int lambda, int miu, int k, int n)
        {
            InitializeComponent();
            this.n = n;
            pics = new PICS(lambda, miu, k, n);
        }

        private void FormPICS_Load(object sender, EventArgs e)
        {
            tbRo.Text = pics.Ro.ToString("N2");
            tbPsubZero.Text = pics.PsubZero.ToString("N2");
            for(int i = 0; i < n ; i++)
            {
                tbPsubN.Text += "P("+ (i+1) +") --> " +
                    pics.PsubN[i].ToString("N3")+string.Format(Environment.NewLine);
            }

            tbL.Text = pics.L.ToString("N2");
            tbLsubQ.Text = pics.LsubQ.ToString("N2");
            tbLsubN.Text = pics.LsubN.ToString("N2");

            tbW.Text = pics.W.ToString("N2");
            tbWsubQ.Text = pics.WsubQ.ToString("N2");
            tbWsubN.Text = pics.WsubN.ToString("N2");
        }
    }
}
