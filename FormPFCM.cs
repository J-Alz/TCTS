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
    public partial class FormPFCM : Form
    {
        PFCM pfcm;
        int n;
        public FormPFCM(double lambda, double miu, int k, int n, int m)
        {
            InitializeComponent();
            pfcm = new PFCM(lambda, miu, k, n, m);
        }

        private void FormPFCM_Load(object sender, EventArgs e)
        {
           
            /*
            */
        }
    }
}
