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

        public Conjuge ListarConjugeLocatarioPorId(int idLocatario)
        {
            return _conjugeDAO.ListarConjugeLocatarioPorId(idLocatario);
        }

        public Conjuge ListarConjugeFiadorPorId(int idFiador)
        {
            return _conjugeDAO.ListarConjugeFiadorPorId(idFiador);
        }        

        public void EditarConjuge(Conjuge conjuge)
        {
            _conjugeDAO.EditarConjuge(conjuge);
        }

        public void CadastrarConjuge(Conjuge conjuge)
        {
            _conjugeDAO.CadastrarConjuge(conjuge);
        }

        public void ExcluirConjuge(int idConjuge)
        {
            _conjugeDAO.ExcluirConjuge(idConjuge);
        }
    }
}
