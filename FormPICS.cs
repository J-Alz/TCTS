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
        PICS o;
        public FormPICS(int lambda, int miu, int k, int n)
        {
            InitializeComponent();

            #region Enabled
            tbRo.Enabled = false;
            tbPsubZero.Enabled = false;
            tbPsubN.Enabled = false;
            tbL.Enabled = false;
            tbLsubQ.Enabled = false;
            tbLsubN.Enabled = false;
            tbW.Enabled = false;
            tbWsubQ.Enabled = false;
            tbWsubN.Enabled = false;
            #endregion
            o = new PICS(lambda, miu, k, n);
        }

        private void FormPICS_Load(object sender, EventArgs e)
        {

            tbRo.Text = o.Ro.ToString();
            tbPsubZero.Text = o.PsubZero.ToString();
            tbPsubN.Text = o.PsubN.ToString();
            tbL.Text = o.L.ToString();
            tbLsubQ.Text = o.LsubQ.ToString();
            tbLsubN.Text = o.LsubN.ToString();
            tbW.Text = o.W.ToString();
            tbWsubQ.Text = o.WsubQ.ToString();
            tbWsubN.Text = o.WsubN.ToString();
        }
    }
}
