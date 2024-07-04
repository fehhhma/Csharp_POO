namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                double nota1 = Convert.ToDouble(textBox1.Text);
                double nota2 = Convert.ToDouble(textBox2.Text);
                double nota3 = Convert.ToDouble(textBox3.Text);
                double nota4 = Convert.ToDouble(textBox4.Text);
                double nota5 = Convert.ToDouble(textBox5.Text);

                double media = (nota1 + nota2 + nota3 + nota4 + nota5);


                if (media >= 7)
                    {
                    labelResultado.Text = "Aprovado";
                    MessageBox.Show("O Aluno esta aprovado! Sua média foi: " + media, "Resultado");
                    }
                else
                {
                    labelResultado.Text = "Reprovado";
                    MessageBox.Show("O Aluno esta reprovado! Sua média foi: " + media, "Resultado");
                }
            }
             catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um numero válido");
            }
        }    
    }
}
