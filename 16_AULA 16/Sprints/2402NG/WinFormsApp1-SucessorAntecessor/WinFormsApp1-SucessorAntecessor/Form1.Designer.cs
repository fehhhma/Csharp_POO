namespace WinFormsApp1_SucessorAntecessor
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
            txtNumero = new Label();
            lblSucessor = new Label();
            lblAntecessor = new Label();
            btnCalcular = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.AutoSize = true;
            txtNumero.Location = new Point(216, 126);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(51, 15);
            txtNumero.TabIndex = 0;
            txtNumero.Text = "Número";
            // 
            // lblSucessor
            // 
            lblSucessor.AutoSize = true;
            lblSucessor.Location = new Point(413, 126);
            lblSucessor.Name = "lblSucessor";
            lblSucessor.Size = new Size(56, 15);
            lblSucessor.TabIndex = 1;
            lblSucessor.Text = " Sucessor";
            // 
            // lblAntecessor
            // 
            lblAntecessor.AutoSize = true;
            lblAntecessor.Location = new Point(323, 126);
            lblAntecessor.Name = "lblAntecessor";
            lblAntecessor.Size = new Size(65, 15);
            lblAntecessor.TabIndex = 2;
            lblAntecessor.Text = "Antecessor";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(394, 88);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(216, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Sem_título;
            pictureBox1.Location = new Point(307, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(btnCalcular);
            Controls.Add(lblAntecessor);
            Controls.Add(lblSucessor);
            Controls.Add(txtNumero);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtNumero;
        private Label lblSucessor;
        private Label lblAntecessor;
        private Button btnCalcular;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}
