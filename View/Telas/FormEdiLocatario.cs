using Infrastructure.Entities;
using Domain.Services;
using System.Media;

namespace View.Telas
{
    public partial class FormEdiLocatario : Form
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

        public FormEdiLocatario(int idLocatario, bool editar)
        {
            InitializeComponent();
            _locatarioServices = new LocatarioServices();
            _conjugeServices = new ConjugeServices();
            _fiadorServices = new FiadorServices();
            EstadoInicial(editar);
            _locatario = _locatarioServices.GetLocatarioPorId(idLocatario);
            PreencheCamposLocatario(idLocatario);
            PreencheCamposFiador1(idLocatario);
            PreencheCamposFiador2(idLocatario);
        }

        //METODO CASO O FORM SEJA PARA VISUALIZAR
        private void EstadoInicial(bool editar)
        {
            if (!editar)
            {
                buttonValidarLocatario.Enabled = false;
                buttonValidarConjuge.Enabled = false;
                buttonValidarFiador1.Enabled = false;
                buttonValidarConjugeF1.Enabled = false;
                buttonValidarFiador2.Enabled = false;
                buttonValidarConjugeF2.Enabled = false;
                buttonEditar.Enabled = false;
            }
        }

        //METODOS PARA PREENCHER OS CAMPOS
        private void PreencheCamposLocatario(int idLocatario)
        {
            _locatario = _locatarioServices.GetLocatarioPorId(idLocatario);
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
            if (_locatario.MaritalStatus.Equals("CASADO(A)"))
            {
                PreencheCamposConjuge(idLocatario);
            }
        }
        private void PreencheCamposConjuge(int idLocatario)
        {
            _conjuge = _conjugeServices.GetConjugePorId(idLocatario);
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
            _fiadores = _fiadorServices.GetFiadorPorId(idLocatrio);
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
            if (_fiador1.MaritalStatus.Equals("CASADO(A)"))
            {
                PreencheCamposConjugeF1(_fiador1.Id);
            }
        }
        private void PreencheCamposConjugeF1(int idFiador)
        {
            _conjugeF1 = _conjugeServices.GetConjugeFiadorPorId(idFiador);
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
            if (_fiador2.MaritalStatus.Equals("CASADO(A)"))
            {
                PreencheCamposConjugeF2(_fiador2.Id);
            }
        }
        private void PreencheCamposConjugeF2(int idFiador)
        {
            _conjugeF2 = _conjugeServices.GetConjugeFiadorPorId(idFiador);
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

        //EVENTOS DOS BOTOES DE VALIDAR
        private void buttonValidarLocatario_Click(object sender, EventArgs e)
        {
            _locatario.Name = textName.Text;
            _locatario.BirthDate = (string.IsNullOrEmpty(maskedBirthDate.Text) || maskedBirthDate.Text.Length < 8 ? null : DateOnly.ParseExact(maskedBirthDate.Text, "ddMMyyyy"));
            _locatario.MaritalStatus = IdentifierMaritalStatus(groupMaritalStatus);
            _locatario.Sex = IdentifierSex(groupSex);
            _locatario.Cpf = maskedCpf.Text;
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
                _locatario.Casado = _locatario.MaritalStatus.Equals("CASADO(A)") ? true : false;
                _locatarioServices.EditarLocatario(_locatario);
            }
        }
        private void buttonValidarConjuge_Click(object sender, EventArgs e)
        {
            _conjuge = new Conjuge();
            _conjuge.Name = textName1.Text;
            _conjuge.BirthDate = (string.IsNullOrEmpty(maskedBirthDate1.Text) || maskedBirthDate1.Text.Length < 8 ? null : DateOnly.ParseExact(maskedBirthDate1.Text, "ddMMyyyy"));
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
            _fiador1.BirthDate = (string.IsNullOrEmpty(maskedBirthDate2.Text) || maskedBirthDate2.Text.Length < 8 ? null : DateOnly.ParseExact(maskedBirthDate2.Text, "ddMMyyyy"));
            _fiador1.MaritalStatus = IdentifierMaritalStatus(groupMaritalStatus2);
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
                _fiador1.Casado = _fiador1.MaritalStatus.Equals("CASADO(A)") ? true : false;
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
            _conjugeF1.BirthDate = (string.IsNullOrEmpty(maskedBirthDate3.Text) || maskedBirthDate3.Text.Length < 8 ? null : DateOnly.ParseExact(maskedBirthDate3.Text, "ddMMyyyy"));
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
            _fiador2.BirthDate = (string.IsNullOrEmpty(maskedBirthDate4.Text) || maskedBirthDate4.Text.Length < 8 ? null : DateOnly.ParseExact(maskedBirthDate4.Text, "ddMMyyyy"));
            _fiador2.MaritalStatus = IdentifierMaritalStatus(groupMaritalStatus4);
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
                _fiador2.Casado = _fiador2.MaritalStatus.Equals("CASADO(A)") ? true : false;
                if (_fiador2.Casado)
                {
                    ((Control)tabControl1.TabPages["tabPageConjugeF2"]).Enabled = true;
                    tabControl1.SelectTab(tabPageConjugeF2);
                }
                else
                {
                    
                }
            }
        }
        private void buttonValidarConjugeF2_Click(object sender, EventArgs e)
        {
            _conjugeF2 = new Conjuge();
            _conjugeF2.Name = textName5.Text;
            _conjugeF2.BirthDate = (string.IsNullOrEmpty(maskedBirthDate5.Text) || maskedBirthDate5.Text.Length < 8 ? null : DateOnly.ParseExact(maskedBirthDate5.Text, "ddMMyyyy"));
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
