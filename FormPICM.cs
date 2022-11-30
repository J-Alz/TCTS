﻿using System;
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
            tbP0.Text = picm.P0.ToString();
            tbPk.Text = picm.Pk.ToString();
            tbPNe.Text = picm.PNe.ToString();
            for (int i = 0; i < n; i++)
            {
                tbPn.Text = "P(" + (i + 1) + ") = " +
                    picm.Pn[i].ToString() +
                    string.Format(Environment.NewLine);
            }

            tbL.Text = picm.L.ToString();
            tbLq.Text = picm.Lq.ToString();
            tbLn.Text = picm.Ln.ToString();

            tbW.Text = picm.W.ToString();
            tbWq.Text = picm.Wq.ToString();
            tbWn.Text = picm.Wn.ToString();

        }
    }
}
