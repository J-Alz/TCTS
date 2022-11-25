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
        public FormPICM(int lambda, int miu, int k, int n)
        {
            InitializeComponent();
            this.n = n;
            picm = new PICM(lambda, miu, k, n);
        }

        private void FormPICM_Load(object sender, EventArgs e)
        {
            tbPsubZero.Text = picm.PsubZero.ToString();
            for(int i = 0; i < n; i++)
            {
                tbPsubN.Text += "P(" + (i + 1) + ") --> " +
                    picm.PsubN[i].ToString("N3") + string.Format(Environment.NewLine);
            }
            tbL.Text = picm.L.ToString();
            tbLsubQ.Text = picm.LsubQ.ToString();
            tbLsubN.Text = picm.LsubN.ToString();

            tbW.Text = picm.W.ToString();
            tbWsubQ.Text = picm.WsubQ.ToString();
            tbWsubN.Text = picm.WsubN.ToString();

        }
    }
}
