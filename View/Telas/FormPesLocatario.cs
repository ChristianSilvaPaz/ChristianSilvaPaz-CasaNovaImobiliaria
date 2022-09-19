using Domain.Services;

namespace View.Telas
{
    public partial class FormPesLocatario : Form
    {
        private LocatarioServices _locatarioServices;

        public FormPesLocatario()
        {
            InitializeComponent();
            _locatarioServices = new LocatarioServices();
            dataGridView1.DataSource = _locatarioServices.GetLocatarios();
            PreencheDGV();
        }

        public void PreencheDGV()
        {
            dataGridView1.ReadOnly = true;
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
        }



        //EVENTO CASO O USURIO APERTE A TECLA ENTER
        private void textPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView1.DataSource = _locatarioServices.GetLocatarioPorNome(textPesquisar.Text);
            }
        }

        //EVENTO DO BOTAO DE PESQUISAR
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _locatarioServices.GetLocatarioPorNome(textPesquisar.Text);
        }

        private void buttonVisualizar_Click(object sender, EventArgs e)
        {
            int idLocatario = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            FormEdiLocatario formEdiLocatario = new FormEdiLocatario(idLocatario, false);
            formEdiLocatario.Show();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            int idLocatario = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            FormEdiLocatario formEdiLocatario = new FormEdiLocatario(idLocatario, true);
            formEdiLocatario.Show();
        }
    }
}
