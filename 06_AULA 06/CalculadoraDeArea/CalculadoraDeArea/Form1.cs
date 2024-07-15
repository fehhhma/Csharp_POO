using System;
using System.Windows.Forms;

namespace CalculadoraDeArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Adicionar itens ao ComboBox
            comboBoxFormas.Items.AddRange(new string[] { "Círculo", "Quadrado", "Triângulo" });
            comboBoxFormas.SelectedIndex = 0; // Selecionar o primeiro item por padrão
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            string formaSelecionada = comboBoxFormas.SelectedItem.ToString();

            switch (formaSelecionada)
            {
                case "Círculo":
                    CalcularAreaCirculo();
                    break;
                case "Quadrado":
                    CalcularAreaQuadrado();
                    break;
                case "Triângulo":
                    CalcularAreaTriangulo();
                    break;
                default:
                    MessageBox.Show("Por favor, selecione uma forma geométrica válida.");
                    break;
            }
        }

        private void CalcularAreaCirculo()
        {
            try
            {
                double raio = Convert.ToDouble(textBoxValor1.Text);
                double area = Math.PI * raio * raio;
                labelResultado.Text = "Área do Círculo: " + area.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um valor válido para o raio.");
            }
        }

        private void CalcularAreaQuadrado()
        {
            try
            {
                double lado = Convert.ToDouble(textBoxValor1.Text);
                double area = lado * lado;
                labelResultado.Text = "Área do Quadrado: " + area.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um valor válido para o lado.");
            }
        }

        private void CalcularAreaTriangulo()
        {
            try
            {
                double baseTriangulo = Convert.ToDouble(textBoxValor1.Text);
                double altura = Convert.ToDouble(textBoxValor2.Text);
                double area = 0.5 * baseTriangulo * altura;
                labelResultado.Text = "Área do Triângulo: " + area.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válidos para a base e a altura.");
            }
        }

        private void resetarButton_Click(object sender, EventArgs e)
        {
            // Limpar os TextBox e o Label
            textBoxValor1.Clear();
            textBoxValor2.Clear();
            textBoxValor3.Clear();
            labelResultado.Text = "Resultado da Área";
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            // Sair do programa
            Application.Exit();
        }
    }
}

