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
    public class HumanResourcesMapper : IHumanResourcesMapper
    {
        public DepartamentoDTO DepartamentoTODTO(Departamento departamento)
        {
            return new DepartamentoDTO
            {
                groupName = departamento.groupName,
                nomeDepartamento = departamento.nomeDepartamento
            };
        }

        public List<DepartamentoDTO> ListDepartamentoTODTO(List<Departamento> departamentos)
        {
            List<DepartamentoDTO> listaDTO = new List<DepartamentoDTO>();
            foreach(Departamento departamento in departamentos)
            {
                var deprt = new DepartamentoDTO
                {
                    groupName = departamento.groupName,
                    nomeDepartamento = departamento.nomeDepartamento
                };

                listaDTO.Add(deprt);
            }

            return listaDTO;
        }
    }
}
