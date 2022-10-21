namespace exForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular(object sender, EventArgs e)
        {
            Soma soma;
            soma = new Soma();
            soma.setN1(int.Parse(txtN1.Text));
            soma.setN2(int.Parse(txtN2.Text));
            soma.calcular();
            lblResultado.Text = soma.getResultado().ToString();
        }
    }
}