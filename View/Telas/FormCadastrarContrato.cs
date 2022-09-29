using Domain.Services;
using Infrastructure.Entities;
using Infrastructure.Entities.Enums;

namespace View.Telas
{
    public partial class FormCadastrarContrato : Form
    {
        private LocatarioServices _locatarioServices;
        private CnabServices _cnabServices;

        public FormCadastrarContrato()
        {
            InitializeComponent();
            _cnabServices = new CnabServices();
            _locatarioServices = new LocatarioServices();
            dataGridView1.DataSource = _cnabServices.iterar();
            //dataGridView1.DataSource = _locatarioServices.ListarLocatarios();
            //CustomizaDGV();
        }

        public void CustomizaDGV()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["Rg"].Visible = false;
            dataGridView1.Columns["Sex"].Visible = false;
            dataGridView1.Columns["Conjuge"].Visible = false;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["DispatchingAgency"].Visible = false;
            dataGridView1.Columns["Nacionality"].Visible = false;
            dataGridView1.Columns["Naturalness"].Visible = false;
            dataGridView1.Columns["Uf"].Visible = false;
            dataGridView1.Columns["Profession"].Visible = false;
            dataGridView1.Columns["Income"].Visible = false;
            dataGridView1.Columns["WorkAddress"].Visible = false;
            dataGridView1.Columns["PhoneWork"].Visible = false;
            dataGridView1.Columns["QtdAnimals"].Visible = false;
            dataGridView1.Columns["Email"].Visible = false;
            dataGridView1.Columns["Casado"].Visible = false;
            dataGridView1.Columns["BirthDate"].Visible = false;
            dataGridView1.Columns["MaritalStatus"].Visible = false;
            dataGridView1.Columns["Phone1"].Visible = false;
            dataGridView1.Columns["Phone2"].Visible = false;
        }

        private void buttonSelecionar_Click_1(object sender, EventArgs e)
        {
            textName.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            maskedCpf.Text = dataGridView1.CurrentRow.Cells["Cpf"].Value.ToString();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            /*Contrato contrato = new Contrato();
            contrato.IdLocatario = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            int dia = Convert.ToInt16(maskedDataInicio.Text.Substring(0, 2));
            int mes = Convert.ToInt16(maskedDataInicio.Text.Substring(2, 2));
            int ano = Convert.ToInt16(maskedDataInicio.Text.Substring(4, 4));
            contrato.DataInicio = new DateOnly(dia, mes, ano);
            dia = Convert.ToInt16(maskedDataInicio.Text.Substring(0, 2));
            mes = Convert.ToInt16(maskedDataInicio.Text.Substring(2, 2));
            ano = Convert.ToInt16(maskedDataInicio.Text.Substring(4, 4));
            contrato.DataFinal = new DateOnly(dia, mes, ano);
            contrato.QuantidadeMeses = Convert.ToInt16(textQtdMeses.Text);
            contrato.FormaPagamento = (FormaDePagamento)IdentificaFormaDePagamento(groupFormaPagamento);
            contrato.Valor = (string.IsNullOrEmpty(textValor.Text) ? 0 : Convert.ToDecimal(textValor.Text));
            contrato.Observacoes = textObservacoes.Text;*/
        }

        private FormaDePagamento? IdentificaFormaDePagamento(GroupBox groupBox)
        {
            foreach(RadioButton radioButton in groupBox.Controls)
            {
                if(radioButton.Checked = true)
                {
                    return (FormaDePagamento)(radioButton.Tag);
                }
            }
            return null;
        }        
    }
}
