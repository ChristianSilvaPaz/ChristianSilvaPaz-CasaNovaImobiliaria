using Infrastructure.Entities;
using MySql.Data.MySqlClient;

namespace Infrastructure.Repositorys
{
    public class ConjugeDAO
    {
        //METODO DE INSERIR CONJUGES, INCLUIDO NO ESCOPO DE CONTROLE DE TRANSACAO
        public void addConjuge(Conjuge conjuge)
        {
            string queryAdd = "INSERT INTO spouce(name, birthdate, sex, cpf, rg," +
               " dispatchingagency, nacionality, naturalness, uf, phone1, phone2, email, id_person, id_guarantor)" +
               " VALUES (@name, @birthdate, @sex, @cpf, @rg, @dispatchingagency, @nacionality," +
               " @naturalness, @uf, @phone1, @phone2, @email, @id_person, @id_guarantor);";

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            {
                using (MySqlCommand cmdAdd = new MySqlCommand(queryAdd, conn))
                {
                    conn.Open();
                    cmdAdd.Parameters.AddWithValue("name", conjuge.Name);
                    cmdAdd.Parameters.AddWithValue("birthdate", conjuge.BirthDate.ToString("yyyy-MM-dd"));
                    cmdAdd.Parameters.AddWithValue("sex", conjuge.Sex);
                    cmdAdd.Parameters.AddWithValue("cpf", conjuge.Cpf);
                    cmdAdd.Parameters.AddWithValue("rg", conjuge.Rg);
                    cmdAdd.Parameters.AddWithValue("dispatchingagency", conjuge.DispatchingAgency);
                    cmdAdd.Parameters.AddWithValue("nacionality", conjuge.Nacionality);
                    cmdAdd.Parameters.AddWithValue("naturalness", conjuge.Naturalness);
                    cmdAdd.Parameters.AddWithValue("uf", conjuge.Uf);
                    cmdAdd.Parameters.AddWithValue("phone1", conjuge.Phone1);
                    cmdAdd.Parameters.AddWithValue("phone2", conjuge.Phone2);
                    cmdAdd.Parameters.AddWithValue("email", conjuge.Email);
                    cmdAdd.Parameters.AddWithValue("id_person", conjuge.id_locatario);
                    cmdAdd.Parameters.AddWithValue("id_guarantor", conjuge.id_fiador);
                    cmdAdd.ExecuteNonQuery();
                }
            }
        }

        public Conjuge GetConjugePorId(int idLocatario)
        {
            Conjuge conjuge = new Conjuge();

            string queryGetConjuge = $"SELECT * FROM spouce WHERE id_person = {idLocatario};";

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            {
                using (MySqlCommand cmdGetLocatario = new MySqlCommand(queryGetConjuge, conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmdGetLocatario.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            conjuge.Id = Convert.ToInt32(reader["id"]);
                            conjuge.Name = reader["name"].ToString();
                            conjuge.BirthDate = DateOnly.ParseExact((string)reader["birthdate"], "dd/MM/yyyy");
                            conjuge.Sex = reader["sex"].ToString();
                            conjuge.Cpf = reader["cpf"].ToString();
                            conjuge.Rg = reader["rg"].ToString();
                            conjuge.DispatchingAgency = reader["dispatchingagency"].ToString();
                            conjuge.Nacionality = reader["nacionality"].ToString();
                            conjuge.Naturalness = reader["naturalness"].ToString();
                            conjuge.Uf = reader["uf"].ToString();
                            conjuge.Profession = reader["profession"].ToString();
                            conjuge.Phone1 = reader["phone1"].ToString();
                            conjuge.Phone2 = reader["phone2"].ToString();
                            conjuge.Email = reader["email"].ToString();
                        }
                    }
                }
            }
            return conjuge;
        }

        public Conjuge GetConjugeFiadorPorId(int idFiador)
        {
            Conjuge conjuge = new Conjuge();

            string queryGetConjuge = $"SELECT * FROM spouce WHERE id_guarantor = {idFiador};";

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            {
                using (MySqlCommand cmdGetLocatario = new MySqlCommand(queryGetConjuge, conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmdGetLocatario.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            conjuge.Id = Convert.ToInt32(reader["id"]);
                            conjuge.Name = reader["name"].ToString();
                            conjuge.BirthDate = DateOnly.ParseExact((string)reader["birthdate"], "dd/MM/yyyy");
                            conjuge.Sex = reader["sex"].ToString();
                            conjuge.Cpf = reader["cpf"].ToString();
                            conjuge.Rg = reader["rg"].ToString();
                            conjuge.DispatchingAgency = reader["dispatchingagency"].ToString();
                            conjuge.Nacionality = reader["nacionality"].ToString();
                            conjuge.Naturalness = reader["naturalness"].ToString();
                            conjuge.Uf = reader["uf"].ToString();
                            conjuge.Profession = reader["profession"].ToString();
                            conjuge.Phone1 = reader["phone1"].ToString();
                            conjuge.Phone2 = reader["phone2"].ToString();
                            conjuge.Email = reader["email"].ToString();
                        }
                    }
                }
            }
            return conjuge;
        }
    }
}
