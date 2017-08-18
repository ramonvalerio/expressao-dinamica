using app = ExpressaoDinamica.Application.Service;
using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using ExpressaoDinamica.Application.DTO;

namespace ExpressaoDinamica.View
{
    public partial class Form1 : Form
    {
        private readonly app.IExpressaoService _expressaoService;

        public Form1()
        {
            _expressaoService = new app.ExpressaoService();

            InitializeComponent();

            dgvResultado.AutoGenerateColumns = true;

            cbTipoValor.SelectedIndex = 0;
            cbLinguagem.SelectedIndex = 0;
        }

        private void txtQtdIteracoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtExpressao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnCalcular_Click(null, null);
                return;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) 
                && (e.KeyChar != '.')
                && (e.KeyChar != ',')
                && (e.KeyChar != '+')
                && (e.KeyChar != '-')
                && (e.KeyChar != '*')
                && (e.KeyChar != '/')
                && (e.KeyChar != ' ')
                && (e.KeyChar != '(')
                && (e.KeyChar != ')')
                )
                e.Handled = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int tamanhoLista = Convert.ToInt32(txtQtdIteracoes.Text);

                switch (cbLinguagem.Text)
                {
                    case "Python":
                        CalcularExpressaoFromPython(tamanhoLista,0 , 10);
                        break;

                    case "NCalc":
                        CalcularExpressaoFromNCalc(tamanhoLista, 0, 10);
                        break;

                    case "CSharp (nativo)":
                        CalcularExpressaoFromCSharp(tamanhoLista, 0, 10);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0}{1}{2}", "Expressão inválida.", Environment.NewLine, ex.Message));
            }
        }

        private string getExpression()
        {
            return txtExpressao.Text.Trim();
        }

        private void CalcularExpressaoFromPython(int tamanhoLista, int min, int max)
        {
            //var random = new Random();
            //int[] lista = Enumerable.Repeat(0, tamanhoLista).Select(i => random.Next(min, max)).ToArray();

            var resultado = new List<ValueObject>(tamanhoLista);

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < tamanhoLista; i++)
                resultado.Add(new ValueObject { Date = DateTime.Now.Date, Value = _expressaoService.CalcularExpressaoFromPython<double>(getExpression()) });

            stopwatch.Stop();

            dgvResultado.DataSource = resultado;
            lblPython.Text = string.Format("{0} {1}", stopwatch.Elapsed.TotalSeconds, " segundos.");
        }

        private void CalcularExpressaoFromNCalc(int tamanhoLista, int min, int max)
        {
            //var random = new Random();
            //int[] lista = Enumerable.Repeat(0, tamanhoLista).Select(i => random.Next(min, max)).ToArray();

            var resultado = new List<ValueObject>(tamanhoLista);

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < tamanhoLista; i++)
                resultado.Add(new ValueObject { Date = DateTime.Now.Date, Value = _expressaoService.CalcularExpressaoFromNCalc(getExpression()) });

            stopwatch.Stop();

            dgvResultado.DataSource = resultado;
            lblNCalc.Text = string.Format("{0} {1}", stopwatch.Elapsed.TotalSeconds, " segundos.");
        }

        private void CalcularExpressaoFromCSharp(int tamanhoLista, int min, int max)
        {
            var resultado = new List<ValueObject>(tamanhoLista);

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < tamanhoLista; i++)
                resultado.Add(new ValueObject { Date = DateTime.Now.Date, Value = _expressaoService.CalcularExpressaoFromCSharp(getExpression()) });

            stopwatch.Stop();

            dgvResultado.DataSource = resultado;
            lblCSharp.Text = string.Format("{0} {1}", stopwatch.Elapsed.TotalSeconds, " segundos.");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dgvResultado.DataSource = null;
            lblPython.Text = string.Empty;
            lblNCalc.Text = string.Empty;
            lblCSharp.Text = string.Empty;
        }
    }
}
