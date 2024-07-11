namespace CalculadoraMediaWhileParar
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
            this.adicionarButton = new System.Windows.Forms.Button();
            this.resetarButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.labelMedia = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // adicionarButton
            // 
            this.adicionarButton.Location = new System.Drawing.Point(50, 100);
            this.adicionarButton.Name = "adicionarButton";
            this.adicionarButton.Size = new System.Drawing.Size(100, 23);
            this.adicionarButton.TabIndex = 0;
            this.adicionarButton.Text = "Adicionar";
            this.adicionarButton.UseVisualStyleBackColor = true;
            this.adicionarButton.Click += new System.EventHandler(this.adicionarButton_Click);
            // 
            // resetarButton
            // 
            this.resetarButton.Location = new System.Drawing.Point(160, 100);
            this.resetarButton.Name = "resetarButton";
            this.resetarButton.Size = new System.Drawing.Size(100, 23);
            this.resetarButton.TabIndex = 1;
            this.resetarButton.Text = "Resetar";
            this.resetarButton.UseVisualStyleBackColor = true;
            this.resetarButton.Click += new System.EventHandler(this.resetarButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(270, 100);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(100, 23);
            this.sairButton.TabIndex = 2;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // labelMedia
            // 
            this.labelMedia.AutoSize = true;
            this.labelMedia.Location = new System.Drawing.Point(160, 150);
            this.labelMedia.Name = "labelMedia";
            this.labelMedia.Size = new System.Drawing.Size(97, 13);
            this.labelMedia.TabIndex = 3;
            this.labelMedia.Text = "Média dos Números";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(160, 50);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumero.TabIndex = 4;
            this.textBoxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumero_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelMedia);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.resetarButton);
            this.Controls.Add(this.adicionarButton);
            this.Name = "Form1";
            this.Text = "Calculadora de Média";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button adicionarButton;
        private System.Windows.Forms.Button resetarButton;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Label labelMedia;
        private System.Windows.Forms.TextBox textBoxNumero;
    }
}
