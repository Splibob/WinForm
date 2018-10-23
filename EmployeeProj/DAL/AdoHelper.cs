using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace EmployeeProj.DAL
{
    public class AdoHelper
    {

        #region Connection And Disconnection

        private static SqlConnection connection = new SqlConnection(ConfigurationManager
                                                     .ConnectionStrings["EmployeesConStr"]
                                                     .ConnectionString);

        public void OpenConnection(string connectionString)
        {
            connection.ConnectionString = connectionString;
            try
            {
                connection.Open();
            }
            catch (SqlException se)
            {
                Console.WriteLine("Error connecting to DB: \n{0}", se.Message);
            }
        }

        public void CloseConnection()
        {
            connection.Close();
        }
        #endregion

        #region Select
        public static DataTable GetAllEmployees(string query)
        {

            DataTable employees = new DataTable();
            try
            {


                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    SqlDataAdapter tableAdpter = new SqlDataAdapter(cmd);
                    tableAdpter.Fill(employees);
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            return employees;
        }

        public static DataTable GetAllSkills(string query )
        {
            DataTable skills = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {

                    SqlDataAdapter tableAdepter = new SqlDataAdapter(cmd);
                    tableAdepter.Fill(skills);
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            return skills;
        }

        public static DataTable GetAllSkills(string query, string skillName)
        {
            DataTable skills = new DataTable();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlParameter param = new SqlParameter();

            param.ParameterName = "@SkillName";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Size = 50;
            param.Value = skillName;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            try
            {
                
                using (cmd)
                {

                    SqlDataAdapter tableAdepter = new SqlDataAdapter(cmd);
                    tableAdepter.Fill(skills);
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            return skills;
        }

        public static DataTable GetAllSkillsInfo(string query)
        {

            DataTable skillsInfo = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    SqlDataAdapter tableAdepter = new SqlDataAdapter(cmd);
                    tableAdepter.Fill(skillsInfo);
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            return skillsInfo;
        }

        public static DataTable GetAllEmployeeReferences(string quary)
        {

            DataTable refer = new DataTable();

            try
            {
                using (SqlCommand cmd = new SqlCommand(quary, connection))
                {
                    SqlDataAdapter tableAdepter = new SqlDataAdapter(cmd);
                    tableAdepter.Fill(refer);
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }

            return refer;

        }


        #endregion

        #region Insert

        public static void InsertNewEmployee(string newFirst, string newLast, string newAlias, string newEmail)
        {
            string sqlQuary = String.Format(" insert into Employees " +
                                            " (FirstName, LastName, Alias, Email) " +
                                            " Values " +
                                            " (@FirstName, @LastName, @Alias, @Email) ");
            using (SqlCommand cmd = new SqlCommand(sqlQuary, connection))
            {
                SqlParameter param = new SqlParameter();

                param.ParameterName = "@FirstName";
                param.Value = newFirst;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@LastName";
                param.Value = newLast;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Alias";
                param.Value = newAlias;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Email";
                param.Value = newEmail;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException se)
                {
                    Console.WriteLine("Eror Inserting new employee /nEror: {0}", se.Message);
                }

            }
        }

        public static void InsertNewSkill(string newSkillName, string newSKillBrief, int employeeID)
        {
            string sqlQuary = String.Format(" insert into Skills " +
                                            " (SkillName, BriefDescription, EmployeeID) " +
                                            " Values " +
                                            " (@SkillName, @BriefDescription, @EmployeeID) ");
            using (SqlCommand cmd = new SqlCommand(sqlQuary, connection))
            {
                SqlParameter param = new SqlParameter();

                param.ParameterName = "@SkillName";
                param.Value = newSkillName;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@BriefDescription";
                param.Value = newSKillBrief;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 4000;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@EmployeeID";
                param.Value = employeeID;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);



                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException se)
                {
                    Console.WriteLine("Eror Inserting new employee /nEror: {0}", se.Message);
                }
            }



        }

        public static void InsertNewSkillInfo(string url, int skillID)
        {
            string sqlQuary = String.Format(" insert into SkillsInfoes " +
                                       " (URL, SkillID) " +
                                       " Values " +
                                       " (@URL, @SkillID) ");

            using (SqlCommand cmd = new SqlCommand(sqlQuary, connection))
            {
                SqlParameter param = new SqlParameter();

                param.ParameterName = "@URL";
                param.Value = url;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);


                param = new SqlParameter();
                param.ParameterName = "@SkillID";
                param.Value = skillID;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);



                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException se)
                {
                    Console.WriteLine("Eror Inserting new employee /nEror: {0}", se.Message);
                }
            }
        }

        public static void InsertNewRefernce(string newRefFirst, string newRefLast, string newRefPosition, string newRefEmail, int employeeID)
        {
            string sqlQuary = String.Format(" insert into EmployeesReferences " +
                                        " (FirstName, LastName, Position, Email, EmployeeID) " +
                                        " Values " +
                                        " (@FirstName, @LastName, @Position , @Email, @EmployeeID) ");
  
            using (SqlCommand cmd = new SqlCommand(sqlQuary, connection))
            {
                SqlParameter param = new SqlParameter();

                param.ParameterName = "@FirstName";
                param.Value = newRefFirst;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@LastName";
                param.Value = newRefLast;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Position";
                param.Value = newRefPosition;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Email";
                param.Value = newRefEmail;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@EmployeeID";
                param.Value = employeeID;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException se)
                {
                    Console.WriteLine("Eror Inserting new Reference /nEror: {0}", se.Message);
                }
            }
        }
  
        #endregion

        }
}