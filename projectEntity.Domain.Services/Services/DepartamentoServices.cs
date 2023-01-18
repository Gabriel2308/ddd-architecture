using projectEntity.Domain.DTO;
using projectEntity.Domain.Services.IServices;
using projectEntity.Infra.CrossCutting.Adapter.IMapper;
using projectEntity.Infra.Data.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEntity.Domain.Services.Services
{
    public class DepartamentoServices : IDepartamentoServices
    {
        private readonly IHumanResources _humanResources;
        private readonly IHumanResourcesMapper _humanResourcesMapper;
        public DepartamentoServices(IHumanResources humanResources, IHumanResourcesMapper humanResourcesMapper)
        {
            _humanResources = humanResources;
            _humanResourcesMapper = humanResourcesMapper;
        }

        public object CriarDepartamento(string name, string group)
        {
            try
            {
                var departamento = _humanResources.CriarNovoDepartamento(name, group);

                return departamento;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public object DeletarDepartamento(string name)
        {
            try
            {
                var deleteDpt = _humanResources.DeleteDepartamento(name);

                return deleteDpt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<DepartamentoDTO> ListarDepartamentos()
        {
            try
            {
                var listaDepartamentos = _humanResources.ConsultarDepartamentos();

                return _humanResourcesMapper.ListDepartamentoTODTO(listaDepartamentos);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
