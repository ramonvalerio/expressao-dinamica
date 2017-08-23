using ExpressaoDinamica.Domain.Model;
using ExpressaoDinamica.Infrastructure.Repository;
using System;
using System.Windows.Forms;

namespace ExpressaoDinamica.View
{
    public partial class FormCreateFunction : Form
    {
        public IFunctionRepository FunctionRepository { get; set; }

        public FormCreateFunction()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var function = new Function();
            function.Name = txtFunctionName.Text.Trim();
            function.Formula = txtFormula.Text.Trim();
            function.AmountParameters = Convert.ToInt32(txtIterations.Value);

            FunctionRepository.AddFunction(function.Name, function.Formula, function.AmountParameters);

            this.Close();
        }
    }
}
