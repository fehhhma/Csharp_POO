using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CalculadoraMediaWhileParar
{
    public partial class Form1 : Form
    {
        private List<double> numeros = new List<double>();
        private bool continuar = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void adicionarButton_Click(object sender, EventArgs e)
        {
            continuar = true;
            while (continuar)
            {
                
                Application.DoEvents();
            }
        }

        private void textBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'p' || e.KeyChar == 'P')
            {
                // Parar o loop
                continuar = false;

                // Calcular a média e exibir
                if (numeros.Count == 0)
                {
                    MessageBox.Show("Nenhum número foi inserido.");
                    return;
                }

                double soma = 0;
                foreach (var num in numeros)
                {
                    soma += num;
                }

                double media = soma / numeros.Count;
                labelMedia.Text = "Média: " + media.ToString("F2");
                MessageBox.Show("A média dos números inseridos é: " + media.ToString("F2"), "Média");

                // Desativar o TextBox após calcular a média
                textBoxNumero.Enabled = false;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                // Adicionar o número à lista ao pressionar Enter
                try
                {
                    double numero = Convert.ToDouble(textBoxNumero.Text);
                    numeros.Add(numero);
                    textBoxNumero.Clear();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, insira um número válido.");
                    textBoxNumero.Clear();
                }
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true; // Ignorar outros caracteres
            }
        }

        private void resetarButton_Click(object sender, EventArgs e)
        {
            // Resetar a lista e o estado
            numeros.Clear();
            continuar = true;

            // Limpar o TextBox e habilitá-lo novamente
            textBoxNumero.Clear();
            textBoxNumero.Enabled = true;
            // Limpar o Label
            labelMedia.Text = "Média dos Números";
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            // Sair do programa
            Application.Exit();
        }
    }
}
