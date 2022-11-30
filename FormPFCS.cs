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
            tbP0.Text = pfcs.P0.ToString();
            tbPe.Text = pfcs.Pe.ToString();
            for (int i = 0; i < n; i++)
            {
                tbPn.Text = "P(" + (i + 1) + ") = " +
                    pfcs.Pn[i].ToString() +
                    string.Format(Environment.NewLine);
            }

            tbL.Text = pfcs.L.ToString();
            tbLq.Text = pfcs.Lq.ToString();
            tbLn.Text = pfcs.Ln.ToString();

            tbW.Text = pfcs.W.ToString();
            tbWq.Text = pfcs.Wq.ToString();
            tbWn.Text = pfcs.Wn.ToString();
            
        }
    }
}
