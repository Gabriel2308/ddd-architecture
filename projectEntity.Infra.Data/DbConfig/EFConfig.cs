using Microsoft.EntityFrameworkCore;
using projectEntity.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEntity.Infra.Data.DbConfig
{
    public class EFConfig : DbContext
    {
        public DbSet<EmployeeData> Employee { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public string DbPath { get; set; }

        public EFConfig()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "blogging.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");
    }
}
