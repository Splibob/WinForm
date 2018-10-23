using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EmployeeProj.DB
{
     public class SkillsInfo
    {
        /// <summary>
        /// Skills Info Table

        [Key]
        public int SkillInfoID { get; set; }

        [Column("URL", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string URL { get; set; }

        [Column("SkillID", TypeName = "int")]
        public int SkillID { get; set; }
    }
}
