using projectEntity.Domain.Services.IServices;
using projectEntity.Infra.CrossCutting.Adapter.IMapper;
using projectEntity.Infra.Data.Repository.IRepositories;
using System;


namespace projectEntity.Domain.Services.Services
{
    public class EmployeesServices : IEmployeesServices
    {
        public readonly IEmployeesRepository _employeesRepository;
        public readonly IEmployeesMapper _employeesMapper;

        public EmployeesServices(IEmployeesRepository employeesRepository, IEmployeesMapper employeesMapper)
        {
            _employeesRepository = employeesRepository;
            _employeesMapper = employeesMapper;
        }
        public object ConsultarEmpregado(string nationalIdNumber)
        {
            var employee = _employeesRepository.ConsultarEmpregado(nationalIdNumber);

            return _employeesMapper.EmployeeTODTO(employee);
        }
    }
}
