using System.Text.RegularExpressions;
namespace TCTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbPoblacion.Enabled = false;
        }
        Validate validate;
        private bool condicionPoblacion = false;//infinita
        private bool condicionServidor = false;//1
        private void btResolver_Click(object sender, EventArgs e)
        {
            if (rbtFinita.Checked)
                condicionPoblacion = true; else condicionPoblacion = false;
            if (tbServidor.Text != "1")
                condicionServidor = true; else condicionServidor = false;
            validate = new Validate(tbLambda.Text,
                tbMiu.Text,
                tbServidor.Text,
                tbN.Text, tbPoblacion.Text);
            
            if(condicionPoblacion == false && condicionServidor == false)
            {
                FormPICS ventana = new FormPICS(validate.Lambda(),
                    validate.Miu(),validate.K(),validate.N());
                ventana.Show();
            }
            if (condicionPoblacion == false && condicionServidor == true)
            {
                FormPICM ventana = new FormPICM(validate.Lambda(),
                    validate.Miu(),validate.K(),validate.N());
                ventana.Show();
            }
            if (condicionPoblacion == true && condicionServidor == false)
            {
                FormPFCS ventana = new FormPFCS(validate.Lambda(),
                    validate.Miu(),validate.K(),validate.N(),validate.M());
                ventana.Show();
            }
            if(condicionPoblacion == true && condicionServidor == true)
            {
                FormPFCM ventana = new FormPFCM(validate.Lambda(),
                    validate.Miu(),validate.K(),validate.N(),validate.M());
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
        //regex usado anteriormente ^[1-9]{0,10}$
        private void tbServidor_TextChanged(object sender, EventArgs e)
        {
            //puede haber de 1 servidor para adelante
            //*error, debe aceptar el 0 luego de otro nùmero
            if (!Regex.IsMatch(tbServidor.Text, "^[1-9]\\d*$"))
            {
                tbServidor.Clear();
            }
            
        }
        private void tbPoblacion_TextChanged(object sender, EventArgs e)
        {
            //debe aceptar valores desde 1 para adelante
            if (!Regex.IsMatch(tbPoblacion.Text, "^[1-9]\\d*$"))
            {
                tbPoblacion.Clear();
            }
        }
        private void tbLambda_TextChanged(object sender, EventArgs e)
        {
            //es un nùmero decimal, no entero
            if (!Regex.IsMatch(tbLambda.Text, "^[0-9]+([,])?([0-9]+)?$"))
            {
                tbLambda.Clear();
            }
        }
        private void tbMiu_TextChanged(object sender, EventArgs e)
        {
            //es un número decimal, no entero
            if (!Regex.IsMatch(tbMiu.Text, "^[0-9]+([,])?([0-9]+)?$"))
            {
                tbMiu.Clear();
            }
        }
        private void tbN_TextChanged(object sender, EventArgs e)
        {
            //se aceptan valores de 1 para adelante
            if (!Regex.IsMatch(tbN.Text, "^[1-9]\\d*$"))
            {
                tbN.Clear();
            }
        }
        #endregion


    }
}