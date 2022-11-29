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
            
        }
    }
}
