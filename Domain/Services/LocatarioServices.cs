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

        public void AddLocatario(Locatario locatario)
        {
            _locatarioDAO.AddLocatario(locatario);
        }

        public List<Locatario> GetLocatarios()
        {
            return _locatarioDAO.GetLocatarios();
        }

        public Locatario GetLocatarioPorId(int idLocatario)
        {
            return _locatarioDAO.GetLocatarioPorId(idLocatario);
        }

        public List<Locatario> GetLocatarioPorNome(string nome)
        {
            return _locatarioDAO.GetLocatarioPorNome(nome);
        }

        public void EditarLocatario(Locatario locatario)
        {
            _locatarioDAO.EditarLocatario(locatario);
        }
    }
}
