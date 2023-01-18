using projectEntity.Domain.DTO;
using projectEntity.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEntity.Infra.CrossCutting.Adapter.IMapper
{
    public interface IEmployeesMapper
    {
        public EmployeeDTO EmployeeTODTO(EmployeeData employee);
        public EmployeeData DTOTOEmployee(EmployeeDTO employeeDTO);
    }
}
