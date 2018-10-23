using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using EmployeeProj.DAL;

namespace EmployeeProj.BL
{
    public class GetClass
    {
        public class Employees
        {
            public static DataTable GetAllEmployees()
            {
                return AdoHelper.GetAllEmployees(" select * from Employees ");
            }

            public static DataTable GetallEmployeesByFirstName(string firstName)
            {
                return AdoHelper.GetAllEmployees(" select * from Employees " +
                                                    " where FirstName =" + firstName);
            }
            public static DataTable GetallEmployeesBySkill(int skillID)
            {
                return AdoHelper.GetAllEmployees(" select * from Employees " +
                                                    " where SkillID =" + skillID);
            }
            public static DataTable GetallEmployeesByEmployeeID(int employeeID)
            {
                return AdoHelper.GetAllEmployees(" select * from Employees " +
                                                    " where EmployeeID =" + employeeID);
            }

            
     
        }

        public class Skills
        {
            public static DataTable GetallSkill()
            {
                return AdoHelper.GetAllSkills(" select * from Skills ");
            }

            public static DataTable GetSkillByName(string skillName)
            {
                return AdoHelper.GetAllSkills(" select * from Skills " +
                                              " where SkillName = @SkillName", skillName);
            }

            public static DataTable GetSkillByEmployeeID(int employeeID)
            {
                return AdoHelper.GetAllSkills(" select * from Skills " +
                                              " where EmployeeID = " + employeeID);
            }


         

        }
        
        public class SkillsInfo
        {
            public static DataTable GetAllSkilllInfo(int skillID)
            {
                return AdoHelper.GetAllSkillsInfo(" select * from SkillsInfoes " + 
                                                   " where SkillID = " + skillID);
            }

        }

        public class Refer
        {
            public static DataTable GetAllEmployeeReferences(int employeeID)
            {
                return AdoHelper.GetAllEmployeeReferences(" select * from EmployeesReferences " +
                                             " where EmployeeID = " + employeeID);
            }
        }
    }
}

