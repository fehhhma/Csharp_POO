namespace TabuadaDeTreinamento
{

    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int numTentativas = 0;
        private int numAcertos = 0;
        private int numErros = 0;
        private int numeroAlvo;

       

            public Form1()
        {
            InitializeComponent();
            Resetar();

        }

        private void Resetar()
        {
            numTentativas = 0;
            numAcertos = 0;
            numErros = 0;
            AtualizarLabels();
            GerarNovoNumeroAlvo();
            textBoxNumero1.Clear();
            textBoxNumero1.Focus();
        }

        private void GerarNovoNumeroAlvo()
        {
            numeroAlvo = random.Next(1, 11);
        }

        private void AtualizarLabels()
        {
            labelAcertos.Text = $"Acertos: {numAcertos}";
            labelErros.Text = $"Erros: {numErros}";
        }

        private void buttonResetar_Click_Click(object sender, EventArgs e)
        {
            Resetar();
        }

        private void buttonVerificar_Click_Click(object sender, EventArgs e)
        {
            try
            {
                int resposta = 0;

                if (textBoxNumero1.Visible)
                {
                    resposta = int.Parse(textBoxNumero1.Text);
                }
                else if (textBoxNumero2.Visible)
                {
                    resposta = int.Parse(textBoxNumero2.Text);
                }

                if (resposta < 1 || resposta > 10)
                {
                    MessageBox.Show("Digite um número entre 1 e 10.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxNumero1.Clear();
                    textBoxNumero2.Clear();
                    textBoxNumero1.Focus();
                    return;
                }

                numTentativas++;

                if (resposta == numeroAlvo)
                {
                    MessageBox.Show("Você acertou!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    numAcertos++;
                }
                else
                {
                    MessageBox.Show($"Você errou! O número correto era {numeroAlvo}.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numErros++;
                }

                AtualizarLabels();
                GerarNovoNumeroAlvo();
                textBoxNumero1.Clear();
                textBoxNumero2.Clear();
                textBoxNumero1.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, digite um número válido.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNumero1.Clear();
                textBoxNumero2.Clear();
                textBoxNumero1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSair_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }
      
    }
    }

