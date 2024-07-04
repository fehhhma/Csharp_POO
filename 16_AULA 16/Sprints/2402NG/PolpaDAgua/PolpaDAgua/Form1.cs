namespace PolpaDAgua
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

                //Recepção de dados

                double largura = Convert.ToDouble(larguraBox.Text);
                double comprimento = Convert.ToDouble(comprimentoBox.Text);
                double altura = Convert.ToDouble(alturaBox.Text);

                double taxa = Convert.ToDouble(taxaBox.Text); //Litros por dia

                //Capacidade máxima

                double capacidade = (largura * comprimento * altura) / 1000;
                capacidadeBox.Text = Convert.ToString(capacidade) + " Litros";

                //Autonomia

                double autonomia = capacidade / taxa;
                autonomiaBox.Text = Convert.ToString(autonomia) + " dias";

                if (autonomia < 2)
                {
                    nivelBox.Text = "Nível de consumo elevado";

                }
                else if (autonomia >= 2 && autonomia <= 7)
                {
                    nivelBox.Text = "Nível de consumo moderado";
                }
                else
                {
                    nivelBox.Text = "Nível de consumo reduzido";
                }

                



                


            }
            catch
            {
                MessageBox.Show("Deu pepino");
            }
        }


        //Reset de campos
        private void reset_Click(object sender, EventArgs e)
        {
            larguraBox.Text = null;
            comprimentoBox.Text = null;
            alturaBox.Text = null;

            taxaBox.Text = null;

            capacidadeBox.Text = null;
            autonomiaBox.Text = null;
            nivelBox.Text = null;
        }
    }
}
