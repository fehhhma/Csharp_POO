using System.Linq.Expressions;

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
                //valores texbox 
                double valor1 = Convert.ToDouble(textBox1.Text);
                double valor2 = Convert.ToDouble(textBox3.Text);
                double resultado = 0;

                //capturar operação no combobox
                string operacao = comboBox1.SelectedItem.ToString();

                //realização da operação
                switch (operacao)
                {
                    case "+":
                        resultado = valor1 + valor2;
                        break;

                    case "-":
                        resultado = valor1 + valor2;
                        break;

                    case "*":
                        resultado = valor1 + valor2;
                        break;
                    
                    case "%":
                        resultado = valor1 % valor2;
                        break; 

                    case "/":
                        if (valor2 != 0) //operador logico
                            resultado = valor1 + valor2;
                        else
                            MessageBox.Show("Divisçâo por zero não é possivel");
                        break;
                }
                //exibir o resultado no label 
                label2.Text = "resultado: " + resultado.ToString();
            }

            catch (FormatException)
            {
                MessageBox.Show("Por favor insira números válidos");
            }
                        
                        
                }
            }
        }

