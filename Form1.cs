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
            FormResultado ventana = new FormResultado();
            ventana.Show();
        }
    }
}