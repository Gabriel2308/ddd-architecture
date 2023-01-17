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
