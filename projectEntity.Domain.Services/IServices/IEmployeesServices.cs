using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEntity.Domain.Services.IServices
{
    public interface IEmployeesServices
    {
        public Object ConsultarEmpregado(string nationalIdNumber);
    }
}
