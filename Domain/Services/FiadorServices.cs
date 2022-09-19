using Infrastructure.Entities;
using Infrastructure.Repositorys;

namespace Domain.Services
{
    public class FiadorServices
    {
        private FiadorDAO _fiadorDAO;

        public FiadorServices()
        {
            _fiadorDAO = new FiadorDAO();
        }

        public List<Fiador> GetFiadorPorId(int idLocatario)
        {
            return _fiadorDAO.GetFiadorPorId(idLocatario);
        }
    }
}
