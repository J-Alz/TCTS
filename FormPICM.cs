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
            

        }
    }
}
