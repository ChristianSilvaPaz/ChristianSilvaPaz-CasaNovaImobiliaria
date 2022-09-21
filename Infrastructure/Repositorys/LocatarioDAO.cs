using Infrastructure.Entities;
using MySql.Data.MySqlClient;
using System.Transactions;

namespace Infrastructure.Repositorys
{
    public class LocatarioDAO
    {
        private ConjugeDAO _conjugeDAO;
        private FiadorDAO _fiadorDAO;

        public LocatarioDAO()
        {
            _conjugeDAO = new ConjugeDAO();
            _fiadorDAO = new FiadorDAO();
        }

        public void CadastrarLocatario(Locatario locatario)
        {
            string queryAdd = "INSERT INTO pyhsical_person(name, birthdate, maritalstatus, sex, cpf, rg," +
               " dispatchingagency, nacionality, naturalness, uf, profession, income, workaddress, phonework," +
               " phone1, phone2, qtdanimals, email, comments, casado) VALUES (@name, @birthdate, @maritalstatus, @sex, @cpf," +
               " @rg, @dispatchingagency, @nacionality, @naturalness, @uf, @profession, @income, @workaddress," +
               " @phonework, @phone1, @phone2, @qtdanimals, @email, @comments, @casado);";

            string queryGetId = "SELECT id FROM pyhsical_person ORDER BY id DESC LIMIT 1;";

            //INSTANCIA OBJETO PARA CONTROLE DE TRANSACAO
            //TODOS AS COSULTAS E CHAMADAS PARA METODOS EXTERNOS ESTAO INCLUIDOS NO ESCOPO DA TRANSACAO
            using (TransactionScope transactionScope = new TransactionScope())
            {
                using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
                {
                    using (MySqlCommand cmdAdd = new MySqlCommand(queryAdd, conn))
                    {
                        conn.Open();
                        cmdAdd.Parameters.AddWithValue("name", locatario.Name);
                        cmdAdd.Parameters.AddWithValue("birthdate", locatario.BirthDate);
                        cmdAdd.Parameters.AddWithValue("maritalstatus", locatario.MaritalStatus);
                        cmdAdd.Parameters.AddWithValue("sex", locatario.Sex);
                        cmdAdd.Parameters.AddWithValue("cpf", locatario.Cpf);
                        cmdAdd.Parameters.AddWithValue("rg", locatario.Rg);
                        cmdAdd.Parameters.AddWithValue("dispatchingagency", locatario.DispatchingAgency);
                        cmdAdd.Parameters.AddWithValue("nacionality", locatario.Nacionality);
                        cmdAdd.Parameters.AddWithValue("naturalness", locatario.Naturalness);
                        cmdAdd.Parameters.AddWithValue("uf", locatario.Uf);
                        cmdAdd.Parameters.AddWithValue("profession", locatario.Profession);
                        cmdAdd.Parameters.AddWithValue("income", locatario.Income);
                        cmdAdd.Parameters.AddWithValue("workaddress", locatario.WorkAddress);
                        cmdAdd.Parameters.AddWithValue("phonework", locatario.PhoneWork);
                        cmdAdd.Parameters.AddWithValue("phone1", locatario.Phone1);
                        cmdAdd.Parameters.AddWithValue("phone2", locatario.Phone2);
                        cmdAdd.Parameters.AddWithValue("qtdanimals", locatario.QtdAnimals);
                        cmdAdd.Parameters.AddWithValue("email", locatario.Email);
                        cmdAdd.Parameters.AddWithValue("comments", locatario.Comments);
                        cmdAdd.Parameters.AddWithValue("casado", locatario.Casado);
                        cmdAdd.ExecuteNonQuery();
                    }

                    //OBTEM O ID DO LOCATARIO CADASTRADO
                    using (MySqlCommand cmdGetId = new MySqlCommand(queryGetId, conn))
                    {
                        using (MySqlDataReader reader = cmdGetId.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                locatario.Id = reader.GetInt32(0);
                            }
                        }
                    }

                    //ENCERRA CONEXAO
                }

                //CHAMA METODO DA CLASSE CONJUGEDAO PARA INSERIR CONJUGE DO LOCATARIO
                if (locatario.Casado)
                {
                    locatario.Conjuge.id_locatario = locatario.Id;
                    _conjugeDAO.CadastrarConjuge(locatario.Conjuge);
                }

                //CHAMA METODO DA CLASSE FIADORDAO PARA INSERIR OS FIADORES DO LOCATARIO
                _fiadorDAO.CadastrarFiador(locatario.Fiadores, locatario.Id);

                //ENCERRA CONTROLE DE TRANSACAO
                transactionScope.Complete();
            }
        }

