using Infrastructure.Repositorys;
using Infrastructure.Entities;

namespace Domain.Services
{
    public class ConjugeServices
    {
        private ConjugeDAO _conjugeDAO;

        public ConjugeServices()
        {
            _conjugeDAO = new ConjugeDAO();
        }

        public Conjuge GetConjugePorId(int idLocatario)
        {
            return _conjugeDAO.GetConjugePorId(idLocatario);
        }

        public Conjuge GetConjugeFiadorPorId(int idFiador)
        {
            return _conjugeDAO.GetConjugeFiadorPorId(idFiador);
        }        
    }
}
