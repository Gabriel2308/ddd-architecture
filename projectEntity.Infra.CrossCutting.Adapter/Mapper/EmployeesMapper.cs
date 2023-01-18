using projectEntity.Domain.DTO;
using projectEntity.Infra.CrossCutting.Adapter.IMapper;
using projectEntity.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEntity.Infra.CrossCutting.Adapter.Mapper
{
    public class EmployeesMapper : IEmployeesMapper
    {
        public EmployeeData DTOTOEmployee(EmployeeDTO employeeDTO)
        {
            throw new NotImplementedException();
        }

        public EmployeeDTO EmployeeTODTO(EmployeeData employee)
        {
            return new EmployeeDTO
            {
                birthDate = employee.birthDate,
                gender = employee.gender,
                hireDate = employee.hireDate,
                jobTitle = employee.jobTitle,
                loginId = employee.loginId,
                maritialStatus = employee.maritialStatus,
                nationalIdNumber = employee.nationalIdNumber,
                organizationLevel = employee.organizationLevel,
                sickLeaveHours = employee.sickLeaveHours,
                vacationHours = employee.vacationHours
            };
        }
    }
}
