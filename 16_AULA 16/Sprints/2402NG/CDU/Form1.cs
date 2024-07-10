namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Calculadora


                double centena = Convert.ToDouble(textBox1.Text);
                double dezena = Convert.ToDouble(textBox2.Text);
                double unidade = Convert.ToDouble(textBox3.Text);


                //somatoria
                double somatoria = ((centena * 100) + (dezena * 10) + (unidade * 1));
                label4.Text = "O número é: " + somatoria;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira números válidos");
            }
        }
    }
}
