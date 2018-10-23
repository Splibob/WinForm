using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EmployeeProj.DB
{
    public class Skill
    {
        /// <summary>
        /// Skills Table

        
        public int SkillID { get; set; }

        [Column("EmployeeID", TypeName = "int")]
        public int EmployeeID { get; set; }

        [Column("SkillName", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string SkillName { get; set; }

        [Column("BriefDescription", TypeName = "nvarchar")]
        [MaxLength(4000)]
        public string BriefDescription { get; set; }
    }
}
