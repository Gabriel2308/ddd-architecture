using projectEntity.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEntity.Infra.Data.Repository.IRepositories
{
    public interface IHumanResources
    {
        public List<Departamento> ConsultarDepartamentos();
        public SucessResponse CriarNovoDepartamento(string name, string group);
    }
}
