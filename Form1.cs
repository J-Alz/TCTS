using System.Text.RegularExpressions;
namespace TCTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbPoblacion.Enabled = false;
            tbServidor.Focus();
        }
        modeloBase o = new modeloBase();
        bool condicionPoblacion = false;//infinita
        bool condicionServidor = false;//1
        private void btResolver_Click(object sender, EventArgs e)
        {
            if (rbtFinita.Checked)
                condicionPoblacion = true; else condicionPoblacion = false;
            if (tbServidor.Text != "1")
                condicionServidor = true; else condicionServidor = false;
            o.Lambda(tbLambda.Text);
            o.Miu(tbMiu.Text);
            o.K(tbServidor.Text);
            o.N(tbN.Text);


            if(condicionPoblacion == false && condicionServidor == false)
            {
                FormPICS ventana = new FormPICS(o.Lambda(),o.Miu(),o.K(),o.N());
                ventana.Show();
            }



        }

        #region CheckedChanged
        private void rbtFinita_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtFinita.Checked)
                tbPoblacion.Enabled = true;
        }

        private void rbtInfinita_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtInfinita.Checked)
                tbPoblacion.Enabled = false;
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        #region TextChanged
        private void tbServidor_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbServidor.Text, "^[0-9]{0,10}$"))
            {
                tbServidor.Clear();
            }
            
        }
        private void tbPoblacion_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbPoblacion.Text, "^[0-9]{0,10}$"))
            {
                tbPoblacion.Clear();
            }
        }
        private void tbLambda_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbLambda.Text, "^[0-9]{0,10}$"))
            {
                tbLambda.Clear();
            }
        }
        private void tbMiu_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbMiu.Text, "^[0-9]{0,10}$"))
            {
                tbMiu.Clear();
            }
        }
        private void tbN_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbN.Text, "^[0-9]{0,10}$"))
            {
                tbN.Clear();
            }
        }
        #endregion


    }
}