namespace View.Telas
{
    public partial class Form1 : Form
    {
        private Form _formAtivo = null;

        public Form1()
        {
            InitializeComponent();
            OcultaSubMenu();
        }

        private void AbrirFormNovo(Form form)
        {
            if (_formAtivo != null)
            {
                _formAtivo.Close();
            }
            _formAtivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelCarregamento.Controls.Add(form);
            panelCarregamento.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void OcultaSubMenu()
        {
            panelCrudLocatario.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultaSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void buttonLocatario_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelCrudLocatario);
        }

        private void buttonCadCrud_Click(object sender, EventArgs e)
        {
            AbrirFormNovo(new FormCadLocatario());
            OcultaSubMenu();
        }

        private void buttonPesCrud_Click(object sender, EventArgs e)
        {
            AbrirFormNovo(new FormPesLocatario());
            OcultaSubMenu();
        }
    }
}
