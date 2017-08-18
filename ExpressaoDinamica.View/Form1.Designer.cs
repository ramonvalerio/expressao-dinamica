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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cbTipoValor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQtdIteracoes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNCalc = new System.Windows.Forms.Label();
            this.txtQtdIteracoes = new System.Windows.Forms.TextBox();
            this.cbLinguagem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPython = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.lblCSharp = new System.Windows.Forms.Label();
            this.csharp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtExpressao
            // 
            this.txtExpressao.Location = new System.Drawing.Point(12, 78);
            this.txtExpressao.Name = "txtExpressao";
            this.txtExpressao.Size = new System.Drawing.Size(385, 20);
            this.txtExpressao.TabIndex = 0;
            this.txtExpressao.Text = "2 + (3 * 5)";
            this.txtExpressao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpressao_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(403, 13);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(105, 86);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(403, 645);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 91);
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
            "double"});
            this.cbTipoValor.Location = new System.Drawing.Point(160, 29);
            this.cbTipoValor.Name = "cbTipoValor";
            this.cbTipoValor.Size = new System.Drawing.Size(96, 21);
            this.cbTipoValor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(157, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo Valor:";
            // 
            // lblQtdIteracoes
            // 
            this.lblQtdIteracoes.AutoSize = true;
            this.lblQtdIteracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdIteracoes.ForeColor = System.Drawing.Color.DimGray;
            this.lblQtdIteracoes.Location = new System.Drawing.Point(9, 12);
            this.lblQtdIteracoes.Name = "lblQtdIteracoes";
            this.lblQtdIteracoes.Size = new System.Drawing.Size(88, 13);
            this.lblQtdIteracoes.TabIndex = 7;
            this.lblQtdIteracoes.Text = "Qtd. Iterações";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(13, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Expressão:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(92, 679);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "NCalc:";
            // 
            // lblNCalc
            // 
            this.lblNCalc.AutoSize = true;
            this.lblNCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCalc.Location = new System.Drawing.Point(156, 679);
            this.lblNCalc.Name = "lblNCalc";
            this.lblNCalc.Size = new System.Drawing.Size(18, 20);
            this.lblNCalc.TabIndex = 10;
            this.lblNCalc.Text = "0";
            // 
            // txtQtdIteracoes
            // 
            this.txtQtdIteracoes.Location = new System.Drawing.Point(12, 29);
            this.txtQtdIteracoes.MaxLength = 20;
            this.txtQtdIteracoes.Name = "txtQtdIteracoes";
            this.txtQtdIteracoes.Size = new System.Drawing.Size(141, 20);
            this.txtQtdIteracoes.TabIndex = 11;
            this.txtQtdIteracoes.Text = "10000";
            this.txtQtdIteracoes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdIteracoes_KeyPress);
            // 
            // cbLinguagem
            // 
            this.cbLinguagem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLinguagem.FormattingEnabled = true;
            this.cbLinguagem.Items.AddRange(new object[] {
            "NCalc",
            "Python",
            "CSharp (nativo)"});
            this.cbLinguagem.Location = new System.Drawing.Point(262, 28);
            this.cbLinguagem.Name = "cbLinguagem";
            this.cbLinguagem.Size = new System.Drawing.Size(121, 21);
            this.cbLinguagem.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(259, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Linguagem:";
            // 
            // lblPython
            // 
            this.lblPython.AutoSize = true;
            this.lblPython.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPython.Location = new System.Drawing.Point(156, 645);
            this.lblPython.Name = "lblPython";
            this.lblPython.Size = new System.Drawing.Size(18, 20);
            this.lblPython.TabIndex = 15;
            this.lblPython.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(84, 645);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Python:";
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(12, 105);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(496, 534);
            this.dgvResultado.TabIndex = 16;
            // 
            // lblCSharp
            // 
            this.lblCSharp.AutoSize = true;
            this.lblCSharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCSharp.Location = new System.Drawing.Point(156, 716);
            this.lblCSharp.Name = "lblCSharp";
            this.lblCSharp.Size = new System.Drawing.Size(18, 20);
            this.lblCSharp.TabIndex = 18;
            this.lblCSharp.Text = "0";
            // 
            // csharp
            // 
            this.csharp.AutoSize = true;
            this.csharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csharp.ForeColor = System.Drawing.SystemColors.Desktop;
            this.csharp.Location = new System.Drawing.Point(14, 716);
            this.csharp.Name = "csharp";
            this.csharp.Size = new System.Drawing.Size(139, 20);
            this.csharp.TabIndex = 17;
            this.csharp.Text = "CSharp (nativo):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 745);
            this.Controls.Add(this.lblCSharp);
            this.Controls.Add(this.csharp);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.lblPython);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLinguagem);
            this.Controls.Add(this.txtQtdIteracoes);
            this.Controls.Add(this.lblNCalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblQtdIteracoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipoValor);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtExpressao);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expressão Dinâmica";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExpressao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cbTipoValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQtdIteracoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNCalc;
        private System.Windows.Forms.TextBox txtQtdIteracoes;
        private System.Windows.Forms.ComboBox cbLinguagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPython;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Label lblCSharp;
        private System.Windows.Forms.Label csharp;
    }
}

