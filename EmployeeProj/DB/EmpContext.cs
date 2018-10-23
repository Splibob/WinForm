using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeProj.DB;

using System.Data.Entity;

namespace EmployeeProj.DB
{
    public class EmpContext : DbContext
    {
  
        public EmpContext(): base("name=EmployeesConStr")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<EmpContext>());
        }
        public DbSet<Employee> Employees { get; set;} 
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillsInfo> SkillsInfo { get; set; }
        public DbSet<EmployeesReferences> EmployeesReferences { get; set; }
       
        
    }
}
