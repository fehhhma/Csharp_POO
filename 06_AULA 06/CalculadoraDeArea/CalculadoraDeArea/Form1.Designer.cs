namespace CalculadoraDeArea
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            comboBoxFormas = new ComboBox();
            textBoxValor1 = new TextBox();
            textBoxValor2 = new TextBox();
            textBoxValor3 = new TextBox();
            calcularButton = new Button();
            resetarButton = new Button();
            sairButton = new Button();
            labelResultado = new Label();
            SuspendLayout();
            // 
            // comboBoxFormas
            // 
            comboBoxFormas.FormattingEnabled = true;
            comboBoxFormas.Location = new Point(275, 60);
            comboBoxFormas.Margin = new Padding(6, 6, 6, 6);
            comboBoxFormas.Name = "comboBoxFormas";
            comboBoxFormas.Size = new Size(218, 33);
            comboBoxFormas.TabIndex = 0;
            // 
            // textBoxValor1
            // 
            textBoxValor1.Location = new Point(275, 134);
            textBoxValor1.Margin = new Padding(6, 6, 6, 6);
            textBoxValor1.Name = "textBoxValor1";
            textBoxValor1.Size = new Size(180, 33);
            textBoxValor1.TabIndex = 1;
            // 
            // textBoxValor2
            // 
            textBoxValor2.Location = new Point(275, 209);
            textBoxValor2.Margin = new Padding(6, 6, 6, 6);
            textBoxValor2.Name = "textBoxValor2";
            textBoxValor2.Size = new Size(180, 33);
            textBoxValor2.TabIndex = 2;
            // 
            // textBoxValor3
            // 
            textBoxValor3.Location = new Point(275, 280);
            textBoxValor3.Margin = new Padding(6, 6, 6, 6);
            textBoxValor3.Name = "textBoxValor3";
            textBoxValor3.Size = new Size(180, 33);
            textBoxValor3.TabIndex = 3;
            // 
            // calcularButton
            // 
            calcularButton.Location = new Point(92, 365);
            calcularButton.Margin = new Padding(6, 6, 6, 6);
            calcularButton.Name = "calcularButton";
            calcularButton.Size = new Size(138, 44);
            calcularButton.TabIndex = 4;
            calcularButton.Text = "Calcular";
            calcularButton.UseVisualStyleBackColor = true;
            calcularButton.Click += calcularButton_Click;
            // 
            // resetarButton
            // 
            resetarButton.Location = new Point(275, 365);
            resetarButton.Margin = new Padding(6, 6, 6, 6);
            resetarButton.Name = "resetarButton";
            resetarButton.Size = new Size(138, 44);
            resetarButton.TabIndex = 5;
            resetarButton.Text = "Resetar";
            resetarButton.UseVisualStyleBackColor = true;
            resetarButton.Click += resetarButton_Click;
            // 
            // sairButton
            // 
            sairButton.Location = new Point(458, 365);
            sairButton.Margin = new Padding(6, 6, 6, 6);
            sairButton.Name = "sairButton";
            sairButton.Size = new Size(138, 44);
            sairButton.TabIndex = 6;
            sairButton.Text = "Sair";
            sairButton.UseVisualStyleBackColor = true;
            sairButton.Click += sairButton_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(92, 442);
            labelResultado.Margin = new Padding(6, 0, 6, 0);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(170, 28);
            labelResultado.TabIndex = 7;
            labelResultado.Text = "Resultado da Área";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 502);
            Controls.Add(labelResultado);
            Controls.Add(sairButton);
            Controls.Add(resetarButton);
            Controls.Add(calcularButton);
            Controls.Add(textBoxValor3);
            Controls.Add(textBoxValor2);
            Controls.Add(textBoxValor1);
            Controls.Add(comboBoxFormas);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            Text = "Calculadora de Área";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxFormas;
        private System.Windows.Forms.TextBox textBoxValor1;
        private System.Windows.Forms.TextBox textBoxValor2;
        private System.Windows.Forms.TextBox textBoxValor3;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Button resetarButton;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Label labelResultado;
    }
}
