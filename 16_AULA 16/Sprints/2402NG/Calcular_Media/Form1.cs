using System.Reflection.Metadata;

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
                //Conversão de valores dos Textboxes
                double nota1 = Convert.ToDouble(textBox1.Text);
                double nota2 = Convert.ToDouble(textBox2.Text);
                double nota3 = Convert.ToDouble(textBox3.Text);
                double nota4 = Convert.ToDouble(textBox4.Text);
                double nota5 = Convert.ToDouble(textBox5.Text);

                //Calcular média
                double media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

                //Aprovado ou reprovado

                if (media >= 7)
                {
                    labelResultado.Text = "Aprovado " + media;
                    MessageBox.Show("O Aluno está aprovado! :)", "Resultado");
                }
                else
                {
                    labelResultado.Text = "Reprovado " + media;
                    MessageBox.Show("O Aluno está Reprovado! :(", "Resultado");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira números válidos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Resetar textbox
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            labelResultado.Text = "Resultado";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Sair
            Application.Exit();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Média ponderada
            try
            {
                //Conversão de valores dos Textboxes
                double nota1 = Convert.ToDouble(textBox1.Text);
                double nota2 = Convert.ToDouble(textBox2.Text);
                double nota3 = Convert.ToDouble(textBox3.Text);
                double nota4 = Convert.ToDouble(textBox4.Text);
                double nota5 = Convert.ToDouble(textBox5.Text);

                //Calcular média
                double media = ((nota1 * 10) + (nota2 * 20) + (nota3 * 40) + (nota4 * 20 ) + (nota5 * 10)) / 100;

                //Aprovado ou reprovado

                if (media >= 7)
                {
                    labelPonderada.Text = "Aprovado " + media;
                    MessageBox.Show("O Aluno está aprovado! :)", "Resultado");
                }
                else
                {
                    labelPonderada.Text = "Reprovado " + media;
                    MessageBox.Show("O Aluno está Reprovado! :(", "Resultado");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira números válidos");
            }

        }
    }
}
