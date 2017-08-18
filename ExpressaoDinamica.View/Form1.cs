using app = ExpressaoDinamica.Application.Service;
using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;

namespace ExpressaoDinamica.View
{
    public partial class Form1 : Form
    {
        private readonly app.IExpressaoService _expressaoService;

        public Form1()
        {
            _expressaoService = new app.ExpressaoService();

            InitializeComponent();

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
            var random = new Random();
            int[] lista = Enumerable.Repeat(0, tamanhoLista).Select(i => random.Next(min, max)).ToArray();

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < lista.Count(); i++)
            {
                switch (cbTipoValor.Text)
                {
                    case "double":
                        var resultado1 = _expressaoService.CalcularExpressaoFromPython<double>(getExpression());
                        txtResultado.AppendText(string.Format("{0} = {1} as {2}{3}", getExpression(), resultado1, cbTipoValor.Text, Environment.NewLine));
                        break;

                    case "decimal":
                        var resultado2 = _expressaoService.CalcularExpressaoFromPython<decimal>(getExpression());
                        txtResultado.AppendText(string.Format("{0} = {1} as {2}{3}", getExpression(), resultado2, cbTipoValor.Text, Environment.NewLine));
                        break;

                    case "int":
                        var resultado3 = _expressaoService.CalcularExpressaoFromPython<int>(getExpression());
                        txtResultado.AppendText(string.Format("{0} = {1} as {2}{3}", getExpression(), resultado3, cbTipoValor.Text, Environment.NewLine));
                        break;

                    case "string":
                        var resultado4 = _expressaoService.CalcularExpressaoFromPython<string>(getExpression());
                        txtResultado.AppendText(string.Format("{0} = {1} as {2}{3}", getExpression(), resultado4, cbTipoValor.Text, Environment.NewLine));
                        break;
                }
            }

            stopwatch.Stop();
            lblPython.Text = stopwatch.Elapsed.TotalSeconds.ToString();
        }

        private void CalcularExpressaoFromNCalc(int tamanhoLista, int min, int max)
        {
            var random = new Random();
            int[] lista = Enumerable.Repeat(0, tamanhoLista).Select(i => random.Next(min, max)).ToArray();

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < lista.Count(); i++)
            {
                switch (cbTipoValor.Text)
                {
                    case "double":
                        var resultado1 = _expressaoService.CalcularExpressaoFromNCalc(getExpression());
                        txtResultado.AppendText(string.Format("{0} = {1} as {2}{3}", getExpression(), resultado1, cbTipoValor.Text, Environment.NewLine));
                        break;

                    case "decimal":
                        var resultado2 = _expressaoService.CalcularExpressaoFromNCalc(getExpression());
                        txtResultado.AppendText(string.Format("{0} = {1} as {2}{3}", getExpression(), resultado2, cbTipoValor.Text, Environment.NewLine));
                        break;

                    case "int":
                        var resultado3 = _expressaoService.CalcularExpressaoFromNCalc(getExpression());
                        txtResultado.AppendText(string.Format("{0} = {1} as {2}{3}", getExpression(), resultado3, cbTipoValor.Text, Environment.NewLine));
                        break;

                    case "string":
                        var resultado4 = _expressaoService.CalcularExpressaoFromNCalc(getExpression());
                        txtResultado.AppendText(string.Format("{0} = {1} as {2}{3}", getExpression(), resultado4, cbTipoValor.Text, Environment.NewLine));
                        break;
                }
            }

            stopwatch.Stop();
            lblNCalc.Text = stopwatch.Elapsed.TotalSeconds.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            lblPython.Text = string.Empty;
            lblNCalc.Text = string.Empty;
        }
    }
}