        public void EditarLocatario(Locatario locatario)
        {
            string queryEditarLocatario = "UPDATE pyhsical_person SET name=@name, birthdate=@birthdate," +
                " maritalstatus=@maritalstatus, sex=@sex, cpf=@cpf, rg=@rg, dispatchingagency=@dispatchingagency," +
                " nacionality=@nacionality, naturalness=@naturalness, uf=@uf, profession=@profession, income=@income," +
                " workaddress=@workaddress, phonework=@phonework, phone1=@phone1, phone2=@phone2, qtdanimals=@qtdanimals," +
                $" email=@email, comments=@comments, casado=@casado WHERE id={locatario.Id};";

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(queryEditarLocatario, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("name", locatario.Name);
                    cmd.Parameters.AddWithValue("birthdate", locatario.BirthDate);
                    cmd.Parameters.AddWithValue("maritalstatus", locatario.MaritalStatus);
                    cmd.Parameters.AddWithValue("sex", locatario.Sex);
                    cmd.Parameters.AddWithValue("cpf", locatario.Cpf);
                    cmd.Parameters.AddWithValue("rg", locatario.Rg);
                    cmd.Parameters.AddWithValue("dispatchingagency", locatario.DispatchingAgency);
                    cmd.Parameters.AddWithValue("nacionality", locatario.Nacionality);
                    cmd.Parameters.AddWithValue("naturalness", locatario.Naturalness);
                    cmd.Parameters.AddWithValue("uf", locatario.Uf);
                    cmd.Parameters.AddWithValue("profession", locatario.Profession);
                    cmd.Parameters.AddWithValue("income", locatario.Income);
                    cmd.Parameters.AddWithValue("workaddress", locatario.WorkAddress);
                    cmd.Parameters.AddWithValue("phonework", locatario.PhoneWork);
                    cmd.Parameters.AddWithValue("phone1", locatario.Phone1);
                    cmd.Parameters.AddWithValue("phone2", locatario.Phone2);
                    cmd.Parameters.AddWithValue("qtdanimals", locatario.QtdAnimals);
                    cmd.Parameters.AddWithValue("email", locatario.Email);
                    cmd.Parameters.AddWithValue("comments", locatario.Comments);
                    cmd.Parameters.AddWithValue("casado", locatario.Casado);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
            }
        }

