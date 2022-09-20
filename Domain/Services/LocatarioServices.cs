using Infrastructure.Entities;
using Infrastructure.Repositorys;

namespace Domain.Services
{
    public class LocatarioServices
    {
        private LocatarioDAO _locatarioDAO;

        public LocatarioServices()
        {
            _locatarioDAO = new LocatarioDAO();
        }

        public void CadastrarLocatario(Locatario locatario)
        {
            _locatarioDAO.CadastrarLocatario(locatario);
        }

        public void EditarLocatario(Locatario locatario)
        {
            _locatarioDAO.EditarLocatario(locatario);
        }

        public Locatario ListarLocatarioPorId(int idLocatario)
        {
            return _locatarioDAO.ListarLocatarioPorId(idLocatario);
        }

        public List<Locatario> ListarLocatarioPorNome(string nome)
        {
            return _locatarioDAO.ListarLocatarioPorNome(nome);
        }

        public List<Locatario> ListarLocatarios()
        {
            return _locatarioDAO.ListarLocatarios();
        }

    }
}
