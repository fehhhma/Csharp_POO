namespace WinFormsApp8
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
            textBoxDados = new TextBox();
            labelResultado = new Label();
            btn_IMC = new Button();
            btn_Resetar = new Button();
            bnt_Fechar = new Button();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxDados
            // 
            textBoxDados.Location = new Point(271, 158);
            textBoxDados.Name = "textBoxDados";
            textBoxDados.Size = new Size(284, 27);
            textBoxDados.TabIndex = 0;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            labelResultado.Location = new Point(27, 348);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(96, 21);
            labelResultado.TabIndex = 2;
            labelResultado.Text = "Resultado";
            // 
            // btn_IMC
            // 
            btn_IMC.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_IMC.Location = new Point(353, 228);
            btn_IMC.Name = "btn_IMC";
            btn_IMC.Size = new Size(168, 74);
            btn_IMC.TabIndex = 4;
            btn_IMC.Text = "Calcular IMC";
            btn_IMC.UseVisualStyleBackColor = true;
            btn_IMC.Click += btn_IMC_Click;
            // 
            // btn_Resetar
            // 
            btn_Resetar.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn_Resetar.ForeColor = Color.ForestGreen;
            btn_Resetar.Location = new Point(106, 231);
            btn_Resetar.Name = "btn_Resetar";
            btn_Resetar.Size = new Size(130, 69);
            btn_Resetar.TabIndex = 5;
            btn_Resetar.Text = "Resetar";
            btn_Resetar.UseVisualStyleBackColor = true;
            btn_Resetar.Click += btn_Resetar_Click;
            // 
            // bnt_Fechar
            // 
            bnt_Fechar.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            bnt_Fechar.ForeColor = Color.Red;
            bnt_Fechar.Location = new Point(557, 6);
            bnt_Fechar.Name = "bnt_Fechar";
            bnt_Fechar.Size = new Size(50, 43);
            bnt_Fechar.TabIndex = 6;
            bnt_Fechar.Text = "X";
            bnt_Fechar.UseVisualStyleBackColor = true;
            bnt_Fechar.Click += bnt_Fechar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 161);
            label1.Name = "label1";
            label1.Size = new Size(161, 24);
            label1.TabIndex = 7;
            label1.Text = "Digite a altura:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(199, 66);
            label3.Name = "label3";
            label3.Size = new Size(227, 36);
            label3.TabIndex = 8;
            label3.Text = "Calcular IMC";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(616, 450);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(bnt_Fechar);
            Controls.Add(btn_Resetar);
            Controls.Add(btn_IMC);
            Controls.Add(labelResultado);
            Controls.Add(textBoxDados);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDados;
        private Label labelResultado;
        private Button btn_IMC;
        private Button btn_Resetar;
        private Button bnt_Fechar;
        private Label label1;
        private Label label3;
    }
}
