using System.Diagnostics.Eventing.Reader;
using System.Runtime.Intrinsics.X86;

namespace ConversordeMoedas
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
                string moeda1 = comboBox1.Text.ToString();
                string moeda2 = comboBox2.Text.ToString();
                double dados = Convert.ToDouble(textBox1.Text);

                if (moeda1 != "" && moeda2 != "")
                {
                    switch (moeda1)
                    {
                        case "Real (BRL)":
                            {
                                if (moeda2 == "Dólar (USD)")
                                {
                                    CotacaoDolarReal();
                                }
                                else if (moeda2 == "Euro (EUR)")
                                {
                                    CotacaoEuroReal();
                                }
                                else if (moeda2 == "Iene (JPY)")
                                {
                                    CotacaoIeneReal();
                                }
                                else if (moeda2 == "Libra (GBP)")
                                {
                                    CotacaoLibraReal();
                                }
                                else if (moeda2 == "Real (BRL)")
                                {
                                    label4.Text = "Conversão: " + dados + " reais";
                                }

                                else if (moeda2 == "Peso (MXN)")
                                {
                                    CotacaoPesoReal();
                                }
                                break;

                            }
                        case "Dólar (USD)":
                            {
                                if (moeda2 == "Real (BRL)")
                                {
                                    CotacaoRealDolar();
                                }
                                else if (moeda2 == "Euro (EUR)")
                                {
                                    CotacaoEuroDolar();
                                }
                                else if (moeda2 == "Iene (JPY)")
                                {
                                    CotacaoIeneDolar();
                                }
                                else if (moeda2 == "Libra (GBP)")
                                {
                                    CotacaoLibraDolar();
                                }
                                else if (moeda2 == "Dólar (USD)")
                                {
                                    label4.Text = "Conversão: " + dados + " dólares";
                                }

                                else if (moeda2 == "Peso (MXN)")
                                {
                                    CotacaoPesoDolar();
                                }
                                break;

                            }
                        case "Iene (JPY)":
                            {
                                if (moeda2 == "Real (BRL)")
                                {
                                    CotacaoRealIene();
                                }
                                else if (moeda2 == "Euro (EUR)")
                                {
                                    CotacaoEuroIene();
                                }
                                else if (moeda2 == "Dólar (USD)")
                                {
                                    CotacaoDolarIene();
                                }
                                else if (moeda2 == "Libra (GBP)")
                                {
                                    CotacaoLibraIene();
                                }
                                else if (moeda2 == "Iene (JPY)")
                                {
                                    label4.Text = "Conversão: " + dados + " ienes";
                                }

                                else if (moeda2 == "Peso (MXN)")
                                {
                                    CotacaoPesoIene();
                                }
                                break;

                            }
                        case "Euro (EUR)":
                            {
                                if (moeda2 == "Real (BRL)")
                                {
                                    CotacaoRealEuro();
                                }
                                else if (moeda2 == "Iene (JPY)")
                                {
                                    CotacaoIeneEuro();
                                }
                                else if (moeda2 == "Dólar (USD)")
                                {
                                    CotacaoDolarEuro();
                                }
                                else if (moeda2 == "Libra (GBP)")
                                {
                                    CotacaoLibraEuro();
                                }
                                else if (moeda2 == "Euro (EUR)")
                                {
                                    label4.Text = "Conversão: " + dados + " euros";
                                }

                                else if (moeda2 == "Peso (MXN)")
                                {
                                    CotacaoPesoEuro();
                                }
                                break;

                            }
                        case "Libra (GBP)":
                            {
                                if (moeda2 == "Real (BRL)")
                                {
                                    CotacaoRealLibra();
                                }
                                else if (moeda2 == "Iene (JPY)")
                                {
                                    CotacaoIeneLibra();
                                }
                                else if (moeda2 == "Dólar (USD)")
                                {
                                    CotacaoDolarLibra();
                                }
                                else if (moeda2 == "Euro (EUR)")
                                {
                                    CotacaoEuroLibra();
                                }
                                else if (moeda2 == "Libra (GBP)")
                                {
                                    label4.Text = "Conversão: " + dados + " libras";
                                }

                                else if (moeda2 == "Peso (MXN)")
                                {
                                    CotacaoPesoLibra();
                                }
                                break;

                            }
                        case "Peso (MXN)":
                            {
                                if (moeda2 == "Real (BRL)")
                                {
                                    CotacaoRealPeso();
                                }
                                else if (moeda2 == "Iene (JPY)")
                                {
                                    CotacaoIenePeso();
                                }
                                else if (moeda2 == "Dólar (USD)")
                                {
                                    CotacaoDolarPeso();
                                }
                                else if (moeda2 == "Euro (EUR)")
                                {
                                    CotacaoEuroPeso();
                                }
                                else if (moeda2 == "Peso (MXN)")
                                {
                                    label4.Text = "Conversão: " + dados + " pesos";
                                }

                                else if (moeda2 == "Libra (GBP)")
                                {
                                    CotacaoLibraPeso();
                                }
                                break;

                            }                    
                    }                    
                }
                else
                {
                    MessageBox.Show("Selecione uma opção.", "Atenção");
                }
            }
            catch
            {
                MessageBox.Show("Por favor, digite o valor a ser convertido.", "Atenção");
            }

        }
        //converção de real para moedas
        private void CotacaoDolarReal()
        {
            double dolar = Convert.ToDouble(textBox1.Text);
            double resultado = dolar / 5.49;
            label4.Text = "Conversão: " + resultado.ToString("F2") + " dólares";

        }
        private void CotacaoEuroReal()
        {
            double euro = Convert.ToDouble(textBox1.Text);
            double resultado = euro / 6.0;
            label4.Text = "Conversão: " + resultado.ToString("F2") + " euros";

        }
        private void CotacaoIeneReal()
        {
            double iene = Convert.ToDouble(textBox1.Text);
            double resultado = iene * 28.43;
            label4.Text = "Conversão: " + resultado.ToString("F2") + " ienes";

        }
        private void CotacaoLibraReal()
        {
            double libra = Convert.ToDouble(textBox1.Text);
            double resultado = libra / 7.14;
            label4.Text = "Conversão: " + resultado.ToString("F2") + " libras";

        }

        private void CotacaoPesoReal()
        {
            double peso = Convert.ToDouble(textBox1.Text);
            double resultado = peso * 0.14;
            label4.Text = "Conversão: " + resultado.ToString("F2") + " pesos";

        }
        //converção de dolar para moedas
        private void CotacaoEuroDolar()
        {
            double euro = Convert.ToDouble(textBox1.Text);
            double resultado = euro * 0.91;
            label4.Text = "Conversão: " + resultado.ToString("F2") + " euros";

        }
        private void CotacaoIeneDolar()
        {
            double iene = Convert.ToDouble(textBox1.Text);
            double resultado = iene * 156.13;
            label4.Text = "Conversão: " + resultado.ToString("F2") + " ienes";

        }
        private void CotacaoLibraDolar()
        {
            double libra = Convert.ToDouble(textBox1.Text);
            double resultado = libra * 0.77;
            label4.Text = "Conversão: " + resultado.ToString("F2") + " libras";

        }
        private void CotacaoRealDolar()
        {
            double real = Convert.ToDouble(textBox1.Text);
            double resultado = real * 5.49;
            label4.Text = "Conversão: " + resultado.ToString("F2") + " reais";

        }

        private void CotacaoPesoDolar()
        {
            double peso = Convert.ToDouble(textBox1.Text);
            double resultado = peso * 922.83;
            label4.Text = "Conversão: " + resultado.ToString("F2") + " pesos";

        }

        //converção de iene para moedas
        private void CotacaoEuroIene()
        {
            double euro = Convert.ToDouble(textBox1.Text);
            double resultado = euro * 0.0059;
            label4.Text = "Conversão: " + resultado.ToString("F3") + " euros";

        }
        private void CotacaoDolarIene()
        {
            double dolar = Convert.ToDouble(textBox1.Text);
            double resultado = dolar * 0.0064;
            label4.Text = "Conversão: " + resultado.ToString("F3") + " dólares";

        }
        private void CotacaoLibraIene()
        {
            double libra = Convert.ToDouble(textBox1.Text);
            double resultado = libra * 0.0049;
            label4.Text = "Conversão: " + resultado.ToString("F3") + " libras";

        }
        private void CotacaoRealIene()
        {
            double real = Convert.ToDouble(textBox1.Text);
            double resultado = real * 0.035;
            label4.Text = "Conversão: " + resultado.ToString("F2") + " reais";

        }

        private void CotacaoPesoIene()
        {
            double peso = Convert.ToDouble(textBox1.Text);
            double resultado = peso * 5.94;
            label4.Text = "Conversão: " + resultado.ToString("F2") + " pesos";

        }
        //converção de euro para moedas
        private void CotacaoIeneEuro()
        {
            double iene = Convert.ToDouble(textBox1.Text);
            double resultado = iene * 170.20;
            label4.Text = "Conversão: " + resultado.ToString("F2") + " ienes";

        }
        private void CotacaoDolarEuro()
        {
            double dolar = Convert.ToDouble(textBox1.Text);
            double resultado = dolar * 1.09;
            label4.Text = "Conversão: " + resultado.ToString("F2") + " dólares";

        }
        private void CotacaoLibraEuro()
        {
            double libra = Convert.ToDouble(textBox1.Text);
            double resultado = libra * 0.84;
            label4.Text = "Conversão: " + resultado.ToString("F2") + " libras";

        }
        private void CotacaoRealEuro()
        {
            double real = Convert.ToDouble(textBox1.Text);
            double resultado = real * 6.01;
            label4.Text = "Conversão: " + resultado.ToString("F2") + " reais";

        }

        private void CotacaoPesoEuro()
        {
            double peso = Convert.ToDouble(textBox1.Text);
            double resultado = peso * 1009.72;
            label4.Text = "Conversão: " + resultado.ToString("F2") + " pesos";

        }

        //converção de libra para moedas
        private void CotacaoIeneLibra()
        {
            double iene = Convert.ToDouble(textBox1.Text);
            double resultado = iene * 202.49;
            label4.Text = "Conversão: " + resultado.ToString("F2") + " ienes";

        }
        private void CotacaoDolarLibra()
        {
            double dolar = Convert.ToDouble(textBox1.Text);
            double resultado = dolar * 1.30;
            label4.Text = "Conversão: " + resultado.ToString("F2") + " dólares";

        }
        private void CotacaoEuroLibra()
        {
            double euro = Convert.ToDouble(textBox1.Text);
            double resultado = euro * 1.19;
            label4.Text = "Conversão: " + resultado.ToString("F2") + " euros";

        }
        private void CotacaoRealLibra()
        {
            double real = Convert.ToDouble(textBox1.Text);
            double resultado = real * 7.14;
            label4.Text = "Conversão: " + resultado.ToString("F2") + " reais";

        }

        private void CotacaoPesoLibra()
        {
            double peso = Convert.ToDouble(textBox1.Text);
            double resultado = peso * 1200.71;
            label4.Text = "Conversão: " + resultado.ToString("F2") + " pesos";

        }

        //converção de peso para moedas
        private void CotacaoIenePeso()
        {
            double iene = Convert.ToDouble(textBox1.Text);
            double resultado = iene * 0.17;
            label4.Text = "Conversão: " + resultado.ToString("F2") + " ienes";

        }
        private void CotacaoDolarPeso()
        {
            double dolar = Convert.ToDouble(textBox1.Text);
            double resultado = dolar * 0.0011;
            label4.Text = "Conversão: " + resultado.ToString("F4") + " dólares";

        }
        private void CotacaoEuroPeso()
        {
            double euro = Convert.ToDouble(textBox1.Text);
            double resultado = euro * 0.00099;
            label4.Text = "Conversão: " + resultado.ToString("F4") + " euros";

        }
        private void CotacaoRealPeso()
        {
            double real = Convert.ToDouble(textBox1.Text);
            double resultado = real * 0.0059;
            label4.Text = "Conversão: " + resultado.ToString("F3") + " reais";

        }

        private void CotacaoLibraPeso()
        {
            double libra = Convert.ToDouble(textBox1.Text);
            double resultado = libra * 0.00083;
            label4.Text = "Conversão: " + resultado.ToString("F4") + " libras";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            textBox1.Text = "";
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("É hora de dar tchau!", "Encerrando");
            Application.Exit();
        }
    }
}
