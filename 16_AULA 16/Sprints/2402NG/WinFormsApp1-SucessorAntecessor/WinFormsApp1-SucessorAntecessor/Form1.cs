using System.Diagnostics;

namespace WinFormsApp1_SucessorAntecessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            {
                // Verifica se o usuário digitou um número válido
                if (int.TryParse(txtNumero.Text, out int numero))
                {
                    // Calcula o sucessor e exibe na label correspondente
                    lblSucessor.Text = $"Sucessor: {numero + 1}";

                    // Calcula o antecessor e exibe na label correspondente
                    lblAntecessor.Text = $"Antecessor: {numero - 1}";
                }
                else
                {
                    // Caso o usuário não tenha digitado um número válido
                    MessageBox.Show("Por favor, digite um número inteiro válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

    }
    
    