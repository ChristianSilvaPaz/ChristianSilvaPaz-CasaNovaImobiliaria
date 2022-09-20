using Infrastructure.Entities;
using Domain.Services;
using System.Media;

namespace View.Telas
{
    public partial class FormEditarLocatario : Form
    {
        private LocatarioServices _locatarioServices;
        private ConjugeServices _conjugeServices;
        private FiadorServices _fiadorServices;
        private List<Fiador> _fiadores;
        private Locatario _locatario;
        private Conjuge _conjugeF1;
        private Conjuge _conjugeF2;
        private Conjuge _conjuge;
        private Fiador _fiador1;
        private Fiador _fiador2;

        public FormEditarLocatario(int idLocatario, bool editar)
        {
            InitializeComponent();
            _locatarioServices = new LocatarioServices();
            _conjugeServices = new ConjugeServices();
            _fiadorServices = new FiadorServices();
            EstadoInicial(editar);
            PreencheCamposLocatario(idLocatario);
            PreencheCamposFiador1(idLocatario);
            PreencheCamposFiador2(idLocatario);
        }

        //METODO CASO O FORM SEJA PARA VISUALIZAR
        private void EstadoInicial(bool editar)
        {
            if (!editar)
            {
                buttonEditarLocatario.Enabled = false;
                buttonEditarConjuge.Enabled = false;
                buttonEditarFiador1.Enabled = false;
                buttonEditarConjugeF1.Enabled = false;
                buttonEditarFiador2.Enabled = false;
                buttonEditarConjugeF2.Enabled = false;
            }
        }

