﻿using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TipoClienteDAL
    {
        string connectionString = ConnectionString._connectionString;
        public DataResponse<TipoCliente> GetAll()
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,NOME FROM TIPO_CLIENTE";

            SqlConnection connection = new SqlConnection(connectionString);
            //ADO.NET 
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<TipoCliente> tipoClientes = new List<TipoCliente>();
                //Enquanto houver registros, o loop será executado!
                while (reader.Read())
                {
                    TipoCliente tipoCliente = new TipoCliente();
                    tipoCliente.ID = Convert.ToInt32(reader["ID"]);
                    tipoCliente.Nome = Convert.ToString(reader["NOME"]);
                    tipoClientes.Add(tipoCliente);
                }
                return new DataResponse<TipoCliente>("Tipos de Funcionarios selecionados com sucesso!", true, tipoClientes);
            }
            catch (Exception ex)
            {
                return new DataResponse<TipoCliente>("Erro no banco de dados, contate o administrador.", false, null);
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
