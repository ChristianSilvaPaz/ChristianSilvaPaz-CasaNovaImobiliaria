using Infrastructure.Repositorys;
using Infrastructure.Entities;

namespace Domain.Services
{
    public class PersonServices
    {
        private LocatarioDAO _locatarioDAO;
        private ConjugeDAO _conjugeDAO;
        private FiadorDAO _fiadorDAO;

        public PersonServices()
        {
            _locatarioDAO = new LocatarioDAO();
            _conjugeDAO = new ConjugeDAO();
            _fiadorDAO = new FiadorDAO();
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

        public Conjuge GetConjugePorId(int idLocatario)
        {
            return _conjugeDAO.GetConjugePorId(idLocatario);
        }

        public Conjuge GetConjugeFiadorPorId(int idFiador)
        {
            return _conjugeDAO.GetConjugeFiadorPorId(idFiador);
        }

        public List<Fiador> GetFiadorPorId(int idLocatario)
        {
            return _fiadorDAO.GetFiadorPorId(idLocatario);
        }
    }
}
