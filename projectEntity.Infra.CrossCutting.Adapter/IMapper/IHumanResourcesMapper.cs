using projectEntity.Domain.DTO;
using projectEntity.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEntity.Infra.CrossCutting.Adapter.IMapper
{
    public interface IHumanResourcesMapper
    {
        public DepartamentoDTO DepartamentoTODTO(Departamento departamento);
        public List<DepartamentoDTO> ListDepartamentoTODTO(List<Departamento> departamentos);
    }
}
