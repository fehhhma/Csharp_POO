namespace WinFormsApp4
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
                // Capturar a idade do TextBox
                int idade = Convert.ToInt32(textBoxIdade.Text);

                // Variável para armazenar a classificação
                string classificacao = "";

                // Determinar a classificação com base na idade
                if (idade >= 5 && idade <= 7)
                {
                    classificacao = "Infantil A";
                    radioButtonInfantilA.Checked = true;
                }
                else if (idade >= 8 && idade <= 11)
                {
                    classificacao = "Infantil B";
                    radioButtonInfantilB.Checked = true;
                }
                else if (idade >= 12 && idade <= 13)
                {
                    classificacao = "Juvenil A";
                    radioButtonJuvenilA.Checked = true;
                }
                else if (idade >= 14 && idade <= 17)
                {
                    classificacao = "Juvenil B";
                    radioButtonJuvenilB.Checked = true;
                }
                else if (idade >= 18)
                {
                    classificacao = "Adultos";
                    radioButtonAdultos.Checked = true;
                }
                else
                {
                    MessageBox.Show("Idade inválida. Por favor, insira uma idade válida.");
                    return;
                }

                // Exibir a classificação no Label
                labelClassificacao.Text = "Classificação: " + classificacao;

                // Exibir a classificação no MessageBox
                MessageBox.Show("A classificação do nadador é: " + classificacao, "Classificação");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira uma idade válida.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Limpar o TextBox
            textBoxIdade.Clear();
            // Limpar os RadioButtons
            radioButtonInfantilA.Checked = false;
            radioButtonInfantilB.Checked = false;
            radioButtonJuvenilA.Checked = false;
            radioButtonJuvenilB.Checked = false;
            radioButtonAdultos.Checked = false;
            // Limpar o Label
            labelClassificacao.Text = "Classificação";
            // Resetar o DateTimePicker para a data atual
            dateTimePickerClassificacao.Value = DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Sair do programa
            Application.Exit();
        }
    }
}
