using Infrastructure.Repositorys;

namespace View.Telas
{
    public partial class FormPesLocatario : Form
    {
        private LocatarioDAO _locatarioDAO;

        public FormPesLocatario()
        {
            InitializeComponent();
            _locatarioDAO = new LocatarioDAO();
            dataGridView1.DataSource = _locatarioDAO.GetLocatarios();
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
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idLocatario = Convert.ToInt32(dataGridView1["Id", e.RowIndex].Value);
            FormEdiLocatario formEdiLocatario = new FormEdiLocatario(idLocatario);
            formEdiLocatario.Show();
        }
    }
}
