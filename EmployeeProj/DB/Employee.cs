using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EmployeeProj.DB
{
    public class Employee

    {
            /// <summray>
            /// Employees Table
            /// PK - 

        
        public int EmployeeID { get; set; }

        [Column("FirstName", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Column("LastName", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Column("Alias", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string Alias { get; set; }

        [Column("Email", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string Email { get; set; }

        public ICollection<Skill> Skills { get; set; }
        

    }
}