        //METODOS PARA PREENCHER OS CAMPOS
        private void PreencheCamposLocatario(int idLocatario)
        {
            _locatario = _locatarioServices.ListarLocatarioPorId(idLocatario);
            textName.Text = _locatario.Name;
            maskedBirthDate.Text = _locatario.BirthDate.ToString();
            SelecionaMaritalStatus(_locatario.MaritalStatus, groupMaritalStatus);
            SelecionaSex(_locatario.Sex, groupSex);
            maskedCpf.Text = _locatario.Cpf;
            textRg.Text = _locatario.Rg;
            textDispatchingAgency.Text = _locatario.DispatchingAgency;
            textNacionality.Text = _locatario.Nacionality;
            textNaturalness.Text = _locatario.Naturalness;
            textUf.Text = _locatario.Uf;
            textProfession.Text = _locatario.Profession;
            textIncome.Text = _locatario.Income.ToString();
            textWorkAdress.Text = _locatario.WorkAddress;
            maskedPhoneWork.Text = _locatario.WorkAddress;
            maskedPhone1.Text = _locatario.Phone1;
            maskedPhone2.Text = _locatario.Phone2;
            numericQtdAnimals.Value = _locatario.QtdAnimals;
            textEmail.Text = _locatario.Email;
            textComments.Text = _locatario.Comments;
            if (_locatario.Casado)
            {
                PreencheCamposConjuge(idLocatario);
            }
        }
        private void PreencheCamposConjuge(int idLocatario)
        {
            _conjuge = _conjugeServices.ListarConjugeLocatarioPorId(idLocatario);
            textName1.Text = _conjuge.Name;
            maskedBirthDate1.Text = _conjuge.BirthDate.ToString();
            SelecionaSex(_conjuge.Sex, groupSex1);
            maskedCpf1.Text = _conjuge.Cpf;
            textRg1.Text = _conjuge.Rg;
            textDispatchingAgency1.Text = _conjuge.DispatchingAgency;
            textNacionality1.Text = _conjuge.Nacionality;
            textNaturalness1.Text = _conjuge.Naturalness;
            textUf1.Text = _conjuge.Uf;
            textProfession1.Text = _conjuge.Profession;
            maskedTextBox1.Text = _conjuge.Phone1;
            maskedTextBox2.Text = _conjuge.Phone2;
            textEmail1.Text = _conjuge.Email;
        }
        private void PreencheCamposFiador1(int idLocatrio)
        {
            _fiadores = _fiadorServices.ListarFiadorPorId(idLocatrio);
            _fiador1 = _fiadores[0];
            textName2.Text = _fiador1.Name;
            maskedBirthDate2.Text = _fiador1.BirthDate.ToString();
            SelecionaMaritalStatus(_fiador1.MaritalStatus, groupMaritalStatus2);
            SelecionaSex(_fiador1.Sex, groupSex2);
            maskedCpf2.Text = _fiador1.Cpf;
            textRg2.Text = _fiador1.Rg;
            textDispatchingAgency2.Text = _fiador1.DispatchingAgency;
            textNacionality2.Text = _fiador1.Nacionality;
            textNaturalness2.Text = _fiador1.Naturalness;
            textUf2.Text = _fiador1.Uf;
            textProfession2.Text = _fiador1.Profession;
            maskedTextBox3.Text = _fiador1.Phone1;
            maskedTextBox4.Text = _fiador1.Phone2;
            textEmail2.Text = _fiador1.Email;
            if (_fiador1.Casado)
            {
                PreencheCamposConjugeF1(_fiador1.Id);
            }
        }
        private void PreencheCamposConjugeF1(int idFiador)
        {
            _conjugeF1 = _conjugeServices.ListarConjugeFiadorPorId(idFiador);
            textName3.Text = _conjugeF1.Name;
            maskedBirthDate3.Text = _conjugeF1.BirthDate.ToString();
            SelecionaSex(_conjugeF1.Sex, groupSex3);
            maskedCpf3.Text = _conjugeF1.Cpf;
            textRg3.Text = _conjugeF1.Rg;
            textDispatchingAgency3.Text = _conjugeF1.DispatchingAgency;
            textNacionality3.Text = _conjugeF1.Nacionality;
            textNaturalness3.Text = _conjugeF1.Naturalness;
            textUf3.Text = _conjugeF1.Uf;
            textProfession3.Text = _conjugeF1.Profession;
            maskedTextBox5.Text = _conjugeF1.Phone1;
            maskedTextBox6.Text = _conjugeF1.Phone2;
            textEmail3.Text = _conjugeF1.Email;
        }
        private void PreencheCamposFiador2(int idLocatrio)
        {
            _fiador2 = _fiadores[1];
            textName4.Text = _fiador2.Name;
            maskedBirthDate4.Text = _fiador2.BirthDate.ToString();
            SelecionaMaritalStatus(_fiador2.MaritalStatus, groupMaritalStatus4);
            SelecionaSex(_fiador2.Sex, groupSex4);
            maskedCpf4.Text = _fiador2.Cpf;
            textRg4.Text = _fiador2.Rg;
            textDispatchingAgency4.Text = _fiador2.DispatchingAgency;
            textNacionality4.Text = _fiador2.Nacionality;
            textNaturalness4.Text = _fiador2.Naturalness;
            textUf4.Text = _fiador2.Uf;
            textProfession4.Text = _fiador2.Profession;
            maskedTextBox7.Text = _fiador2.Phone1;
            maskedTextBox8.Text = _fiador2.Phone2;
            textEmail4.Text = _fiador2.Email;
            if (_fiador2.Casado)
            {
                PreencheCamposConjugeF2(_fiador2.Id);
            }
        }
        private void PreencheCamposConjugeF2(int idFiador)
        {
            _conjugeF2 = _conjugeServices.ListarConjugeFiadorPorId(idFiador);
            textName5.Text = _conjugeF2.Name;
            maskedBirthDate5.Text = _conjugeF2.BirthDate.ToString();
            SelecionaSex(_conjugeF2.Sex, groupSex5);
            maskedCpf5.Text = _conjugeF2.Cpf;
            textRg5.Text = _conjugeF2.Rg;
            textDispatchingAgency5.Text = _conjugeF2.DispatchingAgency;
            textNacionality5.Text = _conjugeF2.Nacionality;
            textNaturalness5.Text = _conjugeF2.Naturalness;
            textUf5.Text = _conjugeF2.Uf;
            textProfession5.Text = _conjugeF2.Profession;
            maskedTextBox9.Text = _conjugeF2.Phone1;
            maskedTextBox10.Text = _conjugeF2.Phone2;
            textEmail5.Text = _conjugeF2.Email;
        }

