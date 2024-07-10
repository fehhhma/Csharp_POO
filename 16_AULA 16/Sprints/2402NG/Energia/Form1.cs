using System.Configuration;

namespace WinFormsApp7
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
                double salario = Convert.ToDouble(textBox1.Text);
                double quilowatts = Convert.ToDouble(textBox2.Text);

                //o valor em reais de cada quilowatts
                double valor = (salario / 7) / 100;
                double valor2 = Math.Round(valor, 2);

                //o valor em reais a ser pago
                double reais = valor * quilowatts;
                double reais2 = Math.Round(reais, 2);

                //valor com desconto de 10%
                double quant_desconto = (reais * 0.10);
                double desconto = reais - quant_desconto;
                double desconto2 = Math.Round(desconto, 2);

                label3.Text = "O valor em reais de cada quilowatts: " + valor2;
                label4.Text = "O valor em reais a ser pago: " + reais2;
                label5.Text = "O valor a ser pago com 10% de desconto: " + desconto2;
            }
            catch (FormatException)
            {  
                MessageBox.Show("Por favor, insira números válidos");
            }

        }
    }
}
