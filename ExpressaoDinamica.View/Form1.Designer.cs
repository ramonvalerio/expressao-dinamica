namespace ExpressaoDinamica.View
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtExpressao = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cbTipoValor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQtdIteracoes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTempoResultado = new System.Windows.Forms.Label();
            this.txtQtdIteracoes = new System.Windows.Forms.TextBox();
            this.cbLinguagem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtExpressao
            // 
            this.txtExpressao.Location = new System.Drawing.Point(12, 78);
            this.txtExpressao.Name = "txtExpressao";
            this.txtExpressao.Size = new System.Drawing.Size(385, 20);
            this.txtExpressao.TabIndex = 0;
            this.txtExpressao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpressao_KeyPress);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 114);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(496, 572);
            this.txtResultado.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(403, 76);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(105, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(404, 715);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar Resultado";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cbTipoValor
            // 
            this.cbTipoValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoValor.FormattingEnabled = true;
            this.cbTipoValor.Items.AddRange(new object[] {
            "double",
            "decimal",
            "int"});
            this.cbTipoValor.Location = new System.Drawing.Point(160, 29);
            this.cbTipoValor.Name = "cbTipoValor";
            this.cbTipoValor.Size = new System.Drawing.Size(96, 21);
            this.cbTipoValor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo Valor:";
            // 
            // lblQtdIteracoes
            // 
            this.lblQtdIteracoes.AutoSize = true;
            this.lblQtdIteracoes.Location = new System.Drawing.Point(9, 12);
            this.lblQtdIteracoes.Name = "lblQtdIteracoes";
            this.lblQtdIteracoes.Size = new System.Drawing.Size(74, 13);
            this.lblQtdIteracoes.TabIndex = 7;
            this.lblQtdIteracoes.Text = "Qtd. Iterações";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Expressão:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 720);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tempo do calculo:";
            // 
            // lblTempoResultado
            // 
            this.lblTempoResultado.AutoSize = true;
            this.lblTempoResultado.Location = new System.Drawing.Point(110, 720);
            this.lblTempoResultado.Name = "lblTempoResultado";
            this.lblTempoResultado.Size = new System.Drawing.Size(13, 13);
            this.lblTempoResultado.TabIndex = 10;
            this.lblTempoResultado.Text = "0";
            // 
            // txtQtdIteracoes
            // 
            this.txtQtdIteracoes.Location = new System.Drawing.Point(12, 29);
            this.txtQtdIteracoes.MaxLength = 20;
            this.txtQtdIteracoes.Name = "txtQtdIteracoes";
            this.txtQtdIteracoes.Size = new System.Drawing.Size(141, 20);
            this.txtQtdIteracoes.TabIndex = 11;
            this.txtQtdIteracoes.Text = "10";
            this.txtQtdIteracoes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdIteracoes_KeyPress);
            // 
            // cbLinguagem
            // 
            this.cbLinguagem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLinguagem.FormattingEnabled = true;
            this.cbLinguagem.Items.AddRange(new object[] {
            "Python",
            "NCalc"});
            this.cbLinguagem.Location = new System.Drawing.Point(262, 28);
            this.cbLinguagem.Name = "cbLinguagem";
            this.cbLinguagem.Size = new System.Drawing.Size(121, 21);
            this.cbLinguagem.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Linguagem:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 698);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "18/08/2017 14:56";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(9, 698);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Início:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 698);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "18/08/2017 15:20";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(183, 698);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Fim:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 745);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLinguagem);
            this.Controls.Add(this.txtQtdIteracoes);
            this.Controls.Add(this.lblTempoResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblQtdIteracoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipoValor);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtExpressao);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expressão Dinâmica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExpressao;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cbTipoValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQtdIteracoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTempoResultado;
        private System.Windows.Forms.TextBox txtQtdIteracoes;
        private System.Windows.Forms.ComboBox cbLinguagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

