using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private double soma = 0;
        private int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double temperatura = Convert.ToDouble(textBox1.Text);

                soma += temperatura;
                contador++;
                double media = soma / contador;

                while (true)
                {
                    if (temperatura < 37.2)
                    {
                        label1.Text = "Temperatura normal: " + temperatura.ToString("F2");
                    }
                    else if (temperatura > 37.2 || temperatura < 38)
                    {
                        label1.Text = "Estado febril: " + temperatura.ToString("F2");
                    }
                    else if (temperatura > 38.1 || temperatura < 39)
                    {
                        label1.Text = "Com febre: " + temperatura.ToString("F2");
                    }
                    else
                    {
                        label1.Text = "Febre alta: " + temperatura.ToString("F2");
                    }
                    break;
                }
                    
                    MessageBox.Show("A média é: " + media.ToString("F2") + "\nA quantidade de pessoas: " + contador.ToString("F0"), "Média");
                    textBox1.Clear();
            }
            catch
            {
                MessageBox.Show("Insira um número correto");
            }
        }
    }
}
