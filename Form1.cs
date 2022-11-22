namespace TCTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btResolver_Click(object sender, EventArgs e)
        {
            if (rbtInfinita.Checked && tbServidor.Text == "1")
            {
                FormPICS ventana = new FormPICS();
                ventana.Show();
            }
            
        }
    }
}