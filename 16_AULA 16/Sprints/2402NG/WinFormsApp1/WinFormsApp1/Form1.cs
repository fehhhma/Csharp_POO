namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // talvez o texto seja alterado
            label1.Text = "obrigado(a)" + textBox1.Text + "pelo seu cadastro :)";
        }

    }

}
