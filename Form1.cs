namespace TCTS
{
    public partial class Form1 : Form
    {
        int k;
        int lambda;
        int miu;
        int poblacion;
        int n;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btResolver_Click(object sender, EventArgs e)
        {
            k = int.Parse(tbServidor.Text);
            lambda = int.Parse(tbLambda.Text);
            miu = int.Parse(tbMiu.Text);
            poblacion = int.Parse(tbPoblacion.Text);
            n = int.Parse(tbN.Text);

            if (rbtInfinita.Checked && tbServidor.Text == "1")
            {
                FormPICS ventana = new FormPICS();
                ventana.Show();
            }
            
        }
    }
}