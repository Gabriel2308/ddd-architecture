using projectEntity.Infra.Data.DbConfig;
using projectEntity.Infra.Data.Entities;
using projectEntity.Infra.Data.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace projectEntity.Infra.Data.Repository.Repositories
{
    public class HumanResources : ConexaoSQL, IHumanResources
    {
        private string strConnection = @"Persist Security Info=False;Integrated Security=SSPI; database=AdventureWorks2019;server=AGIN15\SQLEXPRESS";
        public List<Departamento> ConsultarDepartamentos()
        {
            List<Departamento> listaDepartamentos = new List<Departamento>();
            try
            {
                sqlCommand = new SqlCommand();
                sqlConnection = new SqlConnection();

                OpenConnection(strConnection);

                sqlCommand = new SqlCommand("SELECT *  FROM HumanResources.Department", sqlConnection);

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    var departamento = new Departamento
                    {
                        departamentoID = Convert.ToInt32(sqlDataReader["DepartmentID"]),
                        nomeDepartamento = String.Format("{0}", sqlDataReader["Name"]),
                        groupName = String.Format("{0}", sqlDataReader["GroupName"])
                    };

                    listaDepartamentos.Add(departamento);
                }

                return listaDepartamentos;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
        }

        public SucessResponse CriarNovoDepartamento(string name, string group)
        {
            var response = new SucessResponse();

            try
            {
                sqlCommand = new SqlCommand();
                sqlConnection = new SqlConnection();

                OpenConnection(strConnection);
                sqlCommand = new SqlCommand("INSERT INTO HumanResources.Department (Name, GroupName)" +
                                            "VALUES (@Name, @GroupName)", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@Name", name);
                sqlCommand.Parameters.AddWithValue("@GroupName", group);

                sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    response.code = 200;
                    response.message = "Cadastro realizado com sucesso";

                    return response;
                }
                else
                {
                    response.code = 500;
                    response.message = "Erro ao realizar cadastro";

                    return response;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
