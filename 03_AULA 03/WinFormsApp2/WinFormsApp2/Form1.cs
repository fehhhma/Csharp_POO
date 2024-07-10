namespace WinFormsApp2
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
                double valor1 = Convert.ToDouble(textBox1.Text);
                double valor2 = Convert.ToDouble(textBox2.Text);
                double resultado = 0;

                // Capturar a operação selecionada no ComboBox
                string operacao = comboBox1.SelectedItem.ToString();

                // Realizar a operação
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
                        if (valor2 != 0)
                            resultado = valor1 / valor2;
                        else
                            MessageBox.Show("Divisão por zero não é permitida.");
                        break;
                    default:
                        MessageBox.Show("Selecione uma operação válida.");
                        break;
                }

                // Exibir o resultado no Label
                label1.Text = "Resultado: " + resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira números válidos.");
            }
        }
    }
}
