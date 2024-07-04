using System.Linq.Expressions;

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
                //Declarando as variáveis
                double aresta = Convert.ToDouble(textBox1.Text);
                double litros = Convert.ToDouble(textBox4.Text);
                double volume = Math.Pow(aresta, 3);
                double volumelitros = volume / 1000;
                double volumedias = volumelitros / litros;
                double volumedias2 = Math.Round(volumedias, 2);

                //Mostrando a informação
                label9.Text = "resultado = " + volumelitros;
                label10.Text = "resultado = " + volumedias2;

                if (volumedias <= 2)
                {
                    label11.Text = "Consumo elevado";
                }
                else if (volumedias > 2 && volumedias < 7)
                {
                    label11.Text = "Consumo moderado";
                }
                else if (volumedias >= 7)
                {
                    label11.Text = "Consumo reduzido";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válidos");
            }

        }
    }
}
