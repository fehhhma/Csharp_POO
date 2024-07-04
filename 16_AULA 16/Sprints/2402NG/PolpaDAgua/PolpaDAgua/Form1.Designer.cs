namespace PolpaDAgua
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
            label1 = new Label();
            larguraBox = new TextBox();
            comprimentoBox = new TextBox();
            alturaBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            taxaBox = new TextBox();
            button1 = new Button();
            label6 = new Label();
            capacidadeBox = new TextBox();
            label7 = new Label();
            autonomiaBox = new TextBox();
            label8 = new Label();
            nivelBox = new TextBox();
            reset = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 16);
            label1.Name = "label1";
            label1.Size = new Size(246, 20);
            label1.TabIndex = 0;
            label1.Text = "Insira as dimensões da caixa d`água";
            // 
            // larguraBox
            // 
            larguraBox.Location = new Point(169, 46);
            larguraBox.Name = "larguraBox";
            larguraBox.Size = new Size(125, 27);
            larguraBox.TabIndex = 1;
            // 
            // comprimentoBox
            // 
            comprimentoBox.Location = new Point(169, 82);
            comprimentoBox.Name = "comprimentoBox";
            comprimentoBox.Size = new Size(125, 27);
            comprimentoBox.TabIndex = 1;
            // 
            // alturaBox
            // 
            alturaBox.Location = new Point(169, 114);
            alturaBox.Name = "alturaBox";
            alturaBox.Size = new Size(125, 27);
            alturaBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 49);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 2;
            label2.Text = "Largura (cm)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 79);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 3;
            label3.Text = "Comprimento (cm)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 114);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 4;
            label4.Text = "Altura (cm)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 157);
            label5.Name = "label5";
            label5.Size = new Size(392, 20);
            label5.TabIndex = 5;
            label5.Text = "Insira a taxa de consumo do reservatório em litros por dia";
            // 
            // taxaBox
            // 
            taxaBox.Location = new Point(28, 191);
            taxaBox.Name = "taxaBox";
            taxaBox.Size = new Size(266, 27);
            taxaBox.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(28, 243);
            button1.Name = "button1";
            button1.Size = new Size(266, 29);
            button1.TabIndex = 7;
            button1.Text = "Gerar informações";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(488, 16);
            label6.Name = "label6";
            label6.Size = new Size(193, 20);
            label6.TabIndex = 8;
            label6.Text = "Capacidade do reservatório";
            // 
            // capacidadeBox
            // 
            capacidadeBox.Location = new Point(488, 49);
            capacidadeBox.Name = "capacidadeBox";
            capacidadeBox.Size = new Size(193, 27);
            capacidadeBox.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(488, 89);
            label7.Name = "label7";
            label7.Size = new Size(188, 20);
            label7.TabIndex = 10;
            label7.Text = "Autonomia do reservatório";
            // 
            // autonomiaBox
            // 
            autonomiaBox.Location = new Point(488, 114);
            autonomiaBox.Name = "autonomiaBox";
            autonomiaBox.Size = new Size(193, 27);
            autonomiaBox.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(488, 157);
            label8.Name = "label8";
            label8.Size = new Size(128, 20);
            label8.TabIndex = 12;
            label8.Text = "Nivel de consumo";
            // 
            // nivelBox
            // 
            nivelBox.Location = new Point(488, 191);
            nivelBox.Name = "nivelBox";
            nivelBox.Size = new Size(188, 27);
            nivelBox.TabIndex = 13;
            // 
            // reset
            // 
            reset.Location = new Point(28, 385);
            reset.Name = "reset";
            reset.Size = new Size(94, 29);
            reset.TabIndex = 14;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reset);
            Controls.Add(nivelBox);
            Controls.Add(label8);
            Controls.Add(autonomiaBox);
            Controls.Add(label7);
            Controls.Add(capacidadeBox);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(taxaBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(alturaBox);
            Controls.Add(comprimentoBox);
            Controls.Add(larguraBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "PoupaDAgua";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox larguraBox;
        private TextBox comprimentoBox;
        private TextBox alturaBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox taxaBox;
        private Button button1;
        private Label label6;
        private TextBox capacidadeBox;
        private Label label7;
        private TextBox autonomiaBox;
        private Label label8;
        private TextBox nivelBox;
        private Button reset;
    }
}
