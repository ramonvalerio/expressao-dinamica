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
        private readonly app.ExpressaoAppService _expressaoService;
        private List<ValueObject> _data;

        public Form1()
        {
            _expressaoService = new app.ExpressaoAppService();

            InitializeComponent();

            dgvResultado.AutoGenerateColumns = true;
        }

        private void txtQtdIteracoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnGenerateData_Click(object sender, EventArgs e)
        {
            var dateActual = DateTime.Now;
            var random = new Random();

            try
            {
                var qtdIteracoes = Convert.ToInt32(txtQtdIteracoes.Text);
                _data = new List<ValueObject>(qtdIteracoes);

                for (int i = 0; i < qtdIteracoes; i++)
                {
                    _data.Add(new ValueObject(dateActual.AddMonths(i).Date, Math.Round(random.NextDouble(), 2)));
                    //_data.Add(new ValueObject(dateActual.AddMonths(i).Date, 0 + (random.Next(0, 100))));
                }

                dgvResultado.DataSource = _data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0}{1}{2}", "Expressão inválida.", Environment.NewLine, ex.Message));
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (_data == null)
            {
                MessageBox.Show("Data Generate is necessary!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtExpressao.Text))
            {
                MessageBox.Show("Expression is necessary!");
                return;
            }

            var stopwatch = new Stopwatch();

            stopwatch.Start();

            try
            {
                _data = _expressaoService.CalcularExpressao(_data, txtExpressao.Text.Trim());

                dgvResultado.DataSource = null;
                dgvResultado.DataSource = _data;

                lblNCalc.Text = string.Format("{0} {1}", stopwatch.Elapsed.TotalSeconds, " seconds.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            stopwatch.Stop();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dgvResultado.DataSource = null;
            lblNCalc.Text = string.Empty;
        }

        private void btnCreateFunction_Click(object sender, EventArgs e)
        {
            var formCreateFunction = new FormCreateFunction();
            formCreateFunction.FunctionRepository = _expressaoService._functionRepository;

            formCreateFunction.ShowDialog();

            var functions = _expressaoService.GetAllFunctions();

            cbFunctionsCreated.Items.Clear();

            foreach (var item in functions)
            {
                cbFunctionsCreated.Items.Add(item);
            }

            cbFunctionsCreated.ValueMember = "Name";
            cbFunctionsCreated.DisplayMember = "Name";

            if (cbFunctionsCreated.Items.Count > 0)
                cbFunctionsCreated.SelectedIndex = 0;
        }
    }
}
