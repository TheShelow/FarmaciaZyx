﻿using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class BairroDAL : ICRUD<Bairro>
    {
        string connectionString = ConnectionString._connectionString;

        public Response Insert(Bairro item)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"INSERT INTO BAIRROS (NOME_BAIRRO,CIDADE_ID) VALUES (@NOME_BAIRRO,@CIDADE_ID); SELECT SCOPE_IDENTITY()";
            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME_BAIRRO", item.NomeBairro);
            command.Parameters.AddWithValue("@CIDADE_ID", item.CidadeId);
            //Estamos conectados na base de dados
            //try catch
            //try catch finally
            //try finally
            try
            {
                connection.Open();
                item.ID = Convert.ToInt32(command.ExecuteScalar());
                return new Response("Bairro cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_ENDERECOS_BAIRRO"))
                {
                    //RETORNAR MENSAGEM QUE O CPF TA DUPLICADO
                    return new Response("Não é possivel excluir um bairro que tenha um endereço cadastrado.", false);
                }
                //SE NAO ENTROU EM NENHUM IF DE CIMA, SÓ PODE SER UM ERRO DE INFRAESTRUTURA
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }

        public Response Update(Bairro bairro)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"UPDATE BAIRROS SET NOME_BAIRRO = @NOME_BAIRRO, CIDADE_ID = @CIDADE_ID WHERE ID = @ID";

            

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME_BAIRRO", bairro.NomeBairro);
            command.Parameters.AddWithValue("@CIDADE_ID", bairro.CidadeId);
            //Estamos conectados na base de dados
            //try catch
            //try catch finally
            //try finally
            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Bairro excluido.", false);
                }
                return new Response("Bairro alterado com sucesso.", true);
            }
            catch (Exception ex)
            {
                //SE NAO ENTROU EM NENHUM IF DE CIMA, SÓ PODE SER UM ERRO DE INFRAESTRUTURA
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }

        public Response Delete(int id)
        {
            string sql = "DELETE FROM BAIRROS WHERE ID = @ID";

            

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            //Estamos conectados na base de dados
            //try catch
            //try catch finally
            //try finally
            try
            {
                connection.Open();
                int qtdLinhasExcluidas = command.ExecuteNonQuery();
                if (qtdLinhasExcluidas == 1)
                {
                    return new Response("Bairro excluído com sucesso.", true);
                }
                return new Response("Bairro não excluído.", false);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_ENDERECOS_BAIRRO"))
                {
                    //RETORNAR MENSAGEM QUE O CPF TA DUPLICADO
                    return new Response("Não é possivel excluir um Bairro que tenha um Endereço cadastrado.", false);
                }

                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }

        public DataResponse<Bairro> GetAll()
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,NOME_BAIRRO,CIDADE_ID FROM BAIRROS";

            

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Bairro> bairros = new List<Bairro>();
                //Enquanto houver registros, o loop será executado!
                while (reader.Read())
                {
                    Bairro bairro = new Bairro();
                    bairro.ID = Convert.ToInt32(reader["ID"]);
                    bairro.NomeBairro = Convert.ToString(reader["NOME_BAIRRO"]);
                    bairro.CidadeId = Convert.ToInt32(reader["CIDADE_ID"]);
                    bairros.Add(bairro);
                }
                return new DataResponse<Bairro>("Bairros selecionados com sucesso!", true, bairros);
            }
            catch (Exception ex)
            {
                return new DataResponse<Bairro>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
        public SingleResponse<Bairro> GetByID(int id)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,NOME_BAIRRO,CIDADE_ID FROM BAIRROS WHERE ID = @ID";

            

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                //Enquanto houver registros, o loop será executado!
                if (reader.Read())
                {
                    Bairro bairro = new Bairro();
                    bairro.ID = Convert.ToInt32(reader["ID"]);
                    bairro.NomeBairro = Convert.ToString(reader["NOME_BAIRRO"]);
                    bairro.CidadeId = Convert.ToInt32(reader["CIDADE_ID"]);
                    return new SingleResponse<Bairro>("Bairro selecionado com sucesso!", true, bairro);
                }
                return new SingleResponse<Bairro>("Bairro não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Bairro>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
        public SingleResponse<Bairro> GetByNameAndCidadeId(Bairro item)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,NOME_BAIRRO,CIDADE_ID FROM BAIRROS WHERE NOME_BAIRRO = @NOME_BAIRRO AND CIDADE_ID = @CIDADE_ID";



            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME_BAIRRO", item.NomeBairro);
            command.Parameters.AddWithValue("@CIDADE_ID", item.CidadeId);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                //Enquanto houver registros, o loop será executado!
                if (reader.Read())
                {
                    Bairro bairro = new Bairro();
                    bairro.ID = Convert.ToInt32(reader["ID"]);
                    bairro.NomeBairro = Convert.ToString(reader["NOME_BAIRRO"]);
                    bairro.CidadeId = Convert.ToInt32(reader["CIDADE_ID"]);
                    return new SingleResponse<Bairro>("Bairro selecionado com sucesso!", true, bairro);
                }
                return new SingleResponse<Bairro>("Bairro não encontrado!", true, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Bairro>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
    }
}
