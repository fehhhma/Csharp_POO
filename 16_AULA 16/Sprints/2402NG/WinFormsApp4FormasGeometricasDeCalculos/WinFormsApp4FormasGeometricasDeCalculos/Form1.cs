namespace WinFormsApp4FormasGeometricasDeCalculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa os campos de entrada e o label de resultado
            txtMedida.Text = "";
            lblResultado.Text = "";
            cmbForma.SelectedIndex = -1; // Reseta a seleção do ComboBox
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Fecha o aplicativo
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Limpa o label de resultado antes de calcular
            lblResultado.Text = "";

            // Lê o tipo de forma geométrica escolhida
            string forma = cmbForma.Text.ToLower();

            // Variáveis para armazenar os dados de entrada
            double area = 0.0;
            double lado = 0.0;
            double raio = 0.0;



            // Verifica qual forma foi escolhida e calcula a área correspondente
            switch (forma)
            {
                case "círculo":
                    if (double.TryParse(txtMedida.Text, out raio))
                    {
                        area = Math.PI * Math.Pow(raio, 2);
                        lblResultado.Text = $"Área do círculo: {area:F2}";
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira um valor válido para o raio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "triângulo":
                    if (double.TryParse(txtMedida.Text, out lado))
                    {
                        area = (lado * lado) / 2.0;
                        lblResultado.Text = $"Área do triângulo: {area:F2}";
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira um valor válido para a base do triângulo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "quadrado":
                    if (double.TryParse(txtMedida.Text, out lado))
                    {
                        area = lado * lado;
                        lblResultado.Text = $"Área do quadrado: {area:F2}";
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira um valor válido para o lado do quadrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                default:
                    MessageBox.Show("Por favor, selecione uma forma geométrica válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
    }