        //METODOS PARA SELECIONAR RADIO BUTTON
        private void SelecionaMaritalStatus(string texto, GroupBox groupBox)
        {
            foreach (RadioButton rb in groupBox.Controls)
            {
                if (rb.Text == texto)
                {
                    rb.Checked = true;
                }
            }
        }
        private void SelecionaSex(string texto, GroupBox groupBox)
        {
            foreach (RadioButton rb in groupBox.Controls)
            {
                if (rb.Text == texto)
                {
                    rb.Checked = true;
                }
            }
        }

        //EVENTOS DOS BOTOES DE EDITAR
        private void buttonEditarLocatario_Click(object sender, EventArgs e)
        {
            Locatario locatarioNovo = new Locatario();
            locatarioNovo.Name = textName.Text;
            locatarioNovo.BirthDate = (string.IsNullOrEmpty(maskedBirthDate.Text) || maskedBirthDate.Text.Length < 8 ? null : DateOnly.ParseExact(maskedBirthDate.Text, "ddMMyyyy"));
            locatarioNovo.MaritalStatus = IdentifierMaritalStatus(groupMaritalStatus);
            locatarioNovo.Sex = IdentifierSex(groupSex);
            locatarioNovo.Cpf = maskedCpf.Text;
            locatarioNovo.Rg = textRg.Text;
            locatarioNovo.DispatchingAgency = textDispatchingAgency.Text;
            locatarioNovo.Nacionality = textNacionality.Text;
            locatarioNovo.Naturalness = textNaturalness.Text;
            locatarioNovo.Uf = textUf.Text;
            locatarioNovo.Profession = textProfession.Text;
            locatarioNovo.Income = (double)(string.IsNullOrEmpty(textIncome.Text) ? 0 : Convert.ToDecimal(textIncome.Text));
            locatarioNovo.WorkAddress = textWorkAdress.Text;
            locatarioNovo.PhoneWork = maskedPhoneWork.Text;
            locatarioNovo.Phone1 = maskedPhone1.Text;
            locatarioNovo.Phone2 = maskedPhone2.Text;
            locatarioNovo.QtdAnimals = (int)numericQtdAnimals.Value;
            locatarioNovo.Email = textEmail.Text;
            locatarioNovo.Comments = textComments.Text;
            if (ValidationDataAnnotation.ValidationModel(locatarioNovo))
            {
                locatarioNovo.Casado = locatarioNovo.MaritalStatus.Equals("CASADO(A)") ? true : false;
                locatarioNovo.Id = _locatario.Id;
                var resposta = DialogResult;
                resposta = MessageBox.Show("Deseja Alterar o Locatário ?", "Alterar Locatário", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    try
                    {
                        _locatarioServices.EditarLocatario(locatarioNovo);
                        MessageBox.Show("Locatário Alterado com Sucesso");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Alterar o Locatário", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (_locatario.Casado != locatarioNovo.Casado)
            {
                if (_locatario.Casado == true && locatarioNovo.Casado == false)
                {
                    MessageBox.Show("Excluir Conjuge");
                }
                else if (_locatario.Casado == false && locatarioNovo.Casado == true)
                {
                    MessageBox.Show("Cadastrar Conjuge");
                }
            }
        }
        private void buttonEditarConjuge_Click(object sender, EventArgs e)
        {
            Conjuge conjugeNovo = new Conjuge();
            conjugeNovo.Name = textName1.Text;
            conjugeNovo.BirthDate = (string.IsNullOrEmpty(maskedBirthDate1.Text) || maskedBirthDate1.Text.Length < 8 ? null : DateOnly.ParseExact(maskedBirthDate1.Text, "ddMMyyyy"));
            conjugeNovo.Sex = IdentifierSex(groupSex1);
            conjugeNovo.Cpf = maskedCpf1.Text;
            conjugeNovo.Rg = textRg1.Text;
            conjugeNovo.DispatchingAgency = textDispatchingAgency1.Text;
            conjugeNovo.Nacionality = textNacionality1.Text;
            conjugeNovo.Naturalness = textNaturalness1.Text;
            conjugeNovo.Uf = textUf1.Text;
            conjugeNovo.Profession = textProfession1.Text;
            conjugeNovo.Phone1 = maskedTextBox1.Text;
            conjugeNovo.Phone2 = maskedTextBox2.Text;
            conjugeNovo.Email = textEmail1.Text;
            if (ValidationDataAnnotation.ValidationModel(conjugeNovo))
            {
                conjugeNovo.Id = _conjuge.Id;
                var resposta = DialogResult;
                resposta = MessageBox.Show("Deseja Alterar o Conjuge ?", "Alterar Conjuge", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    try
                    {
                        _conjugeServices.EditarConjuge(conjugeNovo);
                        MessageBox.Show("Conjuge Alterado com Sucesso");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Alterar o Conjuge", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void buttonEditarFiador1_Click(object sender, EventArgs e)
        {
            Fiador fiador1Novo = new Fiador();
            fiador1Novo.Name = textName2.Text;
            fiador1Novo.BirthDate = (string.IsNullOrEmpty(maskedBirthDate2.Text) || maskedBirthDate2.Text.Length < 8 ? null : DateOnly.ParseExact(maskedBirthDate2.Text, "ddMMyyyy"));
            fiador1Novo.MaritalStatus = IdentifierMaritalStatus(groupMaritalStatus2);
            fiador1Novo.Sex = IdentifierSex(groupSex2);
            fiador1Novo.Cpf = maskedCpf2.Text;
            fiador1Novo.Rg = textRg2.Text;
            fiador1Novo.DispatchingAgency = textDispatchingAgency2.Text;
            fiador1Novo.Nacionality = textNacionality2.Text;
            fiador1Novo.Naturalness = textNaturalness2.Text;
            fiador1Novo.Uf = textUf2.Text;
            fiador1Novo.Profession = textProfession2.Text;
            fiador1Novo.Phone1 = maskedTextBox3.Text;
            fiador1Novo.Phone2 = maskedTextBox4.Text;
            fiador1Novo.Email = textEmail2.Text;
            if (ValidationDataAnnotation.ValidationModel(fiador1Novo))
            {
                fiador1Novo.Casado = fiador1Novo.MaritalStatus.Equals("CASADO(A)") ? true : false;
                fiador1Novo.Id = _fiador1.Id;
                var resposta = DialogResult;
                resposta = MessageBox.Show("Deseja Alterar o Fiador 1 ?", "Alterar Fiador", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    try
                    {
                        _fiadorServices.EditarFiador(fiador1Novo);
                        MessageBox.Show("Fiador 1 Alterado com Sucesso");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Alterar o Fiador 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (_fiador1.Casado != fiador1Novo.Casado)
            {
                if (_fiador1.Casado == true && fiador1Novo.Casado == false)
                {
                    MessageBox.Show("Excluir Conjuge");
                }
                else if (_fiador1.Casado == false && fiador1Novo.Casado == true)
                {
                    MessageBox.Show("Cadastrar Conjuge");
                }
            }
        }        
        private void buttonEditarConjugeF1_Click(object sender, EventArgs e)
        {
            Conjuge conjugeF1Novo = new Conjuge();
            conjugeF1Novo.Name = textName3.Text;
            conjugeF1Novo.BirthDate = (string.IsNullOrEmpty(maskedBirthDate3.Text) || maskedBirthDate3.Text.Length < 8 ? null : DateOnly.ParseExact(maskedBirthDate3.Text, "ddMMyyyy"));
            conjugeF1Novo.Sex = IdentifierSex(groupSex3);
            conjugeF1Novo.Cpf = maskedCpf3.Text;
            conjugeF1Novo.Rg = textRg3.Text;
            conjugeF1Novo.DispatchingAgency = textDispatchingAgency3.Text;
            conjugeF1Novo.Nacionality = textNacionality3.Text;
            conjugeF1Novo.Naturalness = textNaturalness3.Text;
            conjugeF1Novo.Uf = textUf3.Text;
            conjugeF1Novo.Profession = textProfession3.Text;
            conjugeF1Novo.Phone1 = maskedTextBox5.Text;
            conjugeF1Novo.Phone2 = maskedTextBox6.Text;
            conjugeF1Novo.Email = textEmail3.Text;
            if (ValidationDataAnnotation.ValidationModel(conjugeF1Novo))
            {
                conjugeF1Novo.Id = _conjugeF1.Id;
                var resposta = DialogResult;
                resposta = MessageBox.Show("Deseja Alterar o Conjuge ?", "Alterar Conjuge", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    try
                    {
                        _conjugeServices.EditarConjuge(conjugeF1Novo);
                        MessageBox.Show("Conjuge Alterado com Sucesso");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Alterar o Conjuge", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void buttonEditarFiador2_Click(object sender, EventArgs e)
        {
            Fiador fiador2Novo = new Fiador();
            fiador2Novo.Name = textName4.Text;
            fiador2Novo.BirthDate = (string.IsNullOrEmpty(maskedBirthDate4.Text) || maskedBirthDate4.Text.Length < 8 ? null : DateOnly.ParseExact(maskedBirthDate4.Text, "ddMMyyyy"));
            fiador2Novo.MaritalStatus = IdentifierMaritalStatus(groupMaritalStatus4);
            fiador2Novo.Sex = IdentifierSex(groupSex4);
            fiador2Novo.Cpf = maskedCpf4.Text;
            fiador2Novo.Rg = textRg4.Text;
            fiador2Novo.DispatchingAgency = textDispatchingAgency4.Text;
            fiador2Novo.Nacionality = textNacionality4.Text;
            fiador2Novo.Naturalness = textNaturalness4.Text;
            fiador2Novo.Uf = textUf4.Text;
            fiador2Novo.Profession = textProfession4.Text;
            fiador2Novo.Phone1 = maskedTextBox7.Text;
            fiador2Novo.Phone2 = maskedTextBox8.Text;
            fiador2Novo.Email = textEmail4.Text;
            if (ValidationDataAnnotation.ValidationModel(_fiador2))
            {
                fiador2Novo.Casado = fiador2Novo.MaritalStatus.Equals("CASADO(A)") ? true : false;
                fiador2Novo.Id = _fiador2.Id;
                var resposta = DialogResult;
                resposta = MessageBox.Show("Deseja Alterar o Fiador 2 ?", "Alterar Fiador", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    try
                    {
                        _fiadorServices.EditarFiador(fiador2Novo);
                        MessageBox.Show("Fiador 2 Alterado com Sucesso");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Alterar o Fiador 2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (_fiador2.Casado != fiador2Novo.Casado)
            {
                if (_fiador2.Casado == true && fiador2Novo.Casado == false)
                {
                    MessageBox.Show("Excluir Conjuge");
                }
                else if (_fiador2.Casado == false && fiador2Novo.Casado == true)
                {
                    MessageBox.Show("Cadastrar Conjuge");
                }
            }
        }       
        private void buttonEditarConjugeF2_Click(object sender, EventArgs e)
        {
            Conjuge conjugeF2Novo = new Conjuge();
            conjugeF2Novo.Name = textName5.Text;
            conjugeF2Novo.BirthDate = (string.IsNullOrEmpty(maskedBirthDate5.Text) || maskedBirthDate5.Text.Length < 8 ? null : DateOnly.ParseExact(maskedBirthDate5.Text, "ddMMyyyy"));
            conjugeF2Novo.Sex = IdentifierSex(groupSex5);
            conjugeF2Novo.Cpf = maskedCpf5.Text;
            conjugeF2Novo.Rg = textRg5.Text;
            conjugeF2Novo.DispatchingAgency = textDispatchingAgency5.Text;
            conjugeF2Novo.Nacionality = textNacionality5.Text;
            conjugeF2Novo.Naturalness = textNaturalness5.Text;
            conjugeF2Novo.Uf = textUf5.Text;
            conjugeF2Novo.Profession = textProfession5.Text;
            conjugeF2Novo.Phone1 = maskedTextBox9.Text;
            conjugeF2Novo.Phone2 = maskedTextBox10.Text;
            conjugeF2Novo.Email = textEmail5.Text;
            if (ValidationDataAnnotation.ValidationModel(conjugeF2Novo))
            {
                conjugeF2Novo.Id = _conjugeF2.Id;
                var resposta = DialogResult;
                resposta = MessageBox.Show("Deseja Alterar o Conjuge ?", "Alterar Conjuge", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    try
                    {
                        _conjugeServices.EditarConjuge(conjugeF2Novo);
                        MessageBox.Show("Conjuge Alterado com Sucesso");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Alterar o Conjuge", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        //EVENTOS PARA PROIBIR A ENTRADA DE CARACTERES INVALIDOS
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
