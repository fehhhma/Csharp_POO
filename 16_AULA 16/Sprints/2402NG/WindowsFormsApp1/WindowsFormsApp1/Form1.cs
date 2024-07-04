using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
                //Conversão dos valores do texboxes
                double nota1 = Convert.ToDouble(textBox1.Text);
                double nota2 = Convert.ToDouble(textBox2.Text);
                double nota3 = Convert.ToDouble(textBox3.Text);
                double nota4 = Convert.ToDouble(textBox4.Text);
                double nota5 = Convert.ToDouble(textBox5.Text);

                    // calcular media
                double media = (nota1 + nota2 + nota3 + nota4 + nota5);

                    //Aprovado ou reprovado

                if (media >= 7)
                {
                    labelResultado.Text = "Aprovado";
                    MessageBox.Show("O Aluno esta aprovado!");
                }
                else
                {
                    labelResultado.Text = "Reprovado";
                    MessageBox.Show("O alulo esta Reprovado!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, informe um n´pumero válido");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Resetar
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            labelResultado.Text = ("Reprovado");

           

        }
        }
    }
