﻿using Infrastructure.Entities;
using System.Globalization;
using Domain.Services;
using System.Media;

namespace View.Telas
{
    public partial class FormCadLocatario : Form
    {
        private PersonServices _personServices;
        private Locatario _locatario;
        private Conjuge _conjugeF1;
        private Conjuge _conjugeF2;
        private Conjuge _conjuge;
        private Fiador _fiador1;
        private Fiador _fiador2;

        public FormCadLocatario()
        {
            InitializeComponent();
            _personServices = new PersonServices();
            //INICIALIZA OS TABPAGES COMO INATIVOS
            ((Control)tabControl1.TabPages[1]).Enabled = false;
            ((Control)tabControl1.TabPages[2]).Enabled = false;
            ((Control)tabControl1.TabPages[3]).Enabled = false;
            ((Control)tabControl1.TabPages[4]).Enabled = false;
            ((Control)tabControl1.TabPages[5]).Enabled = false;
        }

        //EVENTOS DOS BOTOES DE VALIDAR
        private void buttonValidarLocatario_Click(object sender, EventArgs e)
        {
            _locatario = new Locatario();
            _locatario.Name = textName.Text;
            //_locatario.BirthDate = DateOnly.ParseExact(maskedBirthDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            _locatario.MaritalStatus = IdentifierMaritalStatus(groupMaritalStatus);
            //_locatario.Casado = _locatario.MaritalStatus.Equals("CASADO(A)") ? true : false;
            _locatario.Sex = IdentifierSex(groupSex);
            //_locatario.Cpf = maskedCpf.Text;
            _locatario.Rg = textRg.Text;
            _locatario.DispatchingAgency = textDispatchingAgency.Text;
            _locatario.Nacionality = textNacionality.Text;
            _locatario.Naturalness = textNaturalness.Text;
            _locatario.Uf = textUf.Text;
            _locatario.Profession = textProfession.Text;
            _locatario.Income = (double)(string.IsNullOrEmpty(textIncome.Text) ? 0 : Convert.ToDecimal(textIncome.Text));
            _locatario.WorkAddress = textWorkAdress.Text;
            _locatario.PhoneWork = maskedPhoneWork.Text;
            _locatario.Phone1 = maskedPhone1.Text;
            _locatario.Phone2 = maskedPhone2.Text;
            _locatario.QtdAnimals = (int)numericQtdAnimals.Value;
            _locatario.Email = textEmail.Text;
            _locatario.Comments = textComments.Text;
            if (ValidationDataAnnotation.ValidationModel(_locatario))
            {
                if (_locatario.Casado)
                {
                    ((Control)tabControl1.TabPages["tabPageConjuge"]).Enabled = true;
                    tabControl1.SelectTab(tabPageConjuge);
                }
                else
                {
                    ((Control)tabControl1.TabPages["tabPageFiador1"]).Enabled = true;
                    tabControl1.SelectTab(tabPageFiador1);
                }
            }
        }
        private void buttonValidarConjuge_Click(object sender, EventArgs e)
        {
            _conjuge = new Conjuge();
            _conjuge.Name = textName1.Text;
            _conjuge.BirthDate = DateOnly.ParseExact(maskedBirthDate1.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            _conjuge.Sex = IdentifierSex(groupSex1);
            _conjuge.Cpf = maskedCpf1.Text;
            _conjuge.Rg = textRg1.Text;
            _conjuge.DispatchingAgency = textDispatchingAgency1.Text;
            _conjuge.Nacionality = textNacionality1.Text;
            _conjuge.Naturalness = textNaturalness1.Text;
            _conjuge.Uf = textUf1.Text;
            _conjuge.Profession = textProfession1.Text;
            _conjuge.Phone1 = maskedTextBox1.Text;
            _conjuge.Phone2 = maskedTextBox2.Text;
            _conjuge.Email = textEmail1.Text;
            if (ValidationDataAnnotation.ValidationModel(_conjuge))
            {
                ((Control)tabControl1.TabPages["tabPageFiador1"]).Enabled = true;
                tabControl1.SelectTab(tabPageFiador1);
            }
        }
        private void buttonValidarFiador1_Click(object sender, EventArgs e)
        {
            _fiador1 = new Fiador();
            _fiador1.Name = textName2.Text;
            _fiador1.BirthDate = DateOnly.ParseExact(maskedBirthDate2.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            _fiador1.MaritalStatus = IdentifierMaritalStatus(groupMaritalStatus2);
            _fiador1.Casado = _fiador1.MaritalStatus.Equals("CASADO(A)") ? true : false;
            _fiador1.Sex = IdentifierSex(groupSex2);
            _fiador1.Cpf = maskedCpf2.Text;
            _fiador1.Rg = textRg2.Text;
            _fiador1.DispatchingAgency = textDispatchingAgency2.Text;
            _fiador1.Nacionality = textNacionality2.Text;
            _fiador1.Naturalness = textNaturalness2.Text;
            _fiador1.Uf = textUf2.Text;
            _fiador1.Profession = textProfession2.Text;
            _fiador1.Phone1 = maskedTextBox3.Text;
            _fiador1.Phone2 = maskedTextBox4.Text;
            _fiador1.Email = textEmail2.Text;
            if (ValidationDataAnnotation.ValidationModel(_fiador1))
            {
                if (_fiador1.Casado)
                {
                    ((Control)tabControl1.TabPages["tabPageConjugeF1"]).Enabled = true;
                    tabControl1.SelectTab(tabPageConjugeF1);
                }
                else
                {
                    ((Control)tabControl1.TabPages["tabPageFiador2"]).Enabled = true;
                    tabControl1.SelectTab(tabPageFiador2);
                }
            }
        }
        private void buttonValidarConjugeF1_Click(object sender, EventArgs e)
        {
            _conjugeF1 = new Conjuge();
            _conjugeF1.Name = textName3.Text;
            _conjugeF1.BirthDate = DateOnly.ParseExact(maskedBirthDate3.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            _conjugeF1.Sex = IdentifierSex(groupSex3);
            _conjugeF1.Cpf = maskedCpf3.Text;
            _conjugeF1.Rg = textRg3.Text;
            _conjugeF1.DispatchingAgency = textDispatchingAgency3.Text;
            _conjugeF1.Nacionality = textNacionality3.Text;
            _conjugeF1.Naturalness = textNaturalness3.Text;
            _conjugeF1.Uf = textUf3.Text;
            _conjugeF1.Profession = textProfession3.Text;
            _conjugeF1.Phone1 = maskedTextBox5.Text;
            _conjugeF1.Phone2 = maskedTextBox6.Text;
            _conjugeF1.Email = textEmail3.Text;
            if (ValidationDataAnnotation.ValidationModel(_conjugeF1))
            {
                ((Control)tabControl1.TabPages["tabPageFiador2"]).Enabled = true;
                tabControl1.SelectTab(tabPageFiador2);
            }
        }
        private void buttonValidarFiador2_Click(object sender, EventArgs e)
        {
            _fiador2 = new Fiador();
            _fiador2.Name = textName4.Text;
            _fiador2.BirthDate = DateOnly.ParseExact(maskedBirthDate4.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            _fiador2.MaritalStatus = IdentifierMaritalStatus(groupMaritalStatus4);
            _fiador2.Casado = _fiador2.MaritalStatus.Equals("CASADO(A)") ? true : false;
            _fiador2.Sex = IdentifierSex(groupSex4);
            _fiador2.Cpf = maskedCpf4.Text;
            _fiador2.Rg = textRg4.Text;
            _fiador2.DispatchingAgency = textDispatchingAgency4.Text;
            _fiador2.Nacionality = textNacionality4.Text;
            _fiador2.Naturalness = textNaturalness4.Text;
            _fiador2.Uf = textUf4.Text;
            _fiador2.Profession = textProfession4.Text;
            _fiador2.Phone1 = maskedTextBox7.Text;
            _fiador2.Phone2 = maskedTextBox8.Text;
            _fiador2.Email = textEmail4.Text;
            if (ValidationDataAnnotation.ValidationModel(_fiador2))
            {
                if (_fiador2.Casado)
                {
                    ((Control)tabControl1.TabPages["tabPageConjugeF2"]).Enabled = true;
                    tabControl1.SelectTab(tabPageConjugeF2);
                }
                else
                {
                    buttonCadastrar.Enabled = true;
                }
            }
        }
        private void buttonValidarConjugeF2_Click(object sender, EventArgs e)
        {
            _conjugeF2 = new Conjuge();
            _conjugeF2.Name = textName5.Text;
            _conjugeF2.BirthDate = DateOnly.ParseExact(maskedBirthDate5.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            _conjugeF2.Sex = IdentifierSex(groupSex5);
            _conjugeF2.Cpf = maskedCpf5.Text;
            _conjugeF2.Rg = textRg5.Text;
            _conjugeF2.DispatchingAgency = textDispatchingAgency5.Text;
            _conjugeF2.Nacionality = textNacionality5.Text;
            _conjugeF2.Naturalness = textNaturalness5.Text;
            _conjugeF2.Uf = textUf5.Text;
            _conjugeF2.Profession = textProfession5.Text;
            _conjugeF2.Phone1 = maskedTextBox9.Text;
            _conjugeF2.Phone2 = maskedTextBox10.Text;
            _conjugeF2.Email = textEmail5.Text;
            if (ValidationDataAnnotation.ValidationModel(_conjugeF2))
            {
                buttonCadastrar.Enabled = true;
            }
        }

        //EVENTO DO BOTAO DE CADASTRAR
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        //METODO CADASTRAR
        private void Cadastrar()
        {
            var resposta = DialogResult;
            resposta = MessageBox.Show("Deseja Cadastrar o Locatário ?", "Cadastrar Locatário", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resposta == DialogResult.Yes)
            {
                _locatario.Conjuge = _conjuge;
                _fiador1.Conjuge = _conjugeF1;
                _fiador2.Conjuge = _conjugeF2;
                _locatario.Fiadores.AddRange(new Fiador[] { _fiador1, _fiador2 });

                try
                {
                    _personServices.AddLocatario(_locatario);
                    _locatario = null;
                    LimparControls(this);
                    MessageBox.Show("Locatário Cadastrado com Sucesso");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro ao Cadastrar Locatário", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //METODOS PARA IDENTIFICAR RADIO BUTTON SELECIONADO
        private string IdentifierMaritalStatus(GroupBox groupBox)
        {
            foreach (RadioButton rb in groupBox.Controls)
            {
                if (rb.Checked)
                {
                    return rb.Text;
                }
            }
            return null;
        }
        private string IdentifierSex(GroupBox groupBox)
        {
            foreach (RadioButton rb in groupBox.Controls)
            {
                if (rb.Checked)
                {
                    return rb.Text;
                }
            }
            return null;
        }

        //METODO PARA LIMPAR TODOS OS CAMPO DO FORMULARIO
        private void LimparControls(Form frm)
        {
            foreach (Control item in frm.Controls)
            {
                if (item is TabControl)
                {
                    foreach (TabPage page in ((TabControl)item).TabPages)
                    {
                        foreach (Control control in page.Controls)
                        {
                            if (control is TextBox)
                                control.Text = string.Empty;

                            else if (control is MaskedTextBox)
                                control.Text = String.Empty;

                            else if (control is NumericUpDown)
                            {
                                NumericUpDown numericUpDown = (NumericUpDown)control;
                                numericUpDown.Value = 0;
                            }

                            else if (control is GroupBox)
                            {
                                foreach (RadioButton r in control.Controls)
                                {
                                    r.Checked = false;
                                }
                            }
                        }
                    }
                }
            }
        }

        //EVENTOS PARA PROIBIR A ENTRADA CARACTERES INVALIDOS
        private void textName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsSeparator(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsNumber(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textDispatchingAgency_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textNacionality_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsSeparator(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textNaturalness_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsSeparator(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textUf_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsSeparator(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textIncome_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) ||
                   (e.KeyChar) == '.' || (e.KeyChar) == ','))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textName1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsSeparator(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textRg1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsNumber(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textDispatchingAgency1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textNacionality1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsSeparator(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textNaturalness1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsSeparator(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textUf1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsSeparator(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsSeparator(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textRg2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsNumber(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textDispatchingAgency2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textNacionality2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsSeparator(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textNaturalness2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsSeparator(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textUf2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsSeparator(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textName3_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsSeparator(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textRg3_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsNumber(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textDispatchingAgency3_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textNacionality3_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsSeparator(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textNaturalness3_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsSeparator(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textUf3_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsSeparator(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textName4_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsSeparator(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textRg4_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsNumber(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textDispatchingAgency4_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textNacionality4_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsSeparator(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textNaturalness4_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsSeparator(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textUf4_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsSeparator(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textName5_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsSeparator(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textRg5_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsNumber(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textDispatchingAgency5_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textNacionality5_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsSeparator(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textNaturalness5_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsSeparator(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
        private void textUf5_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                    char.IsSeparator(e.KeyChar)))
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
            catch (System.Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Caractere Inválido");
            }
        }
    }
}