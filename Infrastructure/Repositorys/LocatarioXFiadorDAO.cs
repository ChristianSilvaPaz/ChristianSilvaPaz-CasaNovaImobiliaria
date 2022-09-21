using MySql.Data.MySqlClient;

namespace Infrastructure.Repositorys
{
    public class LocatarioXFiadorDAO
    {
        public void AddRelacionamento(int idLocatario, int idFiador)
        {
            string queryAddRelacionamento = "INSERT INTO person_guarantor(id_person, id_guarantor) VALUES (@id_person, @id_guarantor);";

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            {
                using (MySqlCommand cmdAddRelacionamento = new MySqlCommand(queryAddRelacionamento, conn))
                {
                    conn.Open();
                    cmdAddRelacionamento.Parameters.AddWithValue("id_person", idLocatario);
                    cmdAddRelacionamento.Parameters.AddWithValue("id_guarantor", idFiador);
                    cmdAddRelacionamento.ExecuteNonQuery();
                }
            }
        }

        public void ExcluirRelacionamento(int idFiador)
        {
            string queryExcluirRelacionamento = $"DELETE FROM person_guarantor WHERE id_guarantor = {idFiador};";
            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(queryExcluirRelacionamento, conn))
                {
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
            }
        }
    }


}



