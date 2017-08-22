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
            this.lblQtdIteracoes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNCalc = new System.Windows.Forms.Label();
            this.lblPython = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.lblCSharp = new System.Windows.Forms.Label();
            this.csharp = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGenerateData = new System.Windows.Forms.Button();
            this.cbFunctionsCreated = new System.Windows.Forms.ComboBox();
            this.lblFunction = new System.Windows.Forms.Label();
            this.btnCreateFunction = new System.Windows.Forms.Button();
            this.txtQtdIteracoes = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdIteracoes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtExpressao
            // 
            this.txtExpressao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtExpressao, 3);
            this.txtExpressao.Location = new System.Drawing.Point(3, 58);
            this.txtExpressao.Name = "txtExpressao";
            this.txtExpressao.Size = new System.Drawing.Size(369, 20);
            this.txtExpressao.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(494, 3);
            this.btnCalcular.Name = "btnCalcular";
            this.tableLayoutPanel1.SetRowSpan(this.btnCalcular, 4);
            this.btnCalcular.Size = new System.Drawing.Size(110, 89);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calculate";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnLimpar, 2);
            this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(378, 483);
            this.btnLimpar.Name = "btnLimpar";
            this.tableLayoutPanel1.SetRowSpan(this.btnLimpar, 3);
            this.btnLimpar.Size = new System.Drawing.Size(226, 54);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Clear Result";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblQtdIteracoes
            // 
            this.lblQtdIteracoes.AutoSize = true;
            this.lblQtdIteracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdIteracoes.ForeColor = System.Drawing.Color.DimGray;
            this.lblQtdIteracoes.Location = new System.Drawing.Point(3, 0);
            this.lblQtdIteracoes.Name = "lblQtdIteracoes";
            this.lblQtdIteracoes.Size = new System.Drawing.Size(110, 13);
            this.lblQtdIteracoes.TabIndex = 7;
            this.lblQtdIteracoes.Text = "Amount Iterations:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Expressão:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(75, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "NCalc:";
            // 
            // lblNCalc
            // 
            this.lblNCalc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNCalc.AutoSize = true;
            this.lblNCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCalc.Location = new System.Drawing.Point(136, 497);
            this.lblNCalc.Name = "lblNCalc";
            this.lblNCalc.Size = new System.Drawing.Size(16, 17);
            this.lblNCalc.TabIndex = 10;
            this.lblNCalc.Text = "0";
            // 
            // lblPython
            // 
            this.lblPython.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPython.AutoSize = true;
            this.lblPython.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPython.Location = new System.Drawing.Point(136, 480);
            this.lblPython.Name = "lblPython";
            this.lblPython.Size = new System.Drawing.Size(16, 17);
            this.lblPython.TabIndex = 15;
            this.lblPython.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(67, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Python:";
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvResultado, 5);
            this.dgvResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultado.Location = new System.Drawing.Point(3, 98);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(601, 379);
            this.dgvResultado.TabIndex = 16;
            // 
            // lblCSharp
            // 
            this.lblCSharp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCSharp.AutoSize = true;
            this.lblCSharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCSharp.Location = new System.Drawing.Point(136, 518);
            this.lblCSharp.Name = "lblCSharp";
            this.lblCSharp.Size = new System.Drawing.Size(16, 17);
            this.lblCSharp.TabIndex = 18;
            this.lblCSharp.Text = "0";
            // 
            // csharp
            // 
            this.csharp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.csharp.AutoSize = true;
            this.csharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csharp.ForeColor = System.Drawing.SystemColors.Desktop;
            this.csharp.Location = new System.Drawing.Point(3, 518);
            this.csharp.Name = "csharp";
            this.csharp.Size = new System.Drawing.Size(127, 17);
            this.csharp.TabIndex = 17;
            this.csharp.Text = "CSharp (native):";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.Controls.Add(this.lblQtdIteracoes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLimpar, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblCSharp, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.csharp, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblNCalc, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblPython, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.dgvResultado, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtExpressao, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCalcular, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGenerateData, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbFunctionsCreated, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFunction, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCreateFunction, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtQtdIteracoes, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(607, 540);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // btnGenerateData
            // 
            this.btnGenerateData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerateData.Location = new System.Drawing.Point(378, 3);
            this.btnGenerateData.Name = "btnGenerateData";
            this.tableLayoutPanel1.SetRowSpan(this.btnGenerateData, 4);
            this.btnGenerateData.Size = new System.Drawing.Size(110, 89);
            this.btnGenerateData.TabIndex = 19;
            this.btnGenerateData.Text = "Generate Data";
            this.btnGenerateData.UseVisualStyleBackColor = true;
            this.btnGenerateData.Click += new System.EventHandler(this.btnGenerateData_Click);
            // 
            // cbFunctionsCreated
            // 
            this.cbFunctionsCreated.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFunctionsCreated.FormattingEnabled = true;
            this.cbFunctionsCreated.Location = new System.Drawing.Point(136, 16);
            this.cbFunctionsCreated.Name = "cbFunctionsCreated";
            this.cbFunctionsCreated.Size = new System.Drawing.Size(121, 21);
            this.cbFunctionsCreated.TabIndex = 20;
            // 
            // lblFunction
            // 
            this.lblFunction.AutoSize = true;
            this.lblFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunction.ForeColor = System.Drawing.Color.DimGray;
            this.lblFunction.Location = new System.Drawing.Point(136, 0);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(114, 13);
            this.lblFunction.TabIndex = 21;
            this.lblFunction.Text = "Functions Created:";
            // 
            // btnCreateFunction
            // 
            this.btnCreateFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateFunction.Location = new System.Drawing.Point(263, 16);
            this.btnCreateFunction.Name = "btnCreateFunction";
            this.btnCreateFunction.Size = new System.Drawing.Size(109, 23);
            this.btnCreateFunction.TabIndex = 22;
            this.btnCreateFunction.Text = "Create Function";
            this.btnCreateFunction.UseVisualStyleBackColor = true;
            this.btnCreateFunction.Click += new System.EventHandler(this.btnCreateFunction_Click);
            // 
            // txtQtdIteracoes
            // 
            this.txtQtdIteracoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtdIteracoes.Location = new System.Drawing.Point(3, 16);
            this.txtQtdIteracoes.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtQtdIteracoes.Name = "txtQtdIteracoes";
            this.txtQtdIteracoes.Size = new System.Drawing.Size(127, 20);
            this.txtQtdIteracoes.TabIndex = 23;
            this.txtQtdIteracoes.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 540);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(540, 492);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expressão Dinâmica";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdIteracoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtExpressao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblQtdIteracoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNCalc;
        private System.Windows.Forms.Label lblPython;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Label lblCSharp;
        private System.Windows.Forms.Label csharp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnGenerateData;
        private System.Windows.Forms.ComboBox cbFunctionsCreated;
        private System.Windows.Forms.Label lblFunction;
        private System.Windows.Forms.Button btnCreateFunction;
        private System.Windows.Forms.NumericUpDown txtQtdIteracoes;
    }
}

