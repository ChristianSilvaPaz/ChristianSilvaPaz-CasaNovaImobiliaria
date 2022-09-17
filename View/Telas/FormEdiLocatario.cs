using Domain.Services;
using Infrastructure.Entities;

namespace View.Telas
{
    public partial class FormEdiLocatario : Form
    {
        private PersonServices _personServices;
        private Locatario _locatario;
        private Conjuge _conjuge;
        private Fiador _fiador;
        private List<Fiador> _fiadores;

        public FormEdiLocatario(int idLocatario)
        {
            InitializeComponent();
            _personServices = new PersonServices();
            PreencheCamposLocatario(idLocatario);
            PreencheCamposFiador1(idLocatario);
            PreencheCamposFiador2(idLocatario);
        }

        private void PreencheCamposLocatario(int idLocatario)
        {
            _locatario = _personServices.GetLocatarioPorId(idLocatario);
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

        private void PreencheCamposConjuge(int idLocatrio)
        {
            _conjuge = _personServices.GetConjugePorId(idLocatrio);
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
            _fiadores = _personServices.GetFiadorPorId(idLocatrio);
            _fiador = _fiadores[0];
            textName2.Text = _fiador.Name;
            maskedBirthDate2.Text = _fiador.BirthDate.ToString();
            SelecionaMaritalStatus(_fiador.MaritalStatus, groupMaritalStatus2);
            SelecionaSex(_fiador.Sex, groupSex2);
            maskedCpf2.Text = _fiador.Cpf;
            textRg2.Text = _fiador.Rg;
            textDispatchingAgency2.Text = _fiador.DispatchingAgency;
            textNacionality2.Text = _fiador.Nacionality;
            textNaturalness2.Text = _fiador.Naturalness;
            textUf2.Text = _fiador.Uf;
            textProfession2.Text = _fiador.Profession;
            maskedTextBox3.Text = _fiador.Phone1;
            maskedTextBox4.Text = _fiador.Phone2;
            textEmail2.Text = _fiador.Email;
            if (_fiador.MaritalStatus.Equals("CASADO(A)"))
            {
                PreencheCamposConjugeFiador1(_fiador.Id);
            }
        }

        private void PreencheCamposConjugeFiador1(int idFiador)
        {
            _conjuge = _personServices.GetConjugeFiadorPorId(idFiador);
            textName3.Text = _conjuge.Name;
            maskedBirthDate3.Text = _conjuge.BirthDate.ToString();
            SelecionaSex(_conjuge.Sex, groupSex3);
            maskedCpf3.Text = _conjuge.Cpf;
            textRg3.Text = _conjuge.Rg;
            textDispatchingAgency3.Text = _conjuge.DispatchingAgency;
            textNacionality3.Text = _conjuge.Nacionality;
            textNaturalness3.Text = _conjuge.Naturalness;
            textUf3.Text = _conjuge.Uf;
            textProfession3.Text = _conjuge.Profession;
            maskedTextBox5.Text = _conjuge.Phone1;
            maskedTextBox6.Text = _conjuge.Phone2;
            textEmail3.Text = _conjuge.Email;
        }

        private void PreencheCamposFiador2(int idLocatrio)
        {
            _fiador = _fiadores[1];
            textName4.Text = _fiador.Name;
            maskedBirthDate4.Text = _fiador.BirthDate.ToString();
            SelecionaMaritalStatus(_fiador.MaritalStatus, groupMaritalStatus4);
            SelecionaSex(_fiador.Sex, groupSex4);
            maskedCpf4.Text = _fiador.Cpf;
            textRg4.Text = _fiador.Rg;
            textDispatchingAgency4.Text = _fiador.DispatchingAgency;
            textNacionality4.Text = _fiador.Nacionality;
            textNaturalness4.Text = _fiador.Naturalness;
            textUf4.Text = _fiador.Uf;
            textProfession4.Text = _fiador.Profession;
            maskedTextBox7.Text = _fiador.Phone1;
            maskedTextBox8.Text = _fiador.Phone2;
            textEmail4.Text = _fiador.Email;
            if (_fiador.MaritalStatus.Equals("CASADO(A)"))
            {
                PreencheCamposConjugeFiador2(_fiador.Id);
            }
        }

        private void PreencheCamposConjugeFiador2(int idFiador)
        {
            _conjuge = _personServices.GetConjugeFiadorPorId(idFiador);
            textName5.Text = _conjuge.Name;
            maskedBirthDate5.Text = _conjuge.BirthDate.ToString();
            SelecionaSex(_conjuge.Sex, groupSex5);
            maskedCpf5.Text = _conjuge.Cpf;
            textRg5.Text = _conjuge.Rg;
            textDispatchingAgency5.Text = _conjuge.DispatchingAgency;
            textNacionality5.Text = _conjuge.Nacionality;
            textNaturalness5.Text = _conjuge.Naturalness;
            textUf5.Text = _conjuge.Uf;
            textProfession5.Text = _conjuge.Profession;
            maskedTextBox9.Text = _conjuge.Phone1;
            maskedTextBox10.Text = _conjuge.Phone2;
            textEmail5.Text = _conjuge.Email;
        }

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
    }
}
