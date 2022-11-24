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
        public FormPICM(int lambda, int miu, int k, int n, int m)
        {
            InitializeComponent();
            picm = new PICM(lambda, miu, k, n);
        }

        private void FormPICM_Load(object sender, EventArgs e)
        {
            
        }
    }
}
