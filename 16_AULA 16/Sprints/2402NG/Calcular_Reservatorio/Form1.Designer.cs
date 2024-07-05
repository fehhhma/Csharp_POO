namespace WinFormsApp5
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            labelAltura = new Label();
            labelLargura = new Label();
            comprimento = new Label();
            consumodiario = new Label();
            textBox4 = new TextBox();
            labelCapacidadetotal = new Label();
            labelAutonomia = new Label();
            labelClassificacao = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DeepSkyBlue;
            textBox1.Location = new Point(274, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DeepSkyBlue;
            textBox2.Location = new Point(274, 220);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DeepSkyBlue;
            textBox3.Location = new Point(274, 311);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            // 
            // labelAltura
            // 
            labelAltura.AutoSize = true;
            labelAltura.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAltura.Location = new Point(180, 129);
            labelAltura.Name = "labelAltura";
            labelAltura.Size = new Size(65, 23);
            labelAltura.TabIndex = 3;
            labelAltura.Text = "Altura:";
            // 
            // labelLargura
            // 
            labelLargura.AutoSize = true;
            labelLargura.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLargura.Location = new Point(168, 220);
            labelLargura.Name = "labelLargura";
            labelLargura.Size = new Size(77, 23);
            labelLargura.TabIndex = 4;
            labelLargura.Text = "Largura:";
            // 
            // comprimento
            // 
            comprimento.AutoSize = true;
            comprimento.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comprimento.Location = new Point(118, 316);
            comprimento.Name = "comprimento";
            comprimento.Size = new Size(127, 23);
            comprimento.TabIndex = 5;
            comprimento.Text = "Comprimento:";
            // 
            // consumodiario
            // 
            consumodiario.AutoSize = true;
            consumodiario.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            consumodiario.Location = new Point(48, 402);
            consumodiario.Name = "consumodiario";
            consumodiario.Size = new Size(197, 23);
            consumodiario.TabIndex = 6;
            consumodiario.Text = "Consumo médio diário:";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DeepSkyBlue;
            textBox4.Location = new Point(274, 402);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 7;
            // 
            // labelCapacidadetotal
            // 
            labelCapacidadetotal.AutoSize = true;
            labelCapacidadetotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCapacidadetotal.Location = new Point(580, 100);
            labelCapacidadetotal.Name = "labelCapacidadetotal";
            labelCapacidadetotal.Size = new Size(151, 23);
            labelCapacidadetotal.TabIndex = 8;
            labelCapacidadetotal.Text = "Capacidade total:";
            // 
            // labelAutonomia
            // 
            labelAutonomia.AutoSize = true;
            labelAutonomia.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAutonomia.Location = new Point(580, 227);
            labelAutonomia.Name = "labelAutonomia";
            labelAutonomia.Size = new Size(104, 23);
            labelAutonomia.TabIndex = 9;
            labelAutonomia.Text = "Autonomia:";
            // 
            // labelClassificacao
            // 
            labelClassificacao.AutoSize = true;
            labelClassificacao.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelClassificacao.Location = new Point(580, 364);
            labelClassificacao.Name = "labelClassificacao";
            labelClassificacao.Size = new Size(217, 23);
            labelClassificacao.TabIndex = 10;
            labelClassificacao.Text = "Classificação do consumo:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(580, 147);
            button1.Name = "button1";
            button1.Size = new Size(166, 59);
            button1.TabIndex = 11;
            button1.Text = "Calcular Capacidade Total";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(580, 275);
            button2.Name = "button2";
            button2.Size = new Size(134, 62);
            button2.TabIndex = 12;
            button2.Text = "Calcular autonomia";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(580, 406);
            button3.Name = "button3";
            button3.Size = new Size(130, 77);
            button3.TabIndex = 13;
            button3.Text = "Calcular Classificação do Consumo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SWComp", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(353, 23);
            label1.Name = "label1";
            label1.Size = new Size(277, 38);
            label1.TabIndex = 14;
            label1.Text = "Reservatório ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(415, 136);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 15;
            label2.Text = "cm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(415, 224);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 16;
            label3.Text = "cm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(415, 316);
            label4.Name = "label4";
            label4.Size = new Size(30, 20);
            label4.TabIndex = 17;
            label4.Text = "cm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(416, 408);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 18;
            label5.Text = "litros/dia";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(948, 530);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelClassificacao);
            Controls.Add(labelAutonomia);
            Controls.Add(labelCapacidadetotal);
            Controls.Add(textBox4);
            Controls.Add(consumodiario);
            Controls.Add(comprimento);
            Controls.Add(labelLargura);
            Controls.Add(labelAltura);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label labelAltura;
        private Label labelLargura;
        private Label comprimento;
        private Label consumodiario;
        private TextBox textBox4;
        private Label labelCapacidadetotal;
        private Label labelAutonomia;
        private Label labelClassificacao;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
