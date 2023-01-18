using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEntity.Domain.DTO
{
    public class EmployeeDTO
    {
        public string nationalIdNumber { get; set; }
        public string loginId { get; set; }
        public int organizationLevel { get; set; }
        public string jobTitle { get; set; }
        public string birthDate { get; set; }
        public string maritialStatus { get; set; }
        public string gender { get; set; }
        public string hireDate { get; set; }
        public int vacationHours { get; set; }
        public int sickLeaveHours { get; set; }
    }
}
