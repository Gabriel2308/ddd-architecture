using Autofac;
using projectEntity.Domain.Services.IServices;
using projectEntity.Domain.Services.Services;
using projectEntity.Infra.CrossCutting.Adapter.IMapper;
using projectEntity.Infra.CrossCutting.Adapter.Mapper;
using projectEntity.Infra.Data.Repository.IRepositories;
using projectEntity.Infra.Data.Repository.Repositories;


namespace projectEntity.Infra.CrossCutting.IoC
{
    public class DependencyInjection
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DepartamentoServices>().As<IDepartamentoServices>();
            builder.RegisterType<EmployeesServices>().As<IEmployeesServices>();


            builder.RegisterType<HumanResources>().As<IHumanResources>();
            builder.RegisterType<EmployeesRepository>().As<IEmployeesRepository>();


            builder.RegisterType<HumanResourcesMapper>().As<IHumanResourcesMapper>();
            builder.RegisterType<EmployeesMapper>().As<IEmployeesMapper>();
        }
    }
}
