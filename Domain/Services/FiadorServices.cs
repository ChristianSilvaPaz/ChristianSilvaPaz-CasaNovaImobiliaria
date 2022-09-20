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

        public List<Fiador> ListarFiadorPorId(int idLocatario)
        {
            return _fiadorDAO.ListarFiadorPorId(idLocatario);
        }

        public void EditarFiador(Fiador fiador)
        {
            _fiadorDAO.EditarFiador(fiador);
        }
    }
}
