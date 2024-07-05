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
                //capturar os valores do TextBox
                double valor1 = Convert.ToDouble(textBox1.Text);
                double valor2 = Convert.ToDouble(textBox2.Text);
                double resultado = 0;

                //capturar a operação no combobox
                string operacao = comboBox1.SelectedItem.ToString();

                //realizar a operacao
                switch (operacao)
                {
                    case "+":
                        resultado = valor1 + valor2;
                        break;
                    case "-":
                        resultado = valor1 - valor2;
                        break;
                    case "*":
                        resultado = valor1 * valor2;
                        break;
                    case "/":
                        if (valor2 != 0) //operador lógico
                            resultado = valor1 / valor2;
                        else
                            MessageBox.Show("Divisão por zero não é permitida");
                        break;
                }
                //exibir o resultado no label
                label1.Text = "Resultado: " + resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira números válidos.");
            }
        }
    }
}