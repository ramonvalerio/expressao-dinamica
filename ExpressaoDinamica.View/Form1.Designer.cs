﻿namespace ExpressaoDinamica.View
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
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbFunctionsCreated = new System.Windows.Forms.ComboBox();
            this.lblFunction = new System.Windows.Forms.Label();
            this.txtQtdIteracoes = new System.Windows.Forms.NumericUpDown();
            this.btnCreateFunction = new System.Windows.Forms.Button();
            this.btnEditFunction = new System.Windows.Forms.Button();
            this.btnGenerateData = new System.Windows.Forms.Button();
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
            this.txtExpressao.Location = new System.Drawing.Point(3, 74);
            this.txtExpressao.Name = "txtExpressao";
            this.txtExpressao.Size = new System.Drawing.Size(293, 20);
            this.txtExpressao.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(402, 4);
            this.btnCalcular.MinimumSize = new System.Drawing.Size(94, 89);
            this.btnCalcular.Name = "btnCalcular";
            this.tableLayoutPanel1.SetRowSpan(this.btnCalcular, 4);
            this.btnCalcular.Size = new System.Drawing.Size(95, 89);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calculate";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLimpar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(402, 410);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(94, 35);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Clear Result";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblQtdIteracoes
            // 
            this.lblQtdIteracoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQtdIteracoes.AutoSize = true;
            this.lblQtdIteracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdIteracoes.ForeColor = System.Drawing.Color.DimGray;
            this.lblQtdIteracoes.Location = new System.Drawing.Point(3, 16);
            this.lblQtdIteracoes.Name = "lblQtdIteracoes";
            this.lblQtdIteracoes.Size = new System.Drawing.Size(64, 13);
            this.lblQtdIteracoes.TabIndex = 7;
            this.lblQtdIteracoes.Text = "Iterations:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(3, 58);
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
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(49, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Time:";
            // 
            // lblNCalc
            // 
            this.lblNCalc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNCalc.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblNCalc, 2);
            this.lblNCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCalc.ForeColor = System.Drawing.Color.DimGray;
            this.lblNCalc.Location = new System.Drawing.Point(103, 417);
            this.lblNCalc.Name = "lblNCalc";
            this.lblNCalc.Size = new System.Drawing.Size(18, 20);
            this.lblNCalc.TabIndex = 10;
            this.lblNCalc.Text = "0";
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvResultado, 5);
            this.dgvResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultado.Location = new System.Drawing.Point(3, 100);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(494, 304);
            this.dgvResultado.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblQtdIteracoes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLimpar, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtExpressao, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbFunctionsCreated, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFunction, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtQtdIteracoes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblNCalc, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.dgvResultado, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCreateFunction, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEditFunction, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnGenerateData, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCalcular, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 448);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // cbFunctionsCreated
            // 
            this.cbFunctionsCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFunctionsCreated.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFunctionsCreated.FormattingEnabled = true;
            this.cbFunctionsCreated.Location = new System.Drawing.Point(103, 33);
            this.cbFunctionsCreated.Name = "cbFunctionsCreated";
            this.cbFunctionsCreated.Size = new System.Drawing.Size(114, 21);
            this.cbFunctionsCreated.TabIndex = 20;
            // 
            // lblFunction
            // 
            this.lblFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFunction.AutoSize = true;
            this.lblFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunction.ForeColor = System.Drawing.Color.DimGray;
            this.lblFunction.Location = new System.Drawing.Point(103, 16);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(114, 13);
            this.lblFunction.TabIndex = 21;
            this.lblFunction.Text = "Functions Created:";
            // 
            // txtQtdIteracoes
            // 
            this.txtQtdIteracoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtdIteracoes.Location = new System.Drawing.Point(3, 33);
            this.txtQtdIteracoes.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtQtdIteracoes.Name = "txtQtdIteracoes";
            this.txtQtdIteracoes.Size = new System.Drawing.Size(94, 20);
            this.txtQtdIteracoes.TabIndex = 23;
            this.txtQtdIteracoes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnCreateFunction
            // 
            this.btnCreateFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateFunction.Location = new System.Drawing.Point(223, 3);
            this.btnCreateFunction.Name = "btnCreateFunction";
            this.btnCreateFunction.Size = new System.Drawing.Size(73, 23);
            this.btnCreateFunction.TabIndex = 22;
            this.btnCreateFunction.Text = "New Function";
            this.btnCreateFunction.UseVisualStyleBackColor = true;
            this.btnCreateFunction.Click += new System.EventHandler(this.btnCreateFunction_Click);
            // 
            // btnEditFunction
            // 
            this.btnEditFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditFunction.Location = new System.Drawing.Point(223, 32);
            this.btnEditFunction.Name = "btnEditFunction";
            this.btnEditFunction.Size = new System.Drawing.Size(73, 23);
            this.btnEditFunction.TabIndex = 24;
            this.btnEditFunction.Text = "Edit Function";
            this.btnEditFunction.UseVisualStyleBackColor = true;
            this.btnEditFunction.Click += new System.EventHandler(this.btnEditFunction_Click);
            // 
            // btnGenerateData
            // 
            this.btnGenerateData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateData.Location = new System.Drawing.Point(302, 4);
            this.btnGenerateData.MinimumSize = new System.Drawing.Size(94, 89);
            this.btnGenerateData.Name = "btnGenerateData";
            this.tableLayoutPanel1.SetRowSpan(this.btnGenerateData, 4);
            this.btnGenerateData.Size = new System.Drawing.Size(94, 89);
            this.btnGenerateData.TabIndex = 19;
            this.btnGenerateData.Text = "Generate Data";
            this.btnGenerateData.UseVisualStyleBackColor = true;
            this.btnGenerateData.Click += new System.EventHandler(this.btnGenerateData_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLimpar;
            this.ClientSize = new System.Drawing.Size(500, 448);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador de Calculo Dinâmico";
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
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnGenerateData;
        private System.Windows.Forms.ComboBox cbFunctionsCreated;
        private System.Windows.Forms.Label lblFunction;
        private System.Windows.Forms.Button btnCreateFunction;
        private System.Windows.Forms.NumericUpDown txtQtdIteracoes;
        private System.Windows.Forms.Button btnEditFunction;
    }
}

