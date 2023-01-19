using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEntity.Infra.Data.Entities
{
    public class EmployeeData
    {
        public int businessEntitiyId { get; set; }
        public string nationalIdNumber { get; set; }
        public string loginId { get; set; }
        public string organizationNode { get; set; }
        public int organizationLevel { get; set; }
        public string jobTitle { get; set; }
        public string birthDate { get; set; }
        public string maritialStatus { get; set; }
        public string gender { get; set; }
        public string hireDate { get; set; }
        public int salariedFlag { get; set; }
        public int vacationHours { get; set; }
        public int sickLeaveHours { get; set; }
        public int currentFlag { get; set; }
        public string rowGuid { get; set; }
        public string modifiedDate { get; set; }

    }
}
