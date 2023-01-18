using projectEntity.Infra.Data.DbConfig;
using projectEntity.Infra.Data.Entities;
using projectEntity.Infra.Data.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEntity.Infra.Data.Repository.Repositories
{
    public class EmployeesRepository : ConexaoSQL, IEmployeesRepository
    {
        private string strConnection = @"Persist Security Info=False;Integrated Security=SSPI; database=AdventureWorks2019;server=AGIN15\SQLEXPRESS";
        public EmployeeData ConsultarEmpregado(string nationalIdNumber)
        {
            try
            {
                sqlCommand = new SqlCommand();
                sqlConnection = new SqlConnection();

                OpenConnection(strConnection);

                sqlCommand = new SqlCommand("SELECT * FROM HumanResources.Employee WHERE NationalIDNumber = @NationalIDNumber ", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@NationalIDNumber", nationalIdNumber);

                sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    var employee = new EmployeeData
                    {
                        businessEntitiyId = Convert.ToInt32(sqlDataReader["BusinessEntityID"]),
                        nationalIdNumber = String.Format("{0}", sqlDataReader["NationalIDNumber"]),
                        loginId = String.Format("{0}", sqlDataReader["LoginID"]),
                        organizationNode = String.Format("{0}", sqlDataReader["OrganizationNode"]),
                        organizationLevel = Convert.ToInt32(sqlDataReader["OrganizationLevel"]),
                        jobTitle = String.Format("{0}", sqlDataReader["JobTitle"]),
                        birthDate = String.Format("{0}", sqlDataReader["BirthDate"]),
                        maritialStatus = String.Format("{0}", sqlDataReader["MaritialStatus"]),
                        gender = String.Format("{0}", sqlDataReader["Gender"]),
                        hireDate = String.Format("{0}", sqlDataReader["HireDate"]),
                        salariedFlag = Convert.ToInt32(sqlDataReader["SalariedFlag"]),
                        vacationHours = Convert.ToInt32(sqlDataReader["VacationHours"]),
                        sickLeaveHours = Convert.ToInt32(sqlDataReader["SickLeaveHours"]),
                        currentFlag = Convert.ToInt32(sqlDataReader["CurrentFlag"]),
                        rowGuid = String.Format("{0}", sqlDataReader["rowguid"])
                    };

                    return employee;
                }

                return null;
                
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
    }
}
