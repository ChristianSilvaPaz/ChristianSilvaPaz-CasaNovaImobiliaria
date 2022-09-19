using Infrastructure.Entities;
using MySql.Data.MySqlClient;

namespace Infrastructure.Repositorys
{
    public class FiadorDAO
    {
        private ConjugeDAO _conjugeDAO;
        private LocatarioXFiadorDAO _locatarioXFiadorDAO;

        public FiadorDAO()
        {
            _conjugeDAO = new ConjugeDAO();
            _locatarioXFiadorDAO = new LocatarioXFiadorDAO();
        }

        //METODO DE INSERIR FIADORES, INCLUIDO NO ESCOPO DE CONTROLE DE TRANSACAO
        public void addFiador(List<Fiador> fiadores, int idLocatario)
        {
            foreach (Fiador fiador in fiadores)
            {
                string queryAdd = "INSERT INTO guarantor(name, birthdate, maritalstatus, sex, cpf, rg," +
                               " dispatchingagency, nacionality, naturalness, uf, phone1, phone2, email)" +
                               " VALUES (@name, @birthdate, @maritalstatus, @sex, @cpf, @rg, @dispatchingagency, @nacionality," +
                               " @naturalness, @uf, @phone1, @phone2, @email);";

                string queryGetId = "SELECT id FROM guarantor ORDER BY id DESC LIMIT 1;";

                using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
                {
                    using (MySqlCommand cmdAdd = new MySqlCommand(queryAdd, conn))
                    {
                        conn.Open();
                        cmdAdd.Parameters.AddWithValue("name", fiador.Name);
                        cmdAdd.Parameters.AddWithValue("birthdate", fiador.BirthDate);
                        cmdAdd.Parameters.AddWithValue("maritalstatus", fiador.MaritalStatus);
                        cmdAdd.Parameters.AddWithValue("sex", fiador.Sex);
                        cmdAdd.Parameters.AddWithValue("cpf", fiador.Cpf);
                        cmdAdd.Parameters.AddWithValue("rg", fiador.Rg);
                        cmdAdd.Parameters.AddWithValue("dispatchingagency", fiador.DispatchingAgency);
                        cmdAdd.Parameters.AddWithValue("nacionality", fiador.Nacionality);
                        cmdAdd.Parameters.AddWithValue("naturalness", fiador.Naturalness);
                        cmdAdd.Parameters.AddWithValue("uf", fiador.Uf);
                        cmdAdd.Parameters.AddWithValue("phone1", fiador.Phone1);
                        cmdAdd.Parameters.AddWithValue("phone2", fiador.Phone2);
                        cmdAdd.Parameters.AddWithValue("email", fiador.Email);
                        cmdAdd.ExecuteNonQuery();
                    }

                    //OBTEM O ID DO FIADOR CADASTRADO
                    using (MySqlCommand cmdGet = new MySqlCommand(queryGetId, conn))
                    {
                        using (MySqlDataReader reader = cmdGet.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                fiador.Id = reader.GetInt32(0);
                            }
                        }
                    }

                    //ENCERRA CONEXAO   
                }

                //CHAMA METODO DA CLASSE CONJUGEDAO PARA INSERIR CONJUGE DO FIADOR
                if (fiador.Casado)
                {
                    fiador.Conjuge.id_fiador = fiador.Id;
                    _conjugeDAO.addConjuge(fiador.Conjuge);
                }

                //CHAMA METODO DA CLASSE DE INSERIR NA TABELA DE RELACIONAMENTO
                _locatarioXFiadorDAO.AddRelacionamento(idLocatario, fiador.Id);
            }
        }

        public List<Fiador> GetFiadorPorId(int idLocatario)
        {
            List<Fiador> fiadores = new List<Fiador>();

            Fiador fiador;

            string queryGetFiadores = $"SELECT * FROM guarantor AS g, person_guarantor AS pg WHERE pg.id_person = {idLocatario} AND pg.id_guarantor = g.id";

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            {
                using (MySqlCommand cmdGetLocatario = new MySqlCommand(queryGetFiadores, conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmdGetLocatario.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            fiador = new Fiador();
                            fiador.Id = Convert.ToInt32(reader["id"]);
                            fiador.Name = reader["name"].ToString();
                            fiador.MaritalStatus = reader["maritalstatus"].ToString();
                            fiador.BirthDate = DateOnly.ParseExact((string)reader["birthdate"], "dd/MM/yyyy");
                            fiador.Sex = reader["sex"].ToString();
                            fiador.Cpf = reader["cpf"].ToString();
                            fiador.Rg = reader["rg"].ToString();
                            fiador.DispatchingAgency = reader["dispatchingagency"].ToString();
                            fiador.Nacionality = reader["nacionality"].ToString();
                            fiador.Naturalness = reader["naturalness"].ToString();
                            fiador.Uf = reader["uf"].ToString();
                            fiador.Profession = reader["profession"].ToString();
                            fiador.Phone1 = reader["phone1"].ToString();
                            fiador.Phone2 = reader["phone2"].ToString();
                            fiador.Email = reader["email"].ToString();
                            fiadores.Add(fiador);
                        }
                    }
                }
            }
            return fiadores;
        }
    }
}
