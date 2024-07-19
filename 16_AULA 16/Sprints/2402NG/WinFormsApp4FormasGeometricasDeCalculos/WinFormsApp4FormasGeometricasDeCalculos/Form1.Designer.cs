namespace WinFormsApp4FormasGeometricasDeCalculos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalcular = new Button();
            txtMedida = new TextBox();
            label1 = new Label();
            cmbForma = new ComboBox();
            lblResultado = new Label();
            btnLimpar = new Button();
            btnSair = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(481, 178);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtMedida
            // 
            txtMedida.Location = new Point(80, 178);
            txtMedida.Name = "txtMedida";
            txtMedida.Size = new Size(291, 23);
            txtMedida.TabIndex = 1;
            txtMedida.Text = " Insira a medida necessária (raio, lado ou base) :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(389, 178);
            label1.Name = "label1";
            label1.Size = new Size(60, 45);
            label1.TabIndex = 2;
            label1.Text = "Triangulo\r\nCirculo\r\nQuadrado";
            // 
            // cmbForma
            // 
            cmbForma.FormattingEnabled = true;
            cmbForma.Items.AddRange(new object[] { "círculo", "triângulo", "quadrado" });
            cmbForma.Location = new Point(80, 284);
            cmbForma.Name = "cmbForma";
            cmbForma.Size = new Size(121, 23);
            cmbForma.TabIndex = 3;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(357, 292);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(481, 232);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(481, 275);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 6;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 218);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 23);
            textBox1.TabIndex = 7;
            textBox1.Text = " Insira a medida necessária (raio, lado ou base) :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(lblResultado);
            Controls.Add(cmbForma);
            Controls.Add(label1);
            Controls.Add(txtMedida);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtMedida;
        private Label label1;
        private ComboBox cmbForma;
        private Label lblResultado;
        private Button btnLimpar;
        private Button btnSair;
        private TextBox textBox1;
    }
}
