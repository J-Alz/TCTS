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
            tbRo.Text = pics.Ro.ToString();
            tbP0.Text = pics.P0.ToString();
            for(int i = 0; i < n; i++)
            {
                tbPn.Text = "P("+(i+1)+") = " +
                    pics.Pn[i].ToString() + 
                    string.Format(Environment.NewLine);
            }

            tbL.Text = pics.L.ToString();
            tbLq.Text = pics.Lq.ToString();
            tbLn.Text = pics.Ln.ToString();

            tbW.Text = pics.W.ToString();
            tbWq.Text = pics.Wq.ToString();
            tbWn.Text = pics.Wn.ToString();
        }
    }
}
