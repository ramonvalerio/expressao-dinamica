using ExpressaoDinamica.Domain.Model;
using ExpressaoDinamica.Infrastructure.Repository;
using System;
using System.Windows.Forms;

namespace ExpressaoDinamica.View
{
    public partial class FormCreateFunction : Form
    {
        public IFunctionRepository FunctionRepository { get; set; }
        public bool IsEdit { get; set; }
        public Function SelectedFunction { get; set; }

        public FormCreateFunction()
        {
            InitializeComponent();

            this.Load += FormCreateFunction_Load;
        }

        private void FormCreateFunction_Load(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                txtFormula.Text = SelectedFunction.Formula;
                txtFunctionName.Text = SelectedFunction.Name;
                txtIterations.Value = SelectedFunction.AmountParameters;

                btnRemove.Enabled = true;
            }
            else
            {
                txtFormula.Text = string.Empty;
                txtFunctionName.Text = string.Empty;
                txtIterations.Value = 1;
                SelectedFunction = null;

                btnRemove.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                SelectedFunction.Name = txtFunctionName.Text.Trim();
                SelectedFunction.Formula = txtFormula.Text.Trim();
                SelectedFunction.AmountParameters = Convert.ToInt32(txtIterations.Value);
                FunctionRepository.Save(SelectedFunction);
            }
            else
            {
                var function = new Function();
                function.Name = txtFunctionName.Text.Trim();
                function.Formula = txtFormula.Text.Trim();
                function.AmountParameters = Convert.ToInt32(txtIterations.Value);
                FunctionRepository.Save(function);
            }

            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            FunctionRepository.Remove(SelectedFunction.Name);
            this.Close();
        }
    }
}
