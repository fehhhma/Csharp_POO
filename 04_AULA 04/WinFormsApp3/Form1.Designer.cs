namespace WinFormsApp3
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
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            labelResultado = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(240, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(240, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(240, 196);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(240, 259);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(240, 317);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(503, 95);
            button1.Name = "button1";
            button1.Size = new Size(155, 84);
            button1.TabIndex = 5;
            button1.Text = "Calcular Média";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(503, 196);
            button2.Name = "button2";
            button2.Size = new Size(155, 84);
            button2.TabIndex = 6;
            button2.Text = "Resetar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(680, 301);
            button3.Name = "button3";
            button3.Size = new Size(155, 84);
            button3.TabIndex = 7;
            button3.Text = "Sair";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(338, 378);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(90, 25);
            labelResultado.TabIndex = 8;
            labelResultado.Text = "Resultado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(296, 9);
            label1.Name = "label1";
            label1.Size = new Size(291, 38);
            label1.TabIndex = 9;
            label1.Text = "CÁLCULO DE MÉDIA ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 72);
            label2.Name = "label2";
            label2.Size = new Size(127, 25);
            label2.TabIndex = 10;
            label2.Text = "Insira a Nota 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 134);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 11;
            label3.Text = "Insira a Nota 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 199);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 12;
            label4.Text = "Insira a Nota 3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 262);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 13;
            label5.Text = "Insira a Nota 4";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 317);
            label6.Name = "label6";
            label6.Size = new Size(127, 25);
            label6.TabIndex = 14;
            label6.Text = "Insira a Nota 5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources._360_F_328645510_FxFYKVKnBeeXx22emhoitNYwWXyh776D;
            ClientSize = new Size(856, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelResultado);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
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
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label labelResultado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
