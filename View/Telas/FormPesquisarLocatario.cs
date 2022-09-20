using Domain.Services;

namespace View.Telas
{
    public partial class FormPesquisarLocatario : Form
    {
        private LocatarioServices _locatarioServices;

        public FormPesquisarLocatario()
        {
            InitializeComponent();
            _locatarioServices = new LocatarioServices();
            //PREENCHER O DGV COM TODOS OS LOCATARIOS CADASTRADOS
            dataGridView1.DataSource = _locatarioServices.ListarLocatarios();
            CustomizaDGV();
        }

        //ALTERA PROPRIEDADE VISIBLE DAS COLUNAS
        public void CustomizaDGV()
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
                ListarLocatarioPorNome();
            }
        }

        //EVENTO DO BOTAO DE PESQUISAR
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            ListarLocatarioPorNome();
        }

        //METODO PARA LISTAR OS LOCATARIOS PELO NOME DIGITADO 
        private void ListarLocatarioPorNome()
        {
            dataGridView1.DataSource = _locatarioServices.ListarLocatarioPorNome(textPesquisar.Text);
        }

        //EVENTO DO BOTOES DE VISUALIZAR E EDITAR
        //FALSE = VISUALIZAR
        //TRUE = EDITAR
        private void buttonVisualizar_Click(object sender, EventArgs e)
        {
            int idLocatario = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            FormEditarLocatario formEdiLocatario = new FormEditarLocatario(idLocatario, false);
            formEdiLocatario.Show();
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            int idLocatario = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            FormEditarLocatario formEdiLocatario = new FormEditarLocatario(idLocatario, true);
            formEdiLocatario.Show();
        }
    }
}
