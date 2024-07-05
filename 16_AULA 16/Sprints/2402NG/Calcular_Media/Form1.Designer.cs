namespace WinFormsApp4
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
            button4 = new Button();
            labelPonderada = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(286, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(286, 165);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(287, 254);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(286, 346);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(286, 431);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(510, 156);
            button1.Name = "button1";
            button1.Size = new Size(155, 74);
            button1.TabIndex = 5;
            button1.Text = "Calcular Média";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(510, 262);
            button2.Name = "button2";
            button2.Size = new Size(155, 69);
            button2.TabIndex = 6;
            button2.Text = "Resetar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(510, 371);
            button3.Name = "button3";
            button3.Size = new Size(155, 74);
            button3.TabIndex = 7;
            button3.Text = "Sair do Programa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(539, 85);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(89, 23);
            labelResultado.TabIndex = 8;
            labelResultado.Text = "Resultado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 91);
            label1.Name = "label1";
            label1.Size = new Size(192, 23);
            label1.TabIndex = 9;
            label1.Text = "Insira a primeira nota: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 173);
            label2.Name = "label2";
            label2.Size = new Size(190, 23);
            label2.TabIndex = 10;
            label2.Text = "Insira a segunda nota: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 258);
            label3.Name = "label3";
            label3.Size = new Size(184, 23);
            label3.TabIndex = 11;
            label3.Text = "Insira a terceira nota: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(67, 348);
            label4.Name = "label4";
            label4.Size = new Size(176, 23);
            label4.TabIndex = 12;
            label4.Text = "Insira a quarta nota: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(67, 431);
            label5.Name = "label5";
            label5.Size = new Size(175, 23);
            label5.TabIndex = 13;
            label5.Text = "Insira a quinta nota: ";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(739, 150);
            button4.Name = "button4";
            button4.Size = new Size(153, 98);
            button4.TabIndex = 15;
            button4.Text = "Calcular Média Ponderada";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // labelPonderada
            // 
            labelPonderada.AutoSize = true;
            labelPonderada.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPonderada.Location = new Point(729, 85);
            labelPonderada.Name = "labelPonderada";
            labelPonderada.Size = new Size(179, 23);
            labelPonderada.TabIndex = 16;
            labelPonderada.Text = "Resultado Ponderada";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(460, 9);
            label6.Name = "label6";
            label6.Size = new Size(102, 50);
            label6.TabIndex = 17;
            label6.Text = "Notas";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._2038509;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(776, 324);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 134);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(996, 522);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(labelPonderada);
            Controls.Add(button4);
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
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button button4;
        private Label labelPonderada;
        private Label label6;
        private PictureBox pictureBox1;
    }
}
