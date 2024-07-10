namespace WinFormsApp1QuadradoNumeroApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Verifica se o usuário digitou um número válido
            if (int.TryParse(textBox1.Text, out int numero))
            {
                // Calcula o quadrado do número
                int quadrado = numero * numero;

                // Exibe o resultado na label correspondente
                lblResultado.Text = $"O quadrado de {numero} é: {quadrado}";
            }
            else
            {
                // Caso o usuário não tenha digitado um número válido
                MessageBox.Show("Por favor, digite um número inteiro válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