        public Locatario ListarLocatarioPorId(int idLocatario)
        {
            Locatario locatario = new Locatario();

            string queryGetLocatario = $"SELECT * FROM pyhsical_person WHERE id = {idLocatario};";

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            {
                using (MySqlCommand cmdGetLocatario = new MySqlCommand(queryGetLocatario, conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmdGetLocatario.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            locatario.Id = Convert.ToInt32(reader["id"]);
                            locatario.Name = reader["name"].ToString();
                            locatario.BirthDate = DateOnly.ParseExact((string)reader["birthdate"], "dd/MM/yyyy");
                            locatario.MaritalStatus = reader["maritalstatus"].ToString();
                            locatario.Sex = reader["sex"].ToString();
                            locatario.Cpf = reader["cpf"].ToString();
                            locatario.Rg = reader["rg"].ToString();
                            locatario.DispatchingAgency = reader["dispatchingagency"].ToString();
                            locatario.Nacionality = reader["nacionality"].ToString();
                            locatario.Naturalness = reader["naturalness"].ToString();
                            locatario.Uf = reader["uf"].ToString();
                            locatario.Profession = reader["profession"].ToString();
                            locatario.Income = Convert.ToDouble(reader["income"]);
                            locatario.WorkAddress = reader["workaddress"].ToString();
                            locatario.PhoneWork = reader["phonework"].ToString();
                            locatario.Phone1 = reader["phone1"].ToString();
                            locatario.Phone2 = reader["phone2"].ToString();
                            locatario.QtdAnimals = Convert.ToInt32(reader["qtdanimals"]);
                            locatario.Email = reader["email"].ToString();
                            locatario.Comments = reader["comments"].ToString();
                            locatario.Casado = Convert.ToBoolean(reader["casado"]);
                        }
                    }
                }
            }
            return locatario;
        }

        public List<Locatario> ListarLocatarioPorNome(string nome)
        {
            List<Locatario> list = new List<Locatario>();

            string queryGetLocatario = $"SELECT * FROM pyhsical_person WHERE name LIKE '{nome}%';";

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            {
                using (MySqlCommand cmdGetLocatario = new MySqlCommand(queryGetLocatario, conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmdGetLocatario.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id"]);
                            string name = reader["name"].ToString();
                            DateOnly birthDate = DateOnly.ParseExact((string)reader["birthdate"], "dd/MM/yyyy");
                            string maritalStatus = reader["maritalstatus"].ToString();
                            string sex = reader["sex"].ToString();
                            string cpf = reader["cpf"].ToString();
                            string rg = reader["rg"].ToString();
                            string dispatchingAgency = reader["dispatchingagency"].ToString();
                            string nacionality = reader["nacionality"].ToString();
                            string naturalness = reader["naturalness"].ToString();
                            string uf = reader["uf"].ToString();
                            string profession = reader["profession"].ToString();
                            double income = Convert.ToDouble(reader["income"]);
                            string workAddress = reader["workaddress"].ToString();
                            string phoneWork = reader["phonework"].ToString();
                            string phone1 = reader["phone1"].ToString();
                            string phone2 = reader["phone2"].ToString();
                            int qtdAnimals = Convert.ToInt32(reader["qtdanimals"]);
                            string email = reader["email"].ToString();
                            string comments = reader["comments"].ToString();
                            bool casado = Convert.ToBoolean(reader["casado"]);
                            list.Add(new Locatario()
                            {
                                Id = id,
                                Name = name,
                                BirthDate = birthDate,
                                MaritalStatus = maritalStatus,
                                Sex = sex,
                                Cpf = cpf,
                                Rg = rg,
                                DispatchingAgency = dispatchingAgency,
                                Nacionality = nacionality,
                                Naturalness = naturalness,
                                Uf = uf,
                                Profession = profession,
                                Income = income,
                                WorkAddress = workAddress,
                                PhoneWork = phoneWork,
                                Phone1 = phone1,
                                Phone2 = phone2,
                                QtdAnimals = qtdAnimals,
                                Email = email,
                                Comments = comments,
                                Casado = casado
                            });
                        }
                    }
                }
            }
            return list;
        }

        public List<Locatario> ListarLocatarios()
        {
            List<Locatario> list = new List<Locatario>();

            string queryGetLocatario = "SELECT * FROM pyhsical_person;";

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            {
                using (MySqlCommand cmdGetLocatario = new MySqlCommand(queryGetLocatario, conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmdGetLocatario.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id"]);
                            string name = reader["name"].ToString();
                            DateOnly birthDate = DateOnly.ParseExact((string)reader["birthdate"], "dd/MM/yyyy");
                            string maritalStatus = reader["maritalstatus"].ToString();
                            string sex = reader["sex"].ToString();
                            string cpf = reader["cpf"].ToString();
                            string rg = reader["rg"].ToString();
                            string dispatchingAgency = reader["dispatchingagency"].ToString();
                            string nacionality = reader["nacionality"].ToString();
                            string naturalness = reader["naturalness"].ToString();
                            string uf = reader["uf"].ToString();
                            string profession = reader["profession"].ToString();
                            double income = Convert.ToDouble(reader["income"]);
                            string workAddress = reader["workaddress"].ToString();
                            string phoneWork = reader["phonework"].ToString();
                            string phone1 = reader["phone1"].ToString();
                            string phone2 = reader["phone2"].ToString();
                            int qtdAnimals = Convert.ToInt32(reader["qtdanimals"]);
                            string email = reader["email"].ToString();
                            string comments = reader["comments"].ToString();
                            bool casado = Convert.ToBoolean(reader["casado"]);
                            list.Add(new Locatario()
                            {
                                Id = id,
                                Name = name,
                                BirthDate = birthDate,
                                MaritalStatus = maritalStatus,
                                Sex = sex,
                                Cpf = cpf,
                                Rg = rg,
                                DispatchingAgency = dispatchingAgency,
                                Nacionality = nacionality,
                                Naturalness = naturalness,
                                Uf = uf,
                                Profession = profession,
                                Income = income,
                                WorkAddress = workAddress,
                                PhoneWork = phoneWork,
                                Phone1 = phone1,
                                Phone2 = phone2,
                                QtdAnimals = qtdAnimals,
                                Email = email,
                                Comments = comments,
                                Casado = casado
                            });
                        }
                    }
                }
            }
            return list;
        }

        public void ExcuirLocatario(Locatario locatario)
        {
            string queryExcluirLocatario = $"DELETE FROM pyhsical_person WHERE id = {locatario.Id}";

            using (TransactionScope transactionScope = new TransactionScope())
            {
                using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(queryExcluirLocatario, conn))
                    {
                        try
                        {
                            _fiadorDAO.ExcluirFiador(locatario.Fiadores);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception e)
                        {
                            throw e;
                        }
                    }
                }
                transactionScope.Complete();
            }
        }
    }
}




