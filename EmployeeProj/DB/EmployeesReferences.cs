using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EmployeeProj.DB
{

    public class EmployeesReferences
    {
        /// <summary>
        /// Reference Table

        public int EmployeesReferencesID { get; set; }

        [Column("FirstName", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Column("LastName", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Column("Position", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string Position { get; set; }

        [Column("Alias", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string Alias { get; set; }

        [Column("Email", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string Email { get; set; }

        [Column("EmployeeID", TypeName = "int")]
        public int EmployeeID { get; set; }
    }
}
