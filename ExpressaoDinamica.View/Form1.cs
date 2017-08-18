using app = ExpressaoDinamica.Application.Service;
using System;
using System.Windows.Forms;

namespace ExpressaoDinamica.View
{
    public partial class Form1 : Form
    {
        private readonly app.IExpressaoService _expressaoService;

        public Form1()
        {
            _expressaoService = new app.ExpressaoService();

            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado = _expressaoService.CalcularExpressaoFromPython<double>(getExpression());
                txtResultado.AppendText(string.Format("{0} = {1}{2}", getExpression(), resultado, Environment.NewLine));
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtExpressao.Clear();
            txtResultado.Clear();
        }
    }
}
