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
        public FormPICS(int lambda, int miu, int k, int n)
        {
            InitializeComponent();

            pics = new PICS(lambda, miu, k, n);
        }

        private void FormPICS_Load(object sender, EventArgs e)
        {

            tbRo.Text = pics.Ro.ToString();
            tbPsubZero.Text = pics.PsubZero.ToString();
            tbPsubN.Text = pics.PsubN.ToString();
            tbL.Text = pics.L.ToString();
            tbLsubQ.Text = pics.LsubQ.ToString();
            tbLsubN.Text = pics.LsubN.ToString();
            tbW.Text = pics.W.ToString();
            tbWsubQ.Text = pics.WsubQ.ToString();
            tbWsubN.Text = pics.WsubN.ToString();
        }
    }
}
