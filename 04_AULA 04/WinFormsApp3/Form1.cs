namespace WinFormsApp3
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
                // Capturar os valores dos TextBoxes
                double nota1 = Convert.ToDouble(textBox1.Text);
                double nota2 = Convert.ToDouble(textBox2.Text);
                double nota3 = Convert.ToDouble(textBox3.Text);
                double nota4 = Convert.ToDouble(textBox4.Text);
                double nota5 = Convert.ToDouble(textBox5.Text);

                // Calcular a média
                double media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

                // Determinar se está aprovado ou reprovado
                if (media >= 7)
                {
                    labelResultado.Text = "Aprovado";
                    MessageBox.Show("O aluno(a) está aprovado!", "Resultado");
                }
                else
                {
                    labelResultado.Text = "Reprovado";
                    MessageBox.Show("O aluno(a) está reprovado!", "Resultado");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira números válidos nas notas.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Limpar os TextBoxes
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            // Limpar o Label
            labelResultado.Text = "Resultado";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Sair do programa
            Application.Exit();
        }
    }
}
