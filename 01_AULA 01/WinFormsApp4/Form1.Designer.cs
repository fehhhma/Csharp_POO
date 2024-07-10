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
            textBoxIdade = new TextBox();
            radioButtonInfantilA = new RadioButton();
            radioButtonInfantilB = new RadioButton();
            radioButtonJuvenilA = new RadioButton();
            radioButtonJuvenilB = new RadioButton();
            radioButtonAdultos = new RadioButton();
            dateTimePickerClassificacao = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            labelClassificacao = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxIdade
            // 
            textBoxIdade.Location = new Point(115, 178);
            textBoxIdade.Name = "textBoxIdade";
            textBoxIdade.Size = new Size(150, 31);
            textBoxIdade.TabIndex = 0;
            // 
            // radioButtonInfantilA
            // 
            radioButtonInfantilA.AutoSize = true;
            radioButtonInfantilA.Location = new Point(421, 103);
            radioButtonInfantilA.Name = "radioButtonInfantilA";
            radioButtonInfantilA.Size = new Size(108, 29);
            radioButtonInfantilA.TabIndex = 1;
            radioButtonInfantilA.TabStop = true;
            radioButtonInfantilA.Text = "Infantil A";
            radioButtonInfantilA.UseVisualStyleBackColor = true;
            // 
            // radioButtonInfantilB
            // 
            radioButtonInfantilB.AutoSize = true;
            radioButtonInfantilB.Location = new Point(421, 151);
            radioButtonInfantilB.Name = "radioButtonInfantilB";
            radioButtonInfantilB.Size = new Size(106, 29);
            radioButtonInfantilB.TabIndex = 2;
            radioButtonInfantilB.TabStop = true;
            radioButtonInfantilB.Text = "Infantil B";
            radioButtonInfantilB.UseVisualStyleBackColor = true;
            // 
            // radioButtonJuvenilA
            // 
            radioButtonJuvenilA.AutoSize = true;
            radioButtonJuvenilA.Location = new Point(421, 208);
            radioButtonJuvenilA.Name = "radioButtonJuvenilA";
            radioButtonJuvenilA.Size = new Size(106, 29);
            radioButtonJuvenilA.TabIndex = 3;
            radioButtonJuvenilA.TabStop = true;
            radioButtonJuvenilA.Text = "Juvenil A";
            radioButtonJuvenilA.UseVisualStyleBackColor = true;
            // 
            // radioButtonJuvenilB
            // 
            radioButtonJuvenilB.AutoSize = true;
            radioButtonJuvenilB.Location = new Point(421, 269);
            radioButtonJuvenilB.Name = "radioButtonJuvenilB";
            radioButtonJuvenilB.Size = new Size(104, 29);
            radioButtonJuvenilB.TabIndex = 4;
            radioButtonJuvenilB.TabStop = true;
            radioButtonJuvenilB.Text = "Juvenil B";
            radioButtonJuvenilB.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdultos
            // 
            radioButtonAdultos.AutoSize = true;
            radioButtonAdultos.Location = new Point(421, 325);
            radioButtonAdultos.Name = "radioButtonAdultos";
            radioButtonAdultos.Size = new Size(99, 29);
            radioButtonAdultos.TabIndex = 5;
            radioButtonAdultos.TabStop = true;
            radioButtonAdultos.Text = "Adultos";
            radioButtonAdultos.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerClassificacao
            // 
            dateTimePickerClassificacao.Location = new Point(408, 27);
            dateTimePickerClassificacao.Name = "dateTimePickerClassificacao";
            dateTimePickerClassificacao.Size = new Size(380, 31);
            dateTimePickerClassificacao.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(34, 224);
            button1.Name = "button1";
            button1.Size = new Size(143, 74);
            button1.TabIndex = 7;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(194, 224);
            button2.Name = "button2";
            button2.Size = new Size(143, 74);
            button2.TabIndex = 8;
            button2.Text = "Resetar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(599, 178);
            button3.Name = "button3";
            button3.Size = new Size(143, 74);
            button3.TabIndex = 9;
            button3.Text = "Sair do Programa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // labelClassificacao
            // 
            labelClassificacao.AutoSize = true;
            labelClassificacao.Location = new Point(12, 356);
            labelClassificacao.Name = "labelClassificacao";
            labelClassificacao.Size = new Size(111, 25);
            labelClassificacao.TabIndex = 10;
            labelClassificacao.Text = "Classificação";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 16);
            label1.Name = "label1";
            label1.Size = new Size(400, 45);
            label1.TabIndex = 11;
            label1.Text = "Classificação Nadadores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 134);
            label2.Name = "label2";
            label2.Size = new Size(225, 25);
            label2.TabIndex = 12;
            label2.Text = "Digite a Idade do Nadador";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelClassificacao);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePickerClassificacao);
            Controls.Add(radioButtonAdultos);
            Controls.Add(radioButtonJuvenilB);
            Controls.Add(radioButtonJuvenilA);
            Controls.Add(radioButtonInfantilB);
            Controls.Add(radioButtonInfantilA);
            Controls.Add(textBoxIdade);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIdade;
        private RadioButton radioButtonInfantilA;
        private RadioButton radioButtonInfantilB;
        private RadioButton radioButtonJuvenilA;
        private RadioButton radioButtonJuvenilB;
        private RadioButton radioButtonAdultos;
        private DateTimePicker dateTimePickerClassificacao;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label labelClassificacao;
        private Label label1;
        private Label label2;
    }
}
