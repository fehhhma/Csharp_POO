namespace TabuadaDeTreinamento
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
            labelAcertos = new Label();
            labelErros = new Label();
            textBoxNumero1 = new TextBox();
            buttonVerificar_Click = new Button();
            buttonSair_Click = new Button();
            pictureBox1 = new PictureBox();
            buttonResetar_Click = new Button();
            textBoxNumero2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelAcertos
            // 
            labelAcertos.AutoSize = true;
            labelAcertos.Location = new Point(328, 122);
            labelAcertos.Name = "labelAcertos";
            labelAcertos.Size = new Size(47, 15);
            labelAcertos.TabIndex = 0;
            labelAcertos.Text = "Acertos";
            // 
            // labelErros
            // 
            labelErros.AutoSize = true;
            labelErros.Location = new Point(427, 122);
            labelErros.Name = "labelErros";
            labelErros.Size = new Size(33, 15);
            labelErros.TabIndex = 1;
            labelErros.Text = "Erros";
            // 
            // textBoxNumero1
            // 
            textBoxNumero1.Location = new Point(171, 114);
            textBoxNumero1.Name = "textBoxNumero1";
            textBoxNumero1.Size = new Size(125, 23);
            textBoxNumero1.TabIndex = 2;
            textBoxNumero1.Text = " Digitar o número:";
            // 
            // buttonVerificar_Click
            // 
            buttonVerificar_Click.Location = new Point(171, 171);
            buttonVerificar_Click.Name = "buttonVerificar_Click";
            buttonVerificar_Click.Size = new Size(75, 23);
            buttonVerificar_Click.TabIndex = 3;
            buttonVerificar_Click.Text = "Verificar";
            buttonVerificar_Click.UseVisualStyleBackColor = true;
            buttonVerificar_Click.Click += buttonVerificar_Click_Click;
            // 
            // buttonSair_Click
            // 
            buttonSair_Click.Location = new Point(415, 171);
            buttonSair_Click.Name = "buttonSair_Click";
            buttonSair_Click.Size = new Size(75, 23);
            buttonSair_Click.TabIndex = 5;
            buttonSair_Click.Text = "Sair";
            buttonSair_Click.UseVisualStyleBackColor = true;
            buttonSair_Click.Click += buttonSair_Click_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Sem_título;
            pictureBox1.Location = new Point(275, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // buttonResetar_Click
            // 
            buttonResetar_Click.Location = new Point(300, 171);
            buttonResetar_Click.Name = "buttonResetar_Click";
            buttonResetar_Click.Size = new Size(75, 23);
            buttonResetar_Click.TabIndex = 8;
            buttonResetar_Click.Text = "Resetar";
            buttonResetar_Click.UseVisualStyleBackColor = true;
            buttonResetar_Click.Click += buttonResetar_Click_Click;
            // 
            // textBoxNumero2
            // 
            textBoxNumero2.Location = new Point(171, 219);
            textBoxNumero2.Name = "textBoxNumero2";
            textBoxNumero2.Size = new Size(125, 23);
            textBoxNumero2.TabIndex = 9;
            textBoxNumero2.Text = "Digitar alternativa:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 367);
            Controls.Add(textBoxNumero2);
            Controls.Add(buttonResetar_Click);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSair_Click);
            Controls.Add(buttonVerificar_Click);
            Controls.Add(textBoxNumero1);
            Controls.Add(labelErros);
            Controls.Add(labelAcertos);
            Name = "Form1";
            Text = "Tabuada";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAcertos;
        private Label labelErros;
        private TextBox textBoxNumero1;
        private Button buttonVerificar_Click;
        private Button buttonSair_Click;
        private PictureBox pictureBox1;
        private Button buttonResetar_Click;
        private TextBox textBoxNumero2;
    }
}
