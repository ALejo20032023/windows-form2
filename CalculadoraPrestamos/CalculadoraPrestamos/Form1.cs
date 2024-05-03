namespace CalculadoraPrestamos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Montoinicial = double.Parse(txtM.Text);
            double Interesanual = double.Parse(txtI.Text);
            double periodo = double.Parse(txtA.Text) * 12;
            double tasa = Interesanual / 100;

            double CapitalFinal = Montoinicial * Math.Pow(1 + tasa, periodo);
            txtR.Text = CapitalFinal.ToString();
        }
    }
}
