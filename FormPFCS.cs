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
            pfcs = new PFCS(lambda, miu,k,n,m);
        }

        private void FormPFCS_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
